using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Learner.Server.Data;
using Blazor.Learner.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Learner.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpriteMapController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public SpriteMapController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var devs = await _context.SpriteMaps.ToListAsync();
            return Ok(devs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dev = await _context.SpriteMaps.FirstOrDefaultAsync(a=>a.Id ==id);
            return Ok(dev);
        }
        [HttpPost]
        public async Task<IActionResult> Post(SpriteMap spriteMap)
        {
            _context.Add(spriteMap);
            await _context.SaveChangesAsync();
            return Ok(spriteMap.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(SpriteMap spriteMap)
        {
            _context.Entry(spriteMap).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var spriteMap = new SpriteMap { Id = id };
            _context.Remove(spriteMap);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}