using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/playlist")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public PlaylistController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int]")]
        public IActionResult Get(int id)
        {
            return Ok(_unit.Playlists.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Playlists.GetList());
        }

        [HttpPost]
        public int Add(Playlist playlist)
        {
            return _unit.Playlists.Add(playlist);
        }

        [HttpPut]
        public bool Update(Playlist playlist)
        {
            return _unit.Playlists.Update(playlist);
        }

        [HttpDelete]
        public bool Delete(Playlist playlist)
        {
            return _unit.Playlists.Delete(playlist);
        }
    }
}