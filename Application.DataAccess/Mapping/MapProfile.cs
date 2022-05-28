using Application.Entity.DTOs;
using Application.Entity.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataAccess.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //CreateMap<Product, ProductDto>().ReverseMap(); //product'ı productdto'ya dönüştürüyor, bu 3 ü reverse olan temel dtolar
            CreateMap<Sparepart, SparepartDto>().ReverseMap(); //reverse tersi yapmak demek

            CreateMap<Product, ProductWithSparepartDto>().ForMember(dto => dto.Spareparts, opt => opt.MapFrom(src => src.Product_Spareparts));
                
  

            CreateMap<Product_Sparepart, SparepartDto>();
         

        }
    }
}
