namespace DatingApp.API.Models
{
    public class Like
    {
        public int LikerId { get; set; } // id user like
        public int LikeeId { get; set; } // id user being liked by another user
        public virtual User Liker { get; set; }
        public virtual User Likee { get; set; }
    }
}