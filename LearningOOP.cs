using System;

namespace _02.SimpleClassDefinition
{

    class Mammal   // Class definition consists of : keyword class->class declaration, 
                   //inhereted class or implemeted interface, 
                   //fields, constructors, properties, Methods, Eventes, inner types, etc...
    {
        public int age; //field variable
    }

    class Person : Mammal
    // class Person(Child class ) iherits class Mammal(Parent Class)
    {
        //class2 into class-> becasue we waht the class 2 to be accessible only into class
        private string name;  // field
        private int age; //another field


        public Person()  //empty Constructor
        {

        }

        public Person(string name)  //constructor, dont have return, dont have void type,  
        {
            this.name = name;
        }

        public string Name   //this is the property 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    this.name = value;
                }
            }
        }

        public void Walk()  // this is a method into the class
        {
            Console.WriteLine("{0} is walking !", this.Name);
        }

    }

    class LearningOOP
    {
        static void Main(string[] args)
        {
            Person p = new Person("Blagy");  //we create here the Instaance of teh class , the currnt Object "p".
            Person p2 = new Person(); //creating new onject, this is valid  too //calls teh empty constuctor
            Console.WriteLine(p.Name);  //We access teh property  and print it 
            p.Walk();   //we access the Method and perform call the method to do sth.
            Console.WriteLine(p2.Name);

        }
    }

}

