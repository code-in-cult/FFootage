namespace FFTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbCommands = new System.Windows.Forms.GroupBox();
            this.btKillAllffmpeg = new System.Windows.Forms.Button();
            this.btCrop = new System.Windows.Forms.Button();
            this.btCarPlayerConv = new System.Windows.Forms.Button();
            this.btHardcodeSub = new System.Windows.Forms.Button();
            this.btResize = new System.Windows.Forms.Button();
            this.btChangeSpeed = new System.Windows.Forms.Button();
            this.btInterlacedToProgressive = new System.Windows.Forms.Button();
            this.btChangeAudioNoRecode = new System.Windows.Forms.Button();
            this.btCutNoRecode = new System.Windows.Forms.Button();
            this.tcCommandInstances = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btConvertToMpThree = new System.Windows.Forms.Button();
            this.gbCommands.SuspendLayout();
            this.tcCommandInstances.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCommands
            // 
            this.gbCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbCommands.Controls.Add(this.btKillAllffmpeg);
            this.gbCommands.Controls.Add(this.btConvertToMpThree);
            this.gbCommands.Controls.Add(this.btCrop);
            this.gbCommands.Controls.Add(this.btCarPlayerConv);
            this.gbCommands.Controls.Add(this.btHardcodeSub);
            this.gbCommands.Controls.Add(this.btResize);
            this.gbCommands.Controls.Add(this.btChangeSpeed);
            this.gbCommands.Controls.Add(this.btInterlacedToProgressive);
            this.gbCommands.Controls.Add(this.btChangeAudioNoRecode);
            this.gbCommands.Controls.Add(this.btCutNoRecode);
            this.gbCommands.Location = new System.Drawing.Point(13, 13);
            this.gbCommands.Name = "gbCommands";
            this.gbCommands.Size = new System.Drawing.Size(129, 577);
            this.gbCommands.TabIndex = 0;
            this.gbCommands.TabStop = false;
            this.gbCommands.Text = "Commands";
            // 
            // btKillAllffmpeg
            // 
            this.btKillAllffmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btKillAllffmpeg.Location = new System.Drawing.Point(6, 548);
            this.btKillAllffmpeg.Name = "btKillAllffmpeg";
            this.btKillAllffmpeg.Size = new System.Drawing.Size(75, 23);
            this.btKillAllffmpeg.TabIndex = 1;
            this.btKillAllffmpeg.Text = "Kill ffmpeg";
            this.btKillAllffmpeg.UseVisualStyleBackColor = true;
            this.btKillAllffmpeg.Click += new System.EventHandler(this.btKillAllffmpeg_Click);
            // 
            // btCrop
            // 
            this.btCrop.Location = new System.Drawing.Point(6, 223);
            this.btCrop.Name = "btCrop";
            this.btCrop.Size = new System.Drawing.Size(116, 23);
            this.btCrop.TabIndex = 0;
            this.btCrop.Text = "Crop";
            this.btCrop.UseVisualStyleBackColor = true;
            this.btCrop.Click += new System.EventHandler(this.btCrop_Click);
            // 
            // btCarPlayerConv
            // 
            this.btCarPlayerConv.Location = new System.Drawing.Point(7, 194);
            this.btCarPlayerConv.Name = "btCarPlayerConv";
            this.btCarPlayerConv.Size = new System.Drawing.Size(116, 23);
            this.btCarPlayerConv.TabIndex = 0;
            this.btCarPlayerConv.Text = "Car Player Conv.";
            this.btCarPlayerConv.UseVisualStyleBackColor = true;
            this.btCarPlayerConv.Click += new System.EventHandler(this.btCarPlayerConv_Click);
            // 
            // btHardcodeSub
            // 
            this.btHardcodeSub.Location = new System.Drawing.Point(6, 165);
            this.btHardcodeSub.Name = "btHardcodeSub";
            this.btHardcodeSub.Size = new System.Drawing.Size(116, 23);
            this.btHardcodeSub.TabIndex = 0;
            this.btHardcodeSub.Text = "Hardcode Sub.";
            this.btHardcodeSub.UseVisualStyleBackColor = true;
            this.btHardcodeSub.Click += new System.EventHandler(this.btHardcodeSub_Click);
            // 
            // btResize
            // 
            this.btResize.Location = new System.Drawing.Point(6, 136);
            this.btResize.Name = "btResize";
            this.btResize.Size = new System.Drawing.Size(116, 23);
            this.btResize.TabIndex = 0;
            this.btResize.Text = "Resize";
            this.btResize.UseVisualStyleBackColor = true;
            this.btResize.Click += new System.EventHandler(this.btResize_Click);
            // 
            // btChangeSpeed
            // 
            this.btChangeSpeed.Location = new System.Drawing.Point(6, 107);
            this.btChangeSpeed.Name = "btChangeSpeed";
            this.btChangeSpeed.Size = new System.Drawing.Size(116, 23);
            this.btChangeSpeed.TabIndex = 0;
            this.btChangeSpeed.Text = "Change Speed";
            this.btChangeSpeed.UseVisualStyleBackColor = true;
            this.btChangeSpeed.Click += new System.EventHandler(this.btChangeSpeed_Click);
            // 
            // btInterlacedToProgressive
            // 
            this.btInterlacedToProgressive.Location = new System.Drawing.Point(6, 78);
            this.btInterlacedToProgressive.Name = "btInterlacedToProgressive";
            this.btInterlacedToProgressive.Size = new System.Drawing.Size(116, 23);
            this.btInterlacedToProgressive.TabIndex = 0;
            this.btInterlacedToProgressive.Text = "Interl. To Progessive";
            this.btInterlacedToProgressive.UseVisualStyleBackColor = true;
            this.btInterlacedToProgressive.Click += new System.EventHandler(this.btInterlacedToProgressive_Click);
            // 
            // btChangeAudioNoRecode
            // 
            this.btChangeAudioNoRecode.Location = new System.Drawing.Point(7, 49);
            this.btChangeAudioNoRecode.Name = "btChangeAudioNoRecode";
            this.btChangeAudioNoRecode.Size = new System.Drawing.Size(116, 23);
            this.btChangeAudioNoRecode.TabIndex = 0;
            this.btChangeAudioNoRecode.Text = "Change Audio NR";
            this.btChangeAudioNoRecode.UseVisualStyleBackColor = true;
            this.btChangeAudioNoRecode.Click += new System.EventHandler(this.btChangeAudioNoRecode_Click);
            // 
            // btCutNoRecode
            // 
            this.btCutNoRecode.Location = new System.Drawing.Point(7, 20);
            this.btCutNoRecode.Name = "btCutNoRecode";
            this.btCutNoRecode.Size = new System.Drawing.Size(116, 23);
            this.btCutNoRecode.TabIndex = 0;
            this.btCutNoRecode.Text = "Cut NR";
            this.btCutNoRecode.UseVisualStyleBackColor = true;
            this.btCutNoRecode.Click += new System.EventHandler(this.btCutNoRecode_Click);
            // 
            // tcCommandInstances
            // 
            this.tcCommandInstances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcCommandInstances.Controls.Add(this.tabPage1);
            this.tcCommandInstances.Controls.Add(this.tabPage2);
            this.tcCommandInstances.Location = new System.Drawing.Point(148, 13);
            this.tcCommandInstances.Name = "tcCommandInstances";
            this.tcCommandInstances.SelectedIndex = 0;
            this.tcCommandInstances.Size = new System.Drawing.Size(740, 577);
            this.tcCommandInstances.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btConvertToMpThree
            // 
            this.btConvertToMpThree.Location = new System.Drawing.Point(6, 252);
            this.btConvertToMpThree.Name = "btConvertToMpThree";
            this.btConvertToMpThree.Size = new System.Drawing.Size(116, 23);
            this.btConvertToMpThree.TabIndex = 0;
            this.btConvertToMpThree.Text = "Convert To Mp3";
            this.btConvertToMpThree.UseVisualStyleBackColor = true;
            this.btConvertToMpThree.Click += new System.EventHandler(this.btConvertToMpThree_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 602);
            this.Controls.Add(this.tcCommandInstances);
            this.Controls.Add(this.gbCommands);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FFootage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbCommands.ResumeLayout(false);
            this.tcCommandInstances.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCommands;
        private System.Windows.Forms.Button btChangeAudioNoRecode;
        private System.Windows.Forms.Button btCutNoRecode;
        private System.Windows.Forms.TabControl tcCommandInstances;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btKillAllffmpeg;
        private System.Windows.Forms.Button btInterlacedToProgressive;
        private System.Windows.Forms.Button btChangeSpeed;
        private System.Windows.Forms.Button btResize;
        private System.Windows.Forms.Button btHardcodeSub;
        private System.Windows.Forms.Button btCarPlayerConv;
        private System.Windows.Forms.Button btCrop;
        private System.Windows.Forms.Button btConvertToMpThree;
    }
}

