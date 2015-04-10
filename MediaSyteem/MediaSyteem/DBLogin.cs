using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSyteem
{
    class DBLogin : Database
    {
       
        public bool checkLogin(string email, string password)
        {
            bool resultaat = false;
            string sql;
            sql = "select count (*) as aantal from gebruiker where emailadres = :email and wachtwoord = :password";

            try
            {
                Connect();
                OracleCommand cmd = new OracleCommand(sql, connection);
                cmd.Parameters.Add(new OracleParameter("email", email));
                cmd.Parameters.Add(new OracleParameter("password", password));
                OracleDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    resultaat = true;
                }
            }
            catch (OracleException e)
            {

            }
            finally
            {
                connection.Close();
            }
            return resultaat;
        }
    }
}
