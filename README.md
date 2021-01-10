# C# Unity Milestones

Below is a list of tasks that correspond roughly to the "Take Action" sections of [Learning C# by Developing Games with Unity 2020](https://www.packtpub.com/product/learning-c-by-developing-games-with-unity-2020-fifth-edition/9781800207806) by Harrison Ferrone. By mid-semester, everyone should...

- Understand what the task is asking
- Be able to do the task
- Make it clear through your actions you understand what's happening



## Contents

1. [Instructions](#Instructions)
1. [Resources](#Resources)






## Instructions

1. Fork this repository (into your own Github account)
1. Complete each task below inside the sample project included in this repository
1. Check off each task as you complete it, creating files and adding content where prompted with ✏️ or  **??**
1. Commit and push your work often
1. After you finish, celebrate your C# proficiency! 🙌  


#### Notes...

- **RTM** - Sometimes I give the command you need and sometimes you have to read the documentation to find it.
- **Details** - Following the instructions, especially those with a ✏️
- **Reference** - If you get stuck compare your code with the book [source code](https://github.com/PacktPublishing/Learning-C-8-by-Developing-Games-with-Unity-2020)






## Chapter 1
Getting to Know Your Environment (9–21)

- [ ] ✏️ Open the reference manual for any component from inside Unity. Paste the link: **??**
- [ ] ✏️ Find the button to jump to the scripting reference the any reference manual page. Paste the link: **??**
- [ ] ✏️ Search for the `Strings` class in [Microsoft's C# documents](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/). Paste the link: **??**


## Chapter 2
The Building Blocks of Programming (22–37)

- [ ] Create Assets/Scripts/LearningCurve.cs
	- [ ] Create C# variables with typeof `int`, `float`, `string`, and `bool`
	- [ ] Add a single line, multi line, and summary comment to LearningCurve.cs
	- [ ] Run the code in LearningCurve by attaching it to the Main Camera GameObject


## Chapter 3
Diving into Variables, Types, and Methods (38–64)

- [ ] Update Assets/Scripts/LearningCurve.cs
	- [ ] Variables
		- [ ] Use access modifiers to make your variables explicitly `public` and `private`
		- [ ] Use `Debug.Log` and `Debug.LogFormat` to log your variables to the console
		- [ ] Concatenate strings using the `+` operator, and the string interpolation method `$`
	- [ ] Methods
		- [ ] Define a simple method with parameters
		- [ ] Add a return type and return some data from a method  
		- [ ] Use data returned from a method  
- [ ] ✏️ Explain some differences between public and private variables: **??**


## Chapter 4
Control Flow and Collection Types (65–93)

- [ ] Update Assets/Scripts/LearningCurve.cs
	- [ ] Conditionals
		- [ ] Write `if`, `else if`, and `else` statements
		- [ ] Test for `true` and `!true` in a conditional
		- [ ] Write a nested `if` statement
		- [ ] Write a `switch` statement
	- [ ] Collections
		- [ ] ✏️ What will `arr[1]` return from this array `int[] arr = {'red','green','blue'};` ? : **??**
		- [ ] Write an Array of the type `int[]`
		- [ ] Write a List of the type `List<string>`
		- [ ] Write a Dictionary of the type `Dictionary<string, int>`
	- [ ] Loops
		- [ ] Use a `for` loop to print a specific index of a `List<string>`
		- [ ] Use a `foreach` loop to print all indexes of a `List<string>`
		- [ ] Use a `foreach` loop to print the `KeyValuePair.Key` and `KeyValuePair.Value` of all indexes of a `Dictionary<string, int>`



## Chapter 5
Working with Classes, Structs, and OOP (94–119)

- Classes
	- [ ] ✏️ Explain the difference between reference and value type variables: **??**
	- [ ] Create Assets/Scripts/Character.cs
		- [ ] Create a `Character` class
		- [ ] Create `string` and `int` fields inside the Character class
		- [ ] Create a `Character()` constructor and populate the above fields with its parameters
	- [ ] Update Assets/Scripts/LearningCurve.cs
		- [ ] Instantiate two new Character objects `hero` and `heroine` from the `Character` class
		- [ ] Print out each characters data
- [ ] Structs
	- [ ] Update Assets/Scripts/Character.cs
		- [ ] Add a `Weapon` struct
		- [ ] Create `string` and `int` fields inside the Weapon struct
		- [ ] Create a `Weapon()` constructor and populate the above fields with its parameters
	- [ ] Update Assets/Scripts/LearningCurve.cs
		- [ ] Instantiate two new Weapon objects `huntingBow` and `warBow` from the `Weapon` struct
		- [ ] Print out each weapons' data
- Child classes
	- [ ] Update Assets/Scripts/Character.cs
		- [ ] Add a `Paladin` child class of `Character`
		- [ ] Create a `Weapon` field inside the Paladin class
		- [ ] Create a `Paladin()` constructor that calls the `base()` constructor. Populate the weapon in a parameter
	- [ ] Update Assets/Scripts/LearningCurve.cs
		- [ ] Instantiate a new Paladin object `knight` from the Paladin class
		- [ ] Print the Paladin's name and weapon by overriding `PrintStatsInfo` in the base class
- Referencing objects
	- [ ] Update Assets/Scripts/LearningCurve.cs
		- [ ] Store a reference to the current game object's (Main Camera) `Transform` component using `GetComponent<>()`
		- [ ] Log a reference to the `localPosition` field of the Main Camera's `Transform`
		- [ ] Store a reference to the Light `GameObject` using `GameObject.Find()`
		- [ ] Store a reference to the Light's `Transform` component using `GetComponent<>()`
		- [ ] Log a reference to the `localPosition` field of the Light's `Transform`



## Chapter 6
Getting Your Hands Dirty with Unity (120–148)

- [ ]


## Chapter 7
Movement, Camera Controls, and Collisions (149–175)

- [ ]


## Chapter 8
Scripting Game Mechanics (176–207)

- [ ]
