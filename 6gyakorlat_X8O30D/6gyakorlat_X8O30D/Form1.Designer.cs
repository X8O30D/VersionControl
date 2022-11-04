namespace _6gyakorlat_X8O30D
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
            this.components = new System.ComponentModel.Container();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ballbutton = new System.Windows.Forms.Button();
            this.carbutton = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.AllowDrop = true;
            this.mainpanel.Controls.Add(this.button1);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Controls.Add(this.ballbutton);
            this.mainpanel.Controls.Add(this.carbutton);
            this.mainpanel.Location = new System.Drawing.Point(2, 1);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1120, 699);
            this.mainpanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming next:";
            // 
            // ballbutton
            // 
            this.ballbutton.Location = new System.Drawing.Point(137, 21);
            this.ballbutton.Name = "ballbutton";
            this.ballbutton.Size = new System.Drawing.Size(92, 92);
            this.ballbutton.TabIndex = 1;
            this.ballbutton.Text = "BALL";
            this.ballbutton.UseVisualStyleBackColor = true;
            this.ballbutton.Click += new System.EventHandler(this.ballbutton_Click);
            // 
            // carbutton
            // 
            this.carbutton.Location = new System.Drawing.Point(27, 21);
            this.carbutton.Name = "carbutton";
            this.carbutton.Size = new System.Drawing.Size(92, 92);
            this.carbutton.TabIndex = 0;
            this.carbutton.Text = "CAR";
            this.carbutton.UseVisualStyleBackColor = true;
            this.carbutton.Click += new System.EventHandler(this.carbutton_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Location = new System.Drawing.Point(97, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 46);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 698);
            this.Controls.Add(this.mainpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ballbutton;
        private System.Windows.Forms.Button carbutton;
        private System.Windows.Forms.Button button1;
    }
}

