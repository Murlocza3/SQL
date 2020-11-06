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
    public class AccountPlanController : ControllerBase
    {
        private readonly _3_1Context _context;

        public AccountPlanController(_3_1Context context)
        {
            _context = context;
        }

        // GET: api/AccountPlan
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountPlan>>> GetAccountPlan()
        {
            return await _context.AccountPlan.ToListAsync();
        }

        // GET: api/AccountPlan/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountPlan>> GetAccountPlan(int id)
        {
            var accountPlan = await _context.AccountPlan.FindAsync(id);

            if (accountPlan == null)
            {
                return NotFound();
            }

            return accountPlan;
        }

        // PUT: api/AccountPlan/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccountPlan(int id, AccountPlan accountPlan)
        {
            if (id != accountPlan.ID)
            {
                return BadRequest();
            }

            _context.Entry(accountPlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountPlanExists(id))
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

        // POST: api/AccountPlan
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AccountPlan>> PostAccountPlan(AccountPlan accountPlan)
        {
            _context.AccountPlan.Add(accountPlan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccountPlan", new { id = accountPlan.ID }, accountPlan);
        }

        // DELETE: api/AccountPlan/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AccountPlan>> DeleteAccountPlan(int id)
        {
            var accountPlan = await _context.AccountPlan.FindAsync(id);
            if (accountPlan == null)
            {
                return NotFound();
            }

            _context.AccountPlan.Remove(accountPlan);
            await _context.SaveChangesAsync();

            return accountPlan;
        }

        private bool AccountPlanExists(int id)
        {
            return _context.AccountPlan.Any(e => e.ID == id);
        }
    }
}
