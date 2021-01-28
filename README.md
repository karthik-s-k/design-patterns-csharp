# design-patterns-csharp
This project is to demonstrate how different design patterns can be used in C# application

## Singleton pattern
The singleton pattern allows a class to be instantiated only once and use again and again from entire application.
It uses a global variable to store that instance. 
You can use lazy loading to make sure that there is only one instance of the class because it will only create the class when you need it.

Real time examples where we need to use:

1. Application Logging
2. Database connections
3. Config files
4. Hardware access
5. Shopping Cart

Benefit of Singleton Pattern:

1. Single point of access to instance, so is easy to maintain
2. Reduce the overhead of creating instance again and again so improve performance
3. Lazy Loading: instance will be created only when needed, improve application loading
4. Only one instance, so save the resource

Reference: http://www.advancesharp.com/blog/1230/singleton-design-pattern-in-c-with-real-examples

## Strategy pattern

## Observer pattern

## Decorator pattern
