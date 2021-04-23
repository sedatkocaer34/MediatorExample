using MediatorExample.Domain.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Domain.Queries.Request
{
    public class GetAllProductQueryRequest:IRequest<List<GetAllProductQueryResponse>>
    {
    }
}
