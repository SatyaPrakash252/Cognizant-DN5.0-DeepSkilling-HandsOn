namespace CollectionsLib
{

    public class Employee
    {

        public int Id { get; set; }

        public string Name { get; set; }



        public override bool Equals(object obj)
        {

            Employee emp = obj as Employee;


            return emp != null
            &&
            emp.Id == Id;

        }



        public override int GetHashCode()
        {

            return Id.GetHashCode();

        }

    }

}