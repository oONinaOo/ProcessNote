namespace Processes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.onTop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.comment = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.PropertyText = new System.Windows.Forms.Label();
            this.Properties = new System.Windows.Forms.Label();
            this.running = new System.Windows.Forms.Label();
            this.ProcessList = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 409);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.onTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 314);
            this.panel2.TabIndex = 0;
            // 
            // onTop
            // 
            this.onTop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.onTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.onTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onTop.BorderRadius = 0;
            this.onTop.ButtonText = "Always on Top";
            this.onTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onTop.DisabledColor = System.Drawing.Color.Gray;
            this.onTop.Iconcolor = System.Drawing.Color.Transparent;
            this.onTop.Iconimage = ((System.Drawing.Image)(resources.GetObject("onTop.Iconimage")));
            this.onTop.Iconimage_right = null;
            this.onTop.Iconimage_right_Selected = null;
            this.onTop.Iconimage_Selected = null;
            this.onTop.IconMarginLeft = 0;
            this.onTop.IconMarginRight = 0;
            this.onTop.IconRightVisible = true;
            this.onTop.IconRightZoom = 0D;
            this.onTop.IconVisible = true;
            this.onTop.IconZoom = 90D;
            this.onTop.IsTab = false;
            this.onTop.Location = new System.Drawing.Point(0, 6);
            this.onTop.Name = "onTop";
            this.onTop.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.onTop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.onTop.OnHoverTextColor = System.Drawing.Color.Black;
            this.onTop.selected = false;
            this.onTop.Size = new System.Drawing.Size(163, 48);
            this.onTop.TabIndex = 0;
            this.onTop.Text = "Always on Top";
            this.onTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onTop.Textcolor = System.Drawing.Color.White;
            this.onTop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onTop.Click += new System.EventHandler(this.onTop_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(146, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 314);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.save);
            this.panel4.Controls.Add(this.comment);
            this.panel4.Controls.Add(this.commentLabel);
            this.panel4.Controls.Add(this.PropertyText);
            this.panel4.Controls.Add(this.Properties);
            this.panel4.Controls.Add(this.running);
            this.panel4.Controls.Add(this.ProcessList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(587, 308);
            this.panel4.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(424, 274);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(151, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save comment";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(283, 192);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(292, 73);
            this.comment.TabIndex = 4;
            this.comment.Click += new System.EventHandler(this.comment_Click);
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentLabel.Location = new System.Drawing.Point(283, 173);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(76, 16);
            this.commentLabel.TabIndex = 3;
            this.commentLabel.Text = "Comment:";
            // 
            // PropertyText
            // 
            this.PropertyText.AutoSize = true;
            this.PropertyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PropertyText.Location = new System.Drawing.Point(292, 41);
            this.PropertyText.Name = "PropertyText";
            this.PropertyText.Size = new System.Drawing.Size(0, 15);
            this.PropertyText.TabIndex = 2;
            // 
            // Properties
            // 
            this.Properties.AutoSize = true;
            this.Properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Properties.Location = new System.Drawing.Point(370, 11);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(96, 20);
            this.Properties.TabIndex = 1;
            this.Properties.Text = "Properties:";
            // 
            // running
            // 
            this.running.AutoSize = true;
            this.running.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.running.Location = new System.Drawing.Point(23, 11);
            this.running.Name = "running";
            this.running.Size = new System.Drawing.Size(168, 20);
            this.running.TabIndex = 1;
            this.running.Text = "Running processes:";
            // 
            // ProcessList
            // 
            this.ProcessList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.ItemHeight = 16;
            this.ProcessList.Location = new System.Drawing.Point(23, 37);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(248, 260);
            this.ProcessList.TabIndex = 0;
            this.ProcessList.SelectedIndexChanged += new System.EventHandler(this.select);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(146, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(587, 95);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 409);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton onTop;
        private System.Windows.Forms.ListBox ProcessList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Properties;
        private System.Windows.Forms.Label running;
        private System.Windows.Forms.Label PropertyText;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Button save;
    }
}

