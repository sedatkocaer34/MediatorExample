using System;

namespace MediatorExample.Domain.Command.Response
{
    public class ProductAddResponse
    {
        public bool isSuccess { get; set; }
        public Guid Id { get; set; }
    }
}
