using System;

namespace OnboardingProject
{
    public class PropertyModel
    {
        private static int Number { get; set; }
        public int PropertyID { get; set; }

        public string address { get; set; }
        public double surface { get; set; }
        public DescriptionModel descriptions { get; set; }
        public string services { get; set; }

        public PropertyModel(string a, double su, DescriptionModel d, string se)
        {
            this.address = a;
            this.surface = su;
            this.descriptions = d;
            this.services = se;
            Number++;
            this.PropertyID = Number;

        }

        public PropertyModel() { }

    }
}

