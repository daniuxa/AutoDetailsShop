using AutoShop_Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Bll
{
    public interface IDetailsService
    {
        Task<Dictionary<string, IEnumerable<BaseProduct>>> GetDictionaryOfProductsAsync();
    }
}
