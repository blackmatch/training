using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace training.model
{
    public class Trainee : Person
    {
        public string name;
        public string gender;
        public int age;
        public string jobNumber;

        public Trainee(DataSet ds)
        {
            this.id = ds.Tables["trainees"].Rows[0]["id"].ToString();
            this.name = ds.Tables["trainees"].Rows[0]["name"].ToString();
            this.gender = ds.Tables["trainees"].Rows[0]["gender"].ToString();
            this.age = int.Parse(ds.Tables["trainees"].Rows[0]["age"].ToString());
            this.jobNumber = ds.Tables["trainees"].Rows[0]["jobNumber"].ToString();
            this.pwd = ds.Tables["trainees"].Rows[0]["pwd"].ToString();
        }

        public Trainee()
        {

        }
    }
}
