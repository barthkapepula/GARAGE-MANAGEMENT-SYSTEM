using System;
public class customer
{
 public string custName;
    public string custAd;
    public int phone;
    public int custId;

    public string CustName{
        get{
            return custName;
        }
        set{
            custName=value;
        }
    }
    public string CustAd{
        get{
            return custAd;
        }
        set{
            custAd=value;
        }
    }
    public void displayCustomer(){
        Console.WriteLine("Customer's Name:"+" "+custName);
        Console.WriteLine("Customer' Address:"+ " "+custAd);
        Console.WriteLine("Phone Number:"+ " "+phone);
        Console.WriteLine("Customer Number:"+ " "+custId);
    
    
    }
}  

        
