using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{   public class Cat
    {   //attributes 
        public string name;
        public int age;
        public int weight;
        public int length;
        public string color;
        public string sound;
        public bool is_sociable;
        public string feeling;
        //constructors 
        public Cat(){
            Console.WriteLine("New cat");        
        }
        public Cat(string name)
        {
            this.name = name;
            Console.WriteLine("Name: {0}", name);
        }
        public Cat(int age)
        {
            this.age = age;
            Console.WriteLine("Age: "+age);
        }
        public Cat (int weight,int lenght)
        {
            this.weight = weight;
            this.weight = lenght;
            Console.WriteLine("Weight: {0}", weight);
            Console.WriteLine("Lenght: {0}",lenght);
        }
        public Cat(bool is_sociable)
        {
            if (is_sociable)
                Console.WriteLine("Cat is sociable");
        }
        //methods
        public void input_name()
        {
            Console.WriteLine("Name:");
            name=Console.ReadLine();
        }
        public void input_age()
        {
            Console.WriteLine("Age:");
            age =int.Parse( Console.ReadLine());
        }
        public void input_weight()
        {
            Console.WriteLine("Weight:");
            weight =int.Parse(Console.ReadLine());
        }
        public void input_lenght()
        {
            Console.WriteLine("Lenght:");
            length = int.Parse(Console.ReadLine());
        }
        public void input_color()
        {
            Console.WriteLine("Color:");
            color = Console.ReadLine();
        }
        public void cat_sound(string sound)
        {
            this.sound = sound;
            Console.WriteLine(sound);
        }
        public void print(string name,int age, int weight, int length , bool is_sociable) 
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.length = length;
            this.is_sociable = is_sociable;
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Weight: {0}", weight);
            Console.WriteLine("Lenght: {0}", length);
            Console.WriteLine("Is sociable: {0}",is_sociable);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.input_name();
            cat1.input_age();
            cat1.input_weight();
            cat1.input_lenght();
            cat1.input_color();
            cat1.cat_sound("Meoooo!");
            cat1.print(cat1.name,cat1.age,cat1.weight,cat1.length,true);
        }
    }
}
