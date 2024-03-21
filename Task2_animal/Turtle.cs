using System;

namespace Task2_animal
{
    internal class Turtle : Animal
    {

        public Turtle(int speed) : base (speed)
        {
        }

        public override string Move()
        {
            speed = Math.Min(speed + 1, 5);
            string ext = "Черепаха двигается со скоростью " + speed.ToString();
            return ext;
        }

        public override string Stand()
        {
            speed = Math.Max(speed - 1, 0);
            string ext = "Черепаха двигается со скоростью " + speed.ToString();
            return ext;
        }
    }
}