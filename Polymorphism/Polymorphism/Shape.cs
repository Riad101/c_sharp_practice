﻿using System;
namespace Polymorphism
{
    partial class Program
    {
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a circle");
                //base.Draw();
            }
        }
        public class Rectangle : Shape
        {           
            public override void Draw()
            {
                Console.WriteLine("Draw a Rectangle");               

                //base.Draw();
            }
            
        }
        public class Shape
        {
            public int width { get; set; }
            public int height { get; set; }
            
            public virtual void Draw()
            {

            }
        }
    }
}
