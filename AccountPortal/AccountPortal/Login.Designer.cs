namespace Kiran.Accountportal.UI
{
    partial class Login
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
            this.utxtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtUserName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ubtnCancel = new Infragistics.Win.Misc.UltraButton();
            this.ubtnLogin = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraPanel2 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraPanel3 = new Infragistics.Win.Misc.UltraPanel();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUserName)).BeginInit();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            this.ultraPanel2.ClientArea.SuspendLayout();
            this.ultraPanel2.SuspendLayout();
            this.ultraPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // utxtPassword
            // 
            this.utxtPassword.Location = new System.Drawing.Point(109, 44);
            this.utxtPassword.Name = "utxtPassword";
            this.utxtPassword.Size = new System.Drawing.Size(174, 21);
            this.utxtPassword.TabIndex = 11;
            // 
            // utxtUserName
            // 
            this.utxtUserName.Location = new System.Drawing.Point(109, 11);
            this.utxtUserName.Name = "utxtUserName";
            this.utxtUserName.Size = new System.Drawing.Size(174, 21);
            this.utxtUserName.TabIndex = 10;
            // 
            // ubtnCancel
            // 
            this.ubtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ubtnCancel.Location = new System.Drawing.Point(173, 79);
            this.ubtnCancel.Name = "ubtnCancel";
            this.ubtnCancel.Size = new System.Drawing.Size(75, 23);
            this.ubtnCancel.TabIndex = 9;
            this.ubtnCancel.Text = "Cancel";
            // 
            // ubtnLogin
            // 
            this.ubtnLogin.Location = new System.Drawing.Point(92, 79);
            this.ubtnLogin.Name = "ubtnLogin";
            this.ubtnLogin.Size = new System.Drawing.Size(75, 23);
            this.ubtnLogin.TabIndex = 8;
            this.ubtnLogin.Text = "Login";
            this.ubtnLogin.Click += new System.EventHandler(this.ubtnLogin_Click);
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(23, 48);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(80, 19);
            this.ultraLabel2.TabIndex = 7;
            this.ultraLabel2.Text = "Password";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(23, 14);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(80, 19);
            this.ultraLabel1.TabIndex = 6;
            this.ultraLabel1.Text = "User Name";
            // 
            // ultraPanel1
            // 
            this.ultraPanel1.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraPanel3);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraPanel2);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(333, 331);
            this.ultraPanel1.TabIndex = 12;
            // 
            // ultraPanel2
            // 
            this.ultraPanel2.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft;
            // 
            // ultraPanel2.ClientArea
            // 
            this.ultraPanel2.ClientArea.Controls.Add(this.utxtUserName);
            this.ultraPanel2.ClientArea.Controls.Add(this.utxtPassword);
            this.ultraPanel2.ClientArea.Controls.Add(this.ubtnLogin);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel1);
            this.ultraPanel2.ClientArea.Controls.Add(this.ubtnCancel);
            this.ultraPanel2.ClientArea.Controls.Add(this.ultraLabel2);
            this.ultraPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraPanel2.Location = new System.Drawing.Point(0, 207);
            this.ultraPanel2.Name = "ultraPanel2";
            this.ultraPanel2.Size = new System.Drawing.Size(331, 122);
            this.ultraPanel2.TabIndex = 12;
            // 
            // ultraPanel3
            // 
            this.ultraPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPanel3.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel3.Name = "ultraPanel3";
            this.ultraPanel3.Size = new System.Drawing.Size(331, 207);
            this.ultraPanel3.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(333, 331);
            this.Controls.Add(this.ultraPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUserName)).EndInit();
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            this.ultraPanel2.ClientArea.ResumeLayout(false);
            this.ultraPanel2.ClientArea.PerformLayout();
            this.ultraPanel2.ResumeLayout(false);
            this.ultraPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtUserName;
        private Infragistics.Win.Misc.UltraButton ubtnCancel;
        private Infragistics.Win.Misc.UltraButton ubtnLogin;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.Misc.UltraPanel ultraPanel2;
        private Infragistics.Win.Misc.UltraPanel ultraPanel3;

    }
}

