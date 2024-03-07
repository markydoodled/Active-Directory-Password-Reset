using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Management;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ActiveDirectoryPasswordReset
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var size = new Size(500, 400);
            ApplicationView.PreferredLaunchViewSize = size;
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            Window.Current.CoreWindow.SizeChanged += (s, e) => {
                ApplicationView.GetForCurrentView().TryResizeView(size);

            };
        }
        //function to reset password
        private void ResetActiveDirectoryPassword()
        {
            /*using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                PowerShellInstance.AddCommand("$Pass = ConvertTo-SecureString "Password@123" -AsPlainText -Force");
                PowerShellInstance.AddCommand("Set-ADAccountPassword -Identity txtUsername -NewPassword $Pass -Reset -PassThru | Set-ADUser -ChangePasswordAtLogon $true");
            }*/

            //$Pass = ConvertTo-SecureString "Password@123" -AsPlainText -Force 
            //Set-ADAccountPassword -Identity txtUsername -NewPassword $Pass -Reset -PassThru | Set-ADUser -ChangePasswordAtLogon $true

            // Create PowerShell runspace
            //Windows.System.Launcher.LaunchUriAsync(new Uri(""));
        }
        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Submit Button Clicked");
            //Access Powershell And Reset Active Directory Password
            ResetActiveDirectoryPassword();
            InstallViaPowerShell();
        }
        public static void InstallViaPowerShell()
        {

            var ps1File = @"C:\Users\mark.howard\GitHub\Active-Directory-Password-Reset\reset.ps1";

            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy ByPass -File \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);

        }
    }
}