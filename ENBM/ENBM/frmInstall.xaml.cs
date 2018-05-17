using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using ENBM.Classes;

namespace ENBM
{
    /// <summary>
    /// Interaction logic for frmInstall.xaml
    /// </summary>
    public partial class frmInstall : Window
    {
        clsFile File = new clsFile();
        private string strReceivedPath { get; set; }

        public frmInstall(string strDestination)
        {
            InitializeComponent();
            strReceivedPath = strDestination;
            CheckPath(strReceivedPath);
        }
        private void CheckPath(string strReceivedPath)
        {
            try
            {
                if (strReceivedPath == "404")
                {
                    var initResult = MessageBox.Show("Skyrim SE Install Directory could not be detected. Would you like to manually set it?", "Installation directory not detected!", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    switch (initResult)
                    {
                        case MessageBoxResult.OK:
                            break;
                        case MessageBoxResult.Cancel:
                            break;
                    }
                }
                else
                {
                    lblDestination.Content = strReceivedPath;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnFolder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Files = File.InitializeFileDialog();
                if (Files != null)
                {
                    foreach (var File in Files)
                    {
                        lbFrom.Items.Add(File);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnLocation_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
