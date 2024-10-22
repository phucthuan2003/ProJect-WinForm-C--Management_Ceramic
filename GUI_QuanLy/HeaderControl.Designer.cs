namespace GUI_QuanLy
{
    partial class HeaderControl
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnNoti = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnInfo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnSetting = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.panelHeader.Controls.Add(this.btnNoti);
            this.panelHeader.Controls.Add(this.btnInfo);
            this.panelHeader.Controls.Add(this.btnSetting);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(819, 39);
            this.panelHeader.TabIndex = 0;
            // 
            // btnNoti
            // 
            this.btnNoti.AllowFocused = false;
            this.btnNoti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoti.AutoSizeHeight = true;
            this.btnNoti.BorderRadius = 11;
            this.btnNoti.Image = global::GUI_QuanLy.Properties.Resources.bell;
            this.btnNoti.IsCircle = true;
            this.btnNoti.Location = new System.Drawing.Point(703, 8);
            this.btnNoti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNoti.Name = "btnNoti";
            this.btnNoti.Size = new System.Drawing.Size(23, 23);
            this.btnNoti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNoti.TabIndex = 3;
            this.btnNoti.TabStop = false;
            this.btnNoti.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnInfo
            // 
            this.btnInfo.AllowFocused = false;
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.AutoSizeHeight = true;
            this.btnInfo.BorderRadius = 13;
            this.btnInfo.Image = global::GUI_QuanLy.Properties.Resources.Screenshot_2024_10_15_082907;
            this.btnInfo.IsCircle = true;
            this.btnInfo.Location = new System.Drawing.Point(779, 8);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(27, 27);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfo.TabIndex = 2;
            this.btnInfo.TabStop = false;
            this.btnInfo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnSetting
            // 
            this.btnSetting.AllowFocused = false;
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.AutoSizeHeight = true;
            this.btnSetting.BorderRadius = 11;
            this.btnSetting.Image = global::GUI_QuanLy.Properties.Resources.setting;
            this.btnSetting.IsCircle = true;
            this.btnSetting.Location = new System.Drawing.Point(739, 8);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(23, 23);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSetting.TabIndex = 1;
            this.btnSetting.TabStop = false;
            this.btnSetting.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // HeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "HeaderControl";
            this.Size = new System.Drawing.Size(819, 39);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.UI.WinForms.BunifuPictureBox btnSetting;
        private Bunifu.UI.WinForms.BunifuPictureBox btnInfo;
        private Bunifu.UI.WinForms.BunifuPictureBox btnNoti;
    }
}
