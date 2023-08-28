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
using System.Windows.Threading;

namespace MenuDesign.MVVM.View
{
    /// <summary>
    /// Interação lógica para VideosView.xam
    /// </summary>
    /// 
    public partial class VideosView : UserControl
    {
        private int currentVideo = 1;
        private string[] names = { "Rick Astlay", "Fat Bunny" };
        private string[] paths = { "/Users/joser/source/repos/MenuDesign/MenuDesign/Media/rick.mp4", "/Users/joser/source/repos/MenuDesign/MenuDesign/Media/bunny2.mp4" };
        public VideosView()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void playVideo()
        {
            lblStatus1.Content = names[currentVideo];
            Player.Stop();
            Player.Source = new Uri(paths[currentVideo], UriKind.Relative);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            Player.Play();
        }


        void timer_Tick(object sender, EventArgs e)
        {
            if (Player.Source != null)
            {
                if (Player.NaturalDuration.HasTimeSpan)
                    
                    lblStatus2.Content = String.Format("{0} / {1}", Player.Position.ToString(@"mm\:ss"), Player.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lblStatus1.Content = "Aperte play";
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            lblStatus1.Content = names[currentVideo];
            Player.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            Player.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            Player.Stop();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            currentVideo = (currentVideo + 1) % paths.Length;
            playVideo();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e) 
        {
            currentVideo = (currentVideo - 1) % paths.Length;
            playVideo();
        }
    }
}
