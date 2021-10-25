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
        private Dictionary<string, bool> arguments;

        public Molk(string[] file)
        {
            pathToFile = file;
            arguments = new Dictionary<string, bool>();

            InitializeComponent();

            //foreach (string element in pathToFile)
            //{
            //    checkIfDirOrFile(element);
            //}
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "-f":
                    arguments.Add("-f", true);
                    break;
                case "-d":
                    arguments.Add("-d", true);
                    break;
                case "-r":
                    arguments.Add("-r", true);
                    break;
                case "-0":
                    arguments.Add("-0", true);
                    break;
                case "-1":
                    arguments.Add("-1", true);
                    break;
                case "-q":
                    arguments.Add("-q", true);
                    break;
                case "-c":
                    arguments.Add("-c", true);
                    break;
                case "-@":
                    arguments.Add("-@", true);
                    break;
                case "-x":
                    arguments.Add("-x", true);
                    break;
                case "-F":
                    arguments.Add("-F", true);
                    break;
                case "-A":
                    arguments.Add("-A", true);
                    break;
                case "-T":
                    arguments.Add("-T", true);
                    break;
                case "-!":
                    arguments.Add("-!", true);
                    break;
                case "-R":
                    arguments.Add("-R", true);
                    break;
                case "-$":
                    arguments.Add("-$", true);
                    break;
                case "-e":
                    arguments.Add("-e", true);
                    break;
                case "-u":
                    arguments.Add("-u", true);
                    break;
                case "-m":
                    arguments.Add("-m", true);
                    break;
                case "-j":
                    arguments.Add("-j", true);
                    break;
                case "-l":
                    arguments.Add("-l", true);
                    break;
                case "-9":
                    arguments.Add("-9", true);
                    break;
                case "-v":
                    arguments.Add("-v", true);
                    break;
                case "-z":
                    arguments.Add("-z", true);
                    break;
                case "-o":
                    arguments.Add("-o", true);
                    break;
                case "-i":
                    arguments.Add("-i", true);
                    break;
                case "-D":
                    arguments.Add("-D", true);
                    break;
                case "-J":
                    arguments.Add("-J", true);
                    break;
                case "-X":
                    arguments.Add("-X", true);
                    break;
                case "-S":
                    arguments.Add("-S", true);
                    break;
                case "-n":
                    arguments.Add("-n", true);
                    break;
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "-f":
                    arguments.Remove("-f");
                    break;
                case "-d":
                    arguments.Remove("-d");
                    break;
                case "-r":
                    arguments.Remove("-r");
                    break;
                case "-0":
                    arguments.Remove("-0");
                    break;
                case "-1":
                    arguments.Remove("-1");
                    break;
                case "-q":
                    arguments.Remove("-q");
                    break;
                case "-c":
                    arguments.Remove("-c");
                    break;
                case "-@":
                    arguments.Remove("-@");
                    break;
                case "-x":
                    arguments.Remove("-x");
                    break;
                case "-F":
                    arguments.Remove("-F");
                    break;
                case "-A":
                    arguments.Remove("-A");
                    break;
                case "-T":
                    arguments.Remove("-T");
                    break;
                case "-!":
                    arguments.Remove("-!");
                    break;
                case "-R":
                    arguments.Remove("-R");
                    break;
                case "-$":
                    arguments.Remove("-$");
                    break;
                case "-e":
                    arguments.Remove("-e");
                    break;
                case "-u":
                    arguments.Remove("-u");
                    break;
                case "-m":
                    arguments.Remove("-m");
                    break;
                case "-j":
                    arguments.Remove("-j");
                    break;
                case "-l":
                    arguments.Remove("-l");
                    break;
                case "-9":
                    arguments.Remove("-9");
                    break;
                case "-v":
                    arguments.Remove("-v");
                    break;
                case "-z":
                    arguments.Remove("-z");
                    break;
                case "-o":
                    arguments.Remove("-o");
                    break;
                case "-i":
                    arguments.Remove("-i");
                    break;
                case "-D":
                    arguments.Remove("-D");
                    break;
                case "-J":
                    arguments.Remove("-J");
                    break;
                case "-X":
                    arguments.Remove("-X");
                    break;
                case "-S":
                    arguments.Remove("-S");
                    break;
                case "-n":
                    arguments.Remove("-n");
                    break;
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
