using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Chronos.Database;
using Chronos.Models;

namespace Chronos.Controllers
{
    public class FinanceItemsController : ApiController
    {
        private readonly Database.AppContext _context = new Database.AppContext();

        // GET: api/FinanceItems
        public IQueryable<FinanceItem> GetFinanceItems()
        {
            return _context.FinanceItems;
        }

        // GET: api/FinanceItems/5
        [ResponseType(typeof(FinanceItem))]
        public IHttpActionResult GetFinanceItem(int id)
        {
            FinanceItem financeItem = _context.FinanceItems.Find(id);
            if (financeItem == null)
            {
                return NotFound();
            }

            return Ok(financeItem);
        }

        // PUT: api/FinanceItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFinanceItem(int id, FinanceItem financeItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != financeItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(financeItem).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinanceItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/FinanceItems
        [ResponseType(typeof(FinanceItem))]
        public IHttpActionResult PostFinanceItem(FinanceItem financeItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.FinanceItems.Add(financeItem);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = financeItem.Id }, financeItem);
        }

        // DELETE: api/FinanceItems/5
        [ResponseType(typeof(FinanceItem))]
        public IHttpActionResult DeleteFinanceItem(int id)
        {
            FinanceItem financeItem = _context.FinanceItems.Find(id);
            if (financeItem == null)
            {
                return NotFound();
            }

            _context.FinanceItems.Remove(financeItem);
            _context.SaveChanges();

            return Ok(financeItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FinanceItemExists(int id)
        {
            return _context.FinanceItems.Count(e => e.Id == id) > 0;
        }
    }
}