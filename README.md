# Chapter 1: El camí del mag aprenent 🧙‍♀️

En aquest primer capítol, es demana programar les seguents funcions:

1. Demanar el nom del mag i defineix el seu nivell inicial a 1.
2. Cada dia d’entrenament (5 dies), el mag ha de dedicar una quantitat d’hores (aleatori (màx 24 h)) de meditació i ha d'obtenir una quantitat aleatòria de poder entre 1 i 10 punts.
3. Cada dia, mostrar un missatge de l'evolució del mag dia a dia (acumulativa).
4.  Al final, mostrar el nivell final de poder. Segons el total:

- Menys de 20
- Igual o més de 20
- Igual o més de 30
- Igual o més de 35
- Igual o més de 40


Normal: totalPower = 50

| Instrucció | Iteració | day | hour | power | totalHour | totalPower | level | Output |
|------------|----------|-----|------|-------|-----------|------------|-------|--------|
| 1 | - | 1 | rnd | 0 | 0 | 0 | "1" | - |
| 2 | 1 | 1 | 2 | 0 | 0 | 0 | "1" | hour = 2 |
| 2 | 2 | 1 | 2 | 10 | 0 | 0 | "1" | power = 10 |
| 2 | 3 | 1 | 2 | 10 | 2 | 0 | "1" | totalHour = 2 |
| 2 | 4 | 1 | 2 | 10 | 2 | 10 | "1" | totalPower = 10 |
| 2 | 5 | 1 | 2 | 10 | 2 | 10 | "1" | WRITE = "Day 1 : wizardName meditated for 2 hours and gained 10 power points" |
| 2 | 6 | 1 | 2 | 10 | 2 | 10 | "1" | WRITE = "wizardName has meditated for a total of 2 hours and gained 10 power points" |
| 2 | 7 | 1 | 2 | 10 | 2 | 10 | "1" | WRITE = "Press enter to continue" |
| 3 | 1 | 2 | 4 | 10 | 2 | 10 | "1" | hour = 4 |
| 3 | 2 | 2 | 4 | 10 | 2 | 10 | "1" | power = 10 |
| 3 | 3 | 2 | 4 | 10 | 6 | 10 | "1" | totalHour = 6 |
| 3 | 4 | 2 | 4 | 10 | 6 | 20 | "1" | totalPower = 20 |
| 3 | 5 | 2 | 4 | 10 | 6 | 20 | "1" | WRITE = "Day 2 : wizardName meditated for 4 hours and gained 10 power points" |
| 3 | 6 | 2 | 4 | 10 | 6 | 20 | "1" | WRITE = "wizardName has meditated for a total of 6 hours and gained 20 power points" |
| 3 | 7 | 2 | 4 | 10 | 6 | 20 | "1" | WRITE = "Press enter to continue" |
| 4 | 1 | 3 | 4 | 10 | 6 | 20 | "1" | hour = 4 |
| 4 | 2 | 3 | 4 | 10 | 6 | 20 | "1" | power = 10 |
| 4 | 3 | 3 | 4 | 10 | 10 | 20 | "1" | totalHour = 10 |
| 4 | 4 | 3 | 4 | 10 | 10 | 30 | "1" | totalPower = 30 |
| 4 | 5 | 3 | 4 | 10 | 10 | 30 | "1" | WRITE = "Day 3 : wizardName meditated for 4 hours and gained 10 power points" |
| 4 | 6 | 3 | 4 | 10 | 10 | 30 | "1" | WRITE = "wizardName has meditated for a total of 10 hours and gained 30 power points" |
| 4 | 7 | 3 | 4 | 10 | 10 | 30 | "1" | WRITE = "Press enter to continue" |
| 5 | 1 | 4 | 7 | 10 | 10 | 30 | "1" | hour = 7 |
| 5 | 2 | 4 | 7 | 10 | 10 | 30 | "1" | power = 10 |
| 5 | 3 | 4 | 7 | 10 | 17 | 30 | "1" | totalHour = 17 |
| 5 | 4 | 4 | 7 | 10 | 17 | 40 | "1" | totalPower = 40 |
| 5 | 5 | 4 | 7 | 10 | 17 | 40 | "1" | WRITE = "Day 4 : wizardName meditated for 7 hours and gained 10 power points" |
| 5 | 6 | 4 | 7 | 10 | 17 | 40 | "1" | WRITE = "wizardName has meditated for a total of 17 hours and gained 40 power points" |
| 5 | 7 | 4 | 7 | 10 | 17 | 40 | "1" | WRITE = "Press enter to continue" |
| 6 | 1 | 5 | 5 | 10 | 17 | 40 | "1" | hour = 5 |
| 6 | 2 | 5 | 5 | 10 | 17 | 40 | "1" | power = 10 |
| 6 | 3 | 5 | 5 | 10 | 22 | 40 | "1" | totalHour = 22 |
| 6 | 4 | 5 | 5 | 10 | 22 | 50 | "1" | totalPower = 50 |
| 6 | 5 | 5 | 5 | 10 | 22 | 50 | "1" | WRITE = "Day 5 : wizardName meditated for 5 hours and gained 10 power points" |
| 6 | 6 | 5 | 5 | 10 | 22 | 50 | "1" | WRITE = "wizardName has meditated for a total of 22 hours and gained 50 power points" |
| 6 | 7 | 5 | 5 | 10 | 22 | 50 | "1" | WRITE = "Press enter to continue" |
| 7 | - | 5 | 5 | 10 | 22 | 50 | "1" | switch --> case >= 40: |
| 8 | - | 5 | 5 | 10 | 22 | 50 | "1" | WRITE = "You have achieved the Master of Arcanes rank!" |
| 9 | - | 5 | 5 | 10 | 22 | 50 | "1" | WRITE = "Level: ITB-Wizard the Grey" |
| 10 | - | 5 | 5 | 10 | 22 | 50 | "ITB-Wizard the Grey" | level = "ITB-Wizard the Grey" |


