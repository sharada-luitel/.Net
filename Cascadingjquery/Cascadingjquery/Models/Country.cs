namespace Cascadingjquery.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
    }

}
