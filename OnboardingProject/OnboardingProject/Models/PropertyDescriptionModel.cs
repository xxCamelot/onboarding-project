using OnboardingProject.Models;
using System;
namespace OnboardingProject
{
	public class PropertyDescriptionModel
	{
        public PropertyDataModel property { get; set; }
        public RoomDataModel[] rooms { get; set; }

        public PropertyDescriptionModel(PropertyDataModel p, RoomDataModel[] r)
        {
            this.property = p;
            this.rooms = r;
        }

        public PropertyDescriptionModel() { }

	}
}

