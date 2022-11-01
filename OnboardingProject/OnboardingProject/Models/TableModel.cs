using System;
namespace OnboardingProject.Models
{
    public class TableModel
    {
        public PropertyModel[] properties { get; set; }
        public RoomModel[] rooms { get; set; }

        public TableModel(PropertyModel[] p, RoomModel[] r)
        {
            this.properties = p;
            this.rooms = r;
        }

        public TableModel() { } 
    }
}

