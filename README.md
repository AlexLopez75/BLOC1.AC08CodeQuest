# Chapter 2. Entering the dragon RAMón the Powerful's dungeon

In this first chapter, the following functions are requested to be programmed:

1. There are 3 doors. Each has a random code between (1 – 5).
2. You have 3 attempts per door.
3. If you fail a door, the game ends with the message:

*The dragon has detected your presence and has expelled you from the server!*

If you are correct, the message appears:

*The dragon respects you. You have unlocked the next level!*

If you reach the third door and open it successfully, the message appears:

*You have unlocked the final level. Prepare for battle!*

Normal Win: code = 5 - 3 - 2

| Instrucció | Iteració | door | attempts | code | number | Output |
|------------|----------|------|----------|--------|------|--------|
| 1 | - | 1 | 3 | rnd | - | - |
| 2 | - | 1 | 3 | - | - | dungeonComplete = false |
| 3 | 1 | 1 | 3 | 5 | - | code = 5 |
| 3 | 2 | 1 | 3 | 5 | - | attempts = 3 |
| 3 | 3 | 1 | 3 | 5 | - | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
| 3 | 4 | 1 | 3 | 5 | 5 | try --> READ number |
| 3 | 5 | 1 | 3 | 5 | 5 | number == code == true |
| 3 | 6 | 1 | 3 | 5 | 5 | switch --> case < 3 |
| 3 | 7 | 1 | 3 | 5 | 5 | WRITE = "The drangon respects you. You have unlocked the next level." |
| 3 | 8 | 1 | 5 | 5 | 5 | attempts = 5 |
| 3 | 9 | 1 | 5 | 5 | 5 | attempts <= 0 == false |
| 3 | 10 | 1 | 5 | 5 | 5 | (door >= 3 && attempts > 0) == false |
| 4 | 1 | 2 | 5 | 5 | 5 | door++ |
| 4 | 2 | 2 | 5 | 3 | 5 | code = 3 |
| 4 | 3 | 2 | 3 | 3 | 5 | attempts = 3 |
| 4 | 4 | 2 | 3 | 3 | 5 | WRITE = "You stand before door 2, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
| 4 | 5 | 2 | 3 | 3 | 3 | try --> READ number |
| 4 | 6 | 2 | 3 | 3 | 3 | number == code == true |
| 4 | 7 | 2 | 3 | 3 | 3 | switch --> case < 3 |
| 4 | 8 | 2 | 3 | 3 | 3 | WRITE = "The drangon respects you. You have unlocked the next level." |
| 4 | 9 | 2 | 5 | 3 | 3 | attempts = 5 |
| 4 | 10 | 2 | 5 | 3 | 3 | attempts <= 0 == false |
| 4 | 11 | 2 | 5 | 3 | 3 | (door >= 3 && attempts > 0) == false |
| 5 | 1 | 3 | 5 | 3 | 3 | door++ |
| 5 | 2 | 3 | 5 | 2 | 3 | code = 2 |
| 5 | 3 | 3 | 3 | 2 | 3 | attempts = 3 |
| 5 | 4 | 3 | 3 | 2 | 3 | WRITE = "You stand before door 3, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
| 5 | 5 | 3 | 3 | 2 | 2 | try --> READ number |
| 5 | 6 | 3 | 3 | 2 | 2 | number == code == true |
| 5 | 7 | 3 | 3 | 2 | 2 | switch --> case 3 |
| 5 | 8 | 3 | 3 | 2 | 2 | WRITE = "The last door has been succesfully open!" |
| 5 | 9 | 3 | 5 | 2 | 2 | attempts = 5 |
| 5 | 10 | 3 | 5 | 2 | 2 | attempts <= 0 == false |
| 5 | 11 | 3 | 5 | 2 | 2 | (door >= 3 && attempts > 0) == true |
| 5 | 12 | 3 | 5 | 2 | 2 | dungeonComplete = true |
| 6 | - | 4 | 5 | 2 | 2 | door++ |
| 7 | - | 4 | 5 | 2 | 2 | dungeonComplete ? == true |
| 8 | - | 4 | 5 | 2 | 2 | WRITE = "You have unlocked the final level. Get ready for battle!" |

