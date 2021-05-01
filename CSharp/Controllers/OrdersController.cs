using Microsoft.AspNetCore.Mvc;
//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class OrdersController : ControllerBase
    {

        // GET: api/<OrdersController>
        // gets all of the orders
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Order1", "Order2" };
        }

        // GET api/<OrdersController>/5
        // returns the order for this order id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Single Order";
        }

        // GET api/<OrdersController>/customer/5
        // returns orders for this customer id
        [HttpGet("customer/{id}")]
        public IEnumerable<string> GetOrdersForCustomer(int id)
        {
            return new string[] { "CustomerOrder1", "CustomerOrder2" };
        }

        // POST api/<OrdersController>
        // creates a new order
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //create the new order here
        }

        // PUT api/<OrdersController>/5
        // Used to update the order
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //update the order here
        }

        // DELETE api/<OrdersController>/5
        // I would assume a delete would be used for a cancel.
        // If not a new post method would be created with the payload
        // for the cancel Information 
        // Or this void method could be renamed to better reflect
        // it's actions
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //cancel the order here
        }

    }
}
