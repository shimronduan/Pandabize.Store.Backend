using Pandabize.Store.Domain.Common;

namespace Pandabize.Store.Domain.Entities
{
    public class Option : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Item? Item { get; set; }
    }
}
