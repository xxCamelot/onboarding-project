using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OnboardingProject.Controllers
{
    public static class StaticData
    {
        public static List<PropertyModel> propertyList = new List<PropertyModel>() {

            new PropertyModel("Viale F. Scaduto 10B", 105.7, new DescriptionModel("The house where I live", "La casa dove vivo", "Dom gdzie ja mieszkam"), "Laundry, Fridge, Wi-Fi, Pets, Balcony, TV"),
            new PropertyModel("Via dell'Arsenale 132", 492.2, new DescriptionModel("My old home", "Mia vecchia casa", "Mòj stary dom"), "Fridge, Wi-Fi"),
            new PropertyModel("90200 Tudia", 15820.0, new DescriptionModel("Tudia Agriturismo", "Tudia Agriturismoa", "Tudia Agryturystyka"), "Cows, Sheep, Grass")
        };

        public static List<RoomModel> roomList = new List<RoomModel>() {

            new RoomModel(1,2, 25.3, new DescriptionModel("Camillo's room", "Stanza di Camillo","Pokòj Camilla")),
            new RoomModel(1,1, 30.8, new DescriptionModel("Master bedroom", "Stanza matrimoniale","Głòwna sypialnia")),
            new RoomModel(1,3, 35.6, new DescriptionModel("Kids' room", "Stanza dei bambini","Sypialnia dziecięca")),
            new RoomModel(1,2, 45.2, new DescriptionModel("Attic", "Attico","Strych")),
            new RoomModel(1,1, 7.6, new DescriptionModel("Julia's room", "Stanza di Julia","Pokòj Julii")),
            new RoomModel(2,0, 60.8, new DescriptionModel("Ballroom", "Sala da ballo","Sala balowa")),
            new RoomModel(2,1, 20, new DescriptionModel("Antique bedroom", "Camera da letto antica","Sypialnia antyczna"))
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

