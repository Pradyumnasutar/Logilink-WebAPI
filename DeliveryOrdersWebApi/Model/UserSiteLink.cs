namespace DeliveryOrdersWebApi.Model
{
    public class UserSiteLink
    {
        public int USERSITELINKID { get; set; }
        public int? EX_USERID { get; set; }
        public int? SITEID { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
    }
}
