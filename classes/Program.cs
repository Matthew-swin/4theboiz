/* using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
        var purple = new Colour(1,2,3,"Purple");
        var pink = new Colour(20,60,22,"Pink");
        var c1 = new Cookie(10,"square",purple);
        var c2 = new Cookie(5,"circle", pink);
        var c3 = new Cookie(15,"oval",purple);
        var c4 = new Cookie(20, "retangle", pink);
        
        }
    }
}

public class Cookie {
    public int weight;
    public string shape;
    public Colour cl;

    public Cookie(int w, string s){
    this.weight = 0;
    this.shape = "";
    }

    

    public Cookie(int w, string s, Colour n){
    this.weight = w;
    this.shape = s;
    this.cl = n;
    }

}

public class Colour {

    public int red = 0;
    public int green = 0;
    public int blue = 0;
    public string name = "";

    public Colour(int r, int g, int b, string n){
    this.red = r;
    this.green = g;
    this.blue = b;
    this.name = n;    
    }
} */

using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var p1 = new Person("Matthew", "Jester",DateTime.Parse("1994 03 14"),155);
            var p2 = new Person("Ben", "Gardiner",DateTime.Parse("1900 01 01"),180);
            var p3 = new Person("Tim", "Baird", DateTime.Parse("1900 01 01"), 160);
            Console.WriteLine(p1.GetfullName());
            Console.WriteLine(p1.GetHeightDifference(p2));
            p1.AddSuject("poopface", 1913);
            p1.AddSuject("facepalm", 2020);
            Console.WriteLine(p1.Tester());




        }
    }

    public class Person
    {
        public string firstname;
        public string surname;
        public DateTime dob;
        public int height;
        public int ID;
        List<Subject> perSub;
        public Person()
        {
        }
                //CONSTRUCTOR
        public Person(string f, string s, DateTime d, int h)
        {
            this.firstname = f;
            this.surname = s;
            this.dob = d;
            this.height = h;
            var rand = new Random();
            int randID = rand.Next(1000, 10000);
            this.ID = randID;
            this.perSub = new List<Subject>();

        }

        public string GetfullName()
        {
            return this.firstname + " " + this.surname;
        }

        public int GetHeightDifference(Person p)
        {
            return this.height - p.height;
        }

        public void AddSuject(string subName, int yearOfDelivery){
        Subject name = new Subject(subName,yearOfDelivery);
        this.perSub.Add(name);  
        }

        public string Tester() {
        string name = "";
        foreach (Subject subject in this.perSub){
        // name += subject.subName + " ";
        // name += subject.yearOfDelivery + "\n";  
         name += $"{subject.subName} fuck you, no way {subject.yearOfDelivery}\n";

        }
         
        return name;
        
        }

        
    }

    public class Subject {
    
        public string subName;
        public int yearOfDelivery;

        public Subject(string subName, int yearOfDelivery)
        {
            this.subName = subName;
            this.yearOfDelivery = yearOfDelivery;
        }


    }
}

