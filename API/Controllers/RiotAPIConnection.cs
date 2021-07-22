using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RiotAPIConnections : ControllerBase
    {
        //Connects to riot api/
        string platformRouting = "na1.api.riotgames.com";
        string RegionalRouting = "americas.api.riotgames.com";

        string CharacterDataURL= "http://ddragon.leagueoflegends.com/cdn/11.15.1/data/en_US/champion.json";

        string APIkey = "RGAPI-c3dd2fa2-acee-471d-baec-5759f26bf855";
        private readonly ILogger<WeatherForecastController> _logger;

        public RiotAPIConnections(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

    }
