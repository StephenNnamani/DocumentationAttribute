using System;

namespace DocumentTool
{
    [Documentation("This is a human being")]
    public class PersonModel
    {

        [Documentation("This is the number of years the person has lived", "Only takes an integer (int)")]
        public int Age { get; set; }

        [Documentation("The characteristics of this person", "Takes in an enum")]
        public GenderEnum Gender { get; set; }

        public SkinEnum SkinColor { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(int age, GenderEnum gender, SkinEnum skinColor)
        {
            Age = age;
            Gender = gender;
            SkinColor = skinColor;

        }

        [Documentation("Describes the gender")]
        public enum GenderEnum
        {
            Male,
            Female
        }

        public enum SkinEnum
        {
            Dark,
            Chocolate,
            White,
        }

        [Documentation("Using the model above to describe a person", "Age, gender, Skin color", "Console.Writes description based on Skin Type")]
        public void DescribeAPerson(int age, GenderEnum gender, SkinEnum skinColor)
        {
            this.Gender = gender;
            this.Age = age;
            this.SkinColor = skinColor;

            switch (SkinColor)
            {
                case SkinEnum.Chocolate:
                    if(GenderEnum.Female == gender)
                    {
                        Console.WriteLine($"Welcome Ms.{SkinColor}, it's my pleasure meeting you. Happy {age}th Birthday girl and Gratulation!, I heard you gave birth last month?");
                    }
                    else
                    {
                        Console.WriteLine($"Welcome Mr.{SkinColor}, it's my pleasure meeting you. Happy {age}th Birthday man and Gratulation!!!, I heard your wife gave birth last month?");
                    }
                    break;
                case SkinEnum.Dark:
                    if (GenderEnum.Female == gender)
                    {
                        Console.WriteLine($"Welcome Ms.{SkinColor}, it's my pleasure meeting you. Happy {age}th Birthday girl and Gratulation!, I heard you gave birth last month?");
                    }
                    else
                    {
                        Console.WriteLine($"Welcome Mr.{SkinColor}, it's my pleasure meeting you. Happy {age}th Birthday man and Gratulation!!!, I heard your wife gave birth last month?");
                    }
                    break;
                case SkinEnum.White:
                    if (GenderEnum.Female == gender)
                    {
                        Console.WriteLine($"Welcome Ms.{SkinColor}, it's my pleasure meeting you. Happy {age}th Birthday girl and Gratulation!, I heard you gave birth last month?");
                    }
                    else
                    {
                        Console.WriteLine($"Welcome Mr.{SkinColor}, it's my pleasure meeting you. Happy {age}th Birthday man and Gratulation!!!, I heard your wife gave birth last month?");
                    }
                    break;
            }
        }
    }

}
