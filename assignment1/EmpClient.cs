namespace assignment
{
    class Empclient
    {
        static void Main(string[] args)
        {
            Permanent permanentEmployee = new Permanent();
            Console.WriteLine("Enter Permanent Employee Details:");
            permanentEmployee.AcceptDetails();
            permanentEmployee.DisplayDetails();
            Console.WriteLine($"Calculated Salary: {permanentEmployee.CalculateSalary()}");

            Trainee traineeEmployee = new Trainee();
            Console.WriteLine("\nEnter Trainee Employee Details:");
            traineeEmployee.AcceptDetails();
            traineeEmployee.DisplayDetails();
            Console.WriteLine($"Calculated Salary: {traineeEmployee.CalculateSalary()}");
        }


    }
}