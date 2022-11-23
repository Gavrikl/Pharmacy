using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy
{
    public class SqlConnectionString
    {
        private string sqlConnectionString =
            @"Data Source=LAPTOP-SU7H6358\SQLEXPRESS;
            Initial Catalog = Pharmacy;
            Integrated Security = True";

        public string GetConnectionString { get => sqlConnectionString; set => sqlConnectionString = value; }
    }
}
