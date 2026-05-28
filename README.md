# Prototype

Singleton is a creational design pattern, which ensures that only one object of its kind exists and provides a single point of access to it for any other code.

The Prototype pattern delegates the cloning process to the actual objects that are being cloned. The pattern declares a common interface for all objects that support cloning. This interface lets you clone an object without coupling your code to the class of that object. Usually, such an interface contains just a single clone method.

## Benefits of Prototype Pattern

1. Delegates the cloning process to the actual objects that are being cloned
2. It can declare a common interface for all objects that support cloning. This interface lets you clone an object without coupling your code to the class of that object.

## How to use it

Shallow copy: Use ICloneable interface and implement CLone method (not recommended)
Custom Shallow copy: Implement a custom method that creates a new instance and use this.MemberwiseClone()
Deep copy: Implement a custom method that creates a new instance with this.MemberwiseClone(). Any nested class should also implement the same method to create a deep copy of itself.

## When to use it

Use Prototype when you need to create a new object that is a copy of an existing object. This can be a shallow or a deep copy

## Important notes

Using ICloneable interface is not recommended 