using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DocumentosOrtobio
{
    public partial class LoginForm : Form
    {
        private Dictionary<string, bool> userLoginStatus;

        public LoginForm()
        {
            InitializeComponent();
            LoadUserLoginStatus();
        }

        private void LoadUserLoginStatus()
        {
            if (File.Exists("userLoginStatus.json"))
            {
                userLoginStatus = JsonConvert.DeserializeObject<Dictionary<string, bool>>(File.ReadAllText("userLoginStatus.json"));
            }
            else
            {
                userLoginStatus = new Dictionary<string, bool>();
            }
        }

        private void SaveUserLoginStatus()
        {
            File.WriteAllText("userLoginStatus.json", JsonConvert.SerializeObject(userLoginStatus, Formatting.Indented));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("users.json"));
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                if (userLoginStatus.ContainsKey(username) && userLoginStatus[username])
                {
                    MessageBox.Show("O usuário já está logado em outro terminal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                userLoginStatus[username] = true;
                SaveUserLoginStatus();

                Form1 mainForm = new Form1(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas.");
            }
        }
    }
}