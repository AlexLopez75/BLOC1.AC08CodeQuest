using System;

public class Program
{
    public static void Main()
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
        const string LevelNoob = "You still confuse your wand with a spoon";
        const string LevelNovice = "You are a Magic Breeze Caster";
        const string LevelAdvanced = "Wow! You can cast dragons witout burning the lab!";
        const string LevelMaster = "You have achieved th Master of Arcanes rank!";
        const string TitleNoob = "Level: Zyn the bugged";
        const string TitleNovice = "Level: Arka Nullpointer";
        const string TitleAdvanced = "Level: Elarion of the Embers";
        const string TitleMaster = "Level: ITB-Wizard the Grey";
        const string DayTraining = "Day {0} : {1} meditated for {2} hours and gained {3} power points.";
        const string TotalTraining = "{0} has meditated for a total of {1} hours and gained {2} power points";

        int op = 0, day, hour, power, totalHour = 0, totalPower = 0;
        bool validInput;
        string wizardName, level;

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
            }


        } while (op != 0);
    }

}
