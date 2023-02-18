using AnimalNursery.Models.Animals;
using AnimalNursery.Models;
using AnimalNursery.Services;
using Microsoft.AspNetCore.Mvc;
using AnimalNursery.Models.Request;
using System.Reflection.PortableExecutable;

namespace AnimalNursery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeFriendsController : ControllerBase
    {
        private IHomeFriendsRepository _homeFriendsRepository;

        public HomeFriendsController(IHomeFriendsRepository homeFriendsRepository)
        {
            _homeFriendsRepository = homeFriendsRepository;
        }

        [HttpPost("create")]
        public ActionResult<int> Create ([FromBody] CreateHomeFriendsRequest createHomeFriendsRequest)
        {
            HomeFriend homeFriend  = CreateAnimal.create(createHomeFriendsRequest.Type);
            homeFriend.Name = createHomeFriendsRequest.Name;
            homeFriend.Commands.ToList(createHomeFriendsRequest.Commands);
            homeFriend.Birthday = createHomeFriendsRequest.Birthday;
            return Ok(_homeFriendsRepository.Create(homeFriend));
        }

       
    }
}
