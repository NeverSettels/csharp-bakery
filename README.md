# C# Bakery

#### _C#_ - _28/14/2020_

#### _Eric Settels_

## **Description**

_A small Console application that will allow a user to purchase bread and pastries from their local console._

## **Behavior Driven Development**

| Behavior | Input | Output |
|----------|:-----:|--------|
| User is greeted when they run the program |user imputs into the console dotnet run | Bright cheery welcome with ascii art |
| User is asked if they want to enter the bakery| user enter Y | Title appears | 
| User is asked if they want to enter the bakery| user enter  N| User is told good bye| 
| User is asked if they want to purchase something | user enter  N| User is told good bye| 
| User is asked if they want to purchase something | user enter Y | User is displayed menu with 3 types of bread (Classic, Sour, Defualt) and 4 types of pastry as well as being told about their price and type | 
|User is asked the name of the bread or pastry they want and how many | user says 'something that doesnt exist' and 4 | user sees "Sorry we dont sell that make another selection" |
|User is asked the name of the bread or pastry they want and how many | user says 'classic' and 4 | user is shown their current total after applicable discounts are applied "your total cost is $18" |
| User is asked buy "something else? [Y]es or [N]o" | User selects Y | User is asked to name what they want and how many |
|User is asked the name of the bread or pastry they want and how many | User says 'bm' and 3 | user is  shown their current total after applicable discounts are applied "your total cost is $23" |
| User is asked buy "something else? [Y]es or [N]o" | User selects N | User is told they spent $23 at the bakery and is told good bye|



## **Setup/Installation**

1. Open up your terminal
2. Navigate to the desired directory in which you want to clone this repository.
3. Clone this repository.
4. type dotnet run into the terminal
5. Enjoy!

## **Known Bugs**

There are no known bugs at this time.

## **Support and contact details**

If you have any questions, comments, or concerns, feel free to contact the content creator at settels.eric@gmail.com 

## **Future Plans**

* None Currently

## **Technologies used**

* C#

* Visual Studio Code

* GitBash

* [Colorful.Console](http://colorfulconsole.com/)

## **License**

Copyright (c) 2020 **C# Bakery**

### **_MIT_**