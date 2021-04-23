using MediatorExample.Domain.Command.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Domain.Command.Request
{
    public class ProductUpdateCommand:IRequest<ProductUpdateResponse>
    {
        public Guid Id { get;  set; }
        public string Name { get;  set; }
        public double Price { get;  set; }
        public int Quantity { get;  set; }
    }
}
