using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Interfaces.Summoner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StinoLeaugeApi
{
    public interface ILeaugeApi
    {
        ISummoner GetSummonerByName(string name);

        IItemList GetAllItems();

        IItem GetItemById(int id);
    }
}
