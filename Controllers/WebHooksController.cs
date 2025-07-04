using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
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
    public class WebHooksController : ControllerBase
    {
        private readonly IPaymentManager paymentManager;
        private readonly ILogger<WebHooksController> logger;

        public WebHooksController(IPaymentManager paymentManager, ILogger<WebHooksController> logger)
        {
            this.paymentManager = paymentManager;
            this.logger = logger;
        }

        [HttpPost("/webhook/{channel}")]
        public async Task<IActionResult> Webhook(ChannelCode channel)
        {
            string bodyString = await new StreamReader(Request.Body).ReadToEndAsync();

            logger.LogInformation($"Wallet Transaction Notification Callback Response: {bodyString} to channel {JsonSerializer.Serialize(channel)}");

            var res = paymentManager.WebHookNotification(bodyString, channel);

            return Ok(res);
        }
    }
}