# Abstract

Here is a kata to practise refactoring that I found on this repository: `https://github.com/CodelyTV/incomprehensible-finder-refactoring-kata`

The last commit has my solution to the excercise, feel free to clone this repo and revert that commit to start the excercise.

Here is the original enunciate.

# Introduction 

Here is the bad news: the new developer you hired has written some terrible, atrocious code. 
No one can understand what it does. 

The good news: at least there are unit tests to prove the code is working. 

You job is to refactor the code and make it readable, while keeping the code in working order (pass all tests). 

# How To Start

1. Clone this repository `git clone https://github.com/DoDevJutsu/incomprehensible-finder-refactoring-c-sharp.git`
2. Install all the dependencies.
3. Run the tests.
4. Start refactoring! 

The primary goal is to refactor the code in `Finder.cs` - as it stands the code is incomprehensible. 

# Tips

* Start with simple rename refactors so you can better understand the abstractions you are working with. Rename any class or any variable. 
* Move on to extract methods and making the code more modular.
* See if you can also eliminate switch statements and multiple exit points from methods. 

Anything is fair game, create new classes, new methods, and rename tests. 
The only restriction is that the existing tests have to keep working. 
Lean on the tests and run them after every small change to make sure you are on the right path.

# How to End

You can stop when you feel the code is good enough, something you can come back to in 6 months and understand. 

# Helpful resources

## Refactoring

* [Martin Fowler Refactorings catalog](http://refactoring.com/catalog/)
* [Refactoring.guru Code Smells catalog](https://refactoring.guru/smells/smells)
* [Refactoring.guru Refactorings catalog](https://refactoring.guru/catalog)
* [CodelyTV Refactoring videos (Spanish)](http://codely.tv/tag/refactoring/)

# Credits and other programming languages

This kata is the C# original Incomprehensible Finder Refactoring Kata created by [K. Scott Allen](https://github.com/OdeToCode). 
