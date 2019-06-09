using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DoctorSupportSystem.Models;

namespace DoctorSupportSystem.DataBase
{
    class DataBaseOperator
    {

       
        private static string conStr = "Server=127.0.0.1;Port=3306;Database=DSSystem;Uid=root;Pwd=71557113;";
        private MySqlConnection conn = null;
        private Boolean isConnected = false;

        private static DataBaseOperator db = new DataBaseOperator();
        private DataBaseOperator()
        {
        }
        public static DataBaseOperator GetInstance()
        {
            return db;
        }


        /*
         * Open and close connection..........
         */

        private Boolean openConnection() 
        {
            conn = new MySqlConnection(conStr);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            isConnected = true;
            return true;
        }

        private Boolean closeConnection() 
        {
            if (isConnected)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                    isConnected = false;
                    return true;
                }
            }
            return false;
        }

        /*
         * Add data...............................
         */

        public void addPatient(Patient patient) 
        {
            openConnection();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO PatientDetails VALUES (DEFAULT,@fName,@lName,@dob,@gender,@address,@nic)";
            command.Prepare();
            Console.WriteLine("DB1");
            command.Parameters.AddWithValue("@fName",patient.FirstName);
            command.Parameters.AddWithValue("@lName", patient.LastName);
            command.Parameters.AddWithValue("@dob", patient.getDateOfBith());
            command.Parameters.AddWithValue("@gender", patient.Gender);
            command.Parameters.AddWithValue("@address", patient.Address);
            command.Parameters.AddWithValue("@nic", patient.Nic);
            Console.WriteLine("DB2");
            Console.WriteLine(command.CommandText);
            try {
                command.ExecuteNonQuery();
            }catch(Exception ex){
                Console.WriteLine(ex.ToString());
            }
            
            Console.WriteLine("DB2");
            closeConnection();
        }


        /*
         * Get data....
         */

        // get the maximum PID to produce the next PID

        public int getMaxPID() 
        {
            openConnection();
            string stm = "SELECT MAX(PID) FROM PatientDetails";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            int maxPID = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine( maxPID);
            
            closeConnection();
            return maxPID;

        }

        /* 
         * getters and seters.....................
         */

    }
}
