using GalaSoft.MvvmLight;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models;

namespace MyLeagueApp.WPF.ViewModel
{
    /// <summary>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            //Doe hier iets mee!
            StinoLibrary.ILeaugeApi api = new StinoLibrary.MyLeaugeApi();
        }
    }
}