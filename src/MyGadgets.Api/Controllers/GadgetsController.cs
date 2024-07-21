using Microsoft.AspNetCore.Mvc;
using MyGadgets.Domain.Entities;
using MyGadgets.Domain.Repositories;

namespace MyGadgets.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GadgetsController : ControllerBase
    {
        private readonly ILogger<GadgetsController> _logger;
        private readonly IGadgetRepository _gadgetRepository;

        public GadgetsController(ILogger<GadgetsController> logger,
            IGadgetRepository gadgetRepository)
        {
            _logger = logger;
            _gadgetRepository = gadgetRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Gadget>> Get() => await _gadgetRepository.GetAll();
    }
}
