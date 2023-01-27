using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveType.Query.GetAllLeaveTypes
{
    public class LeaveTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;

        public int DefaultDays { get; set; }
    }
}
