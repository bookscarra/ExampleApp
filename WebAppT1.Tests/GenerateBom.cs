using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLogic;

namespace WebAppT1.Tests
{
    [TestClass]
    public class GenerateBom
    {
        [TestMethod]
        public void GenerateSampleBOM()
        {
            //Setup
            var bom = new BillOfMaterial();
            var rect = new Rectangle(10, 10, 30, 40);
            bom.AddShape(rect);
            var square = new Square(15, 30, 35);
            bom.AddShape(square);
            var ellipse = new Ellipse(100, 150, 300, 200);
            bom.AddShape(ellipse);
            var circle = new Circle(1, 1, 300);
            bom.AddShape(circle);
            var textbox = new Textbox(5, 5, 200, 100, "sample text");
            bom.AddShape(textbox);
            var expectedOutput =
@"----------------------------------------------------------------
Bill of Materials
----------------------------------------------------------------
Rectangle (10,10) width=30 height=40
Square (15,30) size=35
Ellipse (100,150) diameterH = 300 diameterV = 200
Circle (1,1) size=300
Textbox (5,5) width=200 height=100 text=""sample text""
----------------------------------------------------------------";

            //Execute
            var output = bom.GenerateBillOfMaterials();

            //Assert
            Assert.AreEqual("Rectangle (10,10) width=30 height=40", rect.ToString());
            Assert.AreEqual("Square (15,30) size=35", square.ToString());
            Assert.AreEqual("Ellipse (100,150) diameterH = 300 diameterV = 200", ellipse.ToString());
            Assert.AreEqual("Circle (1,1) size=300", circle.ToString());
            Assert.AreEqual("Textbox (5,5) width=200 height=100 text=\"sample text\"", textbox.ToString());
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void GenerateEmptyBOM()
        {
            var bom = new BillOfMaterial();
            var output = bom.GenerateBillOfMaterials();
            var expectedOutput =
@"----------------------------------------------------------------
Bill of Materials
----------------------------------------------------------------
----------------------------------------------------------------";
            Assert.AreEqual(expectedOutput, output);
        }

        [DataTestMethod]
        [DataRow(2000,2000,2,2)]
        [DataRow(-3, 1, 1, 1)]
        [DataRow(1, -3, 1, 1)]
        [DataRow(1, 1, -3, 1)]
        [DataRow(1, 1, 1, -3)]
        public void TestInvalidBOM(short positionX, short positionY, short width, short height)
        {
            var bom = new BillOfMaterial();
            bom.AddShape(new Rectangle(positionX, positionY, width, height));
            var output = bom.GenerateBillOfMaterials();
            Assert.AreEqual(Constants.ABORT, output);
        }
    }
}
