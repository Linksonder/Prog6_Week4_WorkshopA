using GalaSoft.MvvmLight;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueAPI;
using StinoLeaugeApi;
using System.Net.Http;

namespace MyLeaugeApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        private string key = "07e76f39-f226-4ee6-b572-9de1c71c13cb";

        private MyLeaugeApi _api;

        public SummonerVM Summoner { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            _api = new MyLeaugeApi();
            Summoner = new SummonerVM(_api.GetSummonerByName("Links0nder"));
        }

      
    }
}