﻿using System;
using static System.Console;

namespace Liskov
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle()
        {
            
        }

        public Rectangle(int width, int height)
        {
            this.Height = height;
            this.Width = width;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
        
        
    }

    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
    
    class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Height;
        
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2,3);
            WriteLine($"{rc} has area of {Area(rc)}");
            
            Rectangle sq = new Square();
            sq.Width = 4;
            WriteLine($"{sq} has an area of {Area(sq)}");
        }
    }
}