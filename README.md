# Interfaces Lab

Exercise 8 in C#. A console application for practicing interfaces.

## Run the program

Open a terminal in the project folder and run:

dotnet run

## What I did

First, ProgramOne had a Run() method and ProgramTwo had a Go() method.
I then commented out those methods and their calls.

I created IStartable, which requires a Start() method, and implemented
it in both classes. ProgramOne also implements IStoppable, which
requires a Stop() method.

## Why use an interface?

Both classes can now be started through IStartable using Start(),
even though they do different things. I no longer need to call Run()
for one class and Go() for the other.
