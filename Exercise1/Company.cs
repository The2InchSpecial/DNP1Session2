using Session2;

namespace Session2;

public class Company
{
    private List<Employee> Employees = new List<Employee>();
    

    public double GetMonthlySalaryTotal()
    {
        double total = 0;
        foreach (var emp in Employees)
        {
            total += emp.GetMonthlySalary();
        }

        return total;
    }

    public void HireNewEmployee(Employee emp)
    {
        Employees.Add(emp);
    }
}