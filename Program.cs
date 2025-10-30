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
                if (op == 1)
                {
                    Console.Write(MsgInputName);
                    wizardName = Console.ReadLine();
                    level = "1";
                    Console.WriteLine(MsgNameConfirm + wizardName);

                    for (day = 1; day < 6; day++)
                    {
                        hour = rnd.Next(11);
                        power = rnd.Next(11);
                        totalHour = totalHour + hour;
                        totalPower = totalPower + power;
                        Console.WriteLine("Day " + day + ": " + wizardName + " meditated for " + hour + " hours and gained " + power + " power points.");
                        Console.WriteLine(wizardName + " has meditated for a total of " + totalHour + " hours and gained " + totalPower + " power points");
                        Console.WriteLine(PressEnter);
                        Console.ReadLine();
                    }
                    switch (totalPower)
                    {
                        case > 46:
                            Console.WriteLine(LevelMaster);
                            Console.WriteLine(TitleMaster);
                            level = "ITB-Wizard the Grey";
                            break;
                        case > 40:
                            Console.WriteLine(LevelAdvanced);
                            Console.WriteLine(TitleAdvanced);
                            level = "Elarion of the Embers";
                            break;
                        case > 30:
                            Console.WriteLine(LevelNovice);
                            Console.WriteLine(TitleNovice);
                            level = "Arka Nullpointer";
                            break;
                        case > 20:
                            Console.WriteLine(LevelNoob);
                            Console.WriteLine(TitleNoob);
                            level = "Zyn the bugged";
                            break;
                    }
                }
            }


        } while (op != 0);
    }

}
