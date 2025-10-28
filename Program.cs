using System;

public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";
        const string MsgInputName = "Enter your wizard's name: ";
        const string MsgNameConfirm = "Your wizard's name is: ";
        const string PressEnter = "Press enter to continue";

        int op = 0, level, day, hour, power, totalHour = 0, totalPower = 0;
        string wizardName;
        bool validInput;

        Random rnd = new Random();

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            validInput = true;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (validInput)
            {
                Console.WriteLine(op);
                if (op == 1)
                {
                    Console.Write(MsgInputName);
                    wizardName = Console.ReadLine();
                    level = 1;
                    Console.WriteLine(MsgNameConfirm + wizardName);

                    for (day = 1; day < 6; day++)
                    {
                        hour = rnd.Next(11);
                        power = rnd.Next(11);
                        totalHour = totalHour + hour;
                        totalPower = totalPower + power;
                        Console.WriteLine("Day " +day+ ": " +wizardName+ " meditated for " +hour+ " hours and gained " +power+ " power points.");
                        Console.WriteLine(wizardName+ " has meditated for a total of " +totalHour+ " hours and gained " +totalPower+ " power points");
                        Console.WriteLine(PressEnter);
                        Console.ReadLine();
                    }
                }
            }


        } while (op != 0);
    }

}
