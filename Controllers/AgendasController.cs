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
using MonkTechWebAPI.Models.Dto.Agenda;

namespace MonkTechWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendasController : ControllerBase
    {
        private readonly IAgendasRepository _agendasRepository;
        private readonly IMapper _mapper;

        public AgendasController(IAgendasRepository agendasRepository, IMapper mapper)
        {
            this._agendasRepository = agendasRepository;
            this._mapper = mapper;
        }

        // GET: api/Agendas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAgendaDetailsDto>>> GetAgendas()
        {
            var agendas = await _agendasRepository.GetAllAsync();

            var agendasDto = _mapper.Map<List<GetAgendaDetailsDto>>(agendas);
            
            return Ok(agendasDto);
        }

        // GET: api/Agendas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetAgendaDetailsDto>> GetAgenda(int id)
        {
            var agenda = await _agendasRepository.GetAsync(id);

            if (agenda == null)
            {
                return NotFound();
            }

            var agendaDto = _mapper.Map<GetAgendaDetailsDto>(agenda);

            return Ok(agendaDto);
        }

        // GET: api/Agendas/Saloes/4
        [HttpGet("Saloes/{idDoSalao}")]
        public async Task<ActionResult<GetAgendaDetailsDto>> GetAgendasDeUmSalao(int idDoSalao)
        {
            var agenda = await _agendasRepository.GetAgendasDeUmSalao(idDoSalao);

            if (agenda == null)
            {
                return NotFound();
            }

            var agendaDto = _mapper.Map<List<GetAgendaDetailsDto>>(agenda);

            return Ok(agendaDto);
        }

        // PUT: /api/Agendas/Agendar/5
        [HttpPut("Agendar/{idDaAgenda}")]
        public async Task<ActionResult<GetAgendaDto>> MarcarAgenda(int idDaAgenda, PutAgendaDto putAgendaDto)
        {
            var agenda = await _agendasRepository.GetAsync(idDaAgenda);

            if (agenda == null)
            {
                return NotFound();
            }

            if (agenda.Disponivel == false)
            {
                return BadRequest();
            }
            
            var novaAgenda = await _agendasRepository.MarcarAgenda(idDaAgenda, putAgendaDto);

            var agendaDto = _mapper.Map<GetAgendaDto>(novaAgenda);

            return Ok(agendaDto);
        }

        // POST: api/Agendas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GetAgendaDto>> PostAgenda(CreateAgendaDto createAgendaDto)
        {
            var agenda = _mapper.Map<Agenda>(createAgendaDto);

            await _agendasRepository.AddAsync(agenda);

            var agendaDto = _mapper.Map<GetAgendaDto>(agenda);

            return CreatedAtAction("GetAgenda", new { id = agendaDto.Id }, agendaDto);
        }

        // DELETE: api/Agendas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgenda(int id)
        {
            var agenda = await _agendasRepository.GetAsync(id);

            if (agenda == null)
            {
                return NotFound();
            }

            await _agendasRepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
