using System;
namespace OnboardingProject
{
	public class PropertyDescriptionModel
	{
        public PropertyModel property { get; set; }
        public RoomModel[] rooms { get; set; }

        public PropertyDescriptionModel(PropertyModel p, RoomModel[] r)
        {
            this.property = p;
            this.rooms = r;
        }

        public PropertyDescriptionModel() { }

	}
}

