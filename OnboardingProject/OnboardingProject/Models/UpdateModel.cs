using System;
namespace OnboardingProject.Models
{
    public class UpdateModel
    {
        public int ID { get; set; }
        public int index { get; set; }
        public string value { get; set; }

        public UpdateModel(int p, int i)
        {
            this.ID = p;
            this.index = i;
            this.value = " ";
        }

        public UpdateModel() { }

    }
}

