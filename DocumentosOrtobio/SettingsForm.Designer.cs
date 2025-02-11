namespace DocumentosOrtobio
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnGenerateLogReport;
        private System.Windows.Forms.Button btnOnlineUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnGenerateLogReport = new System.Windows.Forms.Button();
            this.btnOnlineUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(12, 12);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(120, 23);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Criar Usuário";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // btnGenerateLogReport
            // 
            this.btnGenerateLogReport.Location = new System.Drawing.Point(12, 41);
            this.btnGenerateLogReport.Name = "btnGenerateLogReport";
            this.btnGenerateLogReport.Size = new System.Drawing.Size(120, 23);
            this.btnGenerateLogReport.TabIndex = 1;
            this.btnGenerateLogReport.Text = "Gerar Logs";
            this.btnGenerateLogReport.UseVisualStyleBackColor = true;
            this.btnGenerateLogReport.Click += new System.EventHandler(this.BtnGenerateLogReport_Click);
            // 
            // btnOnlineUsers
            // 
            this.btnOnlineUsers.Location = new System.Drawing.Point(12, 70);
            this.btnOnlineUsers.Name = "btnOnlineUsers";
            this.btnOnlineUsers.Size = new System.Drawing.Size(120, 23);
            this.btnOnlineUsers.TabIndex = 2;
            this.btnOnlineUsers.Text = "Usuários Online";
            this.btnOnlineUsers.UseVisualStyleBackColor = true;
            this.btnOnlineUsers.Click += new System.EventHandler(this.BtnOnlineUsers_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnOnlineUsers);
            this.Controls.Add(this.btnGenerateLogReport);
            this.Controls.Add(this.btnCreateUser);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Configurações";
            this.ResumeLayout(false);
        }
    }
}