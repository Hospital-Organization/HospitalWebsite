using AutoMapper;
using Hospital.Application.DTO.News;
using Hospital.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.MappingProfiles
{
    public class NewsProfile:Profile
    {
        public NewsProfile() {

            CreateMap<NewsDto, News>().ReverseMap();
            CreateMap<AddNewsDto, News>().ReverseMap();
            CreateMap<News, NewsDto>().ReverseMap();
        }
       
    }
}