Normal Lose: code = 5 - 3 - 2

| Instrucció | Iteració | door | attempts | code | number | Output |
|------------|----------|------|----------|--------|------|--------|
| 1 | - | 1 | 3 | rnd | - | - |
| 2 | - | 1 | 3 | - | - | dungeonComplete = false |
| 3 | 1 | 1 | 3 | 5 | - | code = 5 |
| 3 | 2 | 1 | 3 | 5 | - | attempts = 3 |
| 3 | 3 | 1 | 3 | 5 | - | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
| 3 | 4 | 1 | 3 | 5 | 4 | try --> READ number |
| 3 | 5 | 1 | 3 | 5 | 4 | number == code == false |
| 3 | 6 | 1 | 3 | 5 | 4 | switch --> case > 1 |
| 3 | 7 | 1 | 3 | 5 | 4 | WRITE = "The dragon is suspicious, you may try again." |
| 3 | 8 | 1 | 2 | 5 | 4 | attempts-- |
| 3 | 9 | 1 | 2 | 5 | 4 | attempts <= 0 == false |
| 3 | 10 | 1 | 2 | 5 | 4 | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 2 attempts remaining" |
| 3 | 11 | 1 | 2 | 5 | 2 | try --> READ number |
| 3 | 12 | 1 | 2 | 5 | 2 | number == code == false |
| 3 | 13 | 1 | 2 | 5 | 2 | switch --> case > 1 |
| 3 | 14 | 1 | 2 | 5 | 2 | WRITE = "The dragon is suspicious, you may try again." |
| 3 | 15 | 1 | 1 | 5 | 2 | attempts-- |
| 3 | 16 | 1 | 1 | 5 | 2 | attempts <= 0 == false |
| 3 | 17 | 1 | 1 | 5 | 2 | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 1 attempts remaining" |
| 3 | 18 | 1 | 1 | 5 | 3 | try --> READ number |
| 3 | 19 | 1 | 1 | 5 | 3 | number == code == false |
| 3 | 20 | 1 | 1 | 5 | 3 | switch --> case <= 1 |
| 3 | 21 | 1 | 1 | 5 | 3 | WRITE = "You have failed too many times." |
| 3 | 22 | 1 | 0 | 5 | 3 | attempts-- |
| 3 | 23 | 1 | 0 | 5 | 3 | attempts <= 0 == true |
| 3 | 24 | 1 | 0 | 5 | 3 | door = 3 |
| 4 | - | 1 | 0 | 5 | 3 | dungeonComplete ? == false |
| 5 | - | 1 | 0 | 5 | 3 | WRITE = "The dragon has detected your presence and had you expelled form the server!" |

Limit: code = 5 - 3 - 2

