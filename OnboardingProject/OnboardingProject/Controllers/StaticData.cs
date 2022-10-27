using System;
using System.Collections.Generic;

namespace OnboardingProject.Controllers
{
    public static class StaticData
    {

        public static List<PropertyModel> propertyList = new List<PropertyModel>() {

            new PropertyModel("Viale F. Scaduto 10B", 105.7, new DescriptionModel("The house where I live", "La casa dove vivo", "Dom gdzie ja mieszkam"), "Laundry, Fridge, Wi-Fi, Pets, Balcony, TV"),
            new PropertyModel("Via dell'Arsenale 132", 492.2, new DescriptionModel("My old home", "Mia vecchia casa", "Mòj stary dom"), "Fridge, Wi-Fi")
        };
        
    }
}

