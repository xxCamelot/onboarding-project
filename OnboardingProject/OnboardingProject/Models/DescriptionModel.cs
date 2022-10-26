﻿using System;
namespace OnboardingProject
{
    public class DescriptionModel
    {
        public string englishDescription { get; set; }
        public string italianDescription { get; set; }
        public string polishDescription { get; set; }

        public DescriptionModel(string e, string i, string p)
        {
            englishDescription = e;
            italianDescription = i;
            polishDescription = p;
        }

        public DescriptionModel() { }

    }
}

