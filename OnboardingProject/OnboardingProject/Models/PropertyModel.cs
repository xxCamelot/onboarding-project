using System;

namespace OnboardingProject
{
    public class PropertyModel
    {
        public string address { get; set; }
        public double surface { get; set; }
        public DescriptionModel descriptions { get; set; }
        public string services { get; set; }

        public PropertyModel(string a, double su, DescriptionModel d, string se)
        {
            address = a;
            surface = su;
            descriptions = d;
            services = se;
        }

        public PropertyModel() { }

    }
}

