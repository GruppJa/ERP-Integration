using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1.ERP.Demo;

namespace WindowsFormsApplication1
{
    class Controller
    {
        private WebService webService = new WebService();

        public DataSet getEmployees()
        {
            DataSet ds = webService.getEmployees();
            return ds;
        }

        public DataSet getEmployeeRelatives()
        {
            DataSet ds = webService.getEmployeeRelatives();
            return ds;
        }

        public DataSet getEmployeeAbscence()
        {
            DataSet ds = webService.getEmployeeAbscence();
            return ds;
        }

        public DataSet getEmployeeAbscence2004()
        {
            DataSet ds = webService.getEmployeeAbscence2004();
            return ds;
        }

        public DataSet getMostSick()
        {
            DataSet ds = webService.getMostSick();
            return ds;
        }

        public DataSet getQualafications()
        {
            DataSet ds = webService.getQualafications();
            return ds;
        }

        public DataSet getKeys()
        {
            DataSet ds = webService.getKeys();
            return ds;
        }

        public DataSet getIndexes()
        {
            DataSet ds = webService.getIndexes();
            return ds;
        }

        public DataSet getTableConstraints()
        {
            DataSet ds = webService.getTableConstraints();
            return ds;
        }

        public DataSet getTables()
        {
            DataSet ds = webService.getTables();
            return ds;
        }

        public DataSet getColumns()
        {
            DataSet ds = webService.getColumns();
            return ds;
        }
    }
}
