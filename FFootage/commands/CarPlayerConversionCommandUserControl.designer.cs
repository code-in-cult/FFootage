namespace FFTool.commands
{
    partial class CarPlayerConversionCommandUserControl
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
            this.nudVideoBitrate = new System.Windows.Forms.NumericUpDown();
            this.nudSplitSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplitSize)).BeginInit();
            this.SuspendLayout();
            // 
            // nudVideoBitrate
            // 
            this.nudVideoBitrate.Location = new System.Drawing.Point(7, 20);
            this.nudVideoBitrate.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudVideoBitrate.Name = "nudVideoBitrate";
            this.nudVideoBitrate.Size = new System.Drawing.Size(63, 20);
            this.nudVideoBitrate.TabIndex = 0;
            this.nudVideoBitrate.ThousandsSeparator = true;
            this.nudVideoBitrate.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudVideoBitrate.ValueChanged += new System.EventHandler(this.nudVideoBitrate_ValueChanged);
            // 
            // nudSplitSize
            // 
            this.nudSplitSize.Location = new System.Drawing.Point(7, 73);
            this.nudSplitSize.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudSplitSize.Name = "nudSplitSize";
            this.nudSplitSize.Size = new System.Drawing.Size(63, 20);
            this.nudSplitSize.TabIndex = 0;
            this.nudSplitSize.ThousandsSeparator = true;
            this.nudSplitSize.ValueChanged += new System.EventHandler(this.nudSplitSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video bitrate (k)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Split size (minute, 0 = no split)";
            // 
            // CarPlayerConversionCommandUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSplitSize);
            this.Controls.Add(this.nudVideoBitrate);
            this.Name = "CarPlayerConversionCommandUserControl";
            this.Size = new System.Drawing.Size(365, 96);
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplitSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudVideoBitrate;
        private System.Windows.Forms.NumericUpDown nudSplitSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
