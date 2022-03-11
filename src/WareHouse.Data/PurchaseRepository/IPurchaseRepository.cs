using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Data.SqlModels;

namespace WareHouse.Data.PurchaseRepository
{
    public interface IPurchaseRepository
    {
        void Insert(Purchase purchase);
    }
}
