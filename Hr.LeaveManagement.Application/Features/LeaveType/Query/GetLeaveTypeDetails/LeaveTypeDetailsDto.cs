namespace Hr.LeaveManagement.Application.Features.LeaveType.Query.GetLeaveTypeDetails
{
    public class LeaveTypeDetailsDto
    {
        public string Name { get; set; } = string.Empty;

        public int DefaultDays { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? DateModified { get; set; }
    }
}