using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Threading.Tasks;
using CoPo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoPo.Controllers
{
    public class ComputersController : Controller
    {
        private readonly ILogger<ComputersController> _logger;

        private ServiceReference2.Service1Client service2Client = new ServiceReference2.Service1Client();

        public ComputersController(ILogger<ComputersController> logger)
        {
            _logger = logger;
        }

        public async Task<ComputerModel> CompAsync(ServiceReference2.Service1Client service2Client)
        {
            ComputerModel computer = new ComputerModel(await service2Client.PCNameAsync(),
                await service2Client.OSNameAsync(),
                await service2Client.OSVersionAsync(),
                await service2Client.InputLocaleAsync(),
                await service2Client.SystemLocaleAsync(),
                await service2Client.CPUInfoAsync(),
                await service2Client.DiskCapacityAsync(),
                await service2Client.TotalPhysicalMemoryAsync());

            return computer;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Computers()
        {
            //ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
            if (service2Client.State != CommunicationState.Closed)
            {
                ViewBag.Message = CompAsync(service2Client).Result.PCName;
            }
            else
            {
                service2Client.Close();
            }
            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ComputerAsync(string id)
        {
            if (id == CompAsync(service2Client).Result.PCName)
            {
                ViewBag.Computer = await CompAsync(service2Client);
            }
            return View();
        }
    }
}