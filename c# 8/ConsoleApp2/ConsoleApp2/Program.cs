









// using System;
//
// abstract public class Animal
// {
//     public string Name { get; set; }
//     public string Obitanie { get; set; }
//     public int Vosrast { get; set; }
//
//     public Animal(string name, string obitanie, int vosrast)
//     {
//         Name = name;
//         Obitanie = obitanie;
//         Vosrast = vosrast;
//     }
//
//     public virtual void Print()
//     {
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"Obitanie: {Obitanie}");
//         Console.WriteLine($"Vosrast: {Vosrast}");
//     }
//
// }
//
// public class Tiger : Animal
// {
//     public double Weight { get; set; }
//     public Tiger(string name, double weight) : base(name, "Forest", 12)
//     {
//         Weight = weight;
//     }
//
//     public override void Print()
//     {
//         base.Print();
//         Console.WriteLine($"{Name}: {Weight} kg");
//     }
// }
// public class Crocodile : Animal
// {
//     public double Length { get; set; }
//     public Crocodile(string name, double length) : base(name, "River", 3)
//     {
//         Length = length;
//     }
//     public override void Print()
//     {
//         base.Print();
//         Console.WriteLine($"{Name}: {Length} meters");
//     }
// }
// public class Kangaroo : Animal
// {
//     public double Jump { get; set; }
//     public Kangaroo(string name, double jump) : base(name, "Savanna", 7)
//     {
//         Jump = jump;
//     }
//     public override void Print()
//     {
//         base.Print();
//         Console.WriteLine($"{Name}: {Jump} meters");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Tiger tiger = new Tiger("Tiger tiger", 200.5);
//         Crocodile crocodile = new Crocodile("Crocodile crocodile", 6);
//         Kangaroo kangaroo = new Kangaroo("Kangaroo kangaroo", 5);
//         tiger.Print();
//         Console.WriteLine();
//         crocodile.Print();
//         Console.WriteLine();
//         kangaroo.Print();
//         Console.WriteLine();
//     }
// }








//задание 1
// using System;
//
// abstract public class Device
//  
// {
//     public string Name { get; set; }
//     public string Opisanie { get; set; }
//
//     public Device(string name, string opisanie)
//     {
//         Name = name;
//         Opisanie = opisanie;
//     }
//     
//     public virtual void Sound()
//     {
//         Console.WriteLine("Sound");
//     }
//
//     public void Show()
//     {
//         Console.WriteLine($"Name: {Name}");
//     }
//
//     public void Desc()
//     {
//         Console.WriteLine($"Opisanie: {Opisanie}");
//     }
//
// }
//
// public class Kettle: Device
// {
//
//     public Kettle(string opisanie) : base("Чайник",opisanie)
//     {
//     }
//
//     public override void Sound()
//     {
//         Console.WriteLine("Shhh");
//     }
// }
// public class Microwave : Device
// {
//     public Microwave(string opisanie) : base("Микроволновка",opisanie)
//     {
//     }
//     public override void Sound()
//     {
//         Console.WriteLine("Wrrr");
//     }
// }
// public class Car : Device
// {
//     public Car(string opisanie) : base("Машина",opisanie)
//     {
//     }
//     public override void Sound()
//     {
//         Console.WriteLine("Wruuuhhhh");
//     }
// }
//
// public class Steamboat : Device
// {
//     public Steamboat(string opisanie) : base("Па-роход",opisanie)
//     {
//     }
//     public override void Sound()
//     {
//         Console.WriteLine("Shiuuuu");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Kettle kettle= new Kettle("Kettle, electro");
//         kettle.Show();
//         kettle.Desc();
//         kettle.Sound();
//         Console.WriteLine();
//         
//         Microwave microwave= new Microwave("Microwave, electro");
//         microwave.Show();
//         microwave.Desc();
//         microwave.Sound();
//         Console.WriteLine();
//         
//         Car car= new Car("Car, electro");
//         car.Show();
//         car.Desc();
//         car.Sound();
//         Console.WriteLine();
//         
//         Steamboat steamboat= new Steamboat("Steamboat, electro");
//         steamboat.Show();
//         steamboat.Desc();
//         steamboat.Sound();
//         Console.WriteLine();
//       
//     }
// }



//задание 2
using System;

