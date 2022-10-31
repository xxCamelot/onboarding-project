using System;

namespace OnboardingProject
{
    public class RoomModel
    {
        private static int number { get; set; }
        public int roomID { get; set; }

        public int propertyID { get; set; }
        public int beds { get; set; }
        public double surface { get; set; }

        public DescriptionModel descriptions { get; set; }
        public string description { get; set; }

        public RoomModel(int p, int b, double s, DescriptionModel d)
        {
            this.propertyID = p;
            this.beds = b;
            this.surface = s;

            this.roomID = ++number;

            this.descriptions = d;
            this.description = descriptions.englishDescription;
        }

        public RoomModel() { }
    }
}

