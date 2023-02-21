using Session2;

Company c = new Company();
FullTimeEmployee cedric = new FullTimeEmployee("Cedric",23000);
PartTimeEmployee devlin = new PartTimeEmployee("Devlin",150,46);
c.HireNewEmployee(cedric);
c.HireNewEmployee(devlin);
Console.WriteLine($"the total monthly salary is: "+c.GetMonthlySalaryTotal());