using System;
using System.Collections;
using System.ComponentModel;

public class Telephone :IComparable<Telephone>{
    public string Brend;
    public int price;
    public int memory;
    public string color;

    public Telephone (string Brend, int price, int memory, string color){
        this.Brend = Brend;
        this.price = price;
        this.memory = memory;
        this.color = color;
    }

    public int CompareTo(Telephone? o){
       if(o is Telephone telephone){
        return price.CompareTo(telephone.price);
       } else{
        throw new ArgumentException("Неправильные данные");
       }
    }



}
public class Program{
    public static void Main(){
        Telephone phone1 = new Telephone("Xiaomi", 1000, 1, "black");
        Telephone phone2 = new Telephone("Iphone", 100000, 10000, "black");


        Telephone[] phone = {phone1, phone2};
        Array.Sort(phone);

        foreach(Telephone Telephone in phone){
            Console.WriteLine($"{Telephone.Brend} - {Telephone.price}, {Telephone.memory}, {Telephone.color}");
        }
    }
}

