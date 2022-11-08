using System;
namespace OnboardingProject.Models
{
    public class TableModel
    {
        public PropertyDataModel[] properties { get; set; }
        public RoomDataModel[] rooms { get; set; }

        public TableModel(PropertyDataModel[] p, RoomDataModel[] r)
        {
            this.properties = p;
            this.rooms = r;
        }

        public TableModel() { } 
    }
}

