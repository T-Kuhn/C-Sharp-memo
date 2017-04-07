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

// So what did we learn here.
// There is a thing called DoTween. It can be used to easily make animations with a minimal amount of coding.
// The thing starts subroutines in the background.
// It makes use of extension methods and an abstract class and so forth.
// what else did we figure out? 
// First, there is a thing called ABSSequentiable. This also belongs to the tween library.
// Then, there is an abstract tween class
// Then, theres a abstract tweener class which implements the tween abstract class.
// Wow. so we got 2 abstract classes in a row and the last one finally get's implemented by the public class
// TweenerCore and also by the public class Sequence.
//
// There's a strange thing about all that stuff. There is this static utility class called shortcutExtenstion46.
// it's static methods return a tween object, which seems really strange considering that tween is a abstract class.
//
// Since abstract classes can't be instantiated this seems very strange.
//
// They use the internal keyword. What is the meaning of this?
// Internal seems to mean the following:
// The thing can only be accessed when in the same exe or dll. wtf. how do I even know what get's into a dll or exe file. I have no clue.
// so this means that the program is able to use the class, the same way as if it was public, anywhere at all. but other programs will not be able to access it.
// I didn't even know that it was possible for other assemblies to access code like that. But then again, i guess it makes sense when we think about how dll's are used.
// 
// What are DLLs? Here's an explanation: They contain code, data resources in any combination.
// But has the code to be compiled? because i had to decompile c sharp code. which seems wierd. since it is a interpreter language.
//
// So we did learn something about interpreters and compilers. C sharp get's compiled into byte Code, or IL code, as they call it (intermediate Language code).
// That bytecode then get's interpreted by the virtual machine (cli in the case of c sharp).
//

// The things we need to do today include:
// - some kind of effect research for the virtual reality user interface.
// - making it possible to pick and load an image file using the datatree interface.
//
// combining the 2 things. We might want to use one or several of the effects to load and show a picture after clicking on it.
// We also should think about style. We might want to stylize the interface. With a background and stuff.
// - background stylization. DONE
// - file stylization. DONE!
// The files look like crap at the moment.
//
// We should also think about what we could do about long file names. it would be best if they were cropped automatically
// like this:
// "some very long and strangly unatractive filename"
// -> "some very lo..."
//
// - file-/foldername cropping  DONE!
//
// That seems like a good way to go.
// We might want to make the text scroll from the left to the right in such a manner that one can see the full name over time.
//
// One very important point!
// - we need to deploy katsuyukisans VR clicking and looking around interface !
// 
//
// we need to use the same unity version as katsuyukisan was using to make this work the right way.
// using katsuyukis metro ui might be a good idea. though the things don't need to be of different size.
// maybe just reordering them is enough.
//
// We really need to do the 2D Fourier Transform sometime soon. Maybe even today.
// No, actually we can't do it today. But maybe tomorrow. I got to do other stuff too.
// At this moment in time, it seems to be a good idea to use c sharp for this task. 
// This could actually be really good. I've got to try this. I really have to. There's no other way to put this.
//
// There is an interesting question about what i could do right now. I could do all sorts of things.
// It's a bit hard to implement katsuyukis interface. The reason being that it seems like it is necessary to use an older version of Unity.
// Okay. I got this. Let's install the old unity.
//
// Well, on the other hand, I already made the thing with the newer unity version. So it doesn't really matter.
// Let's try to explore some of the effects.
//

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





