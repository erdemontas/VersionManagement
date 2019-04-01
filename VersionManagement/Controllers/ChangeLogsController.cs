using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VersionManagement.Models;

namespace VersionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangeLogsController : ControllerBase
    {
        private readonly VersionDatabaseModel _context;

        public ChangeLogsController(VersionDatabaseModel context)
        {
            _context = context;
        }

        // GET: api/ChangeLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChangeLog>>> GetChangeLog()
        {
            return await _context.ChangeLog.ToListAsync();
        }

        // GET: api/ChangeLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChangeLog>> GetChangeLog(long id)
        {
            var changeLog = await _context.ChangeLog.FindAsync(id);

            if (changeLog == null)
            {
                return NotFound();
            }

            return changeLog;
        }

        // PUT: api/ChangeLogs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChangeLog(long id, ChangeLog changeLog)
        {
            if (id != changeLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(changeLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChangeLogExists(id))
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

        // POST: api/ChangeLogs
        [HttpPost]
        public async Task<ActionResult<ChangeLog>> PostChangeLog(ChangeLog changeLog)
        {
            _context.ChangeLog.Add(changeLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChangeLog", new { id = changeLog.Id }, changeLog);
        }

        // DELETE: api/ChangeLogs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChangeLog>> DeleteChangeLog(long id)
        {
            var changeLog = await _context.ChangeLog.FindAsync(id);
            if (changeLog == null)
            {
                return NotFound();
            }

            _context.ChangeLog.Remove(changeLog);
            await _context.SaveChangesAsync();

            return changeLog;
        }

        private bool ChangeLogExists(long id)
        {
            return _context.ChangeLog.Any(e => e.Id == id);
        }
    }
}
