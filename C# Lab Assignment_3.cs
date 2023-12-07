using System;

C# Lab Assignment_3
1.	Create a class with a private field and a public method to set its value.
using System;

public class MyClass
{
    // Private field
    private int myPrivateField;

    // Public method to set the value of the private field
    public void SetPrivateFieldValue(int value)
    {
        myPrivateField = value;
    }

    // Public method to get the value of the private field
    public int GetPrivateFieldValue()
    {
        return myPrivateField;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of MyClass
        MyClass myObject = new MyClass();

        // Set the private field value using the public method
        myObject.SetPrivateFieldValue(42);

        // Get and display the private field value using the public method
        int retrievedValue = myObject.GetPrivateFieldValue();
        Console.WriteLine($"The value of the private field is: {retrievedValue}");
    }
}
2.Design a class with a public method that accesses a private field from another class in the same assembly.
 using System;

// Class with a private field
public class ClassWithPrivateField
{
    // Private field
    private int myPrivateField = 10;

    // Public method to access the private field
    public void AccessPrivateFieldFromAnotherClass(ClassAccessingPrivateField otherClass)
    {
        // Accessing the private field of another class
        int valueFromOtherClass = otherClass.GetPrivateFieldValue();
        Console.WriteLine($"Value of private field from another class: {valueFromOtherClass}");
    }
}

// Another class in the same assembly
public class ClassAccessingPrivateField
{
    // Reference to the class with the private field
    private ClassWithPrivateField otherClassInstance;

    // Constructor
    public ClassAccessingPrivateField(ClassWithPrivateField instance)
    {
        otherClassInstance = instance;
    }

    // Public method to get the private field value
    public int GetPrivateFieldValue()
    {
        // Accessing the private field of the other class
        return otherClassInstance.GetPrivateFieldValue();
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of ClassWithPrivateField
        ClassWithPrivateField classWithPrivateField = new ClassWithPrivateField();

        // Create an instance of ClassAccessingPrivateField
        ClassAccessingPrivateField classAccessingPrivateField = new ClassAccessingPrivateField(classWithPrivateField);

        // Access private field from another class
        classWithPrivateField.AccessPrivateFieldFromAnotherClass(classAccessingPrivateField);
    }
}
3.Implement a class with an internal field and access it from a different assembly.
 // Class in AssemblyA with an internal field
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AssemblyB")] // Grant access to AssemblyB

public class ClassWithInternalField
{
    // Internal field
    internal int myInternalField = 20;
}

// Class in AssemblyB that accesses the internal field of ClassWithInternalField from AssemblyA
public class ClassInAssemblyB
{
    public void AccessInternalFieldFromAssemblyA(ClassWithInternalField instance)
    {
        // Accessing the internal field from another assembly
        int value = instance.myInternalField;
        Console.WriteLine($"Value of internal field from another assembly: {value}");
    }
}
4.Create a base class with protected members and derive a class to access those members.
using System;

// Base class with protected members
public class MyBaseClass
{
    // Protected field
    protected int myProtectedField = 30;

    // Protected method
    protected void MyProtectedMethod()
    {
        Console.WriteLine("Base class protected method.");
    }
}

// Derived class accessing protected members of MyBaseClass
public class MyDerivedClass : MyBaseClass
{
    // Method in the derived class accessing protected members of the base class
    public void AccessProtectedMembers()
    {
        // Accessing the protected field from the base class
        int fieldValue = myProtectedField;
        Console.WriteLine($"Value of protected field in derived class: {fieldValue}");

        // Calling the protected method from the base class
        MyProtectedMethod();
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of MyDerivedClass
        MyDerivedClass derivedClassInstance = new MyDerivedClass();

        // Access protected members from the derived class
        derivedClassInstance.AccessProtectedMembers();
    }
}
5.Develop a class with a protected internal member and create an instance in a different assembly to access it.
 // Class in AssemblyA with a protected internal member
