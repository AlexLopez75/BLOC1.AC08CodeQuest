using System;
using System.Linq.Expressions;

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

        int op = 0;
        int level = 0;
        string wizardName;
        bool validInput;

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
                if (op==1)
                {
                    Console.Write(MsgInputName);
                    wizardName = Console.ReadLine();
                    level = 1;
                    Console.WriteLine(MsgNameConfirm + wizardName);
                }
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
            }


        } while (op != 0);
    }

}
