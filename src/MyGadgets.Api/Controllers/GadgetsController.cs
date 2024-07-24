using Microsoft.AspNetCore.Mvc;
using MyGadgets.Api.Dtos;
using MyGadgets.Domain.Entities;
using MyGadgets.Domain.Repositories;

namespace MyGadgets.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GadgetsController : ControllerBase
    {
        private readonly IGadgetRepository _gadgetRepository;

        public GadgetsController(
            IGadgetRepository gadgetRepository)
        {
            _gadgetRepository = gadgetRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<GadgetDto>> GetAll()
        {
            List<Gadget> gadgets = await _gadgetRepository
                .GetAll();
            return gadgets.Select(GadgetDto.FromEntity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GadgetDto>> Get([FromRoute] int id)
        {
            Gadget gadget = await _gadgetRepository
                .GetById(id);
            return GadgetDto.FromEntity(gadget);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateGadgetDto dto)
        {
            await _gadgetRepository.Add(dto.ToGadget());
            await _gadgetRepository.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateGadgetDto dto)
        {
            _gadgetRepository.Update(dto.ToGadget());
            await _gadgetRepository.SaveChanges();

            return Ok();
        }
    }
}