public class MyClassWithProtectedInternalMember
{
    // Protected internal member
    protected internal int MyProtectedInternalField = 40;
}
// Class in AssemblyB that derives from MyClassWithProtectedInternalMember
public class DerivedClassInAnotherAssembly : MyClassWithProtectedInternalMember
{
    // Method in the derived class to access the protected internal member
    public void AccessProtectedInternalMember()
    {
        // Accessing the protected internal member from the base class
        int fieldValue = MyProtectedInternalField;
        Console.WriteLine($"Value of protected internal field in derived class: {fieldValue}");
    }
}
6.Create a class with a public property.Derive another class and try to access the property.
using System;

// Base class with a public property
public class MyBaseClass
{
    // Public property
    public string MyPublicProperty { get; set; }
}

// Derived class accessing the public property of MyBaseClass
public class MyDerivedClass : MyBaseClass
{
    // Method in the derived class using the public property
    public void AccessPublicProperty()
    {
        // Accessing the public property from the base class
        string propertyValue = MyPublicProperty;
        Console.WriteLine($"Value of public property in derived class: {propertyValue}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of MyDerivedClass
        MyDerivedClass derivedClassInstance = new MyDerivedClass();

        // Set the public property value
        derivedClassInstance.MyPublicProperty = "Hello, World!";

        // Access the public property from the derived class
        derivedClassInstance.AccessPublicProperty();
    }
}
7.Build a class with a private property and provide a public method to modify its value. Test the functionality.
 using System;

public class MyClassWithPrivateProperty
{
    // Private property
    private int myPrivateProperty;

    // Public method to modify the private property value
    public void SetPrivatePropertyValue(int newValue)
    {
        myPrivateProperty = newValue;
    }

    // Public method to retrieve the private property value
    public int GetPrivatePropertyValue()
    {
        return myPrivateProperty;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of MyClassWithPrivateProperty
        MyClassWithPrivateProperty myObject = new MyClassWithPrivateProperty();

        // Set the private property value using the public method
        myObject.SetPrivatePropertyValue(50);

        // Get and display the private property value using the public method
        int retrievedValue = myObject.GetPrivatePropertyValue();
        Console.WriteLine($"The value of the private property is: {retrievedValue}");
    }
}
8.Develop a class with a private method.Provide a public method that calls the private method.
 using System;

public class MyClassWithPrivateMethod
{
    // Public method that calls the private method
    public void PublicMethod()
    {
        Console.WriteLine("Calling the private method from the public method.");
        PrivateMethod();
    }

    // Private method
    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of MyClassWithPrivateMethod
        MyClassWithPrivateMethod myObject = new MyClassWithPrivateMethod();

        // Call the public method, which in turn calls the private method
        myObject.PublicMethod();
    }
}
9.Implement a class with a protected method.Derive a class and access the protected method.
 using System;

// Base class with a protected method
public class MyBaseClass
{
    // Protected method
    protected void MyProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }
}

// Derived class accessing the protected method of MyBaseClass
public class MyDerivedClass : MyBaseClass
{
    // Method in the derived class calling the protected method
    public void CallProtectedMethod()
    {
        Console.WriteLine("Calling protected method from the derived class.");
        MyProtectedMethod();
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of MyDerivedClass
        MyDerivedClass derivedClassInstance = new MyDerivedClass();

        // Call the method in the derived class, which in turn calls the protected method
        derivedClassInstance.CallProtectedMethod();
    }
}
10.Build a class with an internal constructor and create an instance from another assembly.
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AssemblyB")] // Grant access to AssemblyB

public class ClassWithInternalConstructor
{
    // Internal constructor
    internal ClassWithInternalConstructor()
    {
        Console.WriteLine("Internal constructor called.");
    }

    // Public method
    public void PublicMethod()
    {
        Console.WriteLine("Public method called.");
    }
}

public class ClassInAnotherAssembly
{
    public void CreateInstanceAndCallMethod()
    {
        // Attempting to create an instance of ClassWithInternalConstructor
        // Note: This will result in a compilation error unless AssemblyB is granted access to internals of AssemblyA
        // ClassWithInternalConstructor instance = new ClassWithInternalConstructor(); // Uncommenting this line will cause an error

        // If access is granted, call the public method
        // instance.PublicMethod(); // Uncommenting this line will cause an error
    }
}



