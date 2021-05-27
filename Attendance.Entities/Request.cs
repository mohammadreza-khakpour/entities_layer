using System;

namespace Attendance.Entities
{
    public class Request
    {
        public long Id { get; set; }
        public DateTime StartDateTime { get; set; } 
        public DateTime EndDateTime { get; set; }      
        public string Excuse { get; set; }
        public RequestState RequestState { get; set; }
        public int RequestTypeId { get; set; }
        public RequestType RequestType { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
