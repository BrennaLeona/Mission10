using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Fisher.Models;

namespace Mission10_Fisher.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingController(IBowlingRepository temp) { 
            _bowlingRepository = temp;
        }
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var joinedData = from Bowlers in _bowlingRepository.Bowlers
                             join Teams in _bowlingRepository.Teams on Bowlers.TeamID equals Teams.TeamID
                             select new JoinedBowler
                             {
                                 BowlerMiddleInit = Bowlers.BowlerMiddleInit,
                                 BowlerAddress = Bowlers.BowlerAddress,
                                 BowlerCity = Bowlers.BowlerCity,
                                 BowlerID = Bowlers.BowlerID,
                                 BowlerLastName = Bowlers.BowlerLastName,
                                 BowlerFirstName = Bowlers.BowlerFirstName,
                                 BowlerState = Bowlers.BowlerState,
                                 BowlerZip = Bowlers.BowlerZip,
                                 BowlerPhoneNumber = Bowlers.BowlerPhoneNumber,
                                 TeamID = Bowlers.TeamID,
                                 TeamName = Teams.TeamName
                             };
            return joinedData.Where(data => data.TeamName == "Marlins" || data.TeamName == "Sharks").ToList();
        }
    }
}
