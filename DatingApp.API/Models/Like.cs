namespace DatingApp.API.Models
{
    public class Like
    {
        public int LikerId { get; set; } // id user like
        public int LikeeId { get; set; } // id user being liked by another user
        public User Liker { get; set; }
        public User Likee { get; set; }
    }
}