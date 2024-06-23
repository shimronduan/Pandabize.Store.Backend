using AutoMapper;
using MediatR;
using Pandabize.Store.Application.Contracts.Persistance;
using Pandabize.Store.Domain.Entities;
using System;

namespace Pandabize.Store.Application.Features.Items.Commands.CreateItem
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, Guid>
    {
        private readonly IAsyncRepository<Item> _itemRepository;
        private readonly IMapper _mapper;

        public CreateItemCommandHandler(IMapper mapper, IAsyncRepository<Item> itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }
        public async Task<Guid> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<Item>(request);

            var validator = new CreateItemCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            item = await _itemRepository.AddAsync(item);
            return item.Id;
        }
    }
}
