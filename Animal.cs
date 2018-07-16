using System;

namespace zoo
{
    class Animal
    {
      public string Name;

      public string Type;

      public int Id;

      public Animal()
      {
          this.Name = "";
          this.Type = "";
          this.Id = 0;
      }

      public Animal(string name, string type, int id)
      {
          this.Name = name;
          this.Type = type;
          this.Id = id;
      }

      public void Print()
      {
          Console.WriteLine($"Name: {this.Name}");
          Console.WriteLine($"Type:{this.Type}");
          Console.WriteLine($"Id:{this.Id}");
      }
    }
}