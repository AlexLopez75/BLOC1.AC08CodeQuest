# Chapter 3: Looting the treasure 💰

1. Every time you mine, you get a random amount between 5 and 50 bits, or maybe nothing You can only do 5 digs.
2. Show the result of each dig.

- With each digging attempt there may be a chance of finding nothing. If this is the case, it indicates with a message:

*"Today is not your lucky day, you found 0 bits."*

- If the total > 200, it shows:

*“You have unlocked the gold GPU! Your spells now run at 120 FPS!”*

- If you finally don’t reach 200 bits, it shows:

*“Your magic card is still integrated. It’s time to defeat another dragon!”*

Normal: totalBits 250

| Instrucció | Iteració | excavation | treasure | bits | totalBits | Output |
|------------|----------|------------|----------|------|-----------|--------|
| 1 | - | 1 | rnd | rnd | 0 | - |
| 2 | 1 | 1 | 1 | 0 | 0 | treasure = 1 |
| 2 | 2 | 1 | 1 | 50 | 0 | bits = 50 |
| 2 | 3 | 1 | 1 | 50 | 0 | WRITE = "Excavation 1, you enter the cave and dig in:" |
| 2 | 4 | 1 | 1 | 50 | 0 | WRITE = "You have found 50 bits today." |
| 2 | 5 | 2 | 1 | 50 | 50 | totalBits = 50 |
| 2 | 6 | 1 | 1 | 50 | 50 | WRITE = "You have gathered a total of 50 bits." |
| 2 | 7 | 1 | 1 | 50 | 50 | WRITE = "Press enter to continue" |
| 3 | 1 | 2 | 1 | 50 | 50 | excavation++ |
| 3 | 2 | 2 | 1 | 50 | 50 | treasure = 1 |
| 3 | 3 | 2 | 1 | 50 | 50 | bits = 50 |
| 3 | 4 | 2 | 1 | 50 | 50 | WRITE = "Excavation 2, you enter the cave and dig in:" |
| 3 | 5 | 2 | 1 | 50 | 50 | WRITE = "You have found 50 bits today." |
| 3 | 6 | 2 | 1 | 50 | 100 | totalBits = 100 |
| 3 | 7 | 2 | 1 | 50 | 100 | WRITE = "You have gathered a total of 100 bits." |
| 3 | 8 | 2 | 1 | 50 | 100 | WRITE = "Press enter to continue" |
| 4 | 1 | 3 | 1 | 50 | 100 | excavation++ |
| 4 | 2 | 3 | 1 | 50 | 100 | treasure = 1 |
| 4 | 3 | 3 | 1 | 50 | 100 | bits = 50 |
| 4 | 4 | 3 | 1 | 50 | 100 | WRITE = "Excavation 3, you enter the cave and dig in:" |
| 4 | 5 | 3 | 1 | 50 | 100 | WRITE = "You have found 50 bits today." |
| 4 | 6 | 3 | 1 | 50 | 150 | totalBits = 150 |
| 4 | 7 | 3 | 1 | 50 | 150 | WRITE = "You have gathered a total of 150 bits." |
| 4 | 8 | 3 | 1 | 50 | 150 | WRITE = "Press enter to continue" |
| 5 | 1 | 4 | 1 | 50 | 150 | excavation++ |
| 5 | 2 | 4 | 1 | 50 | 150 | treasure = 1 |
| 5 | 3 | 4 | 1 | 50 | 150 | bits = 50 |
| 5 | 4 | 4 | 1 | 50 | 150 | WRITE = "Excavation 4, you enter the cave and dig in:" |
| 5 | 5 | 4 | 1 | 50 | 150 | WRITE = "You have found 50 bits today." |
| 5 | 6 | 4 | 1 | 50 | 200 | totalBits = 200 |
| 5 | 7 | 4 | 1 | 50 | 200 | WRITE = "You have gathered a total of 200 bits." |
| 5 | 8 | 4 | 1 | 50 | 200 | WRITE = "Press enter to continue" |
| 6 | 1 | 5 | 1 | 50 | 200 | excavation++ |
| 6 | 2 | 5 | 1 | 50 | 200 | treasure = 1 |
| 6 | 3 | 5 | 1 | 50 | 200 | bits = 50 |
| 6 | 4 | 5 | 1 | 50 | 200 | WRITE = "Excavation 5, you enter the cave and dig in:" |
| 6 | 5 | 5 | 1 | 50 | 200 | WRITE = "You have found 50 bits today." |
| 6 | 6 | 5 | 1 | 50 | 250 | totalBits = 250 |
| 6 | 7 | 5 | 1 | 50 | 250 | WRITE = "You have gathered a total of 250 bits." |
| 6 | 8 | 5 | 1 | 50 | 250 | WRITE = "Press enter to continue" |
| 7 | - | 6 | 1 | 50 | 250 | excavation++ |
| 8 | - | 6 | 1 | 50 | 250 | totalBits >= 200 ? = true |
| 9 | - | 6 | 1 | 50 | 200 | WRITE = "You have unlocked the golden GPU! Your sepells now go at 120 FPS!" |

