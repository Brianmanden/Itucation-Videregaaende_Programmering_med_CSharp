--- Exercise 1: Abstract Class ---
a. Create an abstract class named BankAccount. The class has an attribute called balance.
   You decide whether a bank account has an initial balance of 0 or uses a number parameter in its constructor.
   A bank account has two required abstract methods: Deposit and Withdraw. Both can be either void methods or return balance.
   For testing purposes, you might want a way to check your balance between Deposit/Withdraw calls as well.

b. Create a derived class called CheckingAccount that implements the Withdraw and Deposit methods.
   When you use the withdraw method with a number higher than 3000, 
    the method should print a warning and do nothing else.
   Deposit just adds to your balance.

c. Create a derived class called SavingsAccount that implements the Withdraw and Deposit methods.
   When you use the deposit method, the amount is automatically increased by .1%
    before the amount is added to your balance.
   Withdraw just subtracts from your balance.


--- Exercise 2: Interface ---
a. Create an interface named ILaser.
   The interface contains the method FireLaser.

b. Create a class called DeathStar that implements the ILaser interface.
   You decide what the FireLaser method does. If you can't think of anything, just make it write/return "Pew pew".

c. Fire your lasers!


--- Exercise 3: Enum ---
For this exercise you are making a random card picker!
a. Create two enums:
   Face, which contains all of the 13 face values of playing cards (ace to king).
   Suit, which contains the four suits (spades, hearts, diamonds, clubs).

b. Use an object of the Random class to select two suitable random numbers (use the Next method):
   - Use one random number to get the face value of a card.
   - Use the other random number to get the suit value of a card.

c. Print the card (face and suit)!