using Pandabize.Store.Domain.Common;

namespace Pandabize.Store.Domain.Entities
{
    public class Item : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Option>? Options { get; set; }
    }
}
