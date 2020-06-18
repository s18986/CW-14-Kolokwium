using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW_14_Kolokwium.DTO.Request;
using CW_14_Kolokwium.Models;
using CW_14_Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace CW_14_Kolokwium.Controllers
{
    [ApiController]
    [Route("api/championships")]
    public class ChampionshipController : ControllerBase
    {
        private readonly ChampionshipDbService _service;

        public ChampionshipController(ChampionshipDbService championshipDbService)
        {
            _service = championshipDbService;
        }
        KolosDbContext _kolosDbContext = new KolosDbContext();
        [HttpGet("{id}")]
        public IActionResult GetTeams(int id)
        {
            GetTeamsRequest request = new GetTeamsRequest();
            request.IDChampionship = id;
            IEnumerable<Team> lista = _service.GetTeams(request);
            return Ok(lista);
        }
        [HttpGet]
        public IActionResult GetTest()
        { 
            return Ok("Dziala");
        }
    }
}