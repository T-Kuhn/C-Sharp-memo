// - - - - - - - - - - - - - - -
// - - C-Sharp Syntax Memo - - -
// = = = = = = = = = = = = = = =

// - - - - - - - - - - - - - - -
// - -  Method Overloading - - -
// - - - - - - - - - - - - - - -
// --> It is possible to create several methods with the same name in the same class.
// --> When the method gets called, the one which signature matches the parameter types will be used.

// - - example code - -
class someClass{
    public int add(int para1, int para2){
        return para1 + para2;
    }
    public string add(string str1, string str2){
        return str1 + str2;
    }
}

// - - - - - - - - - - - - - - -
// - - - Method Overriding - - -
// - - - - - - - - - - - - - - -
// --> Overriding is the practice of changing the parent class method in a child class.
// --> When the method is called the newest or most overriden method is used.

// - - example code - -
class parentClass{
    public virtual void yell(){         // <-- keyword: VIRTUAL
        // Yell something
    }
}

class childClass : parentClass{
    public override void yell(){        // <-- keyword: OVERRIDE
        // Do something which is not defined in the base class 
        base.yell();
        // And also do the things defined in the base class yell function
    }
}

// - - - - - - - - - - - - - - -
// -  The Use Of Properties  - -
// - - - - - - - - - - - - - - -
// --> It is possible to better manage weather or not a class member variable can be written to or read from
// --> using the properties syntax. It is also possible to start coroutines (get other code executed) from within
// --> the definition of the getter or setter function.

// - - example code - -
class someClass{
    private int experience;
    public int Experience{
        set{ experience = value; }
        get{ return experience; }
    }
}

// - - - - - - - - - - - - - - -
// - - - - - Generics  - - - - -
// - - - - - - - - - - - - - - -
// --> Generics are a feature whereby classes and methods - among other things - can be passed a type as
// --> a parameter. This allows us to program stuff without knowing what kind of data we will manipulate.

// - - example code - -
class someClass{
    public T GenericMethod<T>(T para){
        return T;
    } 
}

// - - - - - - - - - - - - - - -
// - - - - Inharitance - - - - -
// - - - - - - - - - - - - - - -
// --> Private things in a parent class will be inherited but are not accassable, because they are private.
// --> public things in a parent class will be inherited and accassable from inside the class and outside the class.
// --> protected things are accassable from inside the parent or child class but not from outside. ChildClassObject.ProtectedParentClassMethod(); won't work.
//
// --> When a constructor of a child class is called, the constructor of the parent class is called immediately before.
// --> The constructor used by the parent class can be defined by the use of ":base(para1, para2, ...)" right after the 
// --> child class constructor definition.
// 
// --> private fields are not inherited?

// - - example code - -
class parentClass{
    protected parentString = "string";
    public parentClass(string str1){
        parentString = "updated string";    
    }
    protected void SomeMethod(){
        Debug.log("we are doing the thing.");
    }
}

class childClass : parentClass{
    public childClass() : base("string1"){
        Debug.Log("doing the childClass default Constructor");
    }
    public void SomeOtherMethod(){
        someMethod();
    }
}


// - - - - - - - - - - - - - - -
// - - Extension Methods - - - -
// - - - - - - - - - - - - - - -


// - - - - - - - - - - - - - - -
// - - - - Constructors  - - - -
// - - - - - - - - - - - - - - -
// --> have no return type.
// --> same name as class name.

// - - example code - -
class SomeClass : MonoBehaviour{
    private int int1;
    private string string1;

    //constructor without parameters
    public SomeClass(){
        
    }

    //constructor with parameters passed into it
    public SomeClass(int _int, string _str){
        int1 = _int;
        string1 = _str;    
    }
    
}

// - - - - - - - - - - - - - - -
// - - - - Polymorphism  - - - -
// - - - - - - - - - - - - - - -

// - - - - - - - - - - - - - - -
// - - - -  Interfaces - - - - -
// - - - - - - - - - - - - - - -
// --> Interfaces are like abstract classes. They can not be instantiated.
// --> Also, they can only hold methods without bodies (as if they all were abstract methods) 
// --> If you use an interface on a certain class you are obligated to implement all of it's methods and properties.


// - - - - - - - - - - - - - - -
// - - The "abstract" keyword  -
// - - - - - - - - - - - - - - -
// --> abstract classes can't be instantiated.
// --> abstract methods in abstract classes have to be implemented in classes which are inheriting from the abstract class. 





