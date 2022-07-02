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
        private string fileName = String.Empty;
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
            // TODO - Update the OpenButton_Click method
            // Call GetFileName to get the name of the file to load            
            
            // Populate the editor TextBox with the file contents
         }

        // TODO - Implement a method to get the file name
        // Add a GetFileName method
 

        // Save the data back to the file
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO - Update the SaveButton_Click method
            // Write the contents of the editor TextBox back to the file
        }
    }   
}
