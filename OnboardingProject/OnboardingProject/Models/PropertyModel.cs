using System;

namespace OnboardingProject
{
    public class PropertyModel
    {
        private static int number { get; set; }
        public int propertyID { get; set; }

        public string address { get; set; }
        public double surface { get; set; }
        public string services { get; set; }

        public DescriptionModel descriptions { get; set; }
        public string description { get; set; }

        public PropertyModel(string a, double su, DescriptionModel d, string se)
        {
            this.address = a;
            this.surface = su;
            this.services = se;

            this.propertyID = ++number;

            this.descriptions = d;
            this.description = descriptions.englishDescription;

        }

        public PropertyModel() { }

    }
}

