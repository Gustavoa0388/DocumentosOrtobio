namespace DocumentosOrtobio
{
    partial class OnlineUsersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxOnlineUsers;
        private System.Windows.Forms.Button btnLogoutUser;

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
            this.listBoxOnlineUsers = new System.Windows.Forms.ListBox();
            this.btnLogoutUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOnlineUsers
            // 
            this.listBoxOnlineUsers.FormattingEnabled = true;
            this.listBoxOnlineUsers.Location = new System.Drawing.Point(12, 12);
            this.listBoxOnlineUsers.Name = "listBoxOnlineUsers";
            this.listBoxOnlineUsers.Size = new System.Drawing.Size(260, 186);
            this.listBoxOnlineUsers.TabIndex = 0;
            // 
            // btnLogoutUser
            // 
            this.btnLogoutUser.Location = new System.Drawing.Point(12, 204);
            this.btnLogoutUser.Name = "btnLogoutUser";
            this.btnLogoutUser.Size = new System.Drawing.Size(260, 23);
            this.btnLogoutUser.TabIndex = 1;
            this.btnLogoutUser.Text = "Deslogar Usuário";
            this.btnLogoutUser.UseVisualStyleBackColor = true;
            this.btnLogoutUser.Click += new System.EventHandler(this.BtnLogoutUser_Click);
            // 
            // OnlineUsersForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.btnLogoutUser);
            this.Controls.Add(this.listBoxOnlineUsers);
            this.Name = "OnlineUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Usuários Online";
            this.ResumeLayout(false);
        }
    }
}