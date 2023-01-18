using System;

namespace DocumentTool
{
    [Document("This is a human being")]
    public class PersonModel
    {

        [Document("This is the number of years the person has lived", "Only takes an integer (int)")]
        public int Age { get; set; }

        [Document("The characteristics of this person", "Takes in an enum")]
        public GenderEnum Gender { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(int age, GenderEnum gender)
        {
            Age = age;
            Gender = gender;

        }

        [Document("Describes the gender")]
        public enum GenderEnum
        {
            Male,
            Female
        }

        [Document("Makes a rather obvious sentence with the parameters provided", "Age and gender", "Outputs a sentence, otherwise known as string")]
        public void MakeSentenceWithPerson(int age, GenderEnum gender)
        {
            this.Gender = gender;
            this.Age = age;

            if (GenderEnum.Male == gender) Console.WriteLine("We have a {0} year old male", age);
            else Console.WriteLine("We have a {0} year old female", age);
        }
    }

}
