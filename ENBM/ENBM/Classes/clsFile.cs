using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENBM.Classes
{
    public class clsFile
    {
        private OpenFileDialog Dialog { get; set; }
        private ArrayList Files { get; set; }
        private bool blnExists { get; set; }
        private string strDestination { get; set; }

        public clsFile()
        {
            Dialog = new OpenFileDialog();
            Dialog.Title = "Folder";
            Dialog.Multiselect = true;
            Dialog.Filter = "All files (*.*)|*.*";
        }
        /*#Create a OpenFileDialog for the user that can be used to select files*/
        public ArrayList InitializeFileDialog()
        {
            try
            {
                if (Dialog.ShowDialog() == true)
                {
                    Files = new ArrayList();
                    foreach (var path in Dialog.FileNames)
                    {
                        if (path != null)
                        {
                            Files.Add(path);
                        }
                    }
                    return Files;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /*#Search for the Skyrim Special Edition installation folder*/
        public string InitializeDestination()
        {
            string[] paths = { @"Program Files", @"Program Files (x86)\TestMap" };
            string[] drives = System.IO.Directory.GetLogicalDrives();
            foreach (var drive in drives)
            {
                foreach (var possiblePath in paths)
                {
                    if (Directory.Exists(Path.Combine(drive.ToString(), possiblePath)))
                    {
                        strDestination = Path.Combine(drive.ToString(), possiblePath);
                        if (strDestination.Contains("TestMap"))
                        {
                            blnExists = true;
                        }
                    }
                }
                if (blnExists)
                {
                    return strDestination;
                }           
            }
            if (!blnExists)
            {
                strDestination = "404";
                return strDestination;
            }
            return "404";
        }
    }
}

