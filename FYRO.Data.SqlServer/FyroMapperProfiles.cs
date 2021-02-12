using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fyro.Data.Entities;
using FYRO.Business.Model;

namespace FYRO.Data.SqlServer
{
    public class FyroMapperProfiles : Profile
    {
        public FyroMapperProfiles()
        {
            this.CreateMap<DufferEntity, Duffer>();

            this.CreateMap<Duffer, DufferEntity>();

            this.CreateMap<AddressEntity, Address>();

            this.CreateMap<Address, AddressEntity>();
        }
    }
}
