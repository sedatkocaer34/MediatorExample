using MediatorExample.Domain.Command.Response;
using MediatR;
using System;

namespace MediatorExample.Domain.Command.Request
{
    public class ProductRemoveCommand:IRequest<ProductRemoveResponse>
    {
        public Guid Id { get; set; }
    }
}
