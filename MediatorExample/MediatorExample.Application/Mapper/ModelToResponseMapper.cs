using AutoMapper;
using MediatorExample.Domain.Command.Request;
using MediatorExample.Domain.Domain;
using MediatorExample.Domain.Queries.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Application.Mapper
{
    public class ModelToResponseMapper:Profile
    {
        public ModelToResponseMapper()
        {
            CreateMap<Product, GetByIdProductQueryResponse>();
            CreateMap<Product, GetAllProductQueryResponse>();
        }
    }
}
