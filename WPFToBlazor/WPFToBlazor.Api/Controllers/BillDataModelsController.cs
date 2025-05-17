using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WPFToBlazor.Api;
using WPFToBlazor.Data.Model;

namespace WPFToBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class BillDataModelsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public BillDataModelsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/BillDataModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BillDataModel>>> GetBillDataModel()
        {
            return await _context.BillDataModel.ToListAsync();
        }

        // GET: api/BillDataModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BillDataModel>> GetBillDataModel(long id)
        {
            var billDataModel = await _context.BillDataModel.FindAsync(id);

            if (billDataModel == null)
            {
                return NotFound();
            }

            return billDataModel;
        }

        // PUT: api/BillDataModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBillDataModel(long id, BillDataModel billDataModel)
        {
            if (id != billDataModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(billDataModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillDataModelExists(id))
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

        // POST: api/BillDataModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BillDataModel>> PostBillDataModel(BillDataModel billDataModel)
        {
            _context.BillDataModel.Add(billDataModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBillDataModel", new { id = billDataModel.Id }, billDataModel);
        }

        // DELETE: api/BillDataModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBillDataModel(long id)
        {
            var billDataModel = await _context.BillDataModel.FindAsync(id);
            if (billDataModel == null)
            {
                return NotFound();
            }

            _context.BillDataModel.Remove(billDataModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BillDataModelExists(long id)
        {
            return _context.BillDataModel.Any(e => e.Id == id);
        }
    }
}
