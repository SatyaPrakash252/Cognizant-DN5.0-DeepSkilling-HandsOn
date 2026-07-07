using System.Collections.Generic;


namespace CollectionsLib
{

    public class EmployeeManager
    {


        public List<Employee> GetEmployees()
        {


            return new List<Employee>
            {

                new Employee
                {
                    Id=100,
                    Name="John"
                },


                new Employee
                {
                    Id=101,
                    Name="Smith"
                }

            };


        }






        public List<Employee> GetEmployeesWhoJoinedInPreviousYears()
        {

            return new List<Employee>
            {

                new Employee
                {
                    Id=100,
                    Name="John"
                },


                new Employee
                {
                    Id=101,
                    Name="Smith"
                }

            };

        }


    }

}