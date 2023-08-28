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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MenuDesign.MVVM.View
{
    /// <summary>
    /// Interação lógica para HomeView.xam
    /// </summary>
    public partial class HomeView : UserControl
    {
        private int currentMusic = 0;
        private const string imagem1 = "/Images/trexvegano.jpeg";
        private Uri[] musicPaths = new Uri[6];
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private string[] artists = { "TRex Vegano", "AcousticS", "The Tectives", "Docs", "Psycho", "Skulls" };
        private string[] songs = { "TRex Responde #3", "The Sound", "Clue", "Documentary #3", "Horror day", "Spooky"};
        private string[] imagens = { "/Images/trexvegano.jpeg", "/Images/guitar.png", "/Images/detetive.jpeg", "/Images/documentary.png", "/Images/horror.png", "/Images/spooky.png" };
        private string[] paths = { "/Users/joser/source/repos/MenuDesign/MenuDesign/Media/normalized.mp3", "/Users/joser/source/repos/MenuDesign/MenuDesign/Media/acoustic.mp3", "/Users/joser/source/repos/MenuDesign/MenuDesign/Media/detective.mp3", "/Users/joser/source/repos/MenuDesign/MenuDesign/Media/documentary.mp3", "/Users/joser/source/repos/MenuDesign/MenuDesign/Media/horror.mp3", "/Users/joser/source/repos/MenuDesign/MenuDesign/Media/spooky.mp3" };
        public HomeView()
        {
            InitializeComponent();
            InitializeMp3();
           


        }

        private void InitializeMp3()
        {
            for(int i = 0; i < 6; i++)
            {
                this.musicPaths[i] = new Uri(paths[i], UriKind.Relative);
            }
        }
        private void playMusic(int i)
        {   
            imageViewer.Source = new BitmapImage(new Uri(imagens[i], UriKind.Relative));
            lblStatus1.Content = artists[i];
            lblStatus2.Content = songs[i];  
            mediaPlayer.Stop();
            mediaPlayer.Open(new Uri(paths[i], UriKind.Relative));
            mediaPlayer.Play();
        }

        private void btnPlay_Click1(object sender, RoutedEventArgs e)
        {
            this.currentMusic = 0;
            playMusic(currentMusic);
        }
        private void btnPlay_Click2(object sender, RoutedEventArgs e)
        {
            this.currentMusic = 1;
            playMusic(currentMusic);
        }
        private void btnPlay_Click3(object sender, RoutedEventArgs e)
        {
            this.currentMusic = 2;
            playMusic(currentMusic);
        }
        private void btnPlay_Click4(object sender, RoutedEventArgs e)
        {
            this.currentMusic = 3;
            playMusic(currentMusic);
        }
        private void btnPlay_Click5(object sender, RoutedEventArgs e)
        {
            this.currentMusic = 4;
            playMusic(currentMusic);
        }
        private void btnPlay_Click6(object sender, RoutedEventArgs e)
        {
            this.currentMusic = 5;
            playMusic(currentMusic);
        }
        public void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            this.currentMusic = (this.currentMusic + 1) % 6;
            playMusic(currentMusic);
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.currentMusic = (this.currentMusic - 1) % 6;
            playMusic(currentMusic);
        }
    }
}
