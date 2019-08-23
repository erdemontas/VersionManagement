using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.DTOs
{
    public class LiteChangeLogDTO : SharedEntitiesDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid TypeId { get; set; }
        public Guid? VersionId { get; set; }
        public Guid? ChangeLogTypeId { get; set; }
    }
    public class ChangeLogDTO : LiteChangeLogDTO
    {
        public VersionDTO Version { get; set; }
        public ChangeLogTypeDTO ChangeLogType { get; set; }
    }
}
