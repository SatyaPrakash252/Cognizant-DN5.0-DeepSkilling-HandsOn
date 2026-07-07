using NUnit.Framework;
using Moq;
using MagicFilesLib;
using System.Collections.Generic;



namespace MagicFilesLib.Tests
{


    [TestFixture]

    public class DirectoryExplorerTests
    {


        private readonly string _file1 =
        "file.txt";


        private readonly string _file2 =
        "file2.txt";





        [TestCase]

        public void GetFiles_ReturnFiles()
        {



            Mock<IDirectoryExplorer> mock =
            new Mock<IDirectoryExplorer>();





            mock.Setup(
                x =>
                x.GetFiles(
                    It.IsAny<string>()
                )
            )
            .Returns(
                new List<string>
                {
                _file1,
                _file2
                }
            );





            ICollection<string> files =
            mock.Object.GetFiles(
                "dummy"
            );





            Assert.That(
                files,
                Is.Not.Null
            );



            Assert.That(
                files.Count,
                Is.EqualTo(2)
            );



            Assert.That(
                files,
                Does.Contain(_file1)
            );


        }



    }


}