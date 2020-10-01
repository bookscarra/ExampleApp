namespace ShapeLogic
{
    /// <summary>
    /// Ellipse Class
    /// </summary>
    public class Ellipse: BaseShapeClass
    {
        /// <summary>
        /// Ellipse
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="hDiam">Horizontal Diameter</param>
        /// <param name="vDiam">Vertical Diameter</param>
        public Ellipse(short positionX, short positionY, short hDiam, short vDiam): base(positionX, positionY)
        {
            this.IsCurved = true;
            this.Width = hDiam;
            this.Height = vDiam;
        }
    }
}
