using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Domain.Command.Response
{
    public class ProductUpdateResponse
    {
        public bool isSuccess { get; set; }

        public Guid Id { get; set; }
    }
}
