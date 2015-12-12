// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 11/29/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeaponForger.Tests.Tools;

namespace WeaponForger.Tests
{
    [TestClass]
    public class SchematicTest
    {
        [TestMethod]
        public void SchematicLibraryTest()
        {
            var parser = new SchematicParser();
            var text = parser.TransformText();

            var file = string.Format("{0}\\WeaponForger\\WeaponForger\\Data\\SchematicLibrary.cs",
                Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName));

            File.WriteAllText(file, text);

            var content = File.ReadAllText(file);

            Assert.IsNotNull(content);
        }
    }
}