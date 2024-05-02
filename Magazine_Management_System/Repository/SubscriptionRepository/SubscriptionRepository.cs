using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Magazine_Management_System.Model;
using Oracle.DataAccess.Types;

namespace Magazine_Management_System.Repository.SubscriptionRepository
{
    internal class SubscriptionRepository : BaseRepository
    {
        //make crud operations for this repository
        public SubscriptionRepository() { }

        //save stuff like above
        public int SaveSubscription(int Reader_Id, int Magazine_Id, OracleDate StartDate, OracleDate EndDate)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "INSERT INTO Subscriptions (Reader_Id,Magazine_Id,Start_Date,End_Date) VALUES (:Reader_Id,:Magazine_Id,:Start_Date,:End_Date)";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("Reader_Id", Reader_Id);
                command.Parameters.Add("Magazine_Id", Magazine_Id);
                command.Parameters.Add("Start_Date", StartDate);
                command.Parameters.Add("End_Date", EndDate);
                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows == 0)
                    return -1;
                //if the magazine is saved successfully return the ID of the magazine
                command.CommandText = "SELECT ID FROM Subscriptions WHERE Reader_Id = :Reader_Id AND Magazine_Id = :Magazine_Id";
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.Add("Reader_Id", Reader_Id);
                command.Parameters.Add("Magazine_Id", Magazine_Id);
                OracleDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    return -1;
                }
                //return the ID of the magazine
                reader.Read();
                int ID = Convert.ToInt32(reader[0]);
                return ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;

            }

        }

        //update stuff like above
        public bool UpdateSubscription(int ID, int Reader_Id, int Magazine_Id, OracleDate StartDate, OracleDate EndDate)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "UPDATE Subscriptions SET Reader_Id = :Reader_Id, Magazine_Id = :Magazine_Id, Start_Date = :Start_Date, End_Date = :End_Date WHERE ID = :ID";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("Reader_Id", Reader_Id);
                command.Parameters.Add("Magazine_Id", Magazine_Id);
                command.Parameters.Add("Start_Date", StartDate);
                command.Parameters.Add("End_Date", EndDate);
                command.Parameters.Add("ID", ID);
                int AffectedRows = command.ExecuteNonQuery();
                if (AffectedRows == 0)
                    return false;
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;

            }
        }

        //get subscription details 
        public Subscription GetSubscription(int ID)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "get_subscription";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("ID", ID);
                command.Parameters.Add("Subscription", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader reader = command.ExecuteReader();
                Subscription subscription = new Subscription();
                while (reader.Read())
                {
                    subscription.Reader_Id = Convert.ToInt32(reader["Reader_Id"]);
                    subscription.Magazine_Id = Convert.ToInt32(reader["Magazine_Id"]);
                    subscription.StartDate = (OracleDate)reader["Start_Date"];
                    subscription.EndDate = (OracleDate)reader["End_Date"];
                }
                return subscription;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //delete subscription by id
        public bool DeleteSubscription(int ID)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "DELETE FROM Subscriptions WHERE ID = :ID";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("ID", ID);
                int AffectedRows = command.ExecuteNonQuery();
                if (AffectedRows == 0)
                    return false;
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;

            }
        }

    }
}
