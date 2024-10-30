using Indotalent.Applications.Taxes;
using Indotalent.Models.Entities;

namespace Indotalent.Data.Demo
{
    public static class DemoTax
    {
        public static async Task GenerateAsync(IServiceProvider services)
        {
            var service = services.GetRequiredService<TaxService>();

            await service.AddAsync(new Tax { Name = "NOTAX", Percentage = 0.0 });
            await service.AddAsync(new Tax { Name = "T10", Percentage = 0.0 });
            await service.AddAsync(new Tax { Name = "T15", Percentage = 0.0 });
            await service.AddAsync(new Tax { Name = "T20", Percentage = 0.0 });
        }
    }
}
