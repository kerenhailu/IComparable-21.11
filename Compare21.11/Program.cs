// See https://aka.ms/new-console-template for more information
using Compare21._11;

Console.WriteLine("Hello, World!");

//Car car1 = new Car("Mazda", 200, "Black");
//Car car2 = new Car("Honda", 300, "yellow");
//Car car3 = new Car("Mercedes", 400, "green");
//Car car4 = new Car("Suzuki", 500, "red");
//Car car5 = new Car("Fiat", 600, "pink");
//Car.PrintDetails(car1.model, car1.volumeEngine, car1.color);
//Car.PrintDetails(car2.model, car2.volumeEngine, car2.color);
//Car.PrintDetails(car3.model, car3.volumeEngine, car3.color);
//Car.PrintDetails(car5.model, car5.volumeEngine, car5.color);
//Car.PrintDetails(car4.model, car4.volumeEngine, car4.color);

//var bus1 = new Bus();
//bus1.NumberOfSeats = 50;
//Console.WriteLine(bus1.NumberOfSeats);
//bus1.Company = "harel";
//Console.WriteLine(bus1.Company);

Truck truck1 = new Truck("mazda", 500, "red", 3, "truck");
Truck truck2 = new Truck("fiat", 400, "blue", 1, "truck");
Truck truck3 = new Truck("suzuki", 600, "black", 4, "truck");
Truck truck4 = new Truck("honda", 100, "yellow", 2, "truck");

//Truck.PrintDetails(truck1.model, truck1.volumeEngine, truck1.color, truck1.numberOfSeats, truck1.name);
//truck1.PrintDetails();
//truck2.PrintDetails();
//truck3.PrintDetails();
//truck4.PrintDetails();

//Truck[] ArrayTruck = new Truck[] { truck1, truck2, truck3, truck4 };
//for(int i = 0; i < ArrayTruck.Length; i++)
//{
//    ArrayTruck[i].PrintDetails();
//}
//Array.Sort(ArrayTruck);

//for (int i = 0; i < ArrayTruck.Length; i++)
//{
//    ArrayTruck[i].PrintDetails();
//}
//שאלה 9
Rectangle rectangle1 = new Rectangle(8, 9);
Console.WriteLine(rectangle1);
Console.WriteLine(rectangle1.Area());

Reboa reboa1 = new Reboa(12, 8);
Console.WriteLine(reboa1);
Console.WriteLine(reboa1.Area());

//שאלה 2
User user1=new User("keren","keren@gmail.com",1998);
User user2=new User("tikva", "tikva@gmail.com", 1995);
User user3=new User("yafit", "yafit@gmail.com", 1993);
User user4=new User("eden", "eden@gmail.com", 1994);
User user5=new User("igal","igal@gmail.com",1997);
Console.WriteLine(user1);
User[] ArrayUsers= new User[] { user1, user2, user3, user4, user5 };

for(int i = 0; i < ArrayUsers.Length; i++)
{
    ArrayUsers[i].Print();
}
Array.Sort(ArrayUsers);

for (int i = 0; i < ArrayUsers.Length; i++)
{
    ArrayUsers[i].Print();
}
//=======================================================================
//שאלה 4

//Worker worker1 = new Worker("keren", "kerev@gmail.com", 2000);
//Worker worker2 = new Worker("koki", "koki@gmail.com", 1990);
//Worker worker3 = new Worker("loli", "loli@gmail.com", 1999);
//Worker worker4 = new Worker("dan", "dan@gmail.com", 1988);

//Worker[] ArrayWorkers = new Worker[] { Worker1, Worker2, Worker3, Worker4};

//for (int i = 0; i < ArrayWorkers.Length; i++)
//{
//    ArrayWorkers[i].Print();
//}
//Array.Sort(ArrayWorkers);

//for (int i = 0; i < ArrayWorkers.Length; i++)
//{
//    ArrayWorkers[i].Print();
//}