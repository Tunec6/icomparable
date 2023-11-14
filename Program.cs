using System;
using System.Collections;
using System.ComponentModel;
/// <summary>
/// \details Класс телефон являеться констркуктором, под который будет подставляться значение
/// \brief Конструктор
/// </summary>
public class Telephone :IComparable<Telephone>{

    /// <summary>
    /// Переменные для конструктора 
    /// </summary>
    public string Brend;
    public int price;
    public int memory;
    public string color;
    /// <summary>
    /// \details Переменные в которые будет приминять значения переданные в классе программа
    /// </summary>
    /// <param name="Brend">Название</param>
    /// <param name="price">Цена</param>
    /// <param name="memory">Память</param>
    /// <param name="color">Чвет</param>
    public Telephone (string Brend, int price, int memory, string color){
        this.Brend = Brend;
        this.price = price;
        this.memory = memory;
        this.color = color;
    }


    /// <summary>
    /// \details Компоратор - который принимает значение и проверяет их на значение '-1','0','1'
    /// </summary>
    /// <param name="o">Объект под который подставляються значения</param>
    /// <returns>-1, 0, 1</returns>
    /// <exception cref="ArgumentException"></exception>
    public int CompareTo(Telephone? o){
       if(o is Telephone telephone){
        return price.CompareTo(telephone.price);
       } else{
        throw new ArgumentException("Неправильные данные");
       }
    }



}


/// <summary>
/// \brief Запуск программы
/// \details Класс - который запускает значение, которые подставляються в конструктор
/// </summary>
public class Program{    
    
    public static void Main(){

        
        /// \details Значения передоваемые в конструктор

        Telephone phone1 = new Telephone("Xiaomi", 1000, 1, "black");
        Telephone phone2 = new Telephone("Iphone", 100000, 10000, "black");

        /// Массив в которые засовываються телефоны
        Telephone[] phone = {phone1, phone2};
        /// Сортировка с помощью компоратора
        Array.Sort(phone);

        foreach(Telephone Telephone in phone){
            Console.WriteLine($"{Telephone.Brend} - {Telephone.price}, {Telephone.memory}, {Telephone.color}");
        }
    }
}

