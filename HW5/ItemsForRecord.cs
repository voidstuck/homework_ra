using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_prog1
{
    public record class ItemsForRecord(ItemsForRecord.Types Type, string Name, DateTime LastDateTime)
    {
        public enum Types
        {
            File = 1,
            Directory = 2,
            Unknown = 3
        }
        public Types Type { get; set; } = Type;
        public string Name { get; set; } = Name;
        public DateTime LastDatetime { get; set; } = LastDateTime;
        
    }
}
