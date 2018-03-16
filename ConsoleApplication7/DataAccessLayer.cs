using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Exercise1
{
    public class DataAccessLayer : IDataAccessLayer
    {
        private static Dictionary<int, Employee> Container;

        public void AddEmployeeRecord(int id, Employee employee)
        {
            Container.Add(id, employee);
        }

    }
}
