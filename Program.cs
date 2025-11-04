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
        
        //Chapter 1:
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

        //Chapter 2:
        const string MsgDoor = "You stand before door {0}, enter the correct number between 1 and 5 to progress. You have {1} attempts remaining";
        const string InputErrorDungeon = "Input a nuber between 1 and 5.";
        const string DoorCorrect = "The drangon respects you. You have unlocked the next level.";
        const string DoorCorrectFinal = "The last door has been succesfully open!";
        const string DoorIncorrect = "The dragon is suspicious, you may try again.";
        const string DoorIncorrectLast = "You have failed too many times.";
        const string DungeonFail = "The dragon has detected your presence and had you expelled form the server!";
        const string DungeonComplete = "You have unlocked the final level. Get ready for battle!";

        //Chapter 3:
        const string ExcavationStart = "Excavation {0}, you enter the cave and dig in:";
        const string TreasureFail = "Today it's not your lucky day, you have found 0 bits.";
        const string TreasureFound = "You have found {0} bits today.";
        const string TotalTreasure = "You have gathered a total of {0} bits.";

        //Chapter 1:
        int op = 0, day, hour, power, totalHour = 0, totalPower = 0;
        bool validInput;
        string wizardName, level;

        //Chapter 2:
        int door = 1, attempts = 3, number, code;
        bool dungeonComplete;

        //Chapter 3:
        int excavation = 1, treasure, bits, totalBits = 0;

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
                switch (op)
                {
                    case 1:
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
                            Console.WriteLine(DayTraining, day, wizardName, hour, power);
                            Console.WriteLine(TotalTraining, wizardName, totalHour, totalPower);
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
                        break;
                    case 2:
                        dungeonComplete = false;
                        do
                        {
                            for (door = 1; door <= 3; door++)
                            {
                                code = rnd.Next(1, 6);
                                attempts = 3;

                                while (attempts > 0 && attempts <= 3)
                                {
                                    Console.WriteLine(MsgDoor, door, attempts);

                                    try
                                    {
                                        number = Int32.Parse(Console.ReadLine());
                                        if (number == code)
                                        {
                                            switch (door)
                                            {
                                                case 3:
                                                    Console.WriteLine(DoorCorrectFinal);
                                                    attempts = 5;
                                                    break;
                                                case < 3:
                                                    Console.WriteLine(DoorCorrect);
                                                    attempts = 5;
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            switch (attempts)
                                            {
                                                case <= 1:
                                                    Console.WriteLine(DoorIncorrectLast);
                                                    attempts--;
                                                    break;
                                                case > 1:
                                                    Console.WriteLine(DoorIncorrect);
                                                    attempts--;
                                                    break;
                                            }
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine(InputErrorDungeon);
                                    }
                                    catch
                                    {
                                        Console.WriteLine(InputErrorDungeon);
                                    }
                                }
                                if (attempts <= 0)
                                {
                                    door = 3;
                                }
                            }
                            if (door >= 3 && attempts > 0)
                            {
                                dungeonComplete = true;
                            }
                        } while (attempts <= 3 && attempts >= 1);

                        Console.WriteLine(dungeonComplete ? DungeonComplete : DungeonFail);
                        break;
                    case 3:
                        for (excavation = 1; excavation <= 5; excavation++)
                        {
                            treasure = rnd.Next(0, 11);
                            bits = rnd.Next(5, 51);
                            totalBits = totalBits + bits;

                            Console.WriteLine(ExcavationStart, excavation);

                            switch (treasure)
                            {
                                case <= 0:
                                    Console.WriteLine(TreasureFail);
                                    Console.WriteLine(PressEnter);
                                    Console.ReadLine();
                                    break;
                                case >= 1:
                                    Console.WriteLine(TreasureFound, bits);
                                    Console.WriteLine(PressEnter);
                                    Console.ReadLine();
                                    break;
                            }

                            Console.WriteLine(TotalTreasure, totalBits);
                        }
                        break;
                }
            }
        } while (op != 0);
    }
}
