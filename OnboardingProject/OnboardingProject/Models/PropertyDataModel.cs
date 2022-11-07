namespace OnboardingProject
{
    public class PropertyDataModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Services { get; set; }

        public string Description { get; set; }
        public double Surface { get; set; }
        public string EnglishDescription { get; set; }
        public string ItalianDescription { get; set; }
        public string PolishDescription { get; set; }

        public PropertyDataModel(int id, string a, string s, string d, double su, string ed, string itd, string pd)
        {
            this.Id = id;
            this.Address = a;
            this.Services = s;
            this.Description = d;
            this.Surface = su;
            this.EnglishDescription = ed;
            this.ItalianDescription = itd;
            this.PolishDescription = pd;
        }
    }
}
