using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VetRepository
    {
        public List<Veterinar> GetAllVets()
        {
            List<Veterinar> all = new List<Veterinar>();

            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Vets";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Veterinar v = new Veterinar();
                    v.Id = sqlDataReader.GetInt32(0);
                    v.FullName = sqlDataReader.GetString(1);
                    v.Speciality = sqlDataReader.GetString(2);
                    v.Expirience = sqlDataReader.GetInt32(3);

                    all.Add(v);
                }
            }


            return all;
        }

        public int InsertVet(Veterinar v)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = String.Format("INSERT INTO Vets VALUES('{0}', '{1}', {2})", v.FullName, v.Speciality, v.Expirience);
                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }

        
    }
}
