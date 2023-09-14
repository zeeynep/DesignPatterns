using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Commands.Response
{
    public class UpdateProductCommandResponse
    {
        public string Name {  get; set; }
        public decimal Price { get; set; }
        public int Quantity {  get; set; }
    }
}
