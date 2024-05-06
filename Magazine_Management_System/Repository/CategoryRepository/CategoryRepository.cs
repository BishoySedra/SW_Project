using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine_Management_System.Model;
using Oracle.DataAccess.Client;
using System.Data;

namespace Magazine_Management_System.Repository.CategoryRepository
{
    internal class CategoryRepository : BaseRepository
    {
        public int SaveCategory(string CategoryName)
        {
            OracleCommand command = new OracleCommand();

            try
            {
                command.Connection = this.conn;
                command.CommandText = "INSERT INTO Categories (Name) VALUES (:Name)";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("Name", CategoryName);
                int AffectedRows = command.ExecuteNonQuery();
                if (AffectedRows == 0)
                    return -1;
                //if the category is saved successfully return the ID of the category
                command.CommandText = "SELECT ID FROM Categories WHERE Name = :Name";
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.Add("Name", CategoryName);
                OracleDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    return -1;
                }
                //return the ID of the category
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

        public string GetCategoryName(int ID)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "SELECT Name FROM Categories WHERE ID = :ID";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("ID", ID);
                OracleDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    return null;
                }
                reader.Read();
                return reader[0].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Category> GetAllCategories()
        {
            //stored procedure to get all categories cursor
            OracleCommand command = new OracleCommand();
            command.Connection = this.conn;

            command.CommandText = "get_all_categories";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("Categories", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = command.ExecuteReader();
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category(Convert.ToInt32(reader["ID"]), reader["Name"].ToString());
                categories.Add(category);
            }
            return categories;
        }

        public bool UpdateCategory(int ID,string NewCategoryName)
        {
            OracleCommand command = new OracleCommand();

            try
            {
                command.Connection = this.conn;
                command.CommandText = "UPDATE Categories SET Name = :Name WHERE ID = :ID";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("Name", NewCategoryName);
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
        public bool DeleteCategory(int ID)
        {
            OracleCommand command = new OracleCommand();
            try
            {
                command.Connection = this.conn;
                command.CommandText = "DELETE FROM Categories WHERE ID = :ID";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("ID", ID);
                int AffectedRows = command.ExecuteNonQuery();
                if (AffectedRows == 0)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
