using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ENBM.Classes;

namespace ENBM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        clsFile File = new clsFile();
        private string strInstallationPath { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InitializeInstaller();
        }
        public string InitializeInstaller()
        {
            try
            {
                var strPath = File.InitializeDestination();
                return strInstallationPath = strPath;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnInstaller_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frmInstall newfrmInstall = new frmInstall(strInstallationPath);
                newfrmInstall.Width = this.Width;
                newfrmInstall.Height = this.Height;
                newfrmInstall.WindowStartupLocation = this.WindowStartupLocation;
                newfrmInstall.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnToggleHelp_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ctlAbout newctlAbout = new ctlAbout();
                newctlAbout.Width = 500;
                newctlAbout.Height = 500;
                newctlAbout.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                newctlAbout.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

