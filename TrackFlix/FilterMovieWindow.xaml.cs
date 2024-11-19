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
using System.Windows.Shapes;
using TrackFlix1;

namespace TrackFlix
{

    public partial class FilterMovieWindow : Window
    {
        public Movie MovieFilter { get; set; }
        public FilterMovieWindow() // Reference to MainWIndow
        {
            InitializeComponent();
        }

        private void OnFilterMovieClick(object sender, RoutedEventArgs e)
        {
            // Code here and logic here
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            /********************************************
           * Indicates that the user canceled the operation,
           * preventing any movie from being updated, and closes the window.
           ********************************************/

            DialogResult = false;  // Indicate that no movie was added
            Close();
        }
    }
}
