using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class DataAccessLayer
    {
        private static string userRole;
        private static string userLogin;

        private static string pathBD;
        public static string stringConnect;
        private static SqlConnection connection;

        public string authorization(string login, string password) {
            pathBD = System.IO.Path.GetFullPath("information_system.mdf");
            stringConnect = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True", pathBD);
            connection = new SqlConnection(stringConnect);
            string command = String.Format("SELECT role FROM [users] WHERE login='{0}' AND password='{1}'", login, password);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = command;
            setRole(Convert.ToString(cmd.ExecuteScalar()));
            connection.Close();
            if (userRole != String.Empty)
                setLogin(login);
            return userRole;
        }
        public DataTable clientView() {
            string command = String.Format("SELECT [order].date AS Дата, [order].number AS 'Количество', users.name AS 'Менеджер', [order].price AS 'Стоимость' FROM[order] INNER JOIN users ON[order].manager = users.login WHERE([order].client = '{0}')", userLogin);
            return dataTableTemplateFunction(command);
        }
        public DataTable clothView(string article) {
            string command = String.Format("SELECT cloth.articul, cloth.name, cloth.color, cloth.picture, cloth.image, cloth.composition, cloth.width, cloth.height, cloth.price FROM cloth INNER JOIN cloth_product ON cloth.articul = cloth_product.articul_cloth WHERE(cloth_product.articul_product = {0})", article);
            return dataTableTemplateFunction(command);
        }
        public DataTable fitingView(string article) {
            string command = String.Format("SELECT * FROM [users]");
            return dataTableTemplateFunction(command);
        }
        public void updateStatus(int id, int statusId) {
            pathBD = System.IO.Path.GetFullPath("information_system.mdf");
            stringConnect = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True", pathBD);
            connection = new SqlConnection(stringConnect);
            string command = String.Format("UPDATE [order] SET stage='{0}' WHERE number='{1}'", statusId, id);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public string[] searchMaterial(string tableSearch, string articul) {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            string command = String.Format("SELECT * FROM [{0}] WHERE articul='{1}'", tableSearch, articul);
            cmd.CommandText = command;
            SqlDataReader reader = cmd.ExecuteReader();
            string[] returnData = new string[reader.FieldCount];
            while (reader.Read()) {
                for (int i = 0; i < reader.FieldCount; i++) {
                    returnData[i] = Convert.ToString(reader.GetValue(i));
                }
            }
            connection.Close();
            return returnData;
        }
        public DataTable editOrderStatus()
        {
            string command = String.Format("SELECT number as 'Номер', date as 'Дата', client as 'Клиекнт', price as 'Стоимость', stage FROM [order] WHERE manager='{0}'", userLogin);
            return dataTableTemplateFunction(command);
        }
        public DataTable orderingForClient()
        {
            string command = String.Format("SELECT nameProduct as 'Название', quantity as 'Колличество', salary as 'Стоимость', Client as 'Клиент' ,idProduct FROM [Table] WHERE Client='{0}'", userLogin);
            return dataTableTemplateFunction(command);
        }
        private DataTable dataTableTemplateFunction(string command) {
            DataTable data = new DataTable();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);
            connection.Close();
            return data;
        }
        /// <summary>
        /// Добавление ткани
        /// </summary>
        /// <param name="data"></param>
        /// <param name="price"></param>
        public void setCloth(string[] data, string price) {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            string command = String.Format("INSERT INTO cloth VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], price);
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Заполнение склада
        /// </summary>
        /// <param name="data"></param>
        /// <param name="quantity"></param>
        public void setStorage(string[] data, string quantity)
        { 
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            string command = String.Format("INSERT INTO [storage_cloth] VALUES('{0}','{1}','{2}')", data[1], data[8],quantity);
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void updateCloth(string lenght, string quantity, string articul) {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            string command = String.Format("UPDATE storage_cloth SET(lenght=lenght+'{0}', quantity=quantity+'{1}') WHERE articul_cloth='{2}'", lenght, quantity, articul);
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void ordering(string nameProduct, int quantity, int idProduct)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            string command = String.Format("SELECT 1 FROM [Table]  WHERE nameProduct = '{0}'", nameProduct);
            cmd.CommandText = command;
            int prover = Convert.ToInt16(cmd.ExecuteScalar());
            if (prover != 1)
            {
                command = String.Format("SELECT salary FROM product  WHERE name = '{0}'", nameProduct);
                cmd.CommandText = command;
                int salary = quantity * Convert.ToInt16(cmd.ExecuteScalar());
                command = String.Format("INSERT INTO [Table] VALUES('{0}','{1}','{2}','{3}','{4}')", nameProduct, quantity, salary, userLogin,idProduct);
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();
            }
            else
            {
                command = String.Format("SELECT salary FROM product  WHERE name = '{0}'", nameProduct);
                cmd.CommandText = command;
                int salary = quantity * Convert.ToInt16(cmd.ExecuteScalar());
                command = String.Format("UPDATE [Table] SET quantity=quantity+'{0}', salary=salary+'{1}' WHERE nameProduct='{2}' and Client = '{3}'", quantity, salary, nameProduct, userLogin);
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void creatOrder(int price)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            string command = String.Format("insert into [order] values('{0}','{1}','{2}','{3}','{4}')", DateTime.Now.ToString("dd-MM-yyyy"), '1', userLogin, "Gelevera", price);
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// сохранение заказа
        /// </summary>
        /// <param name="data"></param>
        /// <param name="price"></param>
        public void saveOrder(string[] data,int price) {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = String.Format("SELECT number FROM [order] WHERE client ='{0}' and price='{1}'",userLogin,price);
            int numberOrder = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.CommandText = String.Format("insert into [order_products] values('{0}','{1}','{2}')", data[4], numberOrder, data[1]);
            cmd.ExecuteNonQuery();
            cmd.CommandText ="DELETE FROM [Table]";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        #region getSet

        private void setRole(string role) {
            userRole = role;
        }

        private void setLogin(string login)
        {
            userLogin = login;
        }

        public string getLogin() {
            return userLogin;
        }

        public string getRole() {
            return userRole;
        }
        #endregion
    }
}
