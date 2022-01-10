using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusteriKayit.Data;
using MusteriKayit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusteriKayit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private DataContext _context;

        public CustomersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetCustomers()
        {
            var customers = await _context.Customers.ToListAsync();

            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCustomer(int id)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.id == id);

            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult> CreateCustomer([FromBody]Customer customer)
        {
           var newCustomer = await _context.Customers.AddAsync(customer);

            _context.SaveChanges();

            return Ok(newCustomer);
        }

        [HttpPut]
        public  IActionResult UpdateCustomer([FromBody]Customer customer)
        {
            var updatedCustomer = _context.Customers.Update(customer);

            _context.SaveChanges();

            return Ok(updatedCustomer);
        }







        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            var deletedCustomer = _context.Customers.Find(id);

            _context.Customers.Remove(deletedCustomer);

            _context.SaveChanges();
           
        } 

    }
}
