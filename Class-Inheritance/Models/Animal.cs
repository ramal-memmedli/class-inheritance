using System;

namespace Class_Inheritance.Models
{
    public class Animal
    {
        public Animal()
        {

        }
        public Animal(string name)
        {
            this.name = name;
        }
        public Animal(string name, int age, int lifeSpan) : this(name)
        {
            this.age = age;
            this.lifeSpan = lifeSpan;
        }
        public Animal(string name, int age, int lifeSpan, bool isPredator, bool isDomesticated) : this(name, age, lifeSpan)
        {
            this.isPredator = isPredator;
            this.isDomesticated = isDomesticated;
        }

        public Animal(string name, int age, int lifeSpan, bool isPredator, bool isDomesticated, string color) : this(name, age, lifeSpan, isPredator, isDomesticated)
        {
            this.color = color;
        }

        /// <summary>
        /// Returns all information about animal.
        /// </summary>
        /// <returns>String type of information about animal</returns>
        public string GetAnimalInfo()
        {
            return "\nName of the animal : " + this.name + "\nAge of the animal : " + this.age + "\nLifespan of the animal : " + this.lifeSpan + "\nIs animal predator ? : " + this.isPredator + "\nIs animal domesticated ? : " + this.isDomesticated + "\nColor of the animal : " + this.color;
        }

        public string name;
        public int age;
        public int lifeSpan;
        public bool isPredator;
        public bool isDomesticated;
        public string color;
    }
}
