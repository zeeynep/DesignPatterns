﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Commands.Response
{
    public class CreateProductCommandResponse
    {
        public Guid ProductId { get; set; }
    }
}
