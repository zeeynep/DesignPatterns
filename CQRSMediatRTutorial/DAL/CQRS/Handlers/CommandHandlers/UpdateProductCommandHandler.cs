using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = DbContext.ProductList.FirstOrDefault(x => x.Id == request.Id);
            if(product == null)
            {
                return null;
            }
            product.Name = request.Name;
            product.Price = request.Price;
            product.Quantity = request.Quantity;

            return new UpdateProductCommandResponse
            {
            };
        }
    }
}
