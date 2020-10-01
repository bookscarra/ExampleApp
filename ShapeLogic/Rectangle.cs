namespace ShapeLogic
{
    /// <summary>
    /// Rectangle Class
    /// </summary>
    public class Rectangle: BaseShapeClass
    {
        /// <summary>
        /// Rectangle
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(short positionX, short positionY, short width, short height): base(positionX, positionY)
        {
            this.Width = width;
            this.Height = height;
        }

    }
}
