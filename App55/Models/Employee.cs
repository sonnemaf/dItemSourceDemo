using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App55.Models {

    public class EmployeeList : List<Employee> {

    }

    public class Employee {
        public Employee() {
        }

        public Employee(string name, double salary) {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get; set; }

        public void RaiseSalary(double percentage) {
            this.Salary += Salary * (percentage / 100);
        }

        public double Salary { get; set; }

        public override string ToString() {
            return string.Format("Employee Name = {0}, Salary = {1}", this.Name, this.Salary);
        }
    }

}
