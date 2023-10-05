using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiCenter
{
    class Employee : Person
    {
        private int employmentId;
        private Schedule schedule;
        private PermissionType permission;

        public int EmploymentId
        {
            get { return employmentId; }
            set
            {
                if (value <= 0) throw new ArgumentException("Anställningsnummer måste vara större än 0.");
                employmentId = value;
            }
        }

        //TODO kontrollera värdena i set, returnera
        public Schedule Schedule { get; set; }
        public PermissionType Permission { get; set; }

    }
}
