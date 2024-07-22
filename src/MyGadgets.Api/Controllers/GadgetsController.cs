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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Gadget gadget)
        {
            await _gadgetRepository.Add(gadget);
            await _gadgetRepository.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Gadget gadget)
        {
            _gadgetRepository.Update(gadget);
            await _gadgetRepository.SaveChanges();

            return Ok();
        }
    }
}
