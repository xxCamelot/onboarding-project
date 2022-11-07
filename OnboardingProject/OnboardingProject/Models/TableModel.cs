using System;
namespace OnboardingProject.Models
{
    public class TableModel
    {
        public PropertyDataModel[] properties { get; set; }
        public RoomModel[] rooms { get; set; }

        public TableModel(PropertyDataModel[] p, RoomModel[] r)
        {
            this.properties = p;
            this.rooms = r;
        }

        public TableModel() { } 
    }
}

