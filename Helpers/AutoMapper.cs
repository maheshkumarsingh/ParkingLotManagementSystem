using AutoMapper;
using ParkingLotManagementSystem.Domain.Models;
using ParkingLotManagementSystem.Dtos;

namespace ParkingLotManagementSystem.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateParkingLotRequestDto, ParkingLot>()
                .ReverseMap();
        }
    }
}
