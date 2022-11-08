using System;

namespace OnboardingProject.Models
{
    public class RoomDataModel
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public double Surface { get; set; }

        public string Description { get; set; }
        public int Beds { get; set; }
        public string EnglishDescription { get; set; }
        public string ItalianDescription { get; set; }
        public string PolishDescription { get; set; }

        public RoomDataModel(int Id, int PropertyId, double Surface, int Beds, string Description, string EnglishDescription, string ItalianDescription, string PolishDescription)
        {
            this.Id = Id;
            this.PropertyId = PropertyId;
            this.Surface = Surface;
            this.Beds = Beds;
            this.Description = Description;
            this.EnglishDescription = EnglishDescription;
            this.ItalianDescription = ItalianDescription;
            this.PolishDescription = PolishDescription;
        }

        public RoomDataModel() { }
    }
}
