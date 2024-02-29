
namespace EmployeeManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee details:");
            Console.WriteLine("=======================================");



            Console.Write("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Department Name: ");
            string departmentName = Console.ReadLine();

            Employee employee = new Employee(id,name,departmentName);


            Console.WriteLine("====================================");
            Console.WriteLine("Employee Id"+ employee.GetId());


            Console.WriteLine("====================================");
            Console.WriteLine("Employee Id"+ employee.GetName());

            Console.WriteLine("====================================");
            Console.WriteLine("Employee Id" + employee.GetDepartmentName());



        }
    }
}