Limit: totalPower = 35

| Instrucció | Iteració | day | hour | power | totalHour | totalPower | level | Output |
|------------|----------|-----|------|-------|-----------|------------|-------|--------|
| 1 | - | 1 | rnd | 0 | 0 | 0 | "1" | - |
| 2 | 1 | 1 | 2 | 0 | 0 | 0 | "1" | hour = 2 |
| 2 | 2 | 1 | 2 | 10 | 0 | 0 | "1" | power = 10 |
| 2 | 3 | 1 | 2 | 10 | 2 | 0 | "1" | totalHour = 2 |
| 2 | 4 | 1 | 2 | 10 | 2 | 10 | "1" | totalPower = 10 |
| 2 | 5 | 1 | 2 | 10 | 2 | 10 | "1" | WRITE = "Day 1 : wizardName meditated for 2 hours and gained 10 power points" |
| 2 | 6 | 1 | 2 | 10 | 2 | 10 | "1" | WRITE = "wizardName has meditated for a total of 2 hours and gained 10 power points" |
| 2 | 7 | 1 | 2 | 10 | 2 | 10 | "1" | WRITE = "Press enter to continue" |
| 3 | 1 | 2 | 4 | 10 | 2 | 10 | "1" | hour = 4 |
| 3 | 2 | 2 | 4 | 10 | 2 | 10 | "1" | power = 10 |
| 3 | 3 | 2 | 4 | 10 | 6 | 10 | "1" | totalHour = 6 |
| 3 | 4 | 2 | 4 | 10 | 6 | 20 | "1" | totalPower = 20 |
| 3 | 5 | 2 | 4 | 10 | 6 | 20 | "1" | WRITE = "Day 2 : wizardName meditated for 4 hours and gained 10 power points" |
| 3 | 6 | 2 | 4 | 10 | 6 | 20 | "1" | WRITE = "wizardName has meditated for a total of 6 hours and gained 20 power points" |
| 3 | 7 | 2 | 4 | 10 | 6 | 20 | "1" | WRITE = "Press enter to continue" |
| 4 | 1 | 3 | 4 | 4 | 6 | 20 | "1" | hour = 4 |
| 4 | 2 | 3 | 4 | 4 | 6 | 20 | "1" | power = 10 |
| 4 | 3 | 3 | 4 | 4 | 10 | 20 | "1" | totalHour = 10 |
| 4 | 4 | 3 | 4 | 4 | 10 | 24 | "1" | totalPower = 24 |
| 4 | 5 | 3 | 4 | 4 | 10 | 24 | "1" | WRITE = "Day 3 : wizardName meditated for 4 hours and gained 4 power points" |
| 4 | 6 | 3 | 4 | 4 | 10 | 24 | "1" | WRITE = "wizardName has meditated for a total of 10 hours and gained 24 power points" |
| 4 | 7 | 3 | 4 | 4 | 10 | 24 | "1" | WRITE = "Press enter to continue" |
| 5 | 1 | 4 | 7 | 2 | 10 | 24 | "1" | hour = 7 |
| 5 | 2 | 4 | 7 | 2 | 10 | 24 | "1" | power = 10 |
| 5 | 3 | 4 | 7 | 2 | 17 | 24 | "1" | totalHour = 17 |
| 5 | 4 | 4 | 7 | 2 | 17 | 26 | "1" | totalPower = 26 |
| 5 | 5 | 4 | 7 | 2 | 17 | 26 | "1" | WRITE = "Day 4 : wizardName meditated for 7 hours and gained 2 power points" |
| 5 | 6 | 4 | 7 | 2 | 17 | 26 | "1" | WRITE = "wizardName has meditated for a total of 17 hours and gained 26 power points" |
| 5 | 7 | 4 | 7 | 2 | 17 | 26 | "1" | WRITE = "Press enter to continue" |
| 6 | 1 | 5 | 5 | 9 | 17 | 26 | "1" | hour = 5 |
| 6 | 2 | 5 | 5 | 9 | 17 | 26 | "1" | power = 10 |
| 6 | 3 | 5 | 5 | 9 | 22 | 26 | "1" | totalHour = 22 |
| 6 | 4 | 5 | 5 | 9 | 22 | 35 | "1" | totalPower = 35 |
| 6 | 5 | 5 | 5 | 9 | 22 | 35 | "1" | WRITE = "Day 5 : wizardName meditated for 5 hours and gained 9 power points" |
| 6 | 6 | 5 | 5 | 9 | 22 | 35 | "1" | WRITE = "wizardName has meditated for a total of 22 hours and gained 35 power points" |
| 6 | 7 | 5 | 5 | 9 | 22 | 35 | "1" | WRITE = "Press enter to continue" |
| 7 | - | 5 | 5 | 9 | 22 | 35 | "1" | switch --> case >= 35: |
| 8 | - | 5 | 5 | 9 | 22 | 35 | "1" | WRITE = "Wow! You can cast dragons witout burning the lab!" |
| 9 | - | 5 | 5 | 9 | 22 | 35 | "1" | WRITE = "Level: Elarion of the Embers" |
| 10 | - | 5 | 5 | 9 | 22 | 35 | "Elarion of the Embers" | level = "Elarion of the Embers" |

