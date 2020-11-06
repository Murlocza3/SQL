using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _3._1.Data;
using _3._1.Models;

namespace _3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubAccountController : ControllerBase
    {
        private readonly _3_1Context _context;

        public SubAccountController(_3_1Context context)
        {
            _context = context;
        }

        // GET: api/SubAccount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubAccount>>> GetSubAccount()
        {
            return await _context.SubAccount.ToListAsync();
        }

        // GET: api/SubAccount/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubAccount>> GetSubAccount(int id)
        {
            var subAccount = await _context.SubAccount.FindAsync(id);

            if (subAccount == null)
            {
                return NotFound();
            }

            return subAccount;
        }

        // PUT: api/SubAccount/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubAccount(int id, SubAccount subAccount)
        {
            if (id != subAccount.ID)
            {
                return BadRequest();
            }

            _context.Entry(subAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubAccountExists(id))
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

        // POST: api/SubAccount
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SubAccount>> PostSubAccount(SubAccount subAccount)
        {
            _context.SubAccount.Add(subAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubAccount", new { id = subAccount.ID }, subAccount);
        }

        // DELETE: api/SubAccount/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SubAccount>> DeleteSubAccount(int id)
        {
            var subAccount = await _context.SubAccount.FindAsync(id);
            if (subAccount == null)
            {
                return NotFound();
            }

            _context.SubAccount.Remove(subAccount);
            await _context.SaveChangesAsync();

            return subAccount;
        }

        private bool SubAccountExists(int id)
        {
            return _context.SubAccount.Any(e => e.ID == id);
        }
    }
}
