using System.Windows;
using TrackFlix1;

namespace TrackFlix
{

    public partial class AddMovieWindow : Window
    {
        public Movie NewMovie { get; set; }
        public AddMovieWindow()
        {
            InitializeComponent();
        }

        private void OnAddMovieClick(object sender, RoutedEventArgs e)
        {
            /********************************************
            * Retrieves the movie details from the input fields,
            * validates the data, and creates a new Movie object
            * to be added to the movie collection in MainWindow.
            ********************************************/

            // Retrieve values from input fields
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

            // Create a new Movie object
            NewMovie = new Movie
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
            * preventing any movie from being added, and closes the window.
            ********************************************/

            DialogResult = false;  // Indicate that no movie was added
            Close();
        }
    }
}
