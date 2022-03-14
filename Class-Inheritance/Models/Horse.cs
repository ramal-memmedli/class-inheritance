using System;

namespace Class_Inheritance.Models
{
    public class Horse : Animal
    {
        public Horse(string name) : base(name)
        {
        }
        public Horse(string name, int age, int lifeSpan) : base(name, age, lifeSpan)
        {
        }
        public Horse(string name, int age, int lifeSpan, bool isPredator, bool isDomesticated) : base(name, age, lifeSpan, isPredator, isDomesticated)
        {
        }
        public Horse(string name, int age, int lifeSpan, bool isPredator, bool isDomesticated, string color) : base(name, age, lifeSpan, isPredator, isDomesticated, color)
        {
        }
        public Horse(string name, int age, int lifeSpan, bool isPredator, bool isDomesticated, string color, string food) : this(name, age, lifeSpan, isPredator, isDomesticated, color)
        {
            this.food = food;
        }
        public Horse(string name, int age, int lifeSpan, bool isPredator, bool isDomesticated, string color, string food, string movement, int speed) : this(name, age, lifeSpan, isPredator, isDomesticated, color, food)
        {
            this.movement = movement;
            this.speed = speed;
        }
        public Horse(string name, int age, int lifeSpan, bool isPredator, bool isDomesticated, string color, string food, string movement, int speed, double weight) : this(name, age, lifeSpan, isPredator, isDomesticated, color, food, movement, speed)
        {
            this.weight = weight;
        }
        /// <summary>
        /// Returns all information about horse.
        /// </summary>
        /// <returns>String type of information about horse</returns>
        public string GetAllInformationAboutHorse()
        {
            return "\nName of the animal : " + this.name + "\nAge of the animal : " + this.age + "\nLifespan of the animal : " + this.lifeSpan + "\nIs animal predator ? : " + this.isPredator + "\nIs animal domesticated ? : " + this.isDomesticated + "\nColor of the animal : " + this.color + "\nHorse food : " + this.food + "\nMovement of the horse : " + this.movement + "\nSpeed of the horse : " + this.speed + "\nWeight of the horse : " + this.weight;
        }

        public string food;
        public string movement;
        public int speed;
        public double weight;
    }
}
