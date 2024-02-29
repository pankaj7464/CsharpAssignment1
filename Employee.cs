namespace EmployeeManagement
{
    public class Employee
    {
        private int Id;
        private string Name;
        private string DepartmentName;

        public event EventHandler OnEvent;

        public Employee(int id, string name, string departmentName)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentName = departmentName;
        }
        public int GetId()
        {
            OnEvenFired("GetId() method called");
            return Id;
        }

        public string GetName()
        {
            OnEvenFired("GetName() method called");
            return Name;
        }

        public string GetDepartmentName()
        {

            OnEvenFired("GetDepartmentName() method called");
            return DepartmentName;
        }

        private void OnEvenFired(string message)
        {
            OnEvent?.Invoke(this, new EventArgs());
            Console.WriteLine("____________________________________");
            Console.WriteLine(message);
        }
    }
}