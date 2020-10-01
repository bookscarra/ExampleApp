namespace ShapeLogic
{
    /// <summary>
    /// Square Class
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Square Constructor
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="width"></param>
        public Square(short positionX, short positionY, short width): base(positionX, positionY, width, width)
        {
        }
    }
}
