using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine_Management_System.Model;
using Oracle.DataAccess.Client;
using System.Data;
using Oracle.DataAccess.Types;

namespace Magazine_Management_System.Repository.MagazineRepository
{
    internal class MagazineRepository : BaseRepository
    {
        
        public MagazineRepository() { }
        public int SaveMagazine(string Name, int Admin_Id, OracleDate PublicationDate)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "INSERT INTO Magazines (Name,Admin_Id,PUBLICATION_DATE) VALUES (:Name,:Admin_Id,:PublicationDate)";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("Name", Name);
                command.Parameters.Add("Admin_Id", Admin_Id);
                command.Parameters.Add("PublicationDate", PublicationDate);
                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows == 0)
                    return -1;
                //if the magazine is saved successfully return the ID of the magazine
                command.CommandText = "SELECT ID FROM Magazines WHERE Name = :Name";
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.Add("Name", Name);
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
        
        public bool UpdateMagazine(int ID, string NewMagazineName)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "UPDATE Magazines SET Name = :Name WHERE ID = :ID";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("Name", NewMagazineName);
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

        public Magazine GetMagazine(int MagazineID)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "get_magazine";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("MagazineID", MagazineID);
                command.Parameters.Add("Magazine", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader reader = command.ExecuteReader();
                Magazine magazine = new Magazine();
                while (reader.Read())
                {
                    magazine.Id = Convert.ToInt32(reader["ID"]);
                    magazine.Name = reader["Name"].ToString();
                    magazine.Admin_Id = Convert.ToInt32(reader["Admin_Id"]);
                    magazine.PublicationDate = (OracleDate)reader["PUBLICATION_DATE"];
                }
                return magazine;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Magazine> GetAllMagazines()
        {
            //get all magazines stored procedure cursor 
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "get_all_magazines";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Magazines", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader reader = command.ExecuteReader();
                List<Magazine> magazines = new List<Magazine>();
                while (reader.Read())
                {
                    Magazine magazine = new Magazine();
                    magazine.Id = Convert.ToInt32(reader["ID"]);
                    magazine.Name = reader["Name"].ToString();
                    magazine.Admin_Id = Convert.ToInt32(reader["Admin_Id"]);
                    magazine.PublicationDate = (OracleDate)reader.GetDateTime(reader.GetOrdinal("Publication_Date"));
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

        public List<Article> GetArticles(int MagazineID)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "get_articles";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("MagazineID", MagazineID);
                command.Parameters.Add("Articles", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader reader = command.ExecuteReader();
                List<Article> articles = new List<Article>();
                while (reader.Read())
                {
                    Article article = new Article();
                    article.Id = Convert.ToInt32(reader["ID"]);
                    article.Title = reader["Title"].ToString();
                    article.Content = reader["Content"].ToString();
                    article.Magazine_Id = Convert.ToInt32(reader["Magazine_Id"]);
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

        public bool DeleteMagazine(int magazineID)
        {
            OracleTransaction transaction = null;
            try
            {
                // Begin a transaction
                transaction = conn.BeginTransaction();

                // Create and configure the command for deleting articles
                OracleCommand deleteArticlesCommand = new OracleCommand();
                deleteArticlesCommand.Connection = conn;
                deleteArticlesCommand.Transaction = transaction;
                deleteArticlesCommand.CommandText = "DELETE FROM Articles WHERE MAGAZINE_ID = :MagazineID";
                deleteArticlesCommand.CommandType = CommandType.Text;
                deleteArticlesCommand.Parameters.Add("MagazineID", magazineID);

                // Execute the delete articles command
                int articlesDeleted = deleteArticlesCommand.ExecuteNonQuery();

                // Create and configure the command for deleting the magazine
                OracleCommand deleteMagazineCommand = new OracleCommand();
                deleteMagazineCommand.Connection = conn;
                deleteMagazineCommand.Transaction = transaction;
                deleteMagazineCommand.CommandText = "DELETE FROM Magazines WHERE ID = :ID";
                deleteMagazineCommand.CommandType = CommandType.Text;
                deleteMagazineCommand.Parameters.Add("ID", magazineID);

                // Execute the delete magazine command
                int magazinesDeleted = deleteMagazineCommand.ExecuteNonQuery();

                // Commit the transaction if both operations succeed
                transaction.Commit();

                // If no magazines or articles were deleted, return false
                if (articlesDeleted == 0 && magazinesDeleted == 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                // Rollback the transaction if an error occurs
                if (transaction != null)
                    transaction.Rollback();

                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
