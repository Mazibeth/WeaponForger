// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 10/31/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeaponForger.Tests.Tools;

namespace WeaponForger.Tests
{
    [TestClass]
    public class MaterialTest
    {
        [TestMethod]
        public void MaterialLibraryTest()
        {
            var parser = new MaterialParser();
            var text = parser.TransformText();

            var file = string.Format("{0}\\WeaponForger\\WeaponForger\\Data\\MaterialLibrary.cs",
                Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName));

            File.WriteAllText(file, text);

            var content = File.ReadAllText(file);

            Assert.IsNotNull(content);
        }
    }
}