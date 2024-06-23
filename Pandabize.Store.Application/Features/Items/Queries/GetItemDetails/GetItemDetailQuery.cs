using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandabize.Store.Application.Features.Items.Queries.GetItemDetails
{
    public class GetItemDetailQuery : IRequest<ItemDetailVm>
    {
        public Guid Id { get; set; }
    }
}