Limit: totalBits = 200

| Instrucció | Iteració | excavation | treasure | bits | totalBits | Output |
|------------|----------|------------|----------|------|-----------|--------|
| 1 | - | 1 | rnd | rnd | 0 | - |
| 2 | 1 | 1 | 1 | 0 | 0 | treasure = 1 |
| 2 | 2 | 1 | 1 | 50 | 0 | bits = 50 |
| 2 | 3 | 1 | 1 | 50 | 0 | WRITE = "Excavation 1, you enter the cave and dig in:" |
| 2 | 4 | 1 | 1 | 50 | 0 | WRITE = "You have found 50 bits today." |
| 2 | 5 | 2 | 1 | 50 | 50 | totalBits = 50 |
| 2 | 6 | 1 | 1 | 50 | 50 | WRITE = "You have gathered a total of 50 bits." |
| 2 | 7 | 1 | 1 | 50 | 50 | WRITE = "Press enter to continue" |
| 3 | 1 | 2 | 1 | 50 | 50 | excavation++ |
| 3 | 2 | 2 | 1 | 50 | 50 | treasure = 1 |
| 3 | 3 | 2 | 1 | 50 | 50 | bits = 50 |
| 3 | 4 | 2 | 1 | 50 | 50 | WRITE = "Excavation 2, you enter the cave and dig in:" |
| 3 | 5 | 2 | 1 | 50 | 50 | WRITE = "You have found 50 bits today." |
| 3 | 6 | 2 | 1 | 50 | 100 | totalBits = 100 |
| 3 | 7 | 2 | 1 | 50 | 100 | WRITE = "You have gathered a total of 100 bits." |
| 3 | 8 | 2 | 1 | 50 | 100 | WRITE = "Press enter to continue" |
| 4 | 1 | 3 | 1 | 50 | 100 | excavation++ |
| 4 | 2 | 3 | 1 | 50 | 100 | treasure = 1 |
| 4 | 3 | 3 | 1 | 50 | 100 | bits = 50 |
| 4 | 4 | 3 | 1 | 50 | 100 | WRITE = "Excavation 3, you enter the cave and dig in:" |
| 4 | 5 | 3 | 1 | 50 | 100 | WRITE = "You have found 50 bits today." |
| 4 | 6 | 3 | 1 | 50 | 150 | totalBits = 150 |
| 4 | 7 | 3 | 1 | 50 | 150 | WRITE = "You have gathered a total of 150 bits." |
| 4 | 8 | 3 | 1 | 50 | 150 | WRITE = "Press enter to continue" |
| 5 | 1 | 4 | 1 | 50 | 150 | excavation++ |
| 5 | 2 | 4 | 1 | 50 | 150 | treasure = 1 |
| 5 | 3 | 4 | 1 | 50 | 150 | bits = 50 |
| 5 | 4 | 4 | 1 | 50 | 150 | WRITE = "Excavation 4, you enter the cave and dig in:" |
| 5 | 5 | 4 | 1 | 50 | 150 | WRITE = "You have found 50 bits today." |
| 5 | 6 | 4 | 1 | 50 | 200 | totalBits = 200 |
| 5 | 7 | 4 | 1 | 50 | 200 | WRITE = "You have gathered a total of 200 bits." |
| 5 | 8 | 4 | 1 | 50 | 200 | WRITE = "Press enter to continue" |
| 6 | 1 | 5 | 1 | 50 | 200 | excavation++ |
| 6 | 2 | 5 | 0 | 0 | 200 | treasure = 0 |
| 6 | 3 | 5 | 0 | 0 | 200 | bits = 10 |
| 6 | 4 | 5 | 0 | 0 | 200 | WRITE = "Excavation 5, you enter the cave and dig in:" |
| 6 | 5 | 5 | 0 | 0 | 200 | WRITE = "Today it's not your lucky day, you have found 0 bits." |
| 6 | 6 | 5 | 0 | 0 | 200 | WRITE = "You have gathered a total of 200 bits." |
| 6 | 7 | 5 | 0 | 0 | 200 | WRITE = "Press enter to continue" |
| 7 | - | 6 | 0 | 0 | 200 | excavation++ |
| 8 | - | 6 | 0 | 0 | 200 | totalBits >= 200 ? = true |
| 9 | - | 6 | 0 | 0 | 200 | WRITE = "You have unlocked the golden GPU! Your sepells now go at 120 FPS!" |

