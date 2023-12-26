using interview.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewSession : ControllerBase
    {
        private readonly IReviewSessionRepository _reviewSesssionRepository;

        public ReviewSession(IReviewSessionRepository reviewSesssionRepository) 
        {
            _reviewSesssionRepository = reviewSesssionRepository;
        }

        // GET: api/<ReviewSession>
        [HttpGet]
        public List<interview.Model.ReviewSession> Get()
        {
            return _reviewSesssionRepository.GetReviewSession();
        }

        // GET api/<ReviewSession>/5
        [HttpGet("{id}")]
        public interview.Model.ReviewSession Get(int id)
        {
            return _reviewSesssionRepository.GetReviewSession(id);
        }

        //POST api/<ReviewSession>
        [HttpPost]
        public void Post(interview.Model.ReviewSession review)
        {
            _reviewSesssionRepository.AddReviewSession(review);
        }

        //// PUT api/<ReviewSession>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ReviewSession>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
