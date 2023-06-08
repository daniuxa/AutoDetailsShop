using AutoShop_Dal;
using AutoShop_Dal.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop_Bll
{
    public class DetailsService : IDetailsService
    {
        private readonly AutoShopContext _autoShopContext;

        public DetailsService(AutoShopContext autoShopContext)
        {
            this._autoShopContext = autoShopContext ?? throw new ArgumentNullException(nameof(autoShopContext));
        }

        public async Task<Dictionary<string, IEnumerable<BaseProduct>>> GetDictionaryOfProductsAsync()
        {
            var products = new Dictionary<string, IEnumerable<BaseProduct>>();

            products.Add("filters", await _autoShopContext.Filters.ToListAsync());
            products.Add("candles", await _autoShopContext.Candles.ToListAsync());
            products.Add("oils", await _autoShopContext.Oils.ToListAsync());
            products.Add("pads", await _autoShopContext.Pads.ToListAsync());
            products.Add("wipers", await _autoShopContext.Wipers.ToListAsync());

            return products;
        }
    }
}
