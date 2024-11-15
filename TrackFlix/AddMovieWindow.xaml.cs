using System.Security.Cryptography.X509Certificates;
using System.Windows;
using TrackFlix1;

namespace TrackFlix
{
   
    public partial class AddMovieWindow : Window
    {
        public Movie NewMovie { get; set; } // Reference to MainWindow
        public AddMovieWindow()
        {
            InitializeComponent();
        }

        // Handiling the add button click
        private void OnAddMovieClick(object sender, RoutedEventArgs e)
        {
            // Retrive valies from the input fields
            string movieName = txtMovieName.Text;
            string director = txtDirector.Text;
            // Inizialise integer varibale, will insert values inside the variable.
            int year;
            int duration;
            // True/Flase statemnt for status
            bool seen = Seen.IsChecked ?? false;


            // Validate the input fields
            if (string.IsNullOrWhiteSpace(movieName) || string.IsNullOrWhiteSpace(director) ||
           !int.TryParse(txtYear.Text, out year) || !int.TryParse(txtMinute.Text, out duration))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
            // Indicate that the movie is successfully added, close the window
            DialogResult = true;
            Close();



        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;  // Indicate that no movie was added
            Close();
        }
    }
}
