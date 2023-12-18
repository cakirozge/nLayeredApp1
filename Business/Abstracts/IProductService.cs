using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Task<IPaginate<Product>> GetListAsync(); 
        Task Add(Product product);
        //2.22.03 dkdayım
    }
}
