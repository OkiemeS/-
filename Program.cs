using System;

namespace Банк
{
    class Program
    {
        static void Main(string[] args)
        {
            User kityskin = new User("Павел", "Семейко", 24, 1000999);
            Console.WriteLine($"Здравствуйте {kityskin.FulName} \n Ваши доходы составляют {kityskin.Doxod} укажите сумму вклада");
            string sum = Console.ReadLine();
            double summa = Convert.ToInt32(sum);
            Console.WriteLine(" Укажите на какой срок времени хотите совершить вклад.");
            string tim = Console.ReadLine();
            int timme = Convert.ToInt32(tim);
            double fulMonney = User.Fulmanney(summa, timme, kityskin);
            double chistka = fulMonney - summa;
            Console.WriteLine($" Уважаемый клиент, совершив вклад размером {summa} сроком на {timme} вы сможете снять {fulMonney}" +
                $" \n Чистая прибыль составит {chistka} \n " +
                $"\n Благодарим за то что воспользовались нашим Сервисом, надеемся на дальнеейшее сотрудничество." +
                $" Всем спасибо, и  пошли нафиг");
            Console.ReadKey();
        }
    }
}
