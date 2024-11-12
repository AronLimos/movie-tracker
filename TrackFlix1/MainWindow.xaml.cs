using System.Windows;
using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

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

            LoadMovies();
            DataContext = this;
        }
        private void LoadMovies()
        {
            var json = File.ReadAllText("MovieData.json");
            Movies = JsonConvert.DeserializeObject<ObservableCollection<Movie>>(json);

       
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
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
                MessageBox.Show("Please select a movie to delete.", "No Movie Selected", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SaveMoviesToJson()
        {
            var json = JsonConvert.SerializeObject(Movies, Formatting.Indented);
            File.WriteAllText("MovieData.json", json);
        }
    }
    public class Movie
    {
        public string MovieName { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public bool Seen { get; set; }
    }
}