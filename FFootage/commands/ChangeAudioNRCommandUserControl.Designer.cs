namespace FFTool.commands
{
    partial class ChangeAudioNRCommandUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAudioInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input audio file (Drag\'N\'Drop)";
            // 
            // tbAudioInput
            // 
            this.tbAudioInput.AllowDrop = true;
            this.tbAudioInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAudioInput.Location = new System.Drawing.Point(3, 24);
            this.tbAudioInput.Name = "tbAudioInput";
            this.tbAudioInput.Size = new System.Drawing.Size(306, 20);
            this.tbAudioInput.TabIndex = 4;
            this.tbAudioInput.TextChanged += new System.EventHandler(this.tbAudioInput_TextChanged);
            this.tbAudioInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbAudioInput_DragDrop);
            this.tbAudioInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbAudioInput_DragEnter);
            // 
            // ChangeAudioNRCommandUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAudioInput);
            this.Name = "ChangeAudioNRCommandUserControl";
            this.Size = new System.Drawing.Size(365, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAudioInput;
    }
}