// abstract public class Musical_instrument
//  
// {
//     public string Name { get; set; }
//     public string Opisanie { get; set; }
//
//     public Musical_instrument(string name, string opisanie)
//     {
//         Name = name;
//         Opisanie = opisanie;
//     }
//     
//     public virtual void Sound()
//     {
//         Console.WriteLine("Sound");
//     }
//     public virtual void History()
//     {
//         Console.WriteLine("History");
//     }
//     public void Show()
//     {
//         Console.WriteLine($"Name: {Name}");
//     }
//
//     public void Desc()
//     {
//         Console.WriteLine($"Opisanie: {Opisanie}");
//     }
//
// }
//
// public class Violin: Musical_instrument
// {
//
//     public Violin(string opisanie) : base("Скрипка",opisanie)
//     {
//     }
//
//     public override void Sound()
//     {
//         Console.WriteLine("Sound: Shhh");
//     }
//     public override void History()
//     {
//         Console.WriteLine("History: Скрипка стала результатом дальнейшего развития таких инструментов как фидель (виела), лира да браччо и ребек");
//     }
// }
// public class Trombone : Musical_instrument
// {
//     public Trombone(string opisanie) : base("Тромбон",opisanie)
//     {
//     }
//     public override void Sound()
//     {
//         Console.WriteLine("Sound: Wrrr");
//     }
//     public override void History()
//     {
//         Console.WriteLine("History: Появление тромбона относится к XV веку. Принято считать, что непосредственными предшественниками этого инструмента были кулисные трубы, при игре на которых у музыканта была возможность передвигать трубку инструмента, таким образом получая хроматический звукоряд");
//     }
// }
// public class Ukule : Musical_instrument
// {
//     public Ukule(string opisanie) : base("Укулеле",opisanie)
//     {
//     }
//     public override void Sound()
//     {
//         Console.WriteLine("Sound: Wruuuhhhh");
//     }
//     public override void History()
//     {
//         Console.WriteLine("History: Укулеле появилась на Гавайских островах во второй половине XIX века, куда её, под названием машети да браса (порт. machete da braça), завезли португальцы с острова Мадейра");
//     }
// }
//
// public class Cello : Musical_instrument
// {
//     public Cello(string opisanie) : base("Виолончель",opisanie)
//     {
//     }
//     public override void Sound()
//     {
//         Console.WriteLine("Sound: Shiuuuu");
//     }
//     public override void History()
//     {
//         Console.WriteLine("History: Первоначально она применялась как басовый инструмент для сопровождения пения (или исполнения на инструменте более высокого регистра)");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Violin violin= new Violin("Violin");
//         violin.Show();
//         violin.Desc();
//         violin.Sound();
//         violin.History();
//         Console.WriteLine();
//         
//         Trombone trombone= new Trombone("Trombone");
//         trombone.Show();
//         trombone.Desc();
//         trombone.Sound();
//         trombone.History();
//         Console.WriteLine();
//         
//         Ukule ukule= new Ukule("Ukule");
//         ukule.Show();
//         ukule.Desc();
//         ukule.Sound();
//         ukule.History();
//         Console.WriteLine();
//    
//         Cello cello= new Cello("Cello");
//         cello.Show();
//         cello.Desc();
//         cello.Sound();
//         cello.History();
//         Console.WriteLine();
//     }
// }





//задание 3
// using System;
//
// abstract public class Worker
// {
//     public string Name { get; set; }
//     public int Vosrast { get; set; }
//
//     public Worker(string name,  int vosrast)
//     {
//         Name = name;
//         Vosrast = vosrast;
//     }
//
//     public virtual void Print()
//     {
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"Vosrast: {Vosrast}");
//     }
//
// }
//
// public class President : Worker
// {
//     public double Zp{ get; set; }
//     public President(string name, int zp) : base(name,  22)
//     {
//         Zp = zp;
//     }
//
//     public override void Print()
//     {
//         base.Print();
//         Console.WriteLine($"Zp: {Zp} $");
//     }
// }
// public class Security : Worker
// {
//     public string Responsibilities{ get; set; }
//     public Security(string name, string responsibilities) : base(name, 30)
//     {
//         Responsibilities = responsibilities;
//     }
//     public override void Print()
//     {
//         base.Print();
//         Console.WriteLine($"Responsibilities : {Responsibilities}");
//     }
// }
// public class Manager : Worker
// {
//     public string Employee_number { get; set; }
//     public Manager(string name, string employee_number) : base(name, 20)
//     {
//         Employee_number = employee_number;
//     }
//     public override void Print()
//     {
//         base.Print();
//         Console.WriteLine($"Employee number : {Employee_number}");
//     }
// }
// public class Engineer : Worker
// {
//     public int Experience { get; set; }
//     public Engineer(string name, int experience) : base(name, 55)
//     {
//         Experience = experience;
//     }
//     public override void Print()
//     {
//         base.Print();
//         Console.WriteLine($"Experience : {Experience} years");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         President president = new President("Tom", 4000);
//         Security security = new Security("Dima", "Security and territory of protection");
//         Manager manager = new Manager("Ola", "1234564321");
//         Engineer engineer = new Engineer("Egor", 20);
//         
//         president.Print();
//         Console.WriteLine();
//         security.Print();
//         Console.WriteLine();
//         manager.Print();
//         Console.WriteLine();
//         engineer.Print();
//         Console.WriteLine();
//     }
// }
