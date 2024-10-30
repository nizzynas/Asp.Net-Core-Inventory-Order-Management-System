using Indotalent.Applications.Warehouses;
using Indotalent.Models.Entities;

namespace Indotalent.Data.Demo
{
    public static class DemoWarehouse
    {
        public static async Task GenerateAsync(IServiceProvider services)
        {
            var service = services.GetRequiredService<WarehouseService>();

            await service.AddAsync(new Warehouse { Name = "JAC" });
           // await service.AddAsync(new Warehouse { Name = "San Francisco" });
           // await service.AddAsync(new Warehouse { Name = "Chicago" });
           // await service.AddAsync(new Warehouse { Name = "Los Angeles" });
        }
    }
}
