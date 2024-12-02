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
    /// <summary>
    /// Interaction logic for EditMovieWindow.xaml
    /// </summary>
    public partial class EditMovieWindow : Window
    {
        public Movie EditMovie { get; set; } // Reference to MainWIndow

        public EditMovieWindow()
        {
            InitializeComponent();
        }

        public void ShowEditMovie(Movie movie)
        {
            /********************************************
            * Retrieves the movie data from the data grid,
            * validates the data, and assigns into input fields.
            ********************************************/

            txtMovieName.Text = movie.MovieName;
            txtDirector.Text = movie.Director;
            txtYear.Text = movie.Year.ToString();
            txtMinute.Text = movie.Duration.ToString();
            Seen.IsChecked = movie.Seen;


            // Open the window modally when Movie is selected
            this.ShowDialog();

        }

        private void OnEditMovieClick(object sender, RoutedEventArgs e)
        {
            /********************************************
             * Retrieves the movie details from the input fields,
             * validates the data, and creates a new Movie object
             * to be added to the movie collection in MainWindow.
             ********************************************/

            //Retrieve from input fields
            string movieName = txtMovieName.Text;
            string director = txtDirector.Text;
            int year;
            int duration;
            bool seen = Seen.IsChecked ?? false;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(movieName) || string.IsNullOrWhiteSpace(director) ||
                !int.TryParse(txtYear.Text, out year) || !int.TryParse(txtMinute.Text, out duration))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (year <= 0 || year > DateTime.Now.Year + 15)
            {
                MessageBox.Show($"Please enter a valid year up to {DateTime.Now.Year + 15}.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (duration <= 0)
            {
                MessageBox.Show("Please enter a valid duration.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Create new Edit Movie object
            EditMovie = new Movie 
            {
                MovieName = movieName,
                Director = director,
                Year = year,
                Duration = duration,
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
