using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripCalc
{
    public class Expense
    {
        public int? nameID { get; set; }
        public decimal? value { get; set; }
        public string? description { get; set; }
    }

    [Route("api/[controller]")]
    public class ExpenseController : Controller
    {

        private static List<Expense> Expenses;

        static ExpenseController()
        {
            Expenses = new List<Expense>();
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Expense> Get()
        {
            return Expenses;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Expense Get(int id)
        {
            return Expenses[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Expense expense)
        {
            Expenses.Add(expense);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Expense expense)
        {
            Expenses.Insert(id, expense);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Expenses.RemoveAt(id);
        }
    }
}

