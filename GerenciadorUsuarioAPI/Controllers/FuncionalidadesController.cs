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
    public class FuncionalidadesController : ControllerBase
    {
        private readonly GerenciadorUsuarioDbContext _context;

        public FuncionalidadesController(GerenciadorUsuarioDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET: api/Funcionalidades - Retorna todas as funcionalidades
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Funcionalidades>>> GetFuncionalidades()
        {
            return await _context.Funcionalidades.ToListAsync();
        }

        /// <summary>
        /// GET: api/Funcionalidades/5 - Retorna uma funcionalidade por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Funcionalidades>> GetFuncionalidades(int id)
        {
            var funcionalidades = await _context.Funcionalidades.FindAsync(id);

            if (funcionalidades == null)
            {
                return NotFound();
            }

            return funcionalidades;
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        /// <summary>
        /// PUT: api/Funcionalidades/5 - Atualiza funcionalidade por id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="funcionalidades"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuncionalidades(int id, Funcionalidades funcionalidades)
        {
            if (id != funcionalidades.IdFuncionalidade)
            {
                return BadRequest();
            }

            _context.Entry(funcionalidades).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuncionalidadesExists(id))
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
        /// POST: api/Funcionalidades - Adiciona nova funcionalidade
        /// </summary>
        /// <param name="funcionalidades"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Funcionalidades>> PostFuncionalidades(Funcionalidades funcionalidades)
        {
            _context.Funcionalidades.Add(funcionalidades);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuncionalidades", new { id = funcionalidades.IdFuncionalidade }, funcionalidades);
        }

        /// <summary>
        /// DELETE: api/Funcionalidades/5 - Remove funcionalide por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Funcionalidades>> DeleteFuncionalidades(int id)
        {
            var funcionalidades = await _context.Funcionalidades.FindAsync(id);
            if (funcionalidades == null)
            {
                return NotFound();
            }

            _context.Funcionalidades.Remove(funcionalidades);
            await _context.SaveChangesAsync();

            return funcionalidades;
        }

        private bool FuncionalidadesExists(int id)
        {
            return _context.Funcionalidades.Any(e => e.IdFuncionalidade == id);
        }
    }
}
