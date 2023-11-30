using System;
namespace Inheritance
{
    public  class Program
    {
       public static void Main(string[] args) 
       {
            var bird = new Bird
            {
                WingColor = "Blue",
                CanFly = true,
                BackLength = 10,
                WillMigrate = true
            };

            var reptile = new Reptile
            {   
                HasWebbedFeet = true,
                CanCamoflauge = false,
                IsAquatic = false,
                NumberOfScales = 100
            };

            Console.WriteLine($"I'm a bird, I {(bird.CanFly ? "can fly" : "cant fly")}, my wing color is {bird.WingColor}. My back length is {bird.BackLength}. I {(bird.WillMigrate ? "will migrate" : "will not migrate")}");
            Console.WriteLine($"I'm a reptile, I {(reptile.HasWebbedFeet ? "have webbed feet" : "dont have webbed feet")}. I {(reptile.CanCamoflauge ? "can camoflauge" : "can't camoflauge")}. I am {(reptile.IsAquatic ? "" : "not")} aquatic. I have {reptile.NumberOfScales} scales.";
       }
    }
}
