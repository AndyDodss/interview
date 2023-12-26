namespace interview.Model
{
    public class ReviewSession  
    {
        public int Id { get; set; }
        public int SessionID { get; set; }
        public string? ClientComment { get; set; }
        public string? AdminComment { get; set; }
        public string SessionRating { get; set; }
        public decimal TherapistRating { get; set; }
        public DateTime SubmissionDateTim { get; set; }
        public bool LikeToContact { get; set; }
        public decimal  Question1Rating { get; set; }
        public decimal Question2Rating { get; set; }
        public decimal Question3Rating { get; set; }
        public decimal Question4Rating { get; set; }

    }

}
