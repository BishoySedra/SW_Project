using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine_Management_System.Model;
using Oracle.DataAccess.Client;
using System.Data;
using Oracle.DataAccess.Types;

namespace Magazine_Management_System.Repository.ArticleRepository
{
    internal class ArticleRepository : BaseRepository
    {
        //make crud operations for articles like save, update, delete, get all articles, get article by id


        public ArticleRepository() { }

        //save article
        public int SaveArticle(string Title, string Content, int Magazine_Id)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "INSERT INTO Articles (Title,Content,Magazine_Id) VALUES (:Title,:Content,:Magazine_Id)";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("Title", Title);
                command.Parameters.Add("Content", Content);
                command.Parameters.Add("Magazine_Id", Magazine_Id);
                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows == 0)
                    return -1;
                //if the article is saved successfully return the ID of the article
                command.CommandText = "SELECT ID FROM Articles WHERE Title = :Title";
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.Add("Title", Title);
                OracleDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    return -1;
                }
                //return the ID of the article
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

        //update article
        public bool UpdateArticle(int ID, string NewArticleTitle, string NewArticleContent)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "UPDATE Articles SET Title = :NewArticleTitle, Content = :NewArticleContent WHERE ID = :ID";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("NewArticleTitle", NewArticleTitle);
                command.Parameters.Add("NewArticleContent", NewArticleContent);
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

        //get article by id
        public Article GetArticle(int ID)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "SELECT * FROM Articles WHERE ID = :ID";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("ID", ID);
                OracleDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    return null;
                }
                reader.Read();
                Article article = new Article();
                article.Id = Convert.ToInt32(reader["ID"]);
                article.Title = reader["Title"].ToString();
                article.Content = reader["Content"].ToString();
                article.Magazine_Id = Convert.ToInt32(reader["Magazine_Id"]);
                return article;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        //delete article
        public bool DeleteArticle(int ID)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "DELETE FROM Articles WHERE ID = :ID";
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
