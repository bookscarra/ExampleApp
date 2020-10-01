using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLogic
{
    /// <summary>
    /// Circle
    /// </summary>
    public class Circle : Ellipse
    {
        /// <summary>
        /// Circle constructor
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="diam"></param>
        public Circle(short positionX, short positionY, short diam) : base(positionX, positionY, diam, diam)
        {
        }
    }
}
