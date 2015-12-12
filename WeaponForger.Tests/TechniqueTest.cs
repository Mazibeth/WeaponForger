using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeaponForger.Data;
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