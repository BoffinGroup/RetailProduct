using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DTOs;
using Entities.Models;

namespace StockManagement.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //All the mappings will be done here
            CreateMap<Stock, StockReadDTO>();
            CreateMap<StockCreateDTO, Stock>();
            CreateMap<Purchase, PurchaseReadDTO>();


        }
    }
}
