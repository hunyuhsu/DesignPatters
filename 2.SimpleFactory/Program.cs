using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

//到此一遊0000000000000
        }

    }
    // product 
    public interface Adventurer
    {
        string getType();
    }

    // ====== concrete product =======
    public class Archer : Adventurer
    {
        public Archer() { }
        public string getType()
        {
            Console.WriteLine("我是弓箭手~~");
            return this.GetType().Name;
        }
    }

    public class Warrior : Adventurer
    {
        public Warrior() { }
        public string getType()
        {
            Console.WriteLine("我是鬥士");
            return this.GetType().Name;
        }
    }

    // simple factory facility
    public class TrainingCamp
    {
        public static Adventurer trainAdventturer(string type)
        {


        }
    }









}