Limit: totalBits = 0

| Instrucció | Iteració | excavation | treasure | bits | totalBits | Output |
|------------|----------|------------|----------|------|-----------|--------|
| 1 | - | 1 | rnd | rnd | 0 | - |
| 2 | 2 | 5 | 0 | 0 | 200 | treasure = 0 |
| 2 | 3 | 5 | 0 | 0 | 0 | bits = 10 |
| 2 | 4 | 5 | 0 | 0 | 0 | WRITE = "Excavation 5, you enter the cave and dig in:" |
| 2 | 5 | 5 | 0 | 0 | 0 | WRITE = "Today it's not your lucky day, you have found 0 bits." |
| 2 | 6 | 5 | 0 | 0 | 0 | WRITE = "You have gathered a total of 0 bits." |
| 2 | 7 | 5 | 0 | 0 | 0 | WRITE = "Press enter to continue" |
| 3 | 1 | 2 | 1 | 0 | 0 | excavation++ |
| 3 | 2 | 5 | 0 | 0 | 0 | treasure = 0 |
| 3 | 3 | 5 | 0 | 0 | 0 | bits = 13 |
| 3 | 4 | 5 | 0 | 0 | 0 | WRITE = "Excavation 5, you enter the cave and dig in:" |
| 3 | 5 | 5 | 0 | 0 | 0 | WRITE = "Today it's not your lucky day, you have found 0 bits." |
| 3 | 6 | 5 | 0 | 0 | 0 | WRITE = "You have gathered a total of 0 bits." |
| 3 | 7 | 5 | 0 | 0 | 0 | WRITE = "Press enter to continue" |
| 4 | 1 | 2 | 1 | 0 | 0 | excavation++ |
| 4 | 2 | 5 | 0 | 0 | 0 | treasure = 0 |
| 4 | 3 | 5 | 0 | 0 | 0 | bits = 34 |
| 4 | 4 | 5 | 0 | 0 | 0 | WRITE = "Excavation 5, you enter the cave and dig in:" |
| 4 | 5 | 5 | 0 | 0 | 0 | WRITE = "Today it's not your lucky day, you have found 0 bits." |
| 4 | 6 | 5 | 0 | 0 | 0 | WRITE = "You have gathered a total of 0 bits." |
| 4 | 7 | 5 | 0 | 0 | 0 | WRITE = "Press enter to continue" |
| 5 | 1 | 2 | 1 | 0 | 0 | excavation++ |
| 5 | 2 | 4 | 0 | 0 | 0 | treasure = 0 |
| 5 | 3 | 4 | 0 | 0 | 0 | bits = 7 |
| 5 | 4 | 4 | 0 | 0 | 0 | WRITE = "Excavation 5, you enter the cave and dig in:" |
| 5 | 5 | 4 | 0 | 0 | 0 | WRITE = "Today it's not your lucky day, you have found 0 bits." |
| 5 | 6 | 4 | 0 | 0 | 0 | WRITE = "You have gathered a total of 0 bits." |
| 5 | 7 | 4 | 0 | 0 | 0 | WRITE = "Press enter to continue" |
| 6 | 1 | 2 | 1 | 0 | 0 | excavation++ |
| 6 | 2 | 5 | 0 | 0 | 0 | treasure = 0 |
| 6 | 3 | 5 | 0 | 0 | 0 | bits = 49 |
| 6 | 4 | 5 | 0 | 0 | 0 | WRITE = "Excavation 5, you enter the cave and dig in:" |
| 6 | 5 | 5 | 0 | 0 | 0 | WRITE = "Today it's not your lucky day, you have found 0 bits." |
| 6 | 6 | 5 | 0 | 0 | 0 | WRITE = "You have gathered a total of 0 bits." |
| 6 | 7 | 5 | 0 | 0 | 0 | WRITE = "Press enter to continue" |
| 7 | - | 6 | 0 | 0 | 0 | excavation++ |
| 8 | - | 6 | 0 | 0 | 0 | totalBits >= 200 ? = false |
| 9 | - | 6 | 0 | 0 | 0 | WRITE = "Your graphics card is still integrated. Time to beat another dragon!" |

