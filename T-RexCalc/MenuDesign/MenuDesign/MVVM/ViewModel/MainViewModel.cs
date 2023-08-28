using MenuDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDesign.MVVM.ViewModel
{
    class MainViewModel : ObjetoObservavel
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand VideosViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public VideosViewModel VideosVm { get; set; }

        private object currentView;
        public object CurrentView
        {
            get { return currentView; }
            set { currentView = value; OnPropertyChanged(); }

        }
        public MainViewModel() 
        { 
            HomeVm = new HomeViewModel();
            VideosVm = new VideosViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVm;
            });

            VideosViewCommand = new RelayCommand(o => 
            {
                CurrentView = VideosVm;
            });
        }  
    }
}
