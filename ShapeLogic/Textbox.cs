namespace ShapeLogic
{
    /// <summary>
    /// Textbox
    /// </summary>
    public class Textbox: Rectangle
    {
        public string Text { get; set; }

        public Textbox(short positionX, short positionY, short width, short height, string text): base(positionX, positionY, width, height)
        {
            this.Text = text;
        }


        public override string ToString()
        {
            return base.ToString() + $" text=\"{Text}\"";
        }
    }
}
