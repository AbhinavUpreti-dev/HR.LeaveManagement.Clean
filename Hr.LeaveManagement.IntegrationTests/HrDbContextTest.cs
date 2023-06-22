using FluentAssertions;
using Hr.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Hr.LeaveManagement.IntegrationTests
{
    public class HrDbContextTest
    {
        private HrDatabaseContext _hrDbContext;

        public HrDbContextTest()
        {
            var dbOptions = new DbContextOptionsBuilder<HrDatabaseContext>()
                                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            _hrDbContext = new HrDatabaseContext(dbOptions);
        }
        [Fact]
        public async void Save_SetModifiedDateValue()
        {
            //Arrange 
            var leaveType = new LeaveType
            {
                Id = 1,
                Name = "Test",
                DefaultDays = 10
            };

            //Act

            await _hrDbContext.LeaveTypes.AddAsync(leaveType);
            await _hrDbContext.SaveChangesAsync();

            //Assert 

            leaveType.DateModified.Should().NotBeNull();
        }
    }
}