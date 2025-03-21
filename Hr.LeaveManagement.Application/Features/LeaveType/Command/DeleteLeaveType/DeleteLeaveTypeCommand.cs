﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveType.Command.DeleteLeaveType
{
    public class DeleteLeaveTypeCommand :IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
