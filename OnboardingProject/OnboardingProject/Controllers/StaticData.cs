using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OnboardingProject.Controllers
{
    public static class StaticData
    {
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

