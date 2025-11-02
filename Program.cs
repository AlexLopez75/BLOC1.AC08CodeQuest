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
        const string MsgDoor = "You stand before door {0}, enter the correct number between 1 and 5 to progress. You have {1} attempts remaining";
        const string DoorCorrect = "The drangon respects you. You have unlocked the next level.";
        const string DoorCorrectFinal = "The last door has been succesfully open!";
        const string DoorIncorrect = "The dragon is suspicious, you may try again.";
        const string DoorIncorrectLast = "You have failed too many times.";
        const string DungeonFail = "The dragon has detected your presence and had you expelled form the server!";
        const string DungeonComplete = "You have unlocked the final level. Get ready for battle!";

        int op = 0, door = 1, attempts = 3, number, code;
        bool validInput, dungeonComplete;

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
                if (op == 2)
                {
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
                            if (attempts <= 0)
                            {
                                door = 3;
                            }
                        }
                        if (door == 3 && attempts > 0)
                        {
                            dungeonComplete = true;
                        }
                    } while (attempts <= 3 && attempts >= 1);

                    switch (dungeonComplete)
                    {
                        case true:
                            Console.WriteLine(DungeonComplete);
                            break;
                        case false:
                            Console.WriteLine(DungeonFail);
                            break;
                    }
                }
            }
        } while (op != 0);
    }
}
