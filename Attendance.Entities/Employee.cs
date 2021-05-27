using System;
using System.Collections.Generic;

namespace Attendance.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public Gender Gender { get; set; }
        public bool IsActive { get; set; }        
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid AvatarId { get; set; }
        public string AvatarExtension { get; set; }
        public Mobile Mobile { get; set; }
        public HashSet<Attendance> Attendances { get; set; }


        public Employee()
        {
            Attendances = new HashSet<Attendance>();
        }
    }
}