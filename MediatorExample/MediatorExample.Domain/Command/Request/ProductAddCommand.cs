using MediatorExample.Domain.Command.Response;
using MediatR;

namespace MediatorExample.Domain.Command.Request
{
    public class ProductAddCommand:IRequest<ProductAddResponse>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
