using NUnit.Framework;
using CollectionsLib;
using System.Linq;


namespace CollectionsLib.Tests
{


    [TestFixture]

    public class EmployeeManagerTests
    {

        EmployeeManager manager;



        [SetUp]

        public void Setup()
        {

            manager =
            new EmployeeManager();

        }






        [Test]

        public void GetEmployees_CheckNoNullValues()
        {


            var employees =
            manager.GetEmployees();


            Assert.That
            (
                employees,
                Has.None.Null
            );

        }








        [Test]

        public void GetEmployees_CheckEmployeeId100Exists()
        {


            var employees =
            manager.GetEmployees();


            Assert.That
            (
                employees.Any(
                    e => e.Id == 100
                ),
                Is.True
            );


        }








        [Test]

        public void GetEmployees_CheckUniqueEmployees()
        {


            var employees =
            manager.GetEmployees();



            var count =
            employees
            .Select(e => e.Id)
            .Distinct()
            .Count();



            Assert.That
            (
                count,
                Is.EqualTo(
                    employees.Count
                )
            );


        }









        [Test]

        public void GetEmployees_CompareCollections()
        {


            var employees1 =
            manager.GetEmployees();


            var employees2 =
            manager.GetEmployeesWhoJoinedInPreviousYears();



            Assert.That
            (
                employees1,
                Is.EquivalentTo(
                    employees2
                )
            );


        }



    }

}