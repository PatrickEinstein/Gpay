using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gpay.Interfaces.IProcessors;
using Gpay.Core.Enums;

namespace Gpay.Infrastructure.Interfaces.ISwitches
{
    public interface ICardSwitcher
    {
         public IPaymentProcessor SwitchCardProcessor(ChannelCode channelCode);
    }
}