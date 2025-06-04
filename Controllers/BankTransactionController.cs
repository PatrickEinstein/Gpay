using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gpay.Controllers;
using Gpay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gpay.Core.Enums;
using Gpay.Infrastructure.Interfaces.IManagers;

namespace Gpay.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankTransactionController : ControllerBase
    {

        private readonly IPaymentManager paymentManager;
        private readonly ILogger<BankTransactionController> logger;

        public BankTransactionController(IPaymentManager paymentManager, ILogger<BankTransactionController> logger)
        {
            this.paymentManager = paymentManager;
            this.logger = logger;
        }


        [HttpPost("/Payment/processpayment/bank-debit/{channelCode}")]
        public async Task<IActionResult> ProcessPaymentBank(BankPayment bankDetails, string adviceReference,  ChannelCode channelCode)
        {
            return Ok(await paymentManager.ProcessBankPayment(bankDetails, adviceReference, channelCode));
        }
        [HttpPost("/Payment/generateDynamicacoount/bank-transfer/{channelCode}")]
        public async Task<IActionResult> GenerateDynamicAccount(GenerateBankAccount model,ChannelCode channelCode)
        {
            return Ok(await paymentManager.GenerateBankAccount(model, channelCode));
        }


    }
}