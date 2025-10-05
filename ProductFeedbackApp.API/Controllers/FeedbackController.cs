using Microsoft.AspNetCore.Mvc;
using ProductFeedbackApp.API.Data;
using ProductFeedbackApp.API.Models;

namespace ProductFeedbackApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FeedbackController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/feedback
        [HttpPost]
        public async Task<IActionResult> SubmitFeedback([FromBody] Feedback feedback)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Feedback submitted successfully!" });
        }

        // GET: api/feedback
        [HttpGet]
        public IActionResult GetAllFeedback()
        {
            var feedbacks = _context.Feedbacks.ToList();
            return Ok(feedbacks);
        }
    }
}
