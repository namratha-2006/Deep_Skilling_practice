using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using MagicFilesLib;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        private Mock<IDirectoryExplorer> mockDirectory;

        [OneTimeSetUp]
        public void Init()
        {
            mockDirectory = new Mock<IDirectoryExplorer>();

            mockDirectory
                .Setup(x => x.GetFiles(It.IsAny<string>()))
                .Returns(new List<string>
                {
                    _file1,
                    _file2
                });
        }

        [TestCase]
        public void GetFiles_ReturnsTwoFiles()
        {
            var files = mockDirectory.Object.GetFiles("C:\\");

            Assert.That(files, Is.Not.Null);
            Assert.That(files.Count, Is.EqualTo(2));
            Assert.That(files, Does.Contain(_file1));
        }
    }
}