| Instrucció | Iteració | door | attempts | code | number | Output |
|------------|----------|------|----------|--------|------|--------|
| 1 | - | 1 | 3 | rnd | - | - |
| 2 | - | 1 | 3 | - | - | dungeonComplete = false |
| 3 | 1 | 1 | 3 | 5 | - | code = 5 |
| 3 | 2 | 1 | 3 | 5 | - | attempts = 3 |
| 3 | 3 | 1 | 3 | 5 | - | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
| 3 | 4 | 1 | 3 | 5 | 4 | try --> READ number |
| 3 | 5 | 1 | 3 | 5 | 4 | number == code == false |
| 3 | 6 | 1 | 3 | 5 | 4 | switch --> case > 1 |
| 3 | 7 | 1 | 3 | 5 | 4 | WRITE = "The dragon is suspicious, you may try again." |
| 3 | 8 | 1 | 2 | 5 | 4 | attempts-- |
| 3 | 9 | 1 | 2 | 5 | 4 | attempts <= 0 == false |
| 3 | 10 | 1 | 2 | 5 | 4 | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 2 attempts remaining" |
| 3 | 11 | 1 | 2 | 5 | 2 | try --> READ number |
| 3 | 12 | 1 | 2 | 5 | 2 | number == code == false |
| 3 | 13 | 1 | 2 | 5 | 2 | switch --> case > 1 |
| 3 | 14 | 1 | 2 | 5 | 2 | WRITE = "The dragon is suspicious, you may try again." |
| 3 | 15 | 1 | 1 | 5 | 2 | attempts-- |
| 3 | 16 | 1 | 1 | 5 | 2 | attempts <= 0 == false |
| 3 | 17 | 1 | 1 | 5 | 2 | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 1 attempts remaining" |
| 3 | 18 | 1 | 1 | 5 | 5 | try --> READ number |
| 3 | 19 | 1 | 1 | 5 | 5 | number == code == true |
| 3 | 20 | 1 | 1 | 5 | 5 | switch --> case < 3|
| 3 | 21 | 1 | 1 | 5 | 5 | WRITE = "The drangon respects you. You have unlocked the next level." |
| 3 | 22 | 1 | 5 | 5 | 5 | attempts = 5 |
| 3 | 23 | 1 | 5 | 5 | 5 | attempts <= 0 == false |
| 3 | 24 | 1 | 5 | 5 | 5 | (door >= 3 && attempts > 0) == false |
| 4 | 1 | 2 | 5 | 3 | 5 | door++ |
| 4 | 2 | 2 | 5 | 3 | 5 | code = 3 |
| 4 | 3 | 2 | 3 | 3 | 5 | attempts = 3 |
| 4 | 4 | 2 | 3 | 3 | 5 | WRITE = "You stand before door 2, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
| 4 | 5 | 2 | 3 | 3 | 5 | try --> READ number |
| 4 | 6 | 2 | 3 | 3 | 5 | number == code == false |
| 4 | 7 | 2 | 3 | 3 | 5 | switch --> case > 1 |
| 4 | 8 | 2 | 3 | 3 | 5 | WRITE = "The dragon is suspicious, you may try again." |
| 4 | 9 | 2 | 2 | 3 | 5 | attempts-- |
| 4 | 10 | 2 | 2 | 3 | 5 | attempts <= 0 == false |
| 4 | 11 | 2 | 2 | 3 | 5 | WRITE = "You stand before door 2, enter the correct number between 1 and 5 to progress. You have 2 attempts remaining" |
| 4 | 12 | 2 | 2 | 3 | 1 | try --> READ number |
| 4 | 13 | 2 | 2 | 3 | 1 | number == code == false |
| 4 | 14 | 2 | 2 | 3 | 1 | switch --> case > 1 |
| 4 | 15 | 2 | 2 | 3 | 1 | WRITE = "The dragon is suspicious, you may try again." |
| 4 | 16 | 2 | 1 | 3 | 1 | attempts-- |
| 4 | 17 | 2 | 1 | 3 | 1 | attempts <= 0 == false |
| 4 | 18 | 2 | 1 | 3 | 1 | WRITE = "You stand before door 2, enter the correct number between 1 and 5 to progress. You have 1 attempts remaining" |
| 4 | 19 | 2 | 1 | 3 | 3 | try --> READ number |
| 4 | 20 | 2 | 1 | 3 | 3 | number == code == true |
| 4 | 21 | 2 | 1 | 3 | 3 | switch --> case < 3 |
| 4 | 22 | 2 | 1 | 3 | 3 | WRITE = "The drangon respects you. You have unlocked the next level." |
| 4 | 23 | 2 | 5 | 3 | 3 | attempts = 5 |
| 4 | 24 | 2 | 5 | 3 | 3 | attempts <= 0 == false |
| 4 | 25 | 2 | 5 | 3 | 3 | (door >= 3 && attempts > 0) == false |
| 5 | 1 | 3 | 5 | 2 | 5 | door++ |
| 5 | 2 | 3 | 5 | 2 | 5 | code = 2 |
| 5 | 3 | 3 | 3 | 2 | 5 | attempts = 3 |
| 5 | 4 | 3 | 3 | 2 | 5 | WRITE = "You stand before door 3, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
| 5 | 5 | 3 | 3 | 2 | 1 | try --> READ number |
| 5 | 6 | 3 | 3 | 2 | 1 | number == code == false |
| 5 | 7 | 3 | 3 | 2 | 1 | switch --> case > 1 |
| 5 | 8 | 3 | 3 | 2 | 1 | WRITE = "The dragon is suspicious, you may try again." |
| 5 | 9 | 3 | 2 | 2 | 1 | attempts-- |
| 5 | 10 | 3 | 2 | 2 | 1 | attempts <= 0 == false |
| 5 | 11 | 3 | 2 | 2 | 1 | WRITE = "You stand before door 3, enter the correct number between 1 and 5 to progress. You have 2 attempts remaining" |
| 5 | 12 | 3 | 2 | 2 | 4 | try --> READ number |
| 5 | 13 | 3 | 2 | 2 | 4 | number == code == false |
| 5 | 14 | 3 | 2 | 2 | 4 | switch --> case > 1 |
| 5 | 15 | 3 | 2 | 2 | 4 | WRITE = "The dragon is suspicious, you may try again." |
| 5 | 16 | 3 | 1 | 2 | 4 | attempts-- |
| 5 | 17 | 3 | 1 | 2 | 4 | attempts <= 0 == false |
| 5 | 18 | 3 | 1 | 2 | 4 | WRITE = "You stand before door 3, enter the correct number between 1 and 5 to progress. You have 1 attempts remaining" |
| 5 | 19 | 3 | 1 | 2 | 2 | try --> READ number |
| 5 | 20 | 3 | 1 | 2 | 2 | number == code == true |
| 5 | 21 | 3 | 1 | 2 | 2 | switch --> case 3 |
| 5 | 22 | 3 | 1 | 2 | 2 | WRITE = "The last door has been succesfully open!" |
| 5 | 23 | 3 | 5 | 2 | 2 | attempts = 5 |
| 5 | 24 | 3 | 5 | 2 | 2 | attempts <= 0 == false |
| 5 | 25 | 3 | 5 | 2 | 2 | (door >= 3 && attempts > 0) == true |
| 5 | 26 | 3 | 5 | 2 | 2 | dungeonComplete = true |
| 6 | - | 4 | 5 | 2 | 2 | door++ |
| 7 | - | 4 | 5 | 2 | 2 | dungeonComplete ? == true |
| 8 | - | 4 | 5 | 2 | 2 | WRITE = "You have unlocked the final level. Get ready for battle!" |

Error: code = 5 - 3 - 2

| Instrucció | Iteració | door | attempts | code | number | Output |
|------------|----------|------|----------|--------|------|--------|
| 1 | - | 1 | 3 | rnd | - | - |
| 2 | - | 1 | 3 | - | - | dungeonComplete = false |
| 3 | 1 | 1 | 3 | 5 | - | code = 5 |
| 3 | 2 | 1 | 3 | 5 | - | attempts = 3 |
| 3 | 3 | 1 | 3 | 5 | - | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
| 3 | 4 | 1 | 3 | 5 | Hello | catch (FormatException) --> WRTIE = "Input a nuber between 1 and 5." |
| 3 | 5 | 1 | 3 | 5 | Hello | attempts <= 0 == false |
| 3 | 6 | 1 | 3 | 5 | Hello | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
| 3 | 7 | 1 | 3 | 5 |  | catch (FormatException) --> WRTIE = "Input a nuber between 1 and 5." |
| 3 | 8 | 1 | 3 | 5 |  | attempts <= 0 == false |
| 3 | 9 | 1 | 3 | 5 |  | WRITE = "You stand before door 1, enter the correct number between 1 and 5 to progress. You have 3 attempts remaining" |
...