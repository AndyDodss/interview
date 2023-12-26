namespace interview.Model
{
    public interface IReviewSessionRepository
    {
        public ReviewSession GetReviewSession(int id);
        public List<ReviewSession> GetReviewSession();
           
        public void AddReviewSession(ReviewSession session);

    }
}
