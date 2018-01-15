namespace FFTool.usercontrols
{
    partial class TimeSpanEditUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSec = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMs = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMs)).BeginInit();
            this.SuspendLayout();
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(3, 3);
            this.nudHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(33, 20);
            this.nudHour.TabIndex = 0;
            this.nudHour.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(44, 3);
            this.nudMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(33, 20);
            this.nudMin.TabIndex = 0;
            this.nudMin.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(77, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // nudSec
            // 
            this.nudSec.Location = new System.Drawing.Point(85, 3);
            this.nudSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSec.Name = "nudSec";
            this.nudSec.Size = new System.Drawing.Size(33, 20);
            this.nudSec.TabIndex = 0;
            this.nudSec.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(118, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(8, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = ".";
            // 
            // nudMs
            // 
            this.nudMs.Location = new System.Drawing.Point(126, 3);
            this.nudMs.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMs.Name = "nudMs";
            this.nudMs.Size = new System.Drawing.Size(38, 20);
            this.nudMs.TabIndex = 0;
            this.nudMs.Value = new decimal(new int[] {
            111,
            0,
            0,
            0});
            // 
            // TimeSpanEditUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMs);
            this.Controls.Add(this.nudSec);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.nudHour);
            this.MaximumSize = new System.Drawing.Size(170, 28);
            this.MinimumSize = new System.Drawing.Size(170, 28);
            this.Name = "TimeSpanEditUserControl";
            this.Size = new System.Drawing.Size(170, 28);
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMs;
    }
}
