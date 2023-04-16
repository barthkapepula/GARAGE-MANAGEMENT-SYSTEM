using System;
public class car
{
    public string brand;
    public string modelName;
    public int year;
    public string numberplate;


    public string Brand{
        get{
            return brand;
        }
        set{
            brand=value;
        }
    }
   public string ModelName{
        get{
            return modelName;
        }
        set{
            modelName=value;
        }
   }
    public int Year{
        get{
            return year;
        }
        set{
            year=value;
            }
        }
        public string Numberplate{
        get{
            return numberplate;
        }
        set{
            numberplate=value;
   }
        }
    public car(string brand, string modelName, int year, string numberplate){
        this.brand=brand;
        this.modelName=modelName;
        this.year=year;
        this.numberplate=numberplate;
    }  
    public void carDetails(){
        Console.WriteLine("Brand: "+brand);
        Console.WriteLine("Model: "+modelName);
        Console.WriteLine("Year "+ year);
        Console.WriteLine("Number Plate"+numberplate);
    }
}