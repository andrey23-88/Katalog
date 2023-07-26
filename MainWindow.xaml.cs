using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Windows.Forms;

namespace WpfCatalog
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       


        private void LoadDirectory(string path)
        {
            var directoryItem = new DirectoryItem(path);
            listik.ItemsSource = directoryItem.Files;
            expander.Header = directoryItem.Name;
            expander.Content = listik;
        }

        private void clk(object sender, RoutedEventArgs e)
        {
            string pp = @"E:\Course";
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            pp = dialog.SelectedPath;
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    pp = dialog.SelectedPath;
            //   
            //}
             //pp = @"E:\Course";//Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\");
            LoadDirectory(pp);
        }
    }
}
