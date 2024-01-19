using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IUnitOfWork _unitofWork;

        public MakesController(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        // GET: api/Makes
        [HttpGet]
        // public async Task<ActionResult<IEnumerable<Make>>> GetMakes()

        public async Task<IActionResult> GetMakes()
        {
            var makes = await _unitofWork.Makes.GetAll();
            return Ok(makes);
            
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Make>> GetMake(int id)
        {
         var make = await _unitofWork.Makes.Get(q=>q.id == id);

            if (make == null)
            {
                return NotFound();
            }
            return Ok(make);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.id)
            {
                return BadRequest();
            }

            _unitofWork.Makes.Update(make);

            try
            {
                await _unitofWork.Save(HttpContext);
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!await MakeExists(id))
                {
                    return NotFound();
                }
            }
            return NoContent();
        }

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)   
        {
            await _unitofWork.Makes.Insert(make);
            await _unitofWork.Save(HttpContext);

            return CreatedAtAction("GetMake",new {id =make.id},make);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var make = await _unitofWork.Makes.Get(q=>q.id==id);
            if (make == null) 
            {
                return NotFound();
            }

            await _unitofWork.Makes.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();

        }

        private async Task<bool> MakeExists(int id)
        {
            var make =await _unitofWork.Makes.Get(q=>q.id== id);
            return make != null;
        }
    }
}
