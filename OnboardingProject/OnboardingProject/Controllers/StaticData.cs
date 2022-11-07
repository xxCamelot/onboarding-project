using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OnboardingProject.Controllers
{
    public static class StaticData
    {
        public static List<RoomModel> roomList = new List<RoomModel>() {

            new RoomModel(2,2, 25.3, new DescriptionModel("Camillo's room", "Stanza di Camillo","Pokòj Camilla")),
            new RoomModel(2,1, 30.8, new DescriptionModel("Master bedroom", "Stanza matrimoniale","Głòwna sypialnia")),
            new RoomModel(2,3, 35.6, new DescriptionModel("Kids' room", "Stanza dei bambini","Sypialnia dziecięca")),
            new RoomModel(2,2, 45.2, new DescriptionModel("Attic", "Attico","Strych")),
            new RoomModel(2,1, 7.6, new DescriptionModel("Julia's room", "Stanza di Julia","Pokòj Julii")),
            new RoomModel(3,0, 60.8, new DescriptionModel("Ballroom", "Sala da ballo","Sala balowa")),
            new RoomModel(3,1, 20, new DescriptionModel("Antique bedroom", "Camera da letto antica","Sypialnia antyczna"))
        };

        public enum Language
        {
            English,
            Italian,
            Polish
        };

        public static Language activeLanguage = Language.English;

        public static int propertyAddedTo = 0;
    }
}

