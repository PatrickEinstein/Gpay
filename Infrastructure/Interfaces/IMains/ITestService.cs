using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gpay.Models;


namespace Gpay.Infrastructure.Interfaces.IMains
{
    public interface ITestService
    {
        Task<serviceResponse<String>> Test();
    }
}