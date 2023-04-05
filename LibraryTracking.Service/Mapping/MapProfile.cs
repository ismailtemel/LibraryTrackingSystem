using AutoMapper;
using LibraryTracking.Core.DTOs;
using LibraryTracking.Core.Models;

namespace LibraryTracking.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
