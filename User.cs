using System;
using System.Collections.Generic;
using System.Text;

namespace Банк
{
    class User
    {
        public string name;
        public string Name
        {
            set { name = value; } 
        }
        public string family;
        public string Family 
        { 
            set { family = value;} 
        }
        public string FulName
        {
            get { return $" {name} {family}"; }
        }
        public byte age;
        public byte Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new Exception(" Некоректно заданный возвраст клиента");
                }
            }
        }

        public double Doxod { get; set; }

        public User(string name, string family, byte age, double doxod)
        {
            Name = name;
            Family = family;
            Age = age;
            Doxod = doxod;
        }
        public readonly double minWklad = 1000;
        public readonly int minTime = 1;
        private double rekaficientSum(double doxod, User user)
        {
            if ( doxod <= minWklad) throw new Exception ("недопустимая сумма ");
            if (doxod > user.Doxod) throw new Exception(" Сумма вклада больше имеющейся суммы денег на счету Клиента");
            if (doxod <= 10000)
            {
                return 1.05;
            }
            if (doxod <= 100000 && doxod > 10000)
            {
                return  1.1;
            }
            else
            {
                return 1.12;
            }
        }
        private double kaficientAge(int age)
        {
            if (age < minTime) throw new Exception("минимальный период времени 1 год ");
            if (age <= 2)
            {
                return 1.05;
            }
            if (age <= 5 && age > 2)
            {
                return 1.1;
            }
            else
            {
                return 1.12;
            }
        }
        public static double Fulmanney(double summa, int time, User user)
        {
            return summa * user.rekaficientSum(summa, user) * user.kaficientAge(time);
        }
    }
}
