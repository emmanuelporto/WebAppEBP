using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GerenciadorUsuarioAPI;
using UserLibrary;

namespace GerenciadorUsuarioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilsController : ControllerBase
    {
        private readonly GerenciadorUsuarioDbContext _context;

        public PerfilsController(GerenciadorUsuarioDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET: api/Perfils - Retorna todos perfils
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Perfil>>> GetPerfils()
        {
            return await _context.Perfils.ToListAsync();
        }

        /// <summary>
        /// GET: api/Perfils/5 - Retorna perfil por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Perfil>> GetPerfil(int id)
        {
            var perfil = await _context.Perfils.FindAsync(id);

            if (perfil == null)
            {
                return NotFound();
            }

            return perfil;
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        /// <summary>
        /// PUT: api/Perfils/5 - Atualiza perfil por id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="perfil"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerfil(int id, Perfil perfil)
        {
            if (id != perfil.IdPerfil)
            {
                return BadRequest();
            }

            _context.Entry(perfil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerfilExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        /// <summary>
        /// POST: api/Perfils - Adiciona novo perfil
        /// </summary>
        /// <param name="perfil"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Perfil>> PostPerfil(Perfil perfil)
        {
            _context.Perfils.Add(perfil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerfil", new { id = perfil.IdPerfil }, perfil);
        }

        /// <summary>
        /// DELETE: api/Perfils/5 - Remove perfil por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Perfil>> DeletePerfil(int id)
        {
            var perfil = await _context.Perfils.FindAsync(id);
            if (perfil == null)
            {
                return NotFound();
            }

            _context.Perfils.Remove(perfil);
            await _context.SaveChangesAsync();

            return perfil;
        }

        private bool PerfilExists(int id)
        {
            return _context.Perfils.Any(e => e.IdPerfil == id);
        }
    }
}
