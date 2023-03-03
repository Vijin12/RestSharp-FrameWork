namespace RestSharp_Automation.DTO
{
    public class GetAllUserDTO
    {
        public long Page { get; set; }
        public long PerPage { get; set; }
        public long Total { get; set; }
        public long TotalPages { get; set; }
        public Data[] Data { get; set; }
        public Support Support { get; set; }
    }
    public partial class Data
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri Avatar { get; set; }
    }
    public partial class Support
    {
        public Uri Url { get; set; }
        public string Text { get; set; }
    }
}