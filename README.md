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

## Decorator pattern
