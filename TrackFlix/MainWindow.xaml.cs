using System.Windows;
using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using TrackFlix;
// Must Install Package extension NewtonSoft.Json
// To access between jason library.

namespace TrackFlix1
{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Movie> _movies;
        public ObservableCollection<Movie> Movies
        {
            get => _movies;
            set
            {
                _movies = value;
                OnPropertyChanged();
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            // Instantiate a component for Reading JSon File
            // DataContex is set to get the data of context 

            LoadMovies();
            DataContext = this;

        }

        // Create a class that only accesible within LoadMovies.
        // LoadMovies will read JSON file.
        private void LoadMovies()
        {
            // Type of variable named "json" that reads data from (MovieData.json) File.
            // Lets Movies convert JSON file into .NET usinng NewtonSoft Library.
            // ObservableCollection updates when add/delete for the Ui.
            // Movies will recive the collection inside JSON file, that will populate the data.
            // Movie will get the data through key value pairs. 

            var json = File.ReadAllText("MovieData.json");
            Movies = JsonConvert.DeserializeObject<ObservableCollection<Movie>>(json);
      
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected movie from the DataGrid
            var selectedMovie = DataGrid.SelectedItem as Movie; // 'DataGrid' is the name of your DataGrid

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
                MessageBox.Show("Please select a movie to delete.", "No Movie Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void SaveMoviesToJson()
        {
            var json = JsonConvert.SerializeObject(Movies, Formatting.Indented);
            File.WriteAllText("MovieData.json", json);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            // Instainiate of AddMovieWindow
            AddMovieWindow addMovieWindow = new AddMovieWindow();
            //show the windows as modal dialog
            bool? result = addMovieWindow.ShowDialog();
            if (result == true)
            {
                // Retrieve the newly added movie from the AddMovieWindow
                Movie newMovie = addMovieWindow.NewMovie;

                // Add the new movie to the Movies collection
                Movies.Add(newMovie);

                // Optionally, save the movies back to the JSON file
                SaveMoviesToJson();
            }
        }
    }
    public class Movie
    {
        public required string MovieName { get; set; }
        public required string Director { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public bool Seen { get; set; }
    }
}