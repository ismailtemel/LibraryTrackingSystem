using AutoMapper;
using LibraryTracking.Core.DTOs;
using LibraryTracking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
