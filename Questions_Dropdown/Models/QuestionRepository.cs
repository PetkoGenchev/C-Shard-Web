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
                "that operate on that data within a class.\r\n   2. **Abstraction** – Hiding the complex implementation details and showing only the necessary functionality.\r\n   " +
                "3. **Inheritance** – A mechanism where a new class can inherit properties and methods from an existing class.\r\n   4. **Polymorphism** – The ability to take many " +
                "forms, allowing methods to do different things based on the object that is invoking them.\r\n"},
                new Questions {Id = 4, Text = "What is the difference between an interface and an abstract class?", Answer = "   - **Abstract Class**: Can have implementations for " +
                "some of its members, and a class can inherit from only one abstract class.\r\n   - **Interface**: Cannot have any implementations, only declarations. A class can " +
                "implement multiple interfaces. Interfaces are typically used to define a contract for behavior.\r\n"},
                new Questions {Id = 5, Text = "What is the `static` keyword in C#?", Answer = "   The `static` keyword in C# is used to declare members that belong to the class itself " +
                "rather than to any specific object. A static method or property can be accessed without creating an instance of the class. Static members are shared across all instances " +
                "of the class."},
                new Questions {Id = 6, Text = "What are `value types` and `reference types` in C#?", Answer = "   - **Value types**: Hold the actual data and are stored in the stack. " +
                "Examples include `int`, `char`, `bool`, and structs. When you copy a value type, the data is copied directly.\r\n   - **Reference types**: Hold a reference to the data, " +
                "which is stored in the heap. Examples include classes, arrays, and strings. When you copy a reference type, you are copying the reference, not the actual data.\r\n"},
                new Questions {Id = 7, Text = "What is a delegate in C#?", Answer = "A delegate is a type that represents references to methods with a specific parameter list and return " +
                "type. Delegates are used to pass methods as arguments to other methods, enabling callback methods and event handling. They are similar to function pointers in C++, but " +
                "are type-safe."},
                new Questions {Id = 8,Text = "What is LINQ?", Answer = "   LINQ (Language-Integrated Query) is a powerful query language in C# used to query data from various sources, " +
                "like collections, databases, and XML. It allows writing queries directly within C# code using a more readable syntax."},
                new Questions {Id = 9, Text = "Explain the difference between `==` and `.Equals()` in C#.", Answer = "   - `==` compares the references for reference types and the actual " +
                "values for value types.\r\n   - `.Equals()` is used to compare the contents of an object for equality. For example, in strings, `==` checks if the references are the same, " +
                "while `.Equals()` checks if the content is the same.\r\n"},
                new Questions {Id = 10, Text = "What is the difference between `final`, `finally`, and `finalize`?", Answer = "   - **`final`**: Not applicable in C# (used in Java).\r\n   " +
                "- **`finally`**: A block that is used with `try-catch` to execute code after a `try` or `catch` block, regardless of whether an exception was thrown.\r\n   - **`finalize`**: " +
                "A method that is called by the garbage collector before an object is destroyed to allow the object to clean up resources.\r\n"},
                new Questions {Id = 11, Text = "What is a `constructor` in C#?", Answer = "A constructor is a special method of a class that is automatically called when an instance of the class is " +
                "created. It is used to initialize objects. Constructors can be overloaded, meaning a class can have multiple constructors with different parameters."},
                new Questions {Id = 12, Text = "What are access modifiers in C#?" , Answer = "   Access modifiers define the accessibility of classes, methods, and variables. Common access " +
                "modifiers in C# include:\r\n   - **public**: Accessible from any other code.\r\n   - **private**: Accessible only within the containing class.\r\n   - **protected**: Accessible " +
                "within the containing class and derived classes.\r\n   - **internal**: Accessible within the same assembly.\r\n"},
                new Questions {Id = 13, Text = "What is the `using` statement in C#?" , Answer = "The `using` statement is used to ensure that resources like file handles, database connections, " +
                "or streams are properly disposed of once they are no longer needed. It automatically calls the `Dispose` method at the end of the block."}

            };

            var random = new Random();

            return questions.OrderBy(r => random.Next()).ToList();
        }
    }
}
