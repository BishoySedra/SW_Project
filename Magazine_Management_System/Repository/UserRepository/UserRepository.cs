using Magazine_Management_System.Model;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Types;


namespace Magazine_Management_System.Repository.UserRepository
{
    internal class UserRepository : BaseRepository
    {
        public int SaveUser(User NewUser)
        {
            OracleCommand command = new OracleCommand();

            string username = NewUser.Username;
            string email = NewUser.Email;
            string password = NewUser.Password;
            string role = NewUser.Role;
            try
            {
                command.Connection = this.conn;
                command.CommandText = "INSERT INTO Users (Username, Email, Password, Role) VALUES (:Username, :Email, :Password, :Role)";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("Username", username);
                command.Parameters.Add("Email", email);
                command.Parameters.Add("Password", password);
                command.Parameters.Add("Role", role);
                int AffectedRows = command.ExecuteNonQuery();
                if (AffectedRows == 0)
                    return -1;
                //if the user is saved successfully return the ID of the user
                command.CommandText = "SELECT ID FROM Users WHERE Email = :Email";
                command.CommandType = CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.Add("Email", email);
                OracleDataReader reader = command.ExecuteReader();
                if(reader.HasRows == false)
                {
                    return -1;
                }
                //return the ID of the user
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
        public bool UpdateUser(User NewUser)
        {
            OracleCommand command = new OracleCommand();

            string username = NewUser.Username;

            string email = NewUser.Email;
            string password = NewUser.Password;
            string role = NewUser.Role;
            try
            {
                command.Connection = this.conn;
                command.CommandText = "UPDATE Users SET Username = :Username, Email = :Email, Password = :Password, Role = :Role WHERE Username = :Username";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("Username", username);
                command.Parameters.Add("Email", email);
                command.Parameters.Add("Password", password);
                command.Parameters.Add("Role", role);
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
        public User GetUserByID(int ID)
        {
            
            OracleCommand command = new OracleCommand();
            command.Connection = this.conn;
            command.CommandText = "get_user";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("id_in", ID);
            command.Parameters.Add("username_out", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("email_out", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("password_out", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("role_out", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            try
            {
                //make the stored procedure and read its content if found
                //if not found return null 
                command.ExecuteNonQuery();
                string username = command.Parameters["username_out"].Value.ToString();
                string email = command.Parameters["email_out"].Value.ToString();
                string password = command.Parameters["password_out"].Value.ToString();
                string role = command.Parameters["role_out"].Value.ToString();
                User user = new User(email, username, password, role);
                user.Id = ID;
                return user;

            }catch(Exception ex)
            {
                return null;
            }
            
        }

        public User GetUserByCredentials(string email,string password)
        {
            //make the stored procedure and read the id of the user as output parameter if found

            //if not found return null
            OracleCommand command = new OracleCommand();
            command.Connection = this.conn;
            command.CommandText = "get_user_by_email_password";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("email_in", email);
            command.Parameters.Add("password_in", password);
            command.Parameters.Add("id_out", OracleDbType.Int32).Direction = ParameterDirection.Output;
            try
            {
                command.ExecuteNonQuery();
                OracleParameter idOutParam = (OracleParameter)command.Parameters["id_out"];
                OracleDecimal returnedVal = (OracleDecimal)idOutParam.Value.ToString();

                // Check if the returned value is not null and not DBNull
                if (returnedVal != null && !returnedVal.IsNull)
                {
                    // Convert OracleDecimal to int
                    int ID = returnedVal.ToInt32();
                    return GetUserByID(ID);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                return null;
            }


        }

        public bool DeleteUser(int ID)
        {
            OracleCommand command = new OracleCommand();

            try
            {
                command.Connection = this.conn;
                command.CommandText = "DELETE FROM Users WHERE ID = :ID";
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
