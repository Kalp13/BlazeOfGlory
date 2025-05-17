using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPFToBlazor.Api;
using WPFToBlazor.Data.Model;

namespace WPFToBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class BillRowItemsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public BillRowItemsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/BillRowItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BillRowItem>>> GetBillRowItem()
        {
            return await _context.BillRowItem.ToListAsync();
        }

        // GET: api/BillRowItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BillRowItem>> GetBillRowItem(long id)
        {
            var billRowItem = await _context.BillRowItem.FindAsync(id);

            if (billRowItem == null)
            {
                return NotFound();
            }

            return billRowItem;
        }

        // PUT: api/BillRowItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBillRowItem(long id, BillRowItem billRowItem)
        {
            if (id != billRowItem.BillRowItemId)
            {
                return BadRequest();
            }

            _context.Entry(billRowItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillRowItemExists(id))
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

        // POST: api/BillRowItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BillRowItem>> PostBillRowItem(BillRowItem billRowItem)
        {
            _context.BillRowItem.Add(billRowItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBillRowItem", new { id = billRowItem.BillRowItemId }, billRowItem);
        }

        // DELETE: api/BillRowItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBillRowItem(long id)
        {
            var billRowItem = await _context.BillRowItem.FindAsync(id);
            if (billRowItem == null)
            {
                return NotFound();
            }

            _context.BillRowItem.Remove(billRowItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BillRowItemExists(long id)
        {
            return _context.BillRowItem.Any(e => e.BillRowItemId == id);
        }
    }
}
