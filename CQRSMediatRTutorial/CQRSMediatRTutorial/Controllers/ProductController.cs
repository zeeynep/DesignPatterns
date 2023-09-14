using DAL;
using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using DAL.CQRS.Handlers.CommandHandlers;
using DAL.CQRS.Handlers.QueryHandlers;
using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using DAL.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSMediatRTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IMediator mediator;

        public ProductController(IMediator mediator) 
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest request)
        {
            List<GetAllProductQueryResponse> allProducts = await mediator.Send(request);
            return Ok(allProducts);
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            GetByIdProductQueryRequest req = new() { Id = id };
            GetByIdProductQueryResponse product = await mediator.Send(req);
            if (product == null) 
            {
                return new ObjectResult(product) { StatusCode = StatusCodes.Status404NotFound };
            }
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest request) 
        {
            CreateProductCommandResponse response = await mediator.Send(request);
            var actionName = nameof(Get);
            return CreatedAtAction(actionName, response, null);
            //return new ObjectResult(response) { StatusCode = StatusCodes.Status201Created };
        }
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeleteProductCommandRequest request = new() { Id = id };
            DeleteProductCommandResponse response = await mediator.Send(request);
            if(response == null)
            {
                return new ObjectResult(response) { StatusCode = StatusCodes.Status404NotFound };
            }
            return new ObjectResult(response) { StatusCode = StatusCodes.Status204NoContent };
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromQuery] UpdateProductCommandRequest request)
        {
            UpdateProductCommandResponse response = await mediator.Send(request);
            if (response == null)
            {
                return new ObjectResult(response) { StatusCode = StatusCodes.Status404NotFound };
            }
            var actionName = nameof(Get);
            return CreatedAtAction(actionName, response, null);
            //return new ObjectResult(response) { StatusCode = StatusCodes.Status204NoContent };
        }

    }
}
