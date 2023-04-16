using System;
using System.IO;
using System.Text;

    public class services{
        public string requestedService;
        public string dateOfService;
        public int servicePrice;
        public int advisorNum;
        car Car;
        customer customer1=new customer();
        public services(string requestedService,string date,int servicePrice, int advisorNum,car Car){
            this.requestedService=requestedService;
            dateOfService=date;
            this.servicePrice=servicePrice;
            this.advisorNum=advisorNum;
            this.Car=Car;
        }
        public void summaryOrder(){
           
             Console.WriteLine("Service Requested:"+ " "+requestedService);
              Console.WriteLine("Date of Service:"+ " "+dateOfService);
               Console.WriteLine("Price:"+ " "+servicePrice);
                Console.WriteLine("Advisor Number:"+ " "+advisorNum);
                 Console.WriteLine("--Car Details--");
                  Console.WriteLine(Car);
                   
            

        }

        }
        
