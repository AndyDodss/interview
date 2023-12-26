using interview.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace interview.Model
{
    public class ReviewSessionRepository : IReviewSessionRepository
    {
        private readonly AppDbContext _dbContext;

        public ReviewSessionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddReviewSession(ReviewSession request)
        {
            ReviewSession review = new ReviewSession();
            ReviewSession reviewRequest = new ReviewSession();

            review = _dbContext.reviewSessions.FirstOrDefault(p => p.SessionID == request.SessionID);
            if (review == null)
            {
                reviewRequest.ClientComment = request.ClientComment;
                reviewRequest.LikeToContact = request.LikeToContact;
                reviewRequest.SessionRating = request.SessionRating;
                reviewRequest.SessionID = request.SessionID;
                reviewRequest.SubmissionDateTim = DateTime.Now;
                reviewRequest.Question1Rating= request.Question1Rating;
                reviewRequest.Question2Rating = request.Question2Rating;
                reviewRequest.Question3Rating = request.Question3Rating;
                reviewRequest.Question4Rating = request.Question4Rating;
                reviewRequest.TherapistRating = (request.Question1Rating + request.Question2Rating + request.Question3Rating + request.Question4Rating) / 4;
                _dbContext.reviewSessions.Add(reviewRequest);
                _dbContext.SaveChanges();

            }

        }

        ReviewSession IReviewSessionRepository.GetReviewSession(int id)
        {
            ReviewSession review = _dbContext.reviewSessions.Where(p=>p.Id == id).FirstOrDefault();
            if (review != null)
            {
                return review;
            }
            return new ReviewSession();
        }

        List<ReviewSession> IReviewSessionRepository.GetReviewSession()
        {
           return _dbContext.reviewSessions.ToList();
        }

    }
}
