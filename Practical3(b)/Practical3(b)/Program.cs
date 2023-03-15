using System;

public  class Bird {

    public void voice() {

        Console.WriteLine("Turr Turr");
    
    }
}

public  class Duck : Bird {

    public void voice()
    {

        Console.WriteLine("Quack Quack");

    }
   


}
public class call {

    public static void Main(string[] args)
    {

        //it's call base class method as refrence of base class is given while creating an object...
        Bird myBird = new Duck();

        //from parent class constructor we can't create object of child class 
       // Duck myDuck = new Bird();
        Duck myDuck = new Duck();
        myBird.voice();
        myDuck.voice();
    }

}