using System;



namespace Assignment01
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int len, int wid)
        {
            length = len;
            width = wid;
        }



        public int GetLength()
        {
            return length;
        }



        public int setLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int getWidth()
        {
            return width;
        }

        public int setWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }



    }
}