using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace Gpay.Infrasturcture.Interfaces.Utilities
{
    public interface IDapperContext
    {
        IDbConnection GetDbConnection();
        IDbConnection OctaveConnection();
        IDbConnection GetMerchantDbConnection();
        IDbConnection GetPaymentDbConnection();
    }
}