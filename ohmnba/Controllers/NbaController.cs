using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoORM4NetCore;
using MongoORM4NetCore.Interfaces;
using Newtonsoft.Json;
using ohmnba.apiModels.ScoreBoard;
using ohmnba.entities;
using ohmnba.Infrastructure;
using oohmnba.models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ohmnba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NbaController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly Crud<entities.Team> teamCrud;
        private readonly NbaEndpoints nbaEndpoints;
        private readonly IMapper mapper;
        public NbaController(IConfiguration configuration, IRepository<entities.Team> teamCrud, NbaEndpoints nbaEndpoints, IMapper mapper)
        {
            _configuration = configuration;
            this.nbaEndpoints = nbaEndpoints;
            this.mapper = mapper;
        }


        [HttpGet("GetTodaysMatchs")]
        public IEnumerable<GameViewModel> Get(DateTime? date)
        {
            return nbaEndpoints.GetScoreBoard(date).Select(x=> mapper.Map<GameViewModel>(x));
        }
    }
}
