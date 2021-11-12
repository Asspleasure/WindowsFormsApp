using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class SqlServer
    {
        static string Connection { get; set; } = "server=localhost;port=3307;user=root;password=root;database=data_words";

        public static MySqlConnection mySqlConnection = new MySqlConnection(Connection);
        
        public static Dictionary<string, string> SelectAllWords()
        {
            var keyValues = new Dictionary<string, string>();
            string sql = $"SELECT englishWord, translatedWord FROM words";
            OpenServer();
            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                keyValues.Add(reader[0].ToString(), reader[1].ToString());
            }
            CloseServer();
            return keyValues;
        }

        public static Dictionary<string, string> SelectAllUsers()
        {
            var keyValues = new Dictionary<string, string>();
            string sql = $"SELECT login, pass FROM data_users";
            OpenServer();
            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                keyValues.Add(reader[0].ToString(), reader[1].ToString());
            }
            CloseServer();
            return keyValues;
        }

        public static string ConnectionTo()
        {
            return Connection;
        }

        public static string SelectEnglishWord(string word)
        {
            string sql = $"SELECT englishWord FROM words WHERE englishWord = {word}";
            OpenServer();
            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();    
            while(reader.Read())
            {
                return reader[0].ToString();
            }
            CloseServer();
            return null;
        }

        public static string SelectTranslatedWord(string word)
        {
            string sql = $"SELECT translatedWord FROM words WHERE translatedWord = {word}";
            OpenServer();
            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return reader[0].ToString();
            }
            CloseServer();
            return null;
        }

        public static void OpenServer()
        {
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Not connect to server!", "WARNING", MessageBoxButtons.OK);
            }
        }

        public static void CloseServer()
        {
            try
            {
                mySqlConnection.Close();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }


}
