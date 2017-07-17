using System;

namespace Twee.Api.Models
{
    public class BaseModel
    {
        public Guid ID { get; set; }
    }

    public class AuditModel: BaseModel
    {
        public DateTime CreatedDate { get; set; }
        public Guid CreatorID { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Guid? EditorID { get; set; }
    }
}
