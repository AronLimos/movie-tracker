/****************************************************************
 * Project Name: TracKFlix: Personal Movie Tracker Desktop App
 *      Authors: Joash Daligcon, 000358654
 *               Aron Limos, 000371798
 *               Lance Mirano, 000368826
 *   Created on: 2024-11-14
 *      Release: 1.0
 *  Description: Initial release includes the Movie List Display
 *               and Add & Delete Movie Record.
 ****************************************************************/

using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using TrackFlix;

namespace TrackFlix1
{
    public class Movie
    {
        /********************************************
        * Represents a movie with properties for name,
        * director, release year, duration, and watch status.
        ********************************************/
        public required string MovieName { get; set; }
        public required string Director { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public bool Seen { get; set; }
    }
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Movie> _movies;
        public ObservableCollection<Movie> Movies
        {
            /********************************************
            * Collection of Movie objects that notifies
            * the UI of any changes (additions or deletions).
            ********************************************/
            get => _movies;
            set
            {
                _movies = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public MainWindow()
        {
            /********************************************
            * Initializes the MainWindow components,
            * loads movie data from a JSON file, 
            * and sets the data context for data binding.
            ********************************************/
            InitializeComponent();

            // Load movie data from the JSON file.
            LoadMovies();

            // Set the DataContext for data binding in the UI.
            DataContext = this;
        }

        private void LoadMovies()
        {
            /********************************************
            * Loads movie data from MovieData.json into
            * an ObservableCollection using Newtonsoft.Json.
            * This collection automatically updates the UI.
            ********************************************/

            // Type of variable named "json" that reads data from (MovieData.json) File.
            var json = File.ReadAllText("MovieData.json");

            // ObservableCollection updates when add/delete for the Ui.
            // Movies will receive the collection inside JSON file, that will populate the data.
            // Movie will get the data through key value pairs.
            Movies = JsonConvert.DeserializeObject<ObservableCollection<Movie>>(json);
        }

        private void SaveMoviesToJson()
        {
            /********************************************
            * Saves the current movie collection to
            * MovieData.json in a formatted JSON structure.
            ********************************************/

            // Convert the ObservableCollection of movies to a formatted JSON string.
            var json = JsonConvert.SerializeObject(Movies, Formatting.Indented);

            // Write the JSON string to the file.
            File.WriteAllText("MovieData.json", json);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            /********************************************
            * Opens a dialog to add a new movie. If confirmed,
            * the new movie is added to the collection and
            * the JSON file is updated.
            ********************************************/

            // Instantiate the AddMovieWindow dialog
            AddMovieWindow addMovieWindow = new AddMovieWindow();

            // Show the dialog as a modal window
            bool? result = addMovieWindow.ShowDialog();

            if (result == true)
            {
                // Retrieve the newly added movie from AddMovieWindow
                Movie newMovie = addMovieWindow.NewMovie;

                // Add the new movie to the ObservableCollection
                Movies.Add(newMovie);

                // Save the updated movie collection to the JSON file
                SaveMoviesToJson();
            }
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            /********************************************
           * Opens a dialog to edit a movie. If confirmed,
           * the edited movie is updated to the collection and
           * the JSON file is updated.
           ********************************************/

            // Instantiate the AddMovieWindow dialog
            EditMovieWindow editMovieWindow = new EditMovieWindow();

            // Show thw dialog as a modal window
            bool? result = editMovieWindow.ShowDialog();
        }
        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            /********************************************
          * Opens a dialog to filter movies. If confirmed,
          * the movie filtered.
          ********************************************/

            // Instantiate the AddMovieWindow dialog
            FilterMovieWindow filterMovieWindow = new FilterMovieWindow();

            // Show thw dialog as a modal window
            bool? result = filterMovieWindow.ShowDialog();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            /****************************************************
            * Deletes the selected movie from the DataGrid
            * after user confirmation and updates the JSON file.
            ****************************************************/

            // Get the selected movie from the DataGrid
            var selectedMovie = DataGrid.SelectedItem as Movie;

            if (selectedMovie != null)
            {
                // Ask for confirmation before deleting
                var result = MessageBox.Show($"Are you sure you want to delete {selectedMovie.MovieName}?",
                                             "Delete Confirmation",
                                             MessageBoxButton.YesNo,
                                             MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    // Remove the movie from the ObservableCollection
                    Movies.Remove(selectedMovie);

                    // Save the updated collection to the JSON file
                    SaveMoviesToJson();
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to delete.",
                                "No Movie Selected",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }

        
    }
}