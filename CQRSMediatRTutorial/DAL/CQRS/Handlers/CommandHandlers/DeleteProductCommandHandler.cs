﻿using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteProduct = DbContext.ProductList.FirstOrDefault(p => p.Id == request.Id);
            if (deleteProduct == null) { return null; }
            DbContext.ProductList.Remove(deleteProduct);
            return new DeleteProductCommandResponse { };
        }
    }
}
