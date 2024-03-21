using System;

namespace Task2_animal
{
    internal class Panther : Animal
    {

        public Panther(int speed) : base(speed)
        {
        }

        public override string Move()
        {
            speed = Math.Min(speed + 1, 15);
            string ext = "Пантера двигается со скоростью " + speed.ToString();
            return ext;
        }

        public override string Stand()
        {
            speed = Math.Max(speed - 1, 0);
            string ext = "Пантера двигается со скоростью " + speed.ToString();
            return ext;
        }

        public string Voice()
        {
            return "РРРРРР";
        }

        public string Climb()
        {
            return "Пантера залезла на дерево";
        }
    }
}