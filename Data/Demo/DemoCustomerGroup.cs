using Indotalent.Applications.CustomerGroups;
using Indotalent.Models.Entities;

namespace Indotalent.Data.Demo
{
    public static class DemoCustomerGroup
    {
        public static async Task GenerateAsync(IServiceProvider services)
        {
            var service = services.GetRequiredService<CustomerGroupService>();

            await service.AddAsync(new CustomerGroup { Name = "Student" });
            await service.AddAsync(new CustomerGroup { Name = "Tech" });
            await service.AddAsync(new CustomerGroup { Name = "Tutor" });
            await service.AddAsync(new CustomerGroup { Name = "Professor" });
            //await service.AddAsync(new CustomerGroup { Name = "Education" });
            //await service.AddAsync(new CustomerGroup { Name = "Hospitality" });
        }
    }
}
