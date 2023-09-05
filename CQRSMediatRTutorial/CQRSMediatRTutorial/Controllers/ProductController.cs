using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using DAL.CQRS.Handlers.CommandHandlers;
using DAL.CQRS.Handlers.QueryHandlers;
using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CQRSMediatRTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        CreateProductCommandHandler createProductCommandHandler;
        DeleteProductCommandHandler deleteProductCommandHandler;
        GetAllProductQueryHandler getAllProductQueryHandler;
        GetByIdProductQueryHandler getByIdProductQueryHandler;

        public ProductController(CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler,
            GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler) 
        {
            this.createProductCommandHandler = createProductCommandHandler;
            this.deleteProductCommandHandler = deleteProductCommandHandler;
            this.getAllProductQueryHandler = getAllProductQueryHandler;
            this.getByIdProductQueryHandler = getByIdProductQueryHandler;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] GetAllProductQueryRequest request)
        {
            List<GetAllProductQueryResponse> allProducts = getAllProductQueryHandler.GetAllProduct(request);
            return Ok(allProducts);
        }
        [HttpGet("{id}")]
        public IActionResult Get([FromQuery] GetByIdProductQueryRequest request)
        {
            GetByIdProductQueryResponse product = getByIdProductQueryHandler.GetByIdProduct(request);
            return Ok(product);
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreateProductCommandRequest request) 
        {
            CreateProductCommandResponse response = createProductCommandHandler.CreateProduct(request);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromQuery] DeleteProductCommandRequest request)
        {
            DeleteProductCommandResponse response = deleteProductCommandHandler.DeleteProduct(request);
            return Ok(response);
        }

    }
}
