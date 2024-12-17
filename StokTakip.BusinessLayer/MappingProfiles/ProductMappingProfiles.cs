using AutoMapper;
using StokTakip.BusinessLayer.Dtos.Product.Requests;
using StokTakip.BusinessLayer.Dtos.Product.Responses;
using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer.MappingProfiles
{
    public class ProductMappingProfiles : Profile
    {
        public ProductMappingProfiles()
        {
            CreateMap<Product,ListProductResponse>().ReverseMap();
            CreateMap<Product,GetByIdProductResponse>().ReverseMap();
            CreateMap<Product,InsertProductRequest>().ReverseMap();
            CreateMap<Product,UpdateProductRequest>().ReverseMap();
        }
    }
}
