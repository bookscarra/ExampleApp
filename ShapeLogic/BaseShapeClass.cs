using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLogic
{
    public class BaseShapeClass
    {
        public string Name { get; set; }
        public short PositionX { get; set; }
        public short PositionY { get; set; }

        public short Width { get; set; }
        public short Height { get; set; }

        public bool IsCurved { get; set; }

        public BaseShapeClass()
        {

        }

        public BaseShapeClass(short positionX, short positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        public override string ToString()
        {
            var print = $"{GetType().Name} ({PositionX},{PositionY}) ";

            if (Width > 0 && Height > 0)
            {
                if (Width == Height)
                {
                    print += $"size={Width}";
                }
                else if (IsCurved)
                {
                    print += $"diameterH = {Width} diameterV = {Height}";
                }
                else
                {
                    print += $"width={Width} height={Height}";
                }
            }

            return print;
        }

        internal bool Valid()
        {
            /*The widgets are plotted on a square canvas 1000 units in width and height, 
             * starting at 0,0 in the bottom left corner. The other integer properties 
             * must be positive, and the textbox’s Text property is optional. This is the
             * only validation required */

            // 0 width and 0 height controls are invalid
            if (Width <= 0 || Width > 1000) return false;
            if (Height <= 0 || Height > 1000) return false;
            //position is outside of the canvas
            if (PositionX < 0 || PositionX > 1000) return false;
            if (PositionY < 0 || PositionY > 1000) return false;

            //if we really want to be picky - we could check whether the element drawn actually falls on a canvas
            if (PositionX + Width > 1000) return false;
            if (PositionY + Height > 1000) return false;

            return true;
        }
    }
}
