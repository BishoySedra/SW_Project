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
               
                return Magazine_Id;
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

        public List<Magazine> GetAllMagazinesNotSubscribedTo(int ReaderID)
        {
            //get all magazines that the reader is not subscribed to using stored procedure called get_all_other_magazines
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "get_all_other_magazines";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("ReaderID", ReaderID);
                command.Parameters.Add("Magazines", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader reader = command.ExecuteReader();
                List<Magazine> magazines = new List<Magazine>();
                while (reader.Read())
                {
                    Magazine magazine = new Magazine();
                    magazine.Id = Convert.ToInt32(reader["ID"]);
                    magazine.Name = reader["Name"].ToString();
                    magazines.Add(magazine);
                }
                return magazines;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Magazine> GetAllMagazinesSubscribedTo(int ReaderID)
        {
            //get all magazines that the reader is not subscribed to using stored procedure called get_all_other_magazines
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "get_all_my_magazines";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("ReaderID", ReaderID);
                command.Parameters.Add("Magazines", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader reader = command.ExecuteReader();
                List<Magazine> magazines = new List<Magazine>();
                while (reader.Read())
                {
                    Magazine magazine = new Magazine();
                    magazine.Id = Convert.ToInt32(reader["ID"]);
                    magazine.Name = reader["Name"].ToString();
                    magazines.Add(magazine);
                }
                return magazines;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Article> GetArticlesOfYourSubscriptionMagazines(int ReaderID)
        {
            //get the user articles by calling a stored procedure called get_all_my_magazines_articles
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "get_all_my_magazines_articles";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("ReaderID", ReaderID);
                command.Parameters.Add("Articles", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader reader = command.ExecuteReader();
                List<Article> articles = new List<Article>();
                while (reader.Read())
                {
                    Article article = new Article();
                    article.Id = Convert.ToInt32(reader["ID"]);
                    article.Title = reader["Title"].ToString();
                    article.Content = reader["Content"].ToString();
                    articles.Add(article);
                }
                return articles;
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
