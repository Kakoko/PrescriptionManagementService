﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrescriptionAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        // GET: api/<PrescrptionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
    }
}
