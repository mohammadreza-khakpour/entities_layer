using System;

namespace Attendance.Entities
{
    public class Attendance
    {
        public long Attendance_Id { get; set; }
        public DateTime AttendTime { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
