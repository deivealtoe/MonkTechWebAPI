using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonkTechWebAPI.Contracts;
using MonkTechWebAPI.Models;
using MonkTechWebAPI.Models.Dto.Salao;

namespace MonkTechWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaloesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISaloesRepository _saloesRepository;
        private readonly IEnderecosRepository _enderecosRepository;

        public SaloesController(IMapper mapper, ISaloesRepository saloesRepository, IEnderecosRepository enderecosRepository)
        {
            this._mapper = mapper;
            this._saloesRepository = saloesRepository;
            this._enderecosRepository = enderecosRepository;
        }

        // GET: api/Saloes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetSalaoDto>>> GetSaloes()
        {
            List<Salao> saloes = await _saloesRepository.GetAllAsync();

            List<GetSalaoDto> saloesDto = _mapper.Map<List<GetSalaoDto>>(saloes);

            return saloesDto;
        }

        // GET: api/Saloes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetSalaoDetailsDto>> GetSalao(int id)
        {
            var salao = await _saloesRepository.GetDetails(id);

            if (salao == null)
            {
                return NotFound();
            }

            var salaoDto = _mapper.Map<GetSalaoDetailsDto>(salao);

            return Ok(salaoDto);
        }

        // GET: api/Saloes/Agendas/5
        [HttpGet("Agendas/{id}")]
        public async Task<ActionResult<GetSalaoAgendasDto>> GetSalaoAgendas(int id)
        {
            var salao = await _saloesRepository.GetDetailsAndAgendas(id);

            if (salao == null)
            {
                return NotFound();
            }

            var salaoAgendasDto = _mapper.Map<GetSalaoAgendasDto>(salao);

            return Ok(salaoAgendasDto);
        }

        // POST: api/Saloes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GetSalaoDetailsDto>> PostSalao(CreateSalaoDto salaoDto)
        {
            var salao = _mapper.Map<Salao>(salaoDto);
            var endereco = _mapper.Map<Endereco>(salaoDto);

            await _saloesRepository.AddAsync(salao);

            endereco.SalaoId = salao.Id;
            await _enderecosRepository.AddAsync(endereco);

            var salaoSalvo = await _saloesRepository.GetAsync(salao.Id);

            var salaoDtoOut = _mapper.Map<GetSalaoDetailsDto>(salaoSalvo);

            return CreatedAtAction("GetSalao", new { id = salaoDtoOut.Id }, salaoDtoOut);
        }

        // DELETE: api/Saloes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalao(int id)
        {   
            if (await _saloesRepository.Exists(id))
            {
                var salao = await _saloesRepository.GetAsync(id);
                await _saloesRepository.DeleteAsync(id);
                return NoContent();
            }

            return NotFound();
        }
    }
}
