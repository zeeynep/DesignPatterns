using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request)
        {
            var deleteProduct = DbContext.ProductList.FirstOrDefault(p => p.Id == request.Id);
            DbContext.ProductList.Remove(deleteProduct);
            return new DeleteProductCommandResponse { IsSuccess = true };
        }
    }
}
