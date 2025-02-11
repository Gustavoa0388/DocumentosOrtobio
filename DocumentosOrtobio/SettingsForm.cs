using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace DocumentosOrtobio
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            if (createUserForm.ShowDialog() == DialogResult.OK)
            {
                LogActivity("Criou um novo usuário.");
            }
        }

        private void BtnGenerateLogReport_Click(object sender, EventArgs e)
        {
            GenerateLogReport();
        }

        private void GenerateLogReport()
        {
            string logReportPath = @"\\ntortobio\Central\Arquivos Diversos\Instalação\Basico\DocumentosOrtobio\DocumentosOrtobio\bin\Debug\log_report.txt";
            string logContent = File.ReadAllText("activity_log.txt");
            File.WriteAllText(logReportPath, logContent);
            MessageBox.Show($"Relatório de logs gerado em: {logReportPath}");
            LogActivity("Gerou um relatório de logs.");
        }

        private void BtnOnlineUsers_Click(object sender, EventArgs e)
        {
            OnlineUsersForm onlineUsersForm = new OnlineUsersForm();
            onlineUsersForm.ShowDialog();
            LogActivity("Abriu o painel de controle de usuários online.");
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