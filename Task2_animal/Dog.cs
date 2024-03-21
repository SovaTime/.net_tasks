using System;

namespace Task2_animal
{
    internal class Dog : Animal
    {

        public Dog(int speed) : base(speed)
        {
        }

        public override string Move()
        {
            speed = Math.Min(speed + 1, 10);
            string ext = "Собака двигается со скоростью " + speed.ToString();
            return ext;
        }

        public override string Stand()
        {
            speed = Math.Max(speed - 1, 0);
            string ext = "Собака двигается со скоростью " + speed.ToString();
            return ext;
        }

        public string Voice()
        {
            return "Гав-Гав";
        }

    }
}