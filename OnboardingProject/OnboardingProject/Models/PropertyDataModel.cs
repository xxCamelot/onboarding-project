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

        public PropertyDataModel(int Id, string Address, double Surface, string Services, string Description, string EnglishDescription, string ItalianDescription, string PolishDescription)
        {
            this.Id = Id;
            this.Address = Address;
            this.Surface = Surface;
            this.Services = Services;
            this.Description = Description;
            this.EnglishDescription = EnglishDescription;
            this.ItalianDescription = ItalianDescription;
            this.PolishDescription = PolishDescription;
        }

        public PropertyDataModel() { }
    }
}
