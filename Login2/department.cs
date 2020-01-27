using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login2
{
    public class department
    {
        public int id { get; set; }
        public string Name_department { get; set; }
        public string Manager { get; set; }
        public string Division { get; set; }
        public int Division_id { get; set; }

        public department() { }

        public department(int id, string name, string manager, string division, int division_id) {
            this.id = id;
            this.Name_department = name;
            this.Manager = manager;
            this.Division = division;
            this.Division_id = division_id;
        }
        public virtual void Update(string name, string manager, string division, int division_id) {
            this.Name_department = name;
            this.Manager = manager;
            this.Division = division;
            this.Division_id = division_id;
        }
        public virtual void Delete(int id)
        {
            this.Id = id;

        }
    }
}
