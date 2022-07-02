using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace FileEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Name of file in use
        /// </summary>
        private string fileName = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open the file after the user has been prompted for the file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            fileName = GetFileName();
            if (fileName != String.Empty)
            {
                editor.Text = TextFileOperations.ReadTextFileContents(fileName);
            }
        }

        /// <summary>
        /// Use the common dialog to get a valid file name.
        /// Filtering for .txt.
        /// Starting in predefined location.
        /// </summary>
        private string GetFileName()
        {
            // Initialize the file name.
            string fname = String.Empty;

            // Declare open file dialog box.
            OpenFileDialog openFileDlg = new OpenFileDialog();
            // Configure open file dialog box.
            openFileDlg.InitialDirectory = @"E:\Labfiles\Lab 5\Ex1\Solution";
            openFileDlg.DefaultExt = ".txt"; // Default file extension
            openFileDlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box.
            bool? result = openFileDlg.ShowDialog();

            // Process open file dialog box results.
            if (result == true)
            {
                // Open document.
                fname = openFileDlg.FileName;
            }
            return fname;
        }

        // Save the data back to the file.
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (fileName != String.Empty)
            {
                TextFileOperations.WriteTextFileContents(fileName, editor.Text);
            }
        }
    }    
}
