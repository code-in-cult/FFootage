namespace FFTool.commands
{
    partial class CutNRCommandUserControl
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
            this.tseLength = new FFTool.usercontrols.TimeSpanEditUserControl();
            this.tseTo = new FFTool.usercontrols.TimeSpanEditUserControl();
            this.tseFrom = new FFTool.usercontrols.TimeSpanEditUserControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tseLength
            // 
            this.tseLength.Location = new System.Drawing.Point(3, 67);
            this.tseLength.MaximumSize = new System.Drawing.Size(170, 28);
            this.tseLength.MinimumSize = new System.Drawing.Size(170, 28);
            this.tseLength.Name = "tseLength";
            this.tseLength.Size = new System.Drawing.Size(170, 28);
            this.tseLength.TabIndex = 11;
            this.tseLength.Value = System.TimeSpan.Parse("00:00:00");
            this.tseLength.ValueChanged += new System.Action(this.tseLength_ValueChanged);
            // 
            // tseTo
            // 
            this.tseTo.Enabled = false;
            this.tseTo.Location = new System.Drawing.Point(195, 16);
            this.tseTo.MaximumSize = new System.Drawing.Size(170, 28);
            this.tseTo.MinimumSize = new System.Drawing.Size(170, 28);
            this.tseTo.Name = "tseTo";
            this.tseTo.Size = new System.Drawing.Size(170, 28);
            this.tseTo.TabIndex = 12;
            this.tseTo.Value = System.TimeSpan.Parse("00:00:00");
            // 
            // tseFrom
            // 
            this.tseFrom.Location = new System.Drawing.Point(3, 16);
            this.tseFrom.MaximumSize = new System.Drawing.Size(170, 28);
            this.tseFrom.MinimumSize = new System.Drawing.Size(170, 28);
            this.tseFrom.Name = "tseFrom";
            this.tseFrom.Size = new System.Drawing.Size(170, 28);
            this.tseFrom.TabIndex = 13;
            this.tseFrom.Value = System.TimeSpan.Parse("00:00:00");
            this.tseFrom.ValueChanged += new System.Action(this.tseFrom_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From";
            // 
            // CutNRCommandUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tseLength);
            this.Controls.Add(this.tseTo);
            this.Controls.Add(this.tseFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CutNRCommandUserControl";
            this.Size = new System.Drawing.Size(365, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private usercontrols.TimeSpanEditUserControl tseLength;
        private usercontrols.TimeSpanEditUserControl tseTo;
        private usercontrols.TimeSpanEditUserControl tseFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
