using System;
using System.IO;

namespace Assignment
{
    class Program
    {
        static void Main (string [] args)
        {
        car c1=new car("Benz","S-Class", 2015, "ABT5690");
        services s1=new services("Oil Change","21/03/2022",5000,0001, c1); 
        customer cust1= new customer();
        register reg=new register();
            
       reg.customerRegistration();
        Console.WriteLine("---REPAIR ORDER---");
        reg.displayCustomer();
          s1.advisorNum=99098;
          s1.summaryOrder();
          c1.carDetails();

        Console.WriteLine("---THANKYOU FOR CHOOSING US---");
      
        
        
         
        }
    }
}
