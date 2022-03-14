using System;
using Class_Inheritance.Models;

namespace Class_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Name
            Console.Write("Enter name of the animal : ");
            string name  = Console.ReadLine();
        #endregion

            #region Age
            ReEnterAge:
            Console.Write($"Enter age of the {name} : ");

            int age = 0;

            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (isRightInterval(age)){

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Please re-enter age of the {name}!");
                    goto ReEnterAge;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine($"Please re-enter age of the {name}!");
                goto ReEnterAge;
            }

            #endregion

            #region LifeSpan
            ReEnterLifeSpan:
            Console.Write($"Enter approximate life span of {name} : ");

            int lifeSpan = 0;

            try
            {
                lifeSpan = Convert.ToInt32(Console.ReadLine());
                if(isRightInterval(lifeSpan))
                {

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Please re-enter life span of the {name}!");
                    goto ReEnterLifeSpan;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine($"Please re-enter life span of the {name}!");
                goto ReEnterLifeSpan;
            }
            #endregion

            #region IsPredator
            ReEnterIsPredator:
            Console.Write($"Is {name} predator? (yes/no) : ");

            bool isPredator;
            string yesNoString = Console.ReadLine();

            switch (yesNoString)
            {
                case "yes":
                    isPredator = true;
                    break;
                case "no":
                    isPredator = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"Please re-enter answer!");
                    goto ReEnterIsPredator;
            }

            #endregion

            #region IsDomesticated
            ReEnterIsDomesticated:
            Console.Write($"Is {name} domesticated? (yes/no) : ");

            bool isDomesticated;
            yesNoString = Console.ReadLine();

            switch (yesNoString)
            {
                case "yes":
                    isDomesticated = true;
                    break;
                case "no":
                    isDomesticated = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"Please re-enter answer!");
                    goto ReEnterIsDomesticated;
            }
            #endregion

            #region Color
            ReEnterColor:
            Console.WriteLine("bay, chestnut, gray, black, roan\npalomino, buckskin, dun, pinto, appaloosa");
            Console.Write($"Select color of the {name} : ");

            string color = Console.ReadLine();
            switch (color)
            {
                case "bay":
                    color = "bay";
                    break;
                case "chestnut":
                    color = "chestnut";
                    break;
                case "gray":
                    color = "gray";
                    break;
                case "black":
                    color = "black";
                    break;
                case "roan":
                    color = "roan";
                    break;
                case "palomino":
                    color = "palomino";
                    break;
                case "buckskin":
                    color = "buckskin";
                    break;
                case "dun":
                    color = "dun";
                    break;
                case "pinto":
                    color = "pinto";
                    break;
                case "appaloosa":
                    color = "appaloosa";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"Please re-enter color of the {name}!");
                    goto ReEnterColor;
            }
            #endregion

            #region Food
            Console.Write($"What do {name}s eat : ");
            string food = Console.ReadLine();
            #endregion

            #region Movement
            ReEnterMovement:
            Console.WriteLine("1 - Walk 5–8 km/h (3.1–5.0 mph)\n2 - Trot 8–13 km/h (5.0–8.1 mph)\n3 - Pace 8–13 km/h (5.0–8.1 mph)\n4 - Canter 16–27 km/h (9.9–16.8 mph)\n5 - Gallop 40–48 km/h (25–30 mph), record: 70.76 km/h (43.97 mph)");
            Console.Write($"Select movement of {name} : ");
            string movement;

            try
            {
                int movementSelect = Convert.ToInt32(Console.ReadLine());

                switch (movementSelect)
                {
                    case 1:
                        movement = "Walk 5–8 km/h (3.1–5.0 mph)";
                        break;
                    case 2:
                        movement = "Trot 8–13 km/h (5.0–8.1 mph)";
                        break;
                    case 3:
                        movement = "Pace 8–13 km/h (5.0–8.1 mph)";
                        break;
                    case 4:
                        movement = "Canter 16–27 km/h (9.9–16.8 mph)";
                        break;
                    case 5:
                        movement = "Gallop 40–48 km/h (25–30 mph), record: 70.76 km/h (43.97 mph)";
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please re-select movement of the horse : ");
                        goto ReEnterMovement;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please re-select movement of the horse : ");
                goto ReEnterMovement;
            }

            #endregion

            #region Speed
            ReEnterSpeed:
            Console.Write($"Enter speed of {name} : ");
            int speed = 0;

            try
            {
                speed = Convert.ToInt32(Console.ReadLine());
                if (speed > 0 && speed < 70)
                {

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Please re-enter speed of {name}");
                    goto ReEnterSpeed;
                }
            }
            catch (Exception)
            {

                Console.Clear();
                Console.WriteLine($"Please re-enter speed of {name}");
                goto ReEnterSpeed;
            }

            #endregion

            #region Weight
            ReEnterWeight:
            Console.Write($"Enter weight of the {name} : ");
            double weight = 0;

            try
            {
                weight = Convert.ToDouble(Console.ReadLine());
                if(weight > 200 && weight < 900)
                {

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Please re-enter {name}s weight again! (ex. 521,3 or 500)");
                    goto ReEnterWeight;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine($"Please re-enter {name}s weight again! (ex. 521,3)");
                goto ReEnterWeight;
            }

            #endregion

            Horse horse = new Horse(name, age, lifeSpan, isPredator, isDomesticated, color, food, movement, speed, weight);
            Console.Clear();
            Console.WriteLine(horse.GetAllInformationAboutHorse());
        }

        static bool isRightInterval(int year)
        {
            return year > 0 && year < 35;
        }
    }
}
