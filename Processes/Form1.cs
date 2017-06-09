using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Processes
{
   
    public partial class Form1 : Form
    {
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        Dictionary<String, String> comments = new Dictionary<String, string>();
        public Form1()
        {
            this.TopMost = false;
            InitializeComponent();
            fillList();
            Properties.Hide();
            commentLabel.Hide();
            comment.Hide();
            save.Hide();
        }
        
        public Process[] readProcesses()
        {
            Process[] runningProcesses = Process.GetProcesses();
            Array.Sort(runningProcesses, delegate (Process p1, Process p2) {
                return p1.Id.CompareTo(p2.Id);
            });

            Process[] result = new Process[runningProcesses.Length - 1];
            Array.Copy(runningProcesses, 1, result, 0, runningProcesses.Length - 1);

            return result;
        }
        public void fillList()
        {
            Process[] runningProcesses = readProcesses();
            foreach (Process process in runningProcesses)
            {
                if (process.Id > 0)
                {
                    ProcessList.Items.Add(process.Id + " - " + process.ProcessName);
                }

            }

        }

        private void onTop_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void select(object sender, EventArgs e)
        {
            int currIndex = ProcessList.SelectedIndex;
            Process[] runningProcesses = readProcesses();
            for (int i = 0; i < runningProcesses.Length; i++)
            {
                if (i == currIndex)
                {

                    String cpuUsage = CPU_TIME();
                    String memUsage = runningProcesses[i].WorkingSet64.ToString();
                    String runningTimeFull = (DateTime.UtcNow - runningProcesses[i].StartTime.ToUniversalTime()).ToString();
                    String[] getRunningTime = runningTimeFull.Split('.');
                    String runningTime = "";
                    if (getRunningTime.Length > 2)
                    {
                        runningTime = getRunningTime[0] + " days, " + getRunningTime[1]; 
                    }
                    else
                    {
                        runningTime = getRunningTime[0];
                    }
                    String startTime = runningProcesses[i].StartTime.ToString();
                    String threads = runningProcesses[i].Threads.Count.ToString();
                    Property property = new Property(cpuUsage, memUsage, runningTime, startTime, threads);

                    Properties.Visible = true;
                    PropertyText.Visible = true;
                    PropertyText.Text = property.ToString();
                }


            }
            String name = ProcessList.SelectedItem.ToString();
            String[] splitName = name.Split('-');
            Array.Sort(splitName);
            String getId = splitName[0];
            getId.Substring(0, getId.Length - 1);

            comment.ForeColor = Color.Black;
            commentLabel.Visible = true;
            save.Visible = true;
            comment.Visible = true;
            string comm = "";
            comments.TryGetValue(getId, out comm);
            comment.Text = comm;
            if (comment.Text == "")
            {
                comment.ForeColor = Color.DimGray;
                comment.Text = "Add your comment here... \r\n\r\nThis is NOT permanent, you need to click the \"Save c" +
    "omment\" button.";
            }

        }
        public String CPU_TIME()
        {
            return Math.Round(cpuCounter.NextValue(), 2) + "%";
        }

        private void save_Click(object sender, EventArgs e)
        {
            String name = ProcessList.SelectedItem.ToString();
            String[] splitName = name.Split('-');
            Array.Sort(splitName);
            String getId = splitName[0];
            getId.Substring(0, getId.Length - 1);


            if (comments.ContainsKey(getId))
            {
                comments[getId] = comment.Text;

            }
            else
            {
                comments.Add(getId, comment.Text);

            }

        }

        private void comment_Click(object sender, EventArgs e)
        {
            String placeholder = "Add your comment here... \r\n\r\nThis is NOT permanent, you need to click the \"Save c" +
    "omment\" button.";
            if (comment.Text == placeholder)
            {
                comment.ForeColor = Color.Black;
                comment.Font = new Font(comment.Font, FontStyle.Regular);
                comment.Clear();
            }
        }
    }
}
