using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DocumentosOrtobio
{
    public partial class OnlineUsersForm : Form
    {
        private Dictionary<string, bool> userLoginStatus;

        public OnlineUsersForm()
        {
            InitializeComponent();
            LoadUserLoginStatus();
            PopulateOnlineUsersList();
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

        private void PopulateOnlineUsersList()
        {
            listBoxOnlineUsers.Items.Clear();
            foreach (var user in userLoginStatus)
            {
                if (user.Value)
                {
                    listBoxOnlineUsers.Items.Add(user.Key);
                }
            }
        }

        private void BtnLogoutUser_Click(object sender, EventArgs e)
        {
            if (listBoxOnlineUsers.SelectedItem != null)
            {
                string selectedUser = listBoxOnlineUsers.SelectedItem.ToString();
                userLoginStatus[selectedUser] = false;
                SaveUserLoginStatus();

                // Lógica para fechar o programa do usuário deslogado
                // Implementar a lógica de envio de sinal para o programa do usuário fechar

                MessageBox.Show($"Usuário {selectedUser} foi deslogado.");
                PopulateOnlineUsersList();
                LogActivity($"Deslogou o usuário {selectedUser}.");
            }
        }

        private void SaveUserLoginStatus()
        {
            File.WriteAllText("userLoginStatus.json", JsonConvert.SerializeObject(userLoginStatus, Formatting.Indented));
        }

        private void LogActivity(string activity)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetLocalIPAddress()} - {Environment.UserName} - {activity}{Environment.NewLine}";
            File.AppendAllText("activity_log.txt", logMessage);
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Local IP Address Not Found!";
        }
    }
}