Limit: totalPower = 0

| Instrucció | Iteració | day | hour | power | totalHour | totalPower | level | Output |
|------------|----------|-----|------|-------|-----------|------------|-------|--------|
| 1 | - | 1 | rnd | 0 | 0 | 0 | "1" | - |
| 2 | 1 | 1 | 2 | 0 | 0 | 0 | "1" | hour = 2 |
| 2 | 2 | 1 | 2 | 0 | 0 | 0 | "1" | power = 0 |
| 2 | 3 | 1 | 2 | 0 | 2 | 0 | "1" | totalHour = 2 |
| 2 | 4 | 1 | 2 | 0 | 2 | 0 | "1" | totalPower = 0 |
| 2 | 5 | 1 | 2 | 0 | 2 | 0 | "1" | WRITE = "Day 1 : wizardName meditated for 2 hours and gained 0 power points" |
| 2 | 6 | 1 | 2 | 0 | 2 | 0 | "1" | WRITE = "wizardName has meditated for a total of 2 hours and gained 0 power points" |
| 2 | 7 | 1 | 2 | 0 | 2 | 0 | "1" | WRITE = "Press enter to continue" |
| 3 | 1 | 2 | 4 | 0 | 2 | 0 | "1" | hour = 4 |
| 3 | 2 | 2 | 4 | 0 | 2 | 0 | "1" | power = 00 |
| 3 | 3 | 2 | 4 | 0 | 6 | 0 | "1" | totalHour = 6 |
| 3 | 4 | 2 | 4 | 0 | 6 | 0 | "1" | totalPower = 0 |
| 3 | 5 | 2 | 4 | 0 | 6 | 0 | "1" | WRITE = "Day 2 : wizardName meditated for 4 hours and gained 0 power points" |
| 3 | 6 | 2 | 4 | 0 | 6 | 0 | "1" | WRITE = "wizardName has meditated for a total of 6 hours and gained 0 power points" |
| 3 | 7 | 2 | 4 | 0 | 6 | 0 | "1" | WRITE = "Press enter to continue" |
| 4 | 1 | 3 | 4 | 0 | 6 | 0 | "1" | hour = 4 |
| 4 | 2 | 3 | 4 | 0 | 6 | 0 | "1" | power = 0 |
| 4 | 3 | 3 | 4 | 0 | 10 | 0 | "1" | totalHour = 10 |
| 4 | 4 | 3 | 4 | 0 | 10 | 0 | "1" | totalPower = 0 |
| 4 | 5 | 3 | 4 | 0 | 10 | 0 | "1" | WRITE = "Day 3 : wizardName meditated for 4 hours and gained 0 power points" |
| 4 | 6 | 3 | 4 | 0 | 10 | 0 | "1" | WRITE = "wizardName has meditated for a total of 10 hours and gained 0 power points" |
| 4 | 7 | 3 | 4 | 0 | 10 | 0 | "1" | WRITE = "Press enter to continue" |
| 5 | 1 | 4 | 7 | 0 | 10 | 0 | "1" | hour = 7 |
| 5 | 2 | 4 | 7 | 0 | 10 | 0 | "1" | power = 0 |
| 5 | 3 | 4 | 7 | 0 | 17 | 0 | "1" | totalHour = 17 |
| 5 | 4 | 4 | 7 | 0 | 17 | 0 | "1" | totalPower = 0 |
| 5 | 5 | 4 | 7 | 0 | 17 | 0 | "1" | WRITE = "Day 4 : wizardName meditated for 7 hours and gained 0 power points" |
| 5 | 6 | 4 | 7 | 0 | 17 | 0 | "1" | WRITE = "wizardName has meditated for a total of 17 hours and gained 0 power points" |
| 5 | 7 | 4 | 7 | 0 | 17 | 0 | "1" | WRITE = "Press enter to continue" |
| 6 | 1 | 5 | 5 | 0 | 17 | 0 | "1" | hour = 5 |
| 6 | 2 | 5 | 5 | 0 | 17 | 0 | "1" | power = 0 |
| 6 | 3 | 5 | 5 | 0 | 22 | 0 | "1" | totalHour = 22 |
| 6 | 4 | 5 | 5 | 0 | 22 | 0 | "1" | totalPower = 0 |
| 6 | 5 | 5 | 5 | 0 | 22 | 0 | "1" | WRITE = "Day 5 : wizardName meditated for 5 hours and gained 0 power points" |
| 6 | 6 | 5 | 5 | 0 | 22 | 0 | "1" | WRITE = "wizardName has meditated for a total of 22 hours and gained 0 power points" |
| 6 | 7 | 5 | 5 | 0 | 22 | 0 | "1" | WRITE = "Press enter to continue" |
| 7 | - | 5 | 5 | 0 | 22 | 0 | "1" | switch --> case <= 20: |
| 8 | - | 5 | 5 | 0 | 22 | 0 | "1" | WRITE = "You repeat the 2nd call" |
| 9 | - | 5 | 5 | 0 | 22 | 0 | "1" | WRITE = "Level: Raoden the Elantrin" |
| 10 | - | 5 | 5 | 0 | 22 | 0 | "Raoden the Elantrin" | level = "Raoden the Elantrin" |
