--- Exercise 1 ---
Class: Employee
This employee might want to change department at some point.
- Necessary variables: name, salary, department
- Implement a list of skills, and decide how to manage it in your class
- Implement a way to get complete info of the employee
- Add functionality to change department



--- Exercise 2 ---
Implement a superclass Appointment and the following subclasses:
Onetime, Daily, Monthly.
An appointment has a description (for example: "see the dentist") and a date.
Define a method AppointmentInfo that returns a description, date, and 
whether the appointment is daily, monthly or onetime.



--- Exercise 3 ---
Create a list of objects from Exercise 2.
Use a loop to print out all your AppointmentInfo!



--- Exercise 4 ---
a. Create a class Artist. An artist has a name and a genre.
   Define a PlaySong method, which returns an informative string including the artist name and genre.

b. Create a derived class Band which inherits from Artist.
   A band has their best song, in addition to all the information from the Artist super class.
   Override the PlaySong method, since you now have some more information to include!

c. For this exercise, SoloArtist is a derived class of Band.
   They include no new attributes, but the PlaySong method has to reflect the artist going solo.

d. Create 2 objects of each class, and add them all to a list.
   Use the list to play a little concert, by having all the musicians PlaySong