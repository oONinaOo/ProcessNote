using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processes
{
    class Property
    {
        private String cpuUsage;
        public String CpuUsage
        {
            get { return cpuUsage; }
            set { cpuUsage = value; }
        }

        private String memUsage;
        public String MemUsage
        {
            get { return memUsage; }
            set { memUsage = value; }
        }
        private String runningTime;
        public String RunningTime
        {
            get { return runningTime; }
            set { runningTime = value; }
        }

        private String startTime;
        public String StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private String threads;
        public String Threads
        {
            get { return threads; }
            set { threads = value; }
        }

        public Property(String cpuUsage, String memUsage, String runningTime, String startTime, String threads)
        {
            this.cpuUsage = cpuUsage;
            this.memUsage = memUsage;
            this.runningTime = runningTime;
            this.startTime = startTime;
            this.threads = threads;

        }
        public override string ToString()
        {
            return ("----------------------------------------------------------- \n" +
                "CPU usage:            " + cpuUsage + "\n" +
                "Memory usage:     " + memUsage + "KB\n" +
                "Running Time:      " + runningTime + "\n" +
                "Start Time:              " + startTime + "\n" +
                "Threads:                 " + threads + "\n" +
                "-----------------------------------------------------------");
        }
    }
}
