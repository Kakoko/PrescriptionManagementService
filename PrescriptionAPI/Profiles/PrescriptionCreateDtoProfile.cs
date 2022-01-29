using AutoMapper;
using PrescriptionAPI.Dto;
using PrescriptionAPI.Models;

namespace PrescriptionAPI.Profiles
{
    public class PrescriptionCreateDtoProfile : Profile
    {
        public PrescriptionCreateDtoProfile()
        {
            //Source => Destination
            CreateMap<PrescriptionCreateDto, Prescription>();
        }
    }
}
