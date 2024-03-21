using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace AD_Password_Reset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //get-adusers and foreach loop to add all users to the combobox
            usernameDrop.Items.Add("User1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string newPassword = newPasswordBox.Text;
            InstallViaPowerShell(newPassword, username);
        }
        public static void InstallViaPowerShell(object newPasswordString, object usernameString)
        {
            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy ByPass $Pass = ConvertTo-SecureString \"{newPasswordString}\" -AsPlainText -Force\r\nSet-ADAccountPassword -Identity \"{usernameString}\" -NewPassword $Pass -Reset -PassThru | Set-ADUser -ChangePasswordAtLogon $true\r\nWrite-Host -NoNewLine 'Press any key to continue...';\r\n$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
