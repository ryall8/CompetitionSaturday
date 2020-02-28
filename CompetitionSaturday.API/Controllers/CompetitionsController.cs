using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CompetitionSaturday.API.Data;
using CompetitionSaturday.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompetitionSaturday.API.Controllers
{        
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionsController : ControllerBase
    {
        private readonly ICompetitionRepository _repo;
        private readonly IMapper _mapper;
        public CompetitionsController(ICompetitionRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompetitions()
        {
            var competitions = await _repo.GetCompetitions();

            var competitionsToReturn = _mapper.Map<IEnumerable<CompetitionForListDto>>(competitions);

            return Ok(competitionsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompetition(int id)
        {
            var competition = await _repo.GetCompetition(id);

            var competitionToReturn = _mapper.Map<CompetitionForDetailsDto>(competition);

            return Ok(competitionToReturn);
        }

    }
}