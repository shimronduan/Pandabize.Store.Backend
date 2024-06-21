using Pandabize.Store.Domain.Common;

namespace Pandabize.Store.Domain.Entities
{
    public class Option : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
