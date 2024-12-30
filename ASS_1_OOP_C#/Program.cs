namespace ASS_1_OOP_C_
{
    internal class Program
    {
        #region Part2
        #region 1
        enum weekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        #endregion

        #region 2
        enum Seas
        {
            Spring, Summer, Autumn, Winter
        }
        #endregion

        #region 3
            //  Part1السؤال دا عامله ك مثال في ال
        #endregion

        #region 4
        enum Colors
        {
            Red, Green, Blue
        }
        #endregion
        #endregion

        static void Main(string[] args)
        {
            #region 1
            for (weekDays i = 0; i < (weekDays)7; i++)
            {
                Console.WriteLine($" the day is : {i}");
            }
            #endregion

            #region 2
            Console.WriteLine("\n \t please enter only the first char of season capital to be accepted \n ");
            Console.WriteLine("enter the season ");
            string x = Console.ReadLine();
            Seas season;
            if (Enum.TryParse(x, true, out season))
            {
                if (season == Seas.Spring)
                    Console.WriteLine("spring range is from march to may");
                else if (season == Seas.Summer)
                    Console.WriteLine("summer range is from june to august");
                else if (season == Seas.Autumn)
                    Console.WriteLine("Autumn range is from septamber to novamber");
                else if (season == Seas.Winter)
                    Console.WriteLine("winter range is from december to febuary");
            }
            else
                Console.WriteLine("sorry there is wrong name of season");
            #endregion

            #region 3
            USER user01 = new USER();
            user01.ID = 10;
            //First Way :-
            user01.Permission[0] = true; 
            user01.Permission[1] = false; 
            user01.Permission[2] = false; 
            user01.Permission[3] = false;
            for(int i = 0;i < user01.Permission.Length; i++)
            {
                Console.Write(user01.Permission[i]+"\t");
            }
            Console.WriteLine();
            Console.WriteLine(user01.permissions);
            //Secound Way :-
            user01.permissions = (Permissions)10;
            user01.permissions = (Permissions)13;
            Console.WriteLine(user01.permissions);
            //Third Way :-
            user01.permissions = user01.AddPermission(user01.permissions, Permissions.Delete);
            user01.permissions = user01.RemovePermission(user01.permissions, Permissions.Delete);
            Console.WriteLine(user01.permissions);
            #endregion

            #region 4
            Console.WriteLine("Please enter the color:");
            string x02 = Console.ReadLine();
            Colors color;
            if (Enum.TryParse(x02, true, out color))
            {
                Console.WriteLine("Primary color");
            }
            else
            {
                Console.WriteLine("Not a primary color");
            }
            #endregion
        }
    }
}