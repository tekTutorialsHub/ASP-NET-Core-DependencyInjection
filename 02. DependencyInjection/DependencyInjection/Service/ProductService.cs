using DependencyInjection.Models;
using System.Collections.Generic;

namespace DependencyInjection.Service
{

    public interface IProductService
    {
        List<ProductViewModel> All();
    }

    public class ProductService : IProductService
    {
        public List<ProductViewModel> All()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, Name = "Pen Drive" },
                new ProductViewModel {Id = 2, Name = "Memory Card" },
                new ProductViewModel {Id = 3, Name = "Mobile Phone" },
                new ProductViewModel {Id = 4, Name = "Tablet" },
                new ProductViewModel {Id = 5, Name = "Desktop PC" } ,
            };
        }

    }


    public class BetterProductService : IProductService
    {
        public List<ProductViewModel> All()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, Name = "Television" },
                new ProductViewModel {Id = 2, Name = "Refrigerator" },
                new ProductViewModel {Id = 3, Name = "IPhone" },
                new ProductViewModel {Id = 4, Name = "Laptop" },
            };
        }

    }
}
