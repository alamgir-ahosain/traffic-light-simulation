namespace traficLight
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            start = new Button();
            stop = new Button();
            reset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            movingObj = new PictureBox();
            movingTimer = new System.Windows.Forms.Timer(components);
            red = new PictureBox();
            yellow = new PictureBox();
            green = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)movingObj).BeginInit();
            ((System.ComponentModel.ISupportInitialize)red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)green).BeginInit();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(557, 95);
            start.Name = "start";
            start.Size = new Size(94, 29);
            start.TabIndex = 3;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.Location = new Point(557, 153);
            stop.Name = "stop";
            stop.Size = new Size(94, 29);
            stop.TabIndex = 4;
            stop.Text = "stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // reset
            // 
            reset.Location = new Point(557, 205);
            reset.Name = "reset";
            reset.Size = new Size(94, 29);
            reset.TabIndex = 5;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // movingObj
            // 
            movingObj.Location = new Point(394, 73);
            movingObj.Name = "movingObj";
            movingObj.Size = new Size(125, 215);
            movingObj.TabIndex = 6;
            movingObj.TabStop = false;
            // 
            // movingTimer
            // 
            movingTimer.Tick += movingTimer_Tick;
            // 
            // red
            // 
            red.Image = Properties.Resources.red1;
            red.Location = new Point(686, 73);
            red.Name = "red";
            red.Size = new Size(85, 233);
            red.SizeMode = PictureBoxSizeMode.AutoSize;
            red.TabIndex = 7;
            red.TabStop = false;
            // 
            // yellow
            // 
            yellow.Image = Properties.Resources.yellow1;
            yellow.Location = new Point(685, 73);
            yellow.Name = "yellow";
            yellow.Size = new Size(86, 232);
            yellow.SizeMode = PictureBoxSizeMode.AutoSize;
            yellow.TabIndex = 8;
            yellow.TabStop = false;
            // 
            // green
            // 
            green.Image = Properties.Resources.green1;
            green.Location = new Point(686, 73);
            green.Name = "green";
            green.Size = new Size(86, 230);
            green.SizeMode = PictureBoxSizeMode.AutoSize;
            green.TabIndex = 9;
            green.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(green);
            Controls.Add(yellow);
            Controls.Add(red);
            Controls.Add(movingObj);
            Controls.Add(reset);
            Controls.Add(stop);
            Controls.Add(start);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)movingObj).EndInit();
            ((System.ComponentModel.ISupportInitialize)red).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)green).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button start;
        private Button stop;
        private Button reset;
        private System.Windows.Forms.Timer timer1;
        private PictureBox movingObj;
        private System.Windows.Forms.Timer movingTimer;
        private PictureBox red;
        private PictureBox yellow;
        private PictureBox green;
    }
}
