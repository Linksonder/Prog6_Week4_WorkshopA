using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StinoLeaugeApi
{
    public class MyLeaugeApi : ILeaugeApi
    {
        private string key = "07e76f39-f226-4ee6-b572-9de1c71c13cb";
        public ISummoner GetSummonerByName(string name)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var leagueAPI = new LeagueApi(key, RegionEnum.Euw, true);
                    var task = leagueAPI.Summoner.GetSummonerByNameAsync(name);
                    task.Wait();
                    ISummoner summoner = task.Result;
                    return summoner;
                }
            }
            catch (Exception e)
            {
                throw new KeyNotFoundException("Er is geen summoner met de naam " + name);
            }
           
        }

        public IItemList GetAllItems()
        {
            using (var client = new HttpClient())
            {
                var leagueAPI = new LeagueApi(key, RegionEnum.Euw, true);
                var task = leagueAPI.Static.GetItemsAsync();
                task.Wait();
                IItemList items = task.Result;
                return items;
            }
        }

        public IItem GetItemById(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var leagueAPI = new LeagueApi(key, RegionEnum.Euw, true);
                    var task = leagueAPI.Static.GetItemsAsync(
                          id,
                          ItemDataEnum.All,
                          languageCode: LanguageEnum.EnglishUK);

                    task.Wait();

                    IItem item = task.Result;
                    return item;
                }
            }
            catch (Exception e)
            {
                throw new KeyNotFoundException("Er is geen item met het id " + id);
            }
        }
    }
}
