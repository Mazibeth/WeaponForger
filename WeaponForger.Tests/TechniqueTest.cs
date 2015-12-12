// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 11/25/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeaponForger.Tests.Tools;

namespace WeaponForger.Tests
{
    [TestClass]
    public class TechniqueTest
    {
        [TestMethod]
        public void TechniqueLibraryTest()
        {
            var parser = new TechniqueParser();
            var text = parser.TransformText();

            var file = string.Format("{0}\\WeaponForger\\WeaponForger\\Data\\TechniqueLibrary.cs",
                Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName));

            File.WriteAllText(file, text);

            var content = File.ReadAllText(file);

            Assert.IsNotNull(content);
        }
    }
}