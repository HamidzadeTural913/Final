namespace My_Final_Project_Staffy.Models
{
    public class WishListItem
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
