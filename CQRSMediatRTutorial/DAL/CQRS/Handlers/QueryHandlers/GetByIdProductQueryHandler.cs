﻿using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = DbContext.ProductList.FirstOrDefault(p => p.Id == request.Id);
            if (product == null ) 
            {
                return null;
            }
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Price = product.Price,
                Name = product.Name,
                Quantity = product.Quantity,
                CreateTime = product.CreateTime
            };
        }
    }
}
