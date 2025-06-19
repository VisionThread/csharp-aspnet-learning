using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// this showcases Open and closed principal which says that 
/// code should be open for extension not for modifcation
namespace OpenCloseDemo
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public Employee() { }

        public Employee(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;

        }

        //public decimal CalculateBonus(decimal salary)
        //{
        //    if(this.EmployeeType == "P")
        //    {
        //        return salary * 0.5M;
        //    }
        //    else
        //    {
        //        return salary * 0.2M;
        //    }


        //} instead of if else modifications we can just create different
        /// class for permanent and temperary

        public abstract decimal CalculateBonus(decimal salary);


        public override string ToString()
        {
            return string.Format("ID:{0},Name:{1}", this.ID, this.Name);
        }

    }

    public class PermanentEmp : Employee
    {
        public PermanentEmp() { }

        public PermanentEmp(int ID, string Name) : base(ID, Name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.5M;
        }

    }

    public class TemporaryEmp : Employee
    {
        public TemporaryEmp() { }

        public TemporaryEmp(int ID, string Name) : base(ID, Name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.2M;
        }

    }

    public class ContractEmp : Employee
    {
        public ContractEmp() { }

        public ContractEmp(int ID, string Name) : base(ID, Name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }




}
