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
using System.Xml.Linq;
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
            /********************************************
            * Retrieves the movie details from the input fields,
            * validates the data, and creates a new Movie object
            * to be used as filter to the movie collection in MainWindow.
            ********************************************/

            // Retrieve values from input fields
            string movieName = txtMovieName.Text;
            string director = txtDirector.Text;
            string year = txtYear.Text;
            string duration = txtMinute.Text;
            int intYear;
            int intDuration;
            bool seen = Seen.IsChecked ?? false;

            // Validate input fields
            if (string.IsNullOrEmpty(year))
            {
                intYear = 0;
            }
            else
            {
                intYear = int.Parse(year);
            }

            if (string.IsNullOrEmpty(duration))
            {
                intDuration = 0;
            }
            else
            {
                intDuration = int.Parse(duration);
            }

            // Create a new Movie object
            MovieFilter = new Movie
            {
                MovieName = movieName,
                Director = director,
                Year = intYear,
                Duration = intDuration,
                Seen = seen
            };

            // Indicate success and close the window
            DialogResult = true;
            Close();

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
