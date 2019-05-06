using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using entities;
using entities.viewmodels;
using bll;

namespace GamesList.Controllers
{
    public class GamesController : Controller
    {
        
        GetGamesData listgames = new GetGamesData();
         private readonly IBusinessLogic ContactsRepo;
        //public IBusinessLogic ContactsRepo { get; set; }   
        public GamesController(IBusinessLogic _repo)
        {
            ContactsRepo = _repo;
        }

        [HttpGet]
        [Route("api/games/")]
        public async Task<IActionResult> Get()
        {
            var result = await ContactsRepo.GetAllGames();
            if(result == null)
            return NotFound();
            return Ok(result);
        }
        /*
        // GET api/games/5
        [HttpGet]
         [Route("api/games/{id}")]
        public IActionResult Get(int id)
        {
            var result = listgames.GetDataID(id);
            if(result == null)
            return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("api/Genre/{name}")]
        public IActionResult Get(string name)
        {
            var result = listgames.GetGamesByName(name);
            if(result == null)
            return NotFound();
            return Ok(result);
        }
        [HttpGet]
        [Route("api/games/{count}/{page}")]
        public IActionResult Get(int count, int page, string search)
        {           
            var result = listgames.SearchFilterGames(count, page, search);
            if(result == null)
            return NotFound();
            return Ok(result);

        }
        */
    }
}
