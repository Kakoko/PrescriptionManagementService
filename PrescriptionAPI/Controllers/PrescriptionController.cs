using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PrescriptionAPI.Dto;
using PrescriptionAPI.Models.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrescriptionAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class PrescriptionController : ControllerBase
    {

        private readonly IPrescriptionRepository _prescriptionRepository;
        private readonly IMapper _mapper;
        public PrescriptionController(IPrescriptionRepository prescriptionRepository, IMapper mapper)
        {
            _prescriptionRepository = prescriptionRepository;
            _mapper = mapper;
        }   
        // GET: api/<PrescrptionController>
        [HttpGet]
        public ActionResult<IEnumerable<PrescriptionReadDto>> Get()
        {
            var prescriptions = _prescriptionRepository.GetAll();

            var prescriptionDto = _mapper.Map<IEnumerable<PrescriptionReadDto>>(prescriptions);

            if(prescriptions == null)
            {
               return NotFound();
            }
            return Ok(prescriptionDto);

        }

        
    }
}
