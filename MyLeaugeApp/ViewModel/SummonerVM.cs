using GalaSoft.MvvmLight;
using PortableLeagueApi.Interfaces.Summoner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLeaugeApp.ViewModel
{
    public class SummonerVM : ViewModelBase
    {
        private ISummoner _summoner;

        public String Name
        {
            get { return _summoner.Name; }
        }

        public long Level
        {
            get { return _summoner.SummonerLevel; }
        }

        public int IconId
        {
            get { return _summoner.ProfileIconId; }
        }

        public SummonerVM(PortableLeagueApi.Interfaces.Summoner.ISummoner summoner)
        {
            // TODO: Complete member initialization
            this._summoner = summoner;
            RaisePropertyChanged();
        }
    }
}
