namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1  Object Copying
            //What happens when you assign one object variable to another object variable? => Both variables will reference the same object in memory.
            //Does assigning one object to another create a new object? => No, it does not create a new object. It simply copies the reference to the existing object.
            //What is the difference between copying an object and copying its reference? => Copying an object creates a new instance of the object with the same values, while copying its reference means both variables point to the same object in memory.
            #endregion

            #region Q2  Shallow Copy vs Deep Copy
            //What is a Shallow Copy? => A shallow copy creates a new object, but copies the references to the objects that are contained in the original object.
            //What is a Deep Copy? => A deep copy creates a new object and copies all objects referenced by the original object, resulting in a completely independent copy.
            //What happens to reference-type members when a Shallow Copy is created? => When a shallow copy is created, the reference-type members of the original object are not duplicated. Instead, the new object will reference the same instances of those members as the original object. This means that changes made to the reference-type members in either the original or the copied object will affect both objects since they share the same references.
            //What happens to reference-type members when a Deep Copy is created? => When a deep copy is created, the reference-type members of the original object are duplicated, resulting in new instances of those members in the copied object. This means that changes made to the reference-type members in either the original or the copied object will not affect each other since they have separate instances of those members.
            //Give one situation where Deep Copy would be safer than Shallow Copy. => you want to create a completely independent copy of an object, such as when you are working with mutable objects that may be modified by different parts of your code. For example, if you have a class representing a complex data structure (like a tree or graph) and you want to create a copy of it to perform operations without affecting the original structure.
            #endregion

            #region Q3  Static Members
            //What is a static field, and how is it different from an instance field? => A static field is a variable that is shared among all instances of a class, meaning it belongs to the class itself rather than any specific object. An instance field, on the other hand, is unique to each instance of the class and holds data specific to that particular object. Static fields are accessed using the class name, while instance fields are accessed through an object reference.
            //What is a static method? Can a static method directly access instance members? => A static method is a method that belongs to the class itself rather than any specific instance of the class. It can be called without creating an instance of the class. A static method cannot directly access instance members (fields or methods) because it does not have a reference to any specific object. However, it can access static members of the class.
            //What is a static constructor, and when is it executed? => A static constructor is a special constructor that is used to initialize static members of a class. It is executed automatically by the runtime before any static members are accessed or any instances of the class are created. The static constructor is called only once, and it is typically used to perform one-time initialization tasks for the class.
            //What is a static class? Can you create an object from a static class? => A static class is a class that cannot be instantiated and can only contain static members (fields, methods, properties, etc.). It is used to group related utility functions or constants. You cannot create an object from a static class because it does not have any instance members or constructors. All members of a static class are accessed using the class name directly.
            #endregion

            #region Q4  Extension Methods
            //What is an Extension Method? => An extension method is a special kind of static method that allows you to "add" new methods to existing types without modifying the original type or creating a new derived type. Extension methods are defined in static classes and use the "this" keyword in their first parameter to specify the type they are extending. This allows you to call the extension method as if it were an instance method on the extended type, providing a more natural and readable syntax.
            //What keyword must be used in the first parameter of an extension method? => The "this" keyword must be used in the first parameter of an extension method to indicate that the method is extending the specified type.
            //Where must an extension method be declared? => An extension method must be declared in a static class and all extension methods within it must also be static.
            //Can an extension method access private members of the class it extends? => No, Extension methods can only access public and protected members of the class they are extending, as they are defined outside of the class and do not have access to its private implementation details.
            #endregion

            #region Q5  Partial Classes and Partial Methods 
            //What is a Partial Class? => A partial class is a feature in C# that allows the definition of a class to be split across multiple files. Each part of the class must use the "partial" keyword in its declaration, and when the program is compiled, all parts are combined into a single class. This can be useful for organizing large classes.
            //Why would a developer split one class into multiple files? => A developer might split one class into multiple files to improve code organization, maintainability, and readability. It allows different team members to work on separate parts of the class simultaneously without causing merge conflicts. Additionally, it can help manage large classes by separating concerns and grouping related functionality together in different files.
            //What is a Partial Method? => A partial method is a method that is declared in one part of a partial class and can be optionally implemented in another part of the same partial class. If the method is not implemented, the compiler removes its declaration and any calls to it, resulting in no performance overhead. Partial methods are typically used to provide hooks for extending functionality in generated code or for allowing customization in partial classes.
            //What happens if a declared partial method has no implementation? => If a declared partial method has no implementation, the compiler will remove its declaration and any calls to it during compilation. This means that there will be no performance overhead or runtime impact, as the method effectively does not exist in the compiled code. Partial methods are designed to allow optional implementation, so if they are not implemented, they simply have no effect on the program.
            #endregion

            #endregion
        }
    }
}
