using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SVGFactory;
using System.IO;

namespace SVGFactoryTest
{
    [TestClass]
    public class SVGDocTest
    {
        [TestMethod]
        public void BasicSVGDocTest()
        {
            //Create the SVG Document and get the text
            SVGDocument svgDoc = new SVGDocument();
            string testSvg = svgDoc.Render();

            //using (StreamWriter writer = new StreamWriter(@"Files\BasicSvgDoc.svg"))
            //{
            //    writer.Write(testSvg);
            //}

            //Get the standard svg it should be
            string standardSvg = File.ReadAllText(@"Files\BasicSvgDoc.svg");

            //Ensure the two svg strings are the same
            Assert.AreEqual(testSvg, standardSvg);
        }
    }
}
