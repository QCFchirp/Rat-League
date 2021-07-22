using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Camille;
using Camille.RiotGames.ChampionV3;
using System.Data;
using Camille.Enums;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RiotAPIController : ControllerBase
    {
        //Connects to riot api/
        string platformRouting = "na1.api.riotgames.com";
        string RegionalRouting = "americas.api.riotgames.com";

        string CharacterDataURL= "http://ddragon.leagueoflegends.com/cdn/11.15.1/data/en_US/champion.json";

        static string APIkey = "RGAPI-c3dd2fa2-acee-471d-baec-5759f26bf855";

        static MingweiSamuel.Camille.RiotApi riotApi = RiotApi.NewInstance(APIkey);

        private readonly ILogger<WeatherForecastController> _logger;

        public RiotAPIController()
        {}

        [HttpGet ("SummonerTest")]
        public async Task<ActionResult<Summoner>> summonerTest(string summonerName){
             return riotApi.SummonerV4.GetBySummonerName(Region.NA, "WGKaribu");

        }
        public static List<ChampionDTO> fetchRiotChampionData(){
            List<ChampionDTO>Champions = new List<ChampionDTO>();
            return Champions;
        }
        [HttpGet]
        public async Task<ActionResult<string>> test(){
            return "here";

        }
        //[HttpGet ("All")]
        // public Task<ActionResult<Camille.Enums.Champion>> getAllChamps(){
        //     return Camille.Enums.Champion.AATROX;
        // }



    }
}
