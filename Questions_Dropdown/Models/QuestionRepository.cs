using static System.Net.Mime.MediaTypeNames;

namespace Questions_Dropdown.Models
{
    public class QuestionRepository
    {
        public static List<Questions> GetQuestions()
        {
            var questions = new List<Questions>
            {
                new Questions {Id = 1, Text = "What is C#?", Answer = "C# is a modern, object-oriented programming language developed by Microsoft. It runs on the .NET framework " +
                "and is used to develop Windows applications, web applications, and games, among other things. It is statically typed, meaning the type of a variable is known " +
                "at compile time, which reduces bugs and improves performance."},
                new Questions {Id = 2, Text = "What is the difference between a class and an object?", Answer = "A class is a blueprint or template for creating objects. It defines " +
                "properties, fields, methods, and events that an object will have. An object is an instance of a class. You can create multiple objects from a class, each having " +
                "its own values for the properties defined by the class."},
                new Questions {Id = 3, Text = "What are the four pillars of Object-Oriented Programming (OOP)?", Answer = "1. **Encapsulation** – The bundling of data and methods " +
                "that operate on that data within a class.<br />   2. **Abstraction** – Hiding the complex implementation details and showing only the necessary functionality.<br />   " +
                "3. **Inheritance** – A mechanism where a new class can inherit properties and methods from an existing class.<br />   4. **Polymorphism** – The ability to take many " +
                "forms, allowing methods to do different things based on the object that is invoking them.<br />"},
                new Questions {Id = 4, Text = "What is the difference between an interface and an abstract class?", Answer = "•\tImplementation vs. Contract:<br />o\tAbstract Class: Can provide " +
                "both a contract and some implementation.<br />o\tInterface: Only provides a contract, with no implementation (except default methods starting from C# 8.0).<br />•\tInheritance:<br />o\t" +
                "Abstract Class: Supports single inheritance. A class can inherit only one abstract class.<br />o\tInterface: Supports multiple inheritance. A class can implement multiple interfaces.<br />•\t" +
                "Member Types:<br />o\tAbstract Class: Can include fields, properties, methods, events, constructors, and static members.<br />o\tInterface: Can only include methods, properties, events, " +
                "and indexers, without implementations (except static members and default methods in C# 8.0+).<br />•\tUse Case:<br />o\tAbstract Class: Use when classes share a common base and have a " +
                "relationship (e.g., all animals can make a sound).<br />o\tInterface: Use when classes are unrelated but need to share a common capability (e.g., both a Dog and Car might implement an " +
                "IMovable interface).<br />In summary, abstract classes are for shared functionality among related classes, while interfaces are for defining capabilities that unrelated classes can " +
                "implement.<br />"},
                new Questions {Id = 5, Text = "What is the `static` keyword in C#?", Answer = "   The `static` keyword in C# is used to declare members that belong to the class itself " +
                "rather than to any specific object. A static method or property can be accessed without creating an instance of the class. Static members are shared across all instances " +
                "of the class."},
                new Questions {Id = 6, Text = "What are `value types` and `reference types` in C#?", Answer = "   - **Value types**: Hold the actual data and are stored in the stack. " +
                "Examples include `int`, `char`, `bool`, and structs. When you copy a value type, the data is copied directly.<br />   - **Reference types**: Hold a reference to the data, " +
                "which is stored in the heap. Examples include classes, arrays, and strings. When you copy a reference type, you are copying the reference, not the actual data.<br />"},
                new Questions {Id = 7, Text = "What is a delegate in C#?", Answer = "A delegate is a type that represents references to methods with a specific parameter list and return " +
                "type. Delegates are used to pass methods as arguments to other methods, enabling callback methods and event handling. They are similar to function pointers in C++, but " +
                "are type-safe."},
                new Questions {Id = 8,Text = "What is LINQ?", Answer = "   LINQ (Language-Integrated Query) is a powerful query language in C# used to query data from various sources, " +
                "like collections, databases, and XML. It allows writing queries directly within C# code using a more readable syntax."},
                new Questions {Id = 9, Text = "Explain the difference between `==` and `.Equals()` in C#.", Answer = "   - `==` compares the references for reference types and the actual " +
                "values for value types.<br />   - `.Equals()` is used to compare the contents of an object for equality. For example, in strings, `==` checks if the references are the same, " +
                "while `.Equals()` checks if the content is the same.<br />"},
                new Questions {Id = 10, Text = "What is the difference between `final`, `finally`, and `finalize`?", Answer = "   - **`final`**: Not applicable in C# (used in Java).<br />   " +
                "- **`finally`**: A block that is used with `try-catch` to execute code after a `try` or `catch` block, regardless of whether an exception was thrown.<br />   - **`finalize`**: " +
                "A method that is called by the garbage collector before an object is destroyed to allow the object to clean up resources.<br />"},
                new Questions {Id = 11, Text = "What is a `constructor` in C#?", Answer = "A constructor is a special method of a class that is automatically called when an instance of the class is " +
                "created. It is used to initialize objects. Constructors can be overloaded, meaning a class can have multiple constructors with different parameters."},
                new Questions {Id = 12, Text = "What are access modifiers in C#?" , Answer = "   Access modifiers define the accessibility of classes, methods, and variables. Common access " +
                "modifiers in C# include:<br />   - **public**: Accessible from any other code.<br />   - **private**: Accessible only within the containing class.<br />   - **protected**: Accessible " +
                "within the containing class and derived classes.<br />   - **internal**: Accessible within the same assembly.<br />"},
                new Questions {Id = 13, Text = "What is the `using` statement in C#?" , Answer = "The `using` statement is used to ensure that resources like file handles, database connections, " +
                "or streams are properly disposed of once they are no longer needed. It automatically calls the `Dispose` method at the end of the block."},
                new Questions{Id = 14, Text = "What is a `nullable` type in C#?", Answer = "A nullable type allows value types (like `int`, `bool`, etc.) to represent undefined or missing values. " +
                "This is achieved by adding a `?` to the type, for example, `int?`. This type can store `null` in addition to the normal range of values."},
                new Questions{Id = 15, Text = "What are `async` and `await` in C#?", Answer = "   `async` and `await` are used to perform asynchronous programming in C#. The `async` keyword is " +
                "applied to a method to indicate that it performs an asynchronous operation. The `await` keyword is used inside the `async` method to pause its execution until the awaited task is completed."},
                new Questions{Id = 16, Text = "What is exception handling in C#?", Answer = "Exception handling in C# is the process of catching and handling runtime errors. It is done using the " +
                "`try-catch` block. The `try` block contains code that might throw an exception, and the `catch` block handles the exception if one is thrown. The `finally` block can be used to " +
                "execute code regardless of whether an exception was thrown."},
                new Questions{Id = 17, Text = "What is a `namespace` in C#?", Answer = "A namespace is a way to organize code in C#. It is used to group related classes, interfaces, and methods. " +
                "Namespaces help avoid naming conflicts by providing a way to fully qualify names in large projects. For example, `System.Collections` is a namespace that contains collections-related classes."},
                new Questions{Id = 18, Text = "What is the difference between `Array` and `ArrayList` in C#?", Answer = "Feature/Aspect\tArray\tList<br />Size/Capacity\tFixed size (cannot be changed after " +
                "initialization).\tDynamic size (can grow and shrink as needed).<br />Namespace\tPart of the core language (no namespace needed).\tRequires System.Collections.Generic " +
                "namespace.<br />Performance\tBetter performance for fixed-size collections.\tSlight overhead due to dynamic resizing.<br />Access and Operations\tAccess elements using an index, " +
                "fewer built-in methods.\tAccess using an index, rich set of methods (Add(), Remove(), etc.).<br />Type Safety\tType-safe, all elements must be of the same type.\tType-safe, uses " +
                "generics to define element types (List<T>).<br />Initialization\tInitialized with a fixed size or elements.\tInitialized empty, with capacity, or with elements.<br />Resizing\tCannot " +
                "be resized (must create a new array if needed).\tAutomatically resizes when adding/removing elements.<br />Use Cases\tBest for collections with a known, fixed size.\tBest for " +
                "collections where the size can change dynamically.<br />"},
                new Questions{Id = 19, Text = "What is the purpose of `Garbage Collection` in C#?", Answer = "Garbage collection in C# is an automatic memory management feature that reclaims " +
                "memory that is no longer in use by the program. This helps prevent memory leaks by automatically deallocating memory that is no longer reachable."},
                new Questions{Id = 20, Text = "What are Generics in C#?", Answer = "Generics allow you to define a class or method with a placeholder for the type it operates on. This " +
                "allows code reuse and type safety without sacrificing performance. For example, `List<T>` is a generic collection that can store any type specified by `T`."},
                new Questions{Id = 21, Text = "What is the difference between `const` and `readonly` in C#?", Answer = "   - `const`: A compile-time constant. The value is assigned " +
                "at the time of declaration and cannot be changed. Must be known at compile time.<br />   - `readonly`: A runtime constant. The value can only be set in the constructor " +
                "or at the point of declaration, but it can differ between instances of a class.<br />"},
                new Questions{Id = 22, Text = "What is the difference between `throw` and `throw ex` in exception handling?", Answer = "   - `throw`: Re-throws the original exception, preserving the stack trace " +
                "information.<br />   - `throw ex`: Throws the exception object `ex`, but it resets the stack trace, making it harder to diagnose where the error originally occurred.<br />"},
                new Questions {Id = 23, Text = "What is the difference between a `for` loop and a `foreach` loop?",  Answer = "   - `for` loop: Used when you know how many iterations are required or need " +
                "an index to control the loop.<br />   - `foreach` loop: Simplifies looping through collections like arrays, lists, or dictionaries, where you don't need an index and just want to iterate over " +
                "each item.<br />"},
                new Questions{Id = 24, Text = "What is method overloading in C#?", Answer = "Method overloading is the ability to define multiple methods with the same name but with different parameter lists " +
                "(either in type, number, or both). It allows methods to handle different types of input but return the same logical result."},
                new Questions{Id = 25, Text = "What is the `var` keyword in C#?", Answer = "The `var` keyword is used for implicit typing. It tells the compiler to infer the type of the variable from the type " +
                "of the expression used to initialize it. Once assigned, the type is static and cannot change."},
                new Questions{Id = 26, Text = "What is a `property` in C#?", Answer = "A property in C# is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private " +
                "field. It is defined using `get` and `set` accessors, which can control how values are assigned and retrieved."},
                new Questions{Id = 27, Text = "What are extension methods in C#?", Answer = "Extension methods allow you to add new methods to existing types without modifying their source code. They are " +
                "static methods defined in a static class, but they are called as if they were instance methods of the extended type."},
                new Questions{Id = 28, Text = "What is a `sealed` class in C#?", Answer = "A `sealed` class is a class that cannot be inherited from. When a class is marked as `sealed`, no other class " +
                "can derive from it, which is often done for security or performance reasons."},
                new Questions{Id = 29, Text = "What is the difference between `Dispose` and `Finalize` methods in C#?", Answer = "  - `Dispose`: Explicitly releases unmanaged resources. It is part of " +
                "the `IDisposable` interface and is called manually.<br />   - `Finalize`: Used to clean up unmanaged resources when the garbage collector destroys an object. It is called by the garbage " +
                "collector and not recommended for explicit use because it can introduce delays in memory deallocation.<br />"},
                new Questions{Id = 30, Text = "What is boxing and unboxing in C#?", Answer = "   - **Boxing**: Converting a value type (like `int`) to a reference type (like `object`), " +
                "which involves allocating memory on the heap.<br />   - **Unboxing**: Converting a reference type back to a value type. This can introduce performance overhead and should " +
                "be minimized when possible.<br />"},
                new Questions{Id = 31, Text = "What is the difference between `abstract` and `virtual` methods in C#?", Answer = "- **Virtual method**: A method that can have an implementation in the " +
                "base class but allows derived classes to override it.<br /> - **Abstract method**: A method that has no implementation in the base class and must be implemented in any derived class.<br />"},
                new Questions{Id = 32, Text = "What is a `struct` in C#? How is it different from a `class`?", Answer = " A `struct` is a value type in C#. Unlike classes, structs are " +
                "stored on the stack, not the heap. Structs are best used for small, lightweight objects that don't require inheritance or complex behaviors."},
                new Questions{Id = 33, Text = "What is `dependency injection` in C#?", Answer = "Dependency injection (DI) is a design pattern used to implement Inversion of Control (IoC) " +
                "by providing objects their dependencies, instead of letting the objects create dependencies themselves. It improves modularity and testability."},
                new Questions{Id = 34, Text = "What is a `delegate` in C# and how does it differ from an `event`?", Answer = "A `delegate` is a type-safe function pointer, allowing you to " +
                "pass methods as arguments. An `event` is a wrapper around a delegate that adds restrictions, like allowing only the addition and removal of event handlers."},
                new Questions{Id = 35, Text = "What is the purpose of the `lock` keyword in C#?", Answer = "The `lock` keyword is used to ensure that a block of code runs by only one " +
                "thread at a time, thus avoiding race conditions when multiple threads access shared resources." },
                new Questions{Id = 36, Text = "What are `partial` classes in C#?", Answer = " `partial` classes allow a class definition to be split across multiple files. All the " +
                "parts are combined into one when the program is compiled. This is useful when working with auto-generated code."},
                new Questions{Id = 37, Text = "What is a `Tuple` in C#?", Answer = "A `Tuple` is a data structure that allows you to store multiple items of different types in a single " +
                "object. Tuples are often used when you want to return multiple values from a method."},
                new Questions{Id = 38, Text = "What is `reflection` in C#?", Answer = "Reflection is the process of inspecting metadata about assemblies, types, and their members at " +
                "runtime. It allows you to dynamically create objects, invoke methods, and access fields and properties." },
                new Questions{Id = 39, Text = "What is a `lambda expression` in C#?", Answer = "A lambda expression is an anonymous function that can contain expressions and statements. " +
                "It is used to create delegates or expression tree types more concisely. Example: `(x, y) => x + y`." },
                new Questions{Id = 40, Text = "What is `boxing` and why can it cause performance issues?", Answer = "Boxing is the process of converting a value type to a reference type, " +
                "like `int` to `object`. It causes performance issues because it involves allocating memory on the heap and adding an extra step of retrieving the value later."},
                new Questions{Id = 41, Text = "What is the `async` and `await` pattern in C#?", Answer = "The `async` and `await` keywords are used to write asynchronous code that runs " +
                "non-blocking operations, like I/O tasks. `await` is used to pause the execution of a method until the awaited task completes." },
                new Questions{Id = 42, Text = "What are `params` in C#?", Answer = "The `params` keyword allows you to pass a variable number of arguments to a method. " +
                "This means you can pass zero or more arguments of a specified type to the method."},
                new Questions{Id = 43, Text = "What is the purpose of `out` and `ref` keywords in C#?", Answer = "   - `ref`: Passes a parameter by reference, meaning changes to the " +
                "parameter in the method will be reflected outside the method.<br />   - `out`: Similar to `ref`, but the value does not need to be initialized before it is passed to the " +
                "method. The method must assign a value before it returns.<br />"},
                new Questions{Id = 44, Text = "What is the difference between `String` and `StringBuilder` in C#?", Answer = "- `String`: Immutable, meaning any change creates a new " +
                "instance, which can be inefficient when performing many operations.<br />   - `StringBuilder`: Mutable, allowing you to modify the content without creating new objects, " +
                "which is more efficient when concatenating or modifying strings frequently.<br />" },
                new Questions{Id = 45, Text = "What is `null coalescing` operator (`??`) in C#?", Answer = "The `??` operator is used to provide a default value if the left-hand operand " +
                "is `null`. For example, `x ?? y` returns `x` if `x` is not `null`; otherwise, it returns `y`."},
                new Questions{Id = 46, Text = "What is `IEnumerable` in C#?", Answer = "   `IEnumerable` is an interface that defines a sequence of objects that can be enumerated. " +
                "It is used to iterate over collections using `foreach`. `IEnumerable<T>` allows the type to be strongly typed." },
                new Questions{Id = 47, Text = "What is the difference between `IEnumerable` and `IQueryable`?", Answer = "   - `IEnumerable`: Executes queries in memory and is " +
                "suitable for in-memory collections like lists.<br />   - `IQueryable`: Enables querying against a data source, such as a database, and defers execution until the " +
                "query is enumerated. It's more efficient for large datasets.<br />" },
                new Questions{Id = 48, Text = "What is `Garbage Collection` in C# and how does it work?", Answer = "Garbage Collection (GC) is the process of automatically " +
                "freeing up memory that is no longer being used by the program. The .NET GC works in generations (0, 1, and 2) to improve efficiency, collecting short-lived and " +
                "long-lived objects separately."},
                new Questions{Id = 49, Text = "What are `Generics` in C# and why are they useful?", Answer = "Generics allow you to define classes, methods, delegates, or " +
                "interfaces that operate with any data type, providing type safety without sacrificing performance. They help reduce code duplication by allowing a single " +
                "class or method to work with different types." },
                new Questions{Id = 50, Text = "What are `access modifiers` and list their types in C#?", Answer = "Access modifiers define the visibility and accessibility " +
                "of classes, methods, and other members. The main access modifiers are:<br />   - **public**: Accessible from anywhere.<br />   - **private**: Accessible only within " +
                "the containing class.<br />   - **protected**: Accessible within the containing class and derived classes.<br />   - **internal**: Accessible within the same " +
                "assembly.<br />   - **protected internal**: Accessible within the same assembly or derived classes.<br />" },
                new Questions{Id = 51, Text = "SOLID Principles", Answer = "The SOLID principles are a set of design principles intended to make software designs more " +
                "understandable, flexible, and maintainable. These principles are particularly important in object-oriented programming, including C#. Let's go over each " +
                "of them:<br />1. Single Responsibility Principle (SRP)<br />Definition: A class should have only one reason to change, meaning it should have only one " +
                "responsibility or job.<br />Explanation: Each class should focus on a single task. If a class has more than one responsibility, changes to one responsibility " +
                "could impair or affect the other responsibilities. This principle helps in achieving high cohesion in classes.<br />2. Open/Closed Principle (OCP)<br />Definition: " +
                "Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.<br />Explanation: You should be able to add " +
                "new functionality to a class without altering its existing code. This is typically achieved through inheritance, interfaces, or dependency injection.<br />3. " +
                "Liskov Substitution Principle (LSP)<br />Definition: Subtypes must be substitutable for their base types without altering the correctness of the " +
                "program.<br />Explanation: Objects of a derived class should be able to replace objects of the base class without affecting the correctness of the application. " +
                "This principle ensures that a subclass can assume the place of its superclass without any unexpected behavior.<br />4. Interface Segregation Principle " +
                "(ISP)<br />Definition: No client should be forced to depend on methods it does not use.<br />Explanation: Instead of one large interface, it's better to " +
                "have multiple smaller, more specific interfaces so that implementing classes only need to be concerned with the methods that are relevant to them.<br />5. " +
                "Dependency Inversion Principle (DIP)<br />Definition: High-level modules should not depend on low-level modules. Both should depend on abstractions. " +
                "Abstractions should not depend on details. Details should depend on abstractions.<br />Explanation: This principle emphasizes that code should depend " +
                "on interfaces or abstract classes rather than concrete implementations, promoting loose coupling.<br />" },
                new Questions{Id = 52, Text = "What is Serialization?", Answer = "Answer - Serialization means saving the state of your object to secondary memory, " +
                "such as a file.<br />1.\tBinary serialization (Save your object data into binary format).<br />2.\tSoap Serialization (Save your object data into binary " +
                "format; mainly used in network related communication).<br />3.\tXmlSerialization (Save your object data into an XML file).<br />" },
                new Questions{Id = 53, Text = "What is enum?", Answer = "An enum is a value type with a set of related named constants often referred to as an enumerator " +
                "list. The enum keyword is used to declare an enumeration. It is a primitive data type, which is user defined. An enum is used to create numeric constants " +
                "in .NET framework. All the members of enum are of enum type. There must be a numeric value for each enum type.<br />Some points about enum<br />•\tEnums are " +
                "enumerated data type in C#.<br />•\tEnums are strongly typed constant. They are strongly typed, i.e. an enum of one type may not be implicitly assigned to " +
                "an enum of another type even though the underlying value of their members are the same.<br />•\tEnumerations (enums) make your code much more readable and " +
                "understandable.<br />•\tEnum values are fixed. Enum can be displayed as a string and processed as an integer.<br />•\tThe default type is int, and the approved " +
                "types are byte, sbyte, short, ushort, uint, long, and ulong.<br />•\tEvery enum type automatically derives from System.Enum and thus we can use System.Enum " +
                "methods on enums.<br />•\tEnums are value types and are created on the stack and not on the heap.<br />"},
                new Questions{Id = 54, Text = "What is CSS?", Answer = "Answer - CSS stands for Cascading Style Sheets. CSS is used to define styles for your web pages, " +
                "including the design, layout and variations in display for different devices and screen sizes." },
                new Questions{Id = 55, Text = "What is Stack and Heap?", Answer = "Stack<br />•\tPurpose: The stack is used for storing value types, method call information " +
                "(like local variables, method parameters, return addresses), and the execution flow.<br />•\tAllocation: Memory on the stack is managed automatically. " +
                "When a function is called, its local variables and parameters are pushed onto the stack. When the function exits, these variables are popped off the " +
                "stack.<br />•\tLifetime: Variables on the stack are short-lived. They only exist during the execution of the function or block of code they are defined " +
                "in.<br />•\tType of Data:<br />o\tValue types (e.g., int, char, struct) are typically stored directly on the stack.<br />o\tReference types (e.g., objects, " +
                "arrays, classes) have their reference (or pointer) stored on the stack, but the actual object is stored on the heap.<br />•\tSize Limitations: The stack " +
                "is usually smaller in size compared to the heap, and each thread has its own stack.<br />Heap<br />•\tPurpose: The heap is used for storing reference type " +
                "objects and data that needs to be dynamically allocated or has an uncertain lifetime.<br />•\tAllocation: Memory on the heap is managed by the .NET runtime’s " +
                "garbage collector. When an object is created using new, it is allocated on the heap.<br />•\tLifetime: Objects on the heap live until they are no longer " +
                "referenced and are then cleaned up by the garbage collector.<br />•\tType of Data:<br />o\tReference types (e.g., instances of classes, arrays) are stored " +
                "on the heap.<br />o\tEven if a reference type contains value types as fields, the entire object is stored on the heap.<br />•\tSize and Management: The heap " +
                "is larger and more flexible than the stack but requires more complex management. The garbage collector periodically frees up memory on the heap that is " +
                "no longer in use.<br />"},


            };


            var random = new Random();

            return questions.OrderBy(r => random.Next()).ToList();
        }
    }
}
