using System;
namespace OnboardingProject
{
	public class PropertyDescriptionModel
	{
        public PropertyDataModel property { get; set; }
        public RoomModel[] rooms { get; set; }

        public PropertyDescriptionModel(PropertyDataModel p, RoomModel[] r)
        {
            this.property = p;
            this.rooms = r;
        }

        public PropertyDescriptionModel() { }

	}
}

