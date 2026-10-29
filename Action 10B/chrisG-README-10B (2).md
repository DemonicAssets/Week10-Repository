# CS110 / Action 10B / Three Hello World Investigations

Current phase: independent study with teams and tools.

## My transfer note / saved in the same README

Stayed the same: Classes define objects, objects are instances, methods perform actions, and variables store data. These concepts apply across programming languages.

Changed (trigger/output/API): In C#, an action might be triggered by a button click. In JavaScript and Babylon.js, actions can be triggered by mouse clicks or keyboard input. The syntax and APIs are different.

Evidence: I compared C# and JavaScript examples and found that both use objects, properties, and methods, even though the code is written differently.

For A1 I could use this to: Create an interactive 3D object in Babylon.js that changes color or moves when the user clicks it.

## Lecture investigation notes

Three concepts: Variables, classes, and functions in C#.

One question: How can we transfer our C# Hello World code into Unity?

Whiteboard / Discord check / my contribution: The instructor demonstrated how variables store data, classes organize code, and public functions can be reused. We discussed using Console.WriteLine in C# and Debug.Log in Unity. 

Prediction: I predicted that Unity would have a similar way to display Hello World even though it uses a different environment.

What I tried: I compared a C# console application with Unity and looked at how a Hello World message could be displayed using Debug.Log.

Result / error: Console.WriteLine is not the normal way to display messages in Unity's Console. Unity uses Debug.Log instead.

What it means / next step: The same programming concepts apply across different technologies, but some commands change. My next step is to create a cube in Unity, attach a C# script, and test Debug.Log.

Evidence file/link: https://github.com/DemonicAssets/Week10-Repository/blob/main/Action%2010B/George%20Arbache%20Team%20Tasks%20board%20Action%2010B.png https://github.com/DemonicAssets/Week10-Repository/blob/main/Action%2010B/George%20Arbache%20Professor%20Stalbert's%20Notes%20%232%20Action%2010B.png  https://github.com/DemonicAssets/Week10-Repository/blob/main/Action%2010B/George%20Arbache%20Professor%20Stalbert's%20Lecture%20%231%20Notes%20Action%2010B.png

## Console investigation notes

Three concepts: C# classes, variables/properties, and methods.

One question: How can I use a class and method to display a customized Hello World message in the console?

Whiteboard / Discord check / my contribution: I used the lecture's explanation of classes, variables, and reusable methods to understand how Greeting.cs and Program.cs work together.

Prediction: I predicted that changing the Name property to "FEAR" would make the console display "Hello, world, FEAR!"

What I tried: I created a Greeting class with a Name property and a BuildMessage() method. In Program.cs, I created a Greeting object, changed its Name to "FEAR", and used Console.WriteLine(greeting.BuildMessage()) to display the message.

Result / error: The program ran successfully and displayed "Hello, world, FEAR!" The process exited with code 0, meaning there were no execution errors.

What it means / next step: I learned how classes, properties, and methods work together to create reusable code. My next step is to apply the same logic to a XAML application with a graphical interface.

Evidence file/link: Screenshots of Greeting.cs, Program.cs, and the Visual Studio console showing "Hello, world, FEAR!" https://github.com/DemonicAssets/Week10-Repository/blob/main/Action%2010B/CONSOLEPROOF1-CHRIS%2CNICK.png https://github.com/DemonicAssets/Week10-Repository/blob/main/Action%2010B/CONSOLEPROOF2-CHRIS%2CNICK.png https://github.com/DemonicAssets/Week10-Repository/blob/main/Action%2010B/CONSOLEPROOF3-CHRIS%2CNICK.png

## XAML / WPF investigation notes

George Arbache XAML
XMAL builds and creates applications.
C# is a programming language that makes XAML's interface work.
Our prediction when we click the buttom we expect it to say HelloWorld.
We tried to open the application.
Result it opened and displayed HelloWorld.
It means if we can work with the basic items of XAML, we just know how it works.
https://github.com/DemonicAssets/Week10-Repository/tree/main/Action%2010B

## Engine investigation notes

CS110 / Action 10B / Three Hello World Investigations
Current phase: independent study with teams and tools.

My transfer note / saved in the same README
[Not yet recorded]

Lecture investigation notes
[Not yet recorded]

Console investigation notes
[Not yet recorded]

XAML / WPF investigation notes
[Not yet recorded]

Engine investigation notes
Engine/version/language: Unity Official setup + scripting links: https://docs.unity.com/en-us/engine/6000.0/manual/scripting/get-started/creating-scripts Object / script / callback: A cube named a beacon Ai question - source check - test - decision: By going into the hierarchy Prediction: The cube would do nothing. What I tried: Added the cube and added the given code to the cube. Result / error: The cube has the code along with it. What it means / next step: We will start to figure out what the cube would do next. Evidence file/link: https://github.com/DemonicAssets/Week10-Repository/tree/main/Action%2010B

Working arrangement
Group Lead: Leah Members / contributions: Nick - Console Chris - Console Caleb - XAML George - XAML Andy - Engine Rue - Engine Task | Owner | Status: Engine Console XAML

My handoff
GitHub: https://github.com/DemonicAssets/Week10-Repository Required: Console/, WPF/, EngineTrial/, Evidence/ and cs110-10b-receipt.txt. Canvas: https://sbccd.instructure.com/courses/66804/assignments/1913888 This record does not verify submission or grading.
Evidence file/link: https://courses.addp2p.com/assignments/cs110/week10/action-10b.html#engine

## Working arrangement
Group
Lead: Leah
Members / contributions: Leah - Assigning Jobs + Whiteboard
Nick - Coding Console Hello World
George - Coding XAML Hello World
Chris - Taking Notes on Each Environment
Rue - Coding Engine Hello World
Caleb - Coding XAML Hello World
Andy - Coding Engine Hello World
Task | Owner | Status:
Leah - Manager
Nick - Console
George - XAML
Chris - Notes
Rue - Engine
Caleb - XAML
Andy - Engine



## My handoff
GitHub: https://github.com/DemonicAssets/Week10-Repository
Required: Console/, WPF/, EngineTrial/, Evidence/ and cs110-10b-receipt.txt.
Canvas: https://sbccd.instructure.com/courses/66804/assignments/1913888
This record does not verify submission or grading.
