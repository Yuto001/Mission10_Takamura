using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Takamura.Data;

namespace Mission10_Takamura.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private BowlingDbContext _BowlingContext;

        public BowlingLeagueController(BowlingDbContext temp) 
        { 
            _BowlingContext = temp;
        }

        [HttpGet(Name = "GetBowlingLeague")]
        public IEnumerable<Object> Get()
        {
            var playerList = _BowlingContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks") // This filters to show only those team members
                .Select(b => new
                {
                    b.BowlerID,
                    b.BowlerFirstName,
                    b.BowlerMiddleInit,
                    b.BowlerLastName,
                    b.BowlerAddress,
                    b.BowlerCity,
                    b.BowlerState,
                    b.BowlerZip,
                    b.BowlerPhoneNumber,
                    TeamName = b.Team.TeamName // returns Team Name instead of Team ID
                })
                .ToList();

            return playerList;
        }
    }
}
