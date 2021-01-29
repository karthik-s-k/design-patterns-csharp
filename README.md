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

The strategy is pattern is like an advanced version of an if else statement.
It's basically where you make an interface for a method you have in your base class. This interface is then used to find the right implementation of that method that should be used in a derived class. The implementation, in this case, will be decided at runtime based on the client.

Real time examples where we need to use:

1. Payment processing (credit/debit/wallet/paypal/UPI)
2. Validation and sorting algorithms
3. Handle discount based on coupon/reward points/happy hour.
4. Travel between 2 places with different modes (bike/car/bus/train/flight/ship)

Benefit of Strategy pattern:

1. It’s easy to switch between different algorithms (strategies) in runtime because you’re using polymorphism in the interfaces.
2. Clean code because you avoid conditional-infested code (not complex).
3. More clean code because you separate the concerns into classes (a class to each strategy).

Reference: https://www.dofactory.com/net/strategy-design-pattern

## Observer pattern

The Observer Design Pattern is a Software Design Pattern in which an object (called as Subject) maintains a list of its dependents (called as Observers) and notifies them automatically whenever any state changes by calling one of their methods.

Real time examples where we need to use:

1. Stock value update
2. "Out of stock" to "Available" notification to users.
3. Theme/Color change across application on an event.
4. Notify administrator if a system has error/alert.

Benefit of Strategy pattern:

1. It supports the principle of loose coupling between objects that interact with each other
2. It allows sending data to other objects effectively without any change in the Subject or Observer classes
3. Observers can be added/removed at any point in time

Reference: https://www.dofactory.com/net/observer-design-pattern

## Decorator pattern
