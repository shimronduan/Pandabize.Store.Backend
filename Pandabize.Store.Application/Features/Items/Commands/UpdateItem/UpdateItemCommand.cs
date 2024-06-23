﻿using MediatR;

namespace Pandabize.Store.Application.Features.Items.Commands.UpdateItem
{
    public class UpdateItemCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
