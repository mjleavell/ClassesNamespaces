﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesNamespaces
{
    class Candy
    {
        // ------------ PROPERTIES ------------
        public string Name { get; private set; }
        public string Flavor { get; private set; }
        // below sets the inital value of the property (PROPERTY INITIALIZATION)
        public int Rating { get; private set; } = 1;
        public string Review { get; private set; }
        public CandyType Type { get; private set; }

        // ------------ FIELDS ------------
        // MinRatingValue is a constant field and implicitly private
        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        // ------------ CONSTRUCTOR ------------
        // created a constructor that takes in 3 parameters that you have to enter
        // if you set inside of a constructor,  you technically dont even need to set or private set
        public Candy(string flavor, string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        // ------------ METHODS ------------
        // SetRating is a method signature
        public void SetRating(int userRating)
        {
            // needs to be betwwen 1(bad) - 10(amazing)
            //verification to make sure number is between 1 and 10
            if(userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            } else
            {
                throw new Exception($"You are dumb. Ratings should be between {MinRatingValue}-{MaxRatingValue}");
            }
        }

        // Example of Method Overloading
        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }

        // Example of expression bodied member function
        public void SetRating(bool likedIt) => Rating = likedIt ? 10 : 1;

        public override string ToString()
        {
            return $"This is {Name} {Type}, with a(n) {Flavor} flavor, rated {Rating} with a review of {Review}";
        }
    }

    enum CandyType
    {
        Chocolate,
        HardCandy,
        Sour,
        Caramel,
        Taffy,
        Gummy,
        Nut
    }
}
