using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace CourseDB
{
    class DBUtils
    {
        public static string MySQLEscape(string str)
        {
            return Regex.Replace(str, @"[\x00'""\b\n\r\t\cZ\\%_]",
                delegate (Match match)
                {
                    string v = match.Value;
                    switch (v)
                    {
                        case "\x00":
                            return "\\0";
                        case "\b":
                            return "\\b";
                        case "\n":
                            return "\\n";
                        case "\r":
                            return "\\r";
                        case "\t":
                            return "\\t";
                        case "\u001A":
                            return "\\Z";
                        default:
                            return "\\" + v;
                    }
                });
        }

        protected static MySqlConnection connection;
        static List<int> product;
        static List<int> order;
        static List<int> supply;
        static List<int> provider;
        static List<int> client;
        static List<int> employees;
        public static int mode;
        public static int revId;

        public static object MySqlEscape { get; private set; }

        public static MySqlConnection GetDBConnection(string host, string port, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;
            if (connection == null)
            {
                connection = new MySqlConnection(connString);
                connection.Open();
                connection.Close();

            }
            return connection;
        }

        public static MySqlCommand GetNewCMD(MySqlConnection Connection = null)
        {
            MySqlCommand cmd;
            if (Connection == null)
            {
                cmd = new MySqlCommand();
                cmd.Connection = connection;
            }
            else
            {
                cmd = new MySqlCommand();
                cmd.Connection = Connection;
            }
            return cmd;
        }

        public static List<string> GetAllClient()
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `client`";
            client = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    client.Add(rdr.GetInt32(0));
                    list.Add($"ПІБ: {rdr.GetString(1)} | Адреса: {rdr.GetString(2)} | Телефон: {rdr.GetString(3)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }

        public static List<string> GetAllProvider()
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `provider`";
            provider = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    provider.Add(rdr.GetInt32(0));
                    list.Add($"Компанія: {rdr.GetString(1)} | Представник: {rdr.GetString(2)} | Телефон: {rdr.GetString(3)} | Адреса: {rdr.GetString(4)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        public static List<string> GetAllEmployees()
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `employees`";
            employees = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    employees.Add(rdr.GetInt32(0));
                    list.Add($"Фамілія: {rdr.GetString(1)} | Ім'я: {rdr.GetString(2)} | Посада: {rdr.GetString(3)} | ДН: {rdr.GetString(4)} | Адреса: {rdr.GetString(5)} | Телефон: {rdr.GetString(6)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        public static List<string> GetAllProducts()
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `product`";
            product = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    product.Add(rdr.GetInt32(0));
                    list.Add($"Назва: {rdr.GetString(2)} | Ціна Зак: {rdr.GetString(5)} | Наявність: {rdr.GetString(6)} | Кількість: {rdr.GetString(7)} | Ціна Прод: {rdr.GetString(8)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        public static List<string> GetAllOrder()
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `order`";
            order = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    order.Add(rdr.GetInt32(0));
                    Console.WriteLine(order);
                    list.Add($"Публікація: {rdr.GetString(4)} | Виконання: {rdr.GetString(5)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        public static List<string> GetAllSupply()
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `supply`";
            supply = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    supply.Add(rdr.GetInt32(0));
                    list.Add($"Номер поставки: {rdr.GetString(0)} | Дата поставки: {rdr.GetString(2)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }

        public static List<string> GetAllProductsByParticularMatching(string text)
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `product` WHERE id = '{text}' or " +
                $"supply_id = '{text}' or " +
                $"Descripton like '%{text}%' or " +
                $"Name like '%{text}%' or " +
                $"SupplyerPrice = '%{text}%' or " +
                $"Aviable like '%{text}%' or " +
                $"Count = '{text}' or " +
                $"PriceForSale = '{text}'";
            product = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    product.Add(rdr.GetInt32(0));
                    list.Add($"Назва: {rdr.GetString(2)} | Ціна Зак: {rdr.GetString(5)} | Наявність: {rdr.GetString(6)} | Кількість: {rdr.GetString(7)} | Ціна Прод: {rdr.GetString(8)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        public static List<string> GetAllProvidersByParticularMatching(string text)
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `provider` WHERE id = '{text}' or " +
                $"CompanyName like '%{text}%' or " +
                $"Provider like '%{text}%' or " +
                $"Phone like '%{text}%' or " +
                $"Address like '%{text}%'";
            provider = new List<int>();
            Console.WriteLine(cmd.CommandText);
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    provider.Add(rdr.GetInt32(0));
                    list.Add($"Компанія: {rdr.GetString(1)} | Представник: {rdr.GetString(2)} | Телефон: {rdr.GetString(3)} | Адреса: {rdr.GetString(4)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        public static List<string> GetAllSupplyByParticularMatching(string text)
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `supply` WHERE id = '{text}' or " +
                $"SupplyerID = '{text}' or " +
                $"Date like '%{text}%'";
            supply = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    supply.Add(rdr.GetInt32(0));
                    list.Add($"Номер поставки: {rdr.GetString(0)} | Дата поставки: {rdr.GetString(2)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        public static List<string> GetAllClientByParticularMatching(string text)
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `client` WHERE id = '{text}' or +" +
                $"FullName like '%{text}%' or " +
                $"Address like '%{text}%' or " +
                $"Phone like '%{text}%'";
            client = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    client.Add(rdr.GetInt32(0));
                    list.Add($"ПІБ: {rdr.GetString(1)} | Адреса: {rdr.GetString(2)} | Телефон: {rdr.GetString(3)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        public static List<string> GetAllOrderByParticularMatching(string text)
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `order` WHERE id = '{text}' or " +
                $"product_id = '{text}' or " +
                $"employees_id = '{text}' or " +
                $"client_id = '{text}' or " +
                $"PublicateDate like '%{text}%' or " +
                $"ExecutionDate like '%{text}%'";
            order = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    order.Add(rdr.GetInt32(0));
                    list.Add($"Публікація: {rdr.GetString(4)} | Виконання: {rdr.GetString(5)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        public static List<string> GetAllEmployeesByParticularMatching(string text)
        {
            var cmd = GetNewCMD();
            var list = new List<string>();
            cmd.CommandText = $"SELECT * FROM `employees` WHERE id = '{text}' or " +
                $"SecondName like '%{text}%' or " +
                $"FirstName like '%{text}%' or " +
                $"Position like '%{text}%' or " +
                $"BDay like '%{text}%' or " +
                $"Address like '%{text}%' or " +
                $"Phone like '%{text}%'";
            employees = new List<int>();
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    employees.Add(rdr.GetInt32(0));
                    list.Add($"Фамілія: {rdr.GetString(1)} | Ім'я: {rdr.GetString(2)} | Посада: {rdr.GetString(3)} | ДН: {rdr.GetString(4)} | Адреса: {rdr.GetString(5)} | Телефон: {rdr.GetString(6)}");
                }
            }
            cmd.Connection.Close();
            return list;
        }
        // Realisation
        // Client
        public static void InsertClients(string fullname, string address, string phone)
        {
            var x = GetNewCMD();
            x.CommandText = $"Insert Into client(FullName, Address, Phone) Values('{MySQLEscape(fullname)}','{MySQLEscape(address)}', '{MySQLEscape(phone)}')";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        public static void DeleteClient(int id)
        {
            var x = GetNewCMD();
            x.CommandText = $"Delete From client where id = {client[id]}";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }

        public static List<string> GetClientToUpdate(int id)
        {
            List<string> str = new List<string>();
            var cmd = GetNewCMD();
            cmd.CommandText = $"SELECT * FROM `client` where id = {client[id]}";
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    str.Add(rdr.GetString(1));
                    str.Add(rdr.GetString(2));
                    str.Add(rdr.GetString(3));
                }
            }
            cmd.Connection.Close();
            return str;
        }
        public static void UpdateClient(string fullname, string address, string phone)
        {
            var x = GetNewCMD();
            x.CommandText = $"update `client` set  FullName = '{fullname}', Address = '{address}', Phone = '{phone}' where id = {client[revId]}";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }

        //Employees
        public static void InsertEmployees(string firstname, string secondname, string position, string bday, string address, string phone)
        {
            var x = GetNewCMD();
            x.CommandText = $"Insert Into employees(FirstName, SecondName, Position, BDay, Address, Phone) Values('{MySQLEscape(firstname)}', '{MySQLEscape(secondname)}', " +
                $"'{MySQLEscape(position)}', CAST('{MySQLEscape(bday)}' AS DATE)," +
                $"'{MySQLEscape(address)}', '{MySQLEscape(phone)}')";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        public static void DeleteEmployees(int id)
        {
            var x = GetNewCMD();
            x.CommandText = $"Delete From employees where id = {employees[id]}";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }

        public static List<string> GetEmployeesToUpdate(int id)
        {
            List<string> str = new List<string>();
            var cmd = GetNewCMD();
            cmd.CommandText = $"SELECT * FROM `employees` where id = {employees[id]}";
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    str.Add(rdr.GetString(1));
                    str.Add(rdr.GetString(2));
                    str.Add(rdr.GetString(3));
                    str.Add(rdr.GetString(4));
                    str.Add(rdr.GetString(5));
                    str.Add(rdr.GetString(6));
                }
            }
            cmd.Connection.Close();
            return str;
        }
        public static void UpdateEmployees(string firstname, string secondname, string position, string bday, string address, string phone)
        {
            var x = GetNewCMD();
            x.CommandText = $"update employees set FirstName = '{firstname}', SecondName = '{secondname}', " +
                $"Position = '{position}'," +
                $"Address = '{address}', Phone = '{phone}' where id = {employees[revId]}";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        //Provider
        public static void InsertProvider(string companyname, string provider, string address, string phone)
        {
            var x = GetNewCMD();
            x.CommandText = $"Insert Into provider(CompanyName, Provider, Address, Phone) Values('{MySQLEscape(companyname)}','{MySQLEscape(provider)}'," +
                $"'{MySQLEscape(address)}', '{MySQLEscape(phone)}')";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        public static void DeleteProvider(int id)
        {
            var x = GetNewCMD();
            x.CommandText = $"Delete From provider where id = {provider[id]}";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }

        public static List<string> GetProviderToUpdate(int id)
        {
            List<string> str = new List<string>();
            var cmd = GetNewCMD();
            cmd.CommandText = $"SELECT * FROM `provider` where id = {provider[id]}";
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    str.Add(rdr.GetString(1));
                    str.Add(rdr.GetString(2));
                    str.Add(rdr.GetString(3));
                    str.Add(rdr.GetString(4));
                }
            }
            cmd.Connection.Close();
            return str;
        }
        public static void UpdateProvider(string companyname, string providers, string phone, string address)
        {
            var x = GetNewCMD();
            x.CommandText = $"update `provider` set CompanyName = '{companyname}', Provider = '{providers}'," +
                $"Phone = '{phone}', Address = '{address}' where id = {provider[revId]}";
            Console.WriteLine(x.CommandText);
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        //Supply
        public static void InsertSupply(int providerID, string date)
        {
            var x = GetNewCMD();
            x.CommandText = $"insert into supply (SupplyerID, Date) values ({provider[providerID]}, '{date}')";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        public static void DeleteSupply(int id)
        {
            var x = GetNewCMD();
            x.CommandText = $"Delete From supply where id = {supply[id]}";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        //Order
        public static void InsertOrder(int productID, int employeesID, int clientID, string datePublish, string dateDone)
        {
            var x = GetNewCMD();
            x.CommandText = $"insert into `order` (product_id, employees_id, client_id, PublicateDate, ExecutionDate) values " +
                $"({product[productID]}, {employees[employeesID]}, {client[clientID]}, '{datePublish}', '{dateDone}')";
            Console.WriteLine(x.CommandText);
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        public static void DeleteOrder(int id)
        {
            var x = GetNewCMD();
            x.CommandText = $"Delete From  `order` where id = {order[id]}";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        //Product
        public static void InsertProduct(int supplyID, string name, string description, string image, double supplyerprice, string aviable, int count, double priceforsale)
        {
            var x = GetNewCMD();
            x.CommandText = $"insert into `product` (supply_id, Name, Description, Image, SupplyerPrice, Aviable, Count, PriceForSale) values " +
                $"({supply[supplyID]}, '{name}', '{description}', '{MySQLEscape(image)}', {supplyerprice}, '{aviable}', {count}, {priceforsale})";
            Console.WriteLine(x.CommandText);
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        public static void DeleteProduct(int id)
        {
            var x = GetNewCMD();
            x.CommandText = $"Delete From  `product` where id = {product[id]}";
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
        public static List<string> GetProductToUpdate(int id)
        {
            List<string> str = new List<string>();
            var cmd = GetNewCMD();
            cmd.CommandText = $"SELECT * FROM `product` where id = {product[id]}";
            cmd.Connection.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    str.Add(rdr.GetString(1));
                    str.Add(rdr.GetString(2));
                    str.Add(rdr.GetString(3));
                    str.Add(rdr.GetString(4));
                    str.Add(rdr.GetString(5));
                    str.Add(rdr.GetString(6));
                    str.Add(rdr.GetString(7));
                    str.Add(rdr.GetString(8));
                }
            }
            cmd.Connection.Close();
            return str;
        }
        public static void UpdateProduct(int supplyID, string name, string description, string image, double supplyerprice, string aviable, int count, double priceforsale)
        {
            var x = GetNewCMD();
            x.CommandText = $"update `product` set Name = '{name}', Description = '{description}'," +
                $"Image = '{MySQLEscape(image)}', SupplyerPrice = '{supplyerprice}', " +
                $"Aviable = '{aviable}', Count = '{count}', PriceForSale = '{priceforsale}' " +
                $"where id = {product[revId]}";
            Console.WriteLine(x.CommandText);
            x.Connection.Open();
            x.ExecuteNonQuery();
            x.Connection.Close();
        }
    }
}
