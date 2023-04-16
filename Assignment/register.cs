using System;
using System.IO;

public class register:customer{
    public void customerRegistration(){

    StreamWriter sw= new StreamWriter("C://Users//BARTHELEMI//Desktop//Assignment//register.txt");
    Console.WriteLine ("Enter FullName:");
        custName= Console.ReadLine();
       sw.Write(custName);

         Console.WriteLine ("Enter CustAddress:");
    custAd = Console.ReadLine();
     sw.Write(custAd);

        Console.WriteLine ("Enter Phone number:");
            string? val= Console.ReadLine();
                phone = Convert.ToInt32((val));
               sw.Write(phone);

    Console.WriteLine ("Enter Id Number");
        string? val2= Console.ReadLine();
            custId=Convert.ToInt32(val2);
            sw.Write(custId);
            sw.Flush();
            sw.Close();
    }

    
            
            
        } 
