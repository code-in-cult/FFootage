namespace FFTool.commands
{
    partial class ChangeSpeedCommandUserControl
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
            this.nudSpeedDivide = new System.Windows.Forms.NumericUpDown();
            this.nudOutputFrameRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedDivide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputFrameRate)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSpeedDivide
            // 
            this.nudSpeedDivide.DecimalPlaces = 1;
            this.nudSpeedDivide.Location = new System.Drawing.Point(7, 20);
            this.nudSpeedDivide.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSpeedDivide.Name = "nudSpeedDivide";
            this.nudSpeedDivide.Size = new System.Drawing.Size(63, 20);
            this.nudSpeedDivide.TabIndex = 0;
            this.nudSpeedDivide.ThousandsSeparator = true;
            this.nudSpeedDivide.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeedDivide.ValueChanged += new System.EventHandler(this.nudSpeedDivide_ValueChanged);
            // 
            // nudOutputFrameRate
            // 
            this.nudOutputFrameRate.Location = new System.Drawing.Point(7, 73);
            this.nudOutputFrameRate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudOutputFrameRate.Name = "nudOutputFrameRate";
            this.nudOutputFrameRate.Size = new System.Drawing.Size(63, 20);
            this.nudOutputFrameRate.TabIndex = 0;
            this.nudOutputFrameRate.ThousandsSeparator = true;
            this.nudOutputFrameRate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudOutputFrameRate.ValueChanged += new System.EventHandler(this.nudOutputFrameRate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speed Divide (eg: 2.0 means half the speed, 0.5 means double the speed)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Frame Rate (FPS)";
            // 
            // ChangeSpeedCommandUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudOutputFrameRate);
            this.Controls.Add(this.nudSpeedDivide);
            this.Name = "ChangeSpeedCommandUserControl";
            this.Size = new System.Drawing.Size(365, 96);
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedDivide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputFrameRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSpeedDivide;
        private System.Windows.Forms.NumericUpDown nudOutputFrameRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
