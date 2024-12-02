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

        private void OnMovNameFilterClick(object sender, RoutedEventArgs e)
        {
            /********************************************
            * Retrieves the movie name from the input field,
            * validates the data, and creates a new Movie object
            * to be used as filter to the movie collection in MainWindow.
            ********************************************/

            // Retrieve values from input fields
            string movieName = txtMovieName.Text;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(movieName))
            {
                MessageBox.Show("Please fill the movie name.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Create a new Movie object
            MovieFilter = new Movie
            {
                MovieName = movieName,
                Director = "",
                Year = 0,
                Duration = 0,
                Seen = false
            };

            // Indicate success and close the window
            DialogResult = true;
            Close();
        }

        private void OnDirFilterClick(object sender, RoutedEventArgs e)
        {
            /********************************************
            * Retrieves the director from the input field,
            * validates the data, and creates a new Movie object
            * to be used as filter to the movie collection in MainWindow.
            ********************************************/

            // Retrieve values from input fields
            string director = txtDirector.Text;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(director))
            {
                MessageBox.Show("Please fill the director name.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Create a new Movie object
            MovieFilter = new Movie
            {
                MovieName = "",
                Director = director,
                Year = 0,
                Duration = 0,
                Seen = false
            };

            // Indicate success and close the window
            DialogResult = true;
            Close();
        }

        private void OnYearFilterClick(object sender, RoutedEventArgs e)
        {
            /********************************************
            * Retrieves the year from the input field,
            * validates the data, and creates a new Movie object
            * to be used as filter to the movie collection in MainWindow.
            ********************************************/

            // Retrieve values from input fields
            int year;

            // Validate input fields
            if (!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("Please fill in the year field.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (year <= 0)
            {
                MessageBox.Show("Please enter a valid year.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Create a new Movie object
            MovieFilter = new Movie
            {
                MovieName = "",
                Director = "",
                Year = year,
                Duration = 0,
                Seen = false
            };

            // Indicate success and close the window
            DialogResult = true;
            Close();
        }

        private void OnDurationFilterClick(object sender, RoutedEventArgs e)
        {
            /********************************************
            * Retrieves the duration from the input field,
            * validates the data, and creates a new Movie object
            * to be used as filter to the movie collection in MainWindow.
            ********************************************/

            // Retrieve values from input fields
            int duration;

            // Validate input fields
            if (!int.TryParse(txtMinute.Text, out duration))
            {
                MessageBox.Show("Please fill in the duration field.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (duration <= 0)
            {
                MessageBox.Show("Please enter a valid duration.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Create a new Movie object
            MovieFilter = new Movie
            {
                MovieName = "",
                Director = "",
                Year = 0,
                Duration = duration,
                Seen = false
            };

            // Indicate success and close the window
            DialogResult = true;
            Close();
        }
        
        private void OnSeenFilterClick(object sender, RoutedEventArgs e)
        {
            /********************************************
            * Retrieves the watch status from the input field,
            * validates the data, and creates a new Movie object
            * to be used as filter to the movie collection in MainWindow.
            ********************************************/

            // Retrieve values from input fields
            bool seen = Seen.IsChecked ?? false;

            // Create a new Movie object
            MovieFilter = new Movie
            {
                MovieName = "",
                Director = "",
                Year = -1,
                Duration = -1,
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
