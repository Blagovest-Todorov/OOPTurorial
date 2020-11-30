using System;

namespace _02.SimpleClassDefinition
{

    class Mammal
    {
        public int age; //field variable
    }

    class Person : Mammal  // class Person(Child class ) iherits class Mammal(Parent Class)
    {
        private string name;  // field

        public Person(string name)  //constructor, dont have return, dont have void type,  
        {
            this.name = name;
        }

        public string Name
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
        
    class Program
    {
         static void Main(string[] args)
         {
            Person p = new Person("Blagy");
            Console.WriteLine(p.Name);
            p.Walk();
        
         }
    }
    
}

