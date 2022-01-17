using Microsoft.AspNetCore.Mvc;
using PrescriptionAPI.Models.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrescriptionAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class PrescriptionController : ControllerBase
    {

        private readonly IPrescriptionRepository _prescriptionRepository;
        public PrescriptionController(IPrescriptionRepository prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
        }   
        // GET: api/<PrescrptionController>
        [HttpGet]
        public ActionResult Get()
        {
            var prescriptions = _prescriptionRepository.GetAll();
            if(prescriptions == null)
            {
               return NotFound();
            }
            return Ok(prescriptions);

        }

        
    }
}
