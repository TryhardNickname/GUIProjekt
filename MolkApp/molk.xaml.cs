using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public Molk(string[] files)
        {
            pathToFile = files;
            InitializeComponent();

            foreach (string element in pathToFile)
            {
                Debug.WriteLine(element);
            }
        }
    }
}
