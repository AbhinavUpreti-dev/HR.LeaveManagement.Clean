﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveType.Command.CreateLeaveType
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int DefaultDays { get; set; }
    }
}
