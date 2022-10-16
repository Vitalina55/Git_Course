namespace project_Vitalina
{
    class MainClass

    {
        static int RaisingNumberToPower(int number, int power)
        {
            int raising = 1;

            if (power == 0)
            {
                return raising;
            }

            else
            {
                for (int i = 1; i <= power; i++)
                {
                    raising *= number;
                }
                return raising;
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter power: ");
            int userPower = int.Parse(Console.ReadLine());

            int result = RaisingNumberToPower(userNumber, userPower);
            Console.WriteLine($"{userNumber} ^ {userPower} = {result} ");

        }
    }
}