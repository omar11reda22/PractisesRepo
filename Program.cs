
using Microsoft.EntityFrameworkCore.Query.Internal;


namespace ConsoleApp1
{
    public class Program
    {

        /*
         constructor meaning VS destructor (finalizer) 
         type of constructors [private - static - defualt - parameter] 
         abstraction and differente between (interface) VS (abstract class)
         differente between class VS struct 
         dfferente between override VS overload 
         polymorphizme 
         encapsulation
         access modefier 
         inheritanse 
         
         
         
         */

        // in abstract class founction do u want to being abstract should write abstract keyword (no body)
        abstract public class Person
        {

            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            abstract public void printo();

               public void suppo()
            {
                Console.WriteLine($"id = {ID} , name = {Name} , age = {Age}");
            }
            public virtual int calc(int x, int y)
            {
                return x + y;
            }

        }
        public interface IPerson
        {

            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public void printo();
            // methods in interface abstract by defualt
            // 
            
        }
        public class manger : IPerson
        {
            // when implement from interface musr override all interface member 

            public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void printo() // must override by defualt not using override keyword (just in abstract class must write override keyword) 
            {
                Console.WriteLine($"id = {ID} , name = {Name} , age = {Age}");
            }
        }
         public class employee : Person
        {
            // must override all abstract (one or more) functions
            // 

            public void prt(int num)
            {
                Console.WriteLine($"num = {num}");
            }

            // overloading 
            public void prt(string st)
            {
                Console.WriteLine($"string = {st}");
            }

          
            public override int calc(int x , int y)
            {
                return x - y; 
            }
            public override void printo()
            {
                Console.WriteLine($"id = {ID} , name = {Name} , age = {Age}");
            }

            public virtual void Loly()
            {
                Console.WriteLine("this method will overrode must have virtual keyword");
            }

        }

      
        
        static void Main(string[] args)
        {
            // Person p1 = new Person(); no instanse in abstract class
            // must inherit  
            //employee emp1 = new employee() { ID = 1 , Name = "omar reda" , Age = 23 };
            //emp1.printo();

            //manger mg1 = new manger() { ID = 2, Name = "mng : omar reda", Age = 23 };

            //mg1.printo();

            //employee emp1 = new employee(); 
            //emp1.prt(1);
            //emp1.prt("omar");

            Manger m1= new Manger();
            Console.WriteLine(m1);



            Console.WriteLine();










        }
    }
}
