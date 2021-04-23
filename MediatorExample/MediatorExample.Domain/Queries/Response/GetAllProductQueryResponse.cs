using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Domain.Queries.Response
{
    public class GetAllProductQueryResponse
    {
        public Guid Id { get;  set; }
        public string Name { get;  set; }
        public double Price { get;  set; }
        public int Quantity { get;  set; }
    }
}
