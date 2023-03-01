using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Models.Email
{
    public class EmailSettings
    {
        public string FromName { get; set; }
        public string ApiKey { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
    }
}
