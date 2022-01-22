using AutoMapper;
using PrescriptionAPI.Dto;
using PrescriptionAPI.Models;

namespace PrescriptionAPI.Profiles
{
    public class PrescriptionReadDtoProfile : Profile
    {
        public PrescriptionReadDtoProfile()
        {
            // Source -> Destination
            CreateMap<Prescription, PrescriptionReadDto>();
        }
    }
}
