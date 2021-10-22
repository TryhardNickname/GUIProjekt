using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MolkApp
{
    /// <summary>
    /// Interaction logic for Molk.xaml
    /// </summary>
    public partial class Molk : Window
    {
        private string[] pathToFile;

        public Molk(string[] file)
        {
            pathToFile = file;
            InitializeComponent();

            foreach (string element in pathToFile)
            {
                checkIfDirOrFile(element);
            }
        }

        private void checkIfDirOrFile(string path)
        {
            FileAttributes attr = File.GetAttributes(path);

            if (attr.HasFlag(FileAttributes.Directory))
                MessageBox.Show("Its a directory");
            else
                MessageBox.Show("Its a file");
        }
    }
}
