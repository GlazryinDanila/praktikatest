using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp23
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // Window1 win1 = new Window1();

        Window3 win3 = new Window3();
        Window4 win4 = new Window4();
        Window5 win5 = new Window5();
        Window6 win6 = new Window6();
        Window7 win7 = new Window7();
        Window8 win8 = new Window8();
        Window9 win9 = new Window9();
        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                            // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection("server=CAB212-4\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=vxod;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
            return dataTable;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            win3.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();

              win1.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            win7.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            win5.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            win4.Show();    
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            win6.Show();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            win8.Show();
        }
    }
}
