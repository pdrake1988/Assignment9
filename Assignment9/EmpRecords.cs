using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class EmpRecords
    {
        public List<Tuple<string, string, float>> Records =
            new List<Tuple<string, string, float>>();

        public void AddEmp(Tuple<string, string, float> newEmp)
        {
            this.Records.Add(newEmp);
        }

        public void HighesSalary(float salary)
        {
            this.Records.Where<Tuple<string, string, float>>(t => t.Item3 == salary);
        }
    }
}
