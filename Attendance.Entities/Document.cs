using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Entities
{
    public class Document
    {
        public Guid Id { get; set; }
        public byte[] Data { get; set; }
        public DateTime CreationDate { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public DocumentStatus Status { get; set; }
    }
    
}
