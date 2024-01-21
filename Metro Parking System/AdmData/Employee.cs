using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_Parking_System.AdmData
{
    public class Employee
    {
        public int empID { get; set; }
        public string empUser { get; set; }
        public string empPass { get; set; }
        public string empFirstName { get; set; }
        public string empMiddleName { get; set; }
        public string empLastName { get; set; }
        public string jobDesc { get; set; }
        public string shift { get; set; }
        public byte[] empImg { get; set; }


        public string FullName
        {
            get
            {
                return $"{empLastName}, {empFirstName} {(string.IsNullOrEmpty(empMiddleName) ? "" : empMiddleName.Substring(0, 1))}";
            }
        }

    }



}
