using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        // Строка подключения к базе данных
        private string connectionString;

        // Набор данных для хранения информации из таблиц базы данных
        private DataSet dataSet;

        // Адаптеры для взаимодействия с таблицами "client", "service" и 
        private NpgsqlDataAdapter clientAdapter;
        private NpgsqlCommandBuilder clientBuilder;

        private NpgsqlDataAdapter serviceAdapter;
        private NpgsqlCommandBuilder serviceBuilder;

        private NpgsqlDataAdapter serviceCategoryAdapter;
        private NpgsqlCommandBuilder serviceCategoryBuilder;

        public Form1()
        {
            InitializeComponent();

            // Инициализация набора данных
            dataSet = new DataSet();

            // Получение строки подключения из файла конфигурации приложения
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

            // Создание адаптера для таблицы "client"
            clientAdapter = new NpgsqlDataAdapter("select * from client order by client.id asc;", connectionString);

            // Заполнение набора данных данными из таблицы "client"
            clientAdapter.Fill(dataSet, "client");

            // Создание строителя команд для адаптера "client"
            clientBuilder = new NpgsqlCommandBuilder(clientAdapter);

            // Установка источника данных для DataGridView "dataGridViewClients"
            dataGridViewClients.DataSource = dataSet.Tables["client"];

            // Создание адаптера для таблицы "service_category"
            serviceCategoryAdapter = new NpgsqlDataAdapter("select * from service_category order by service_category.id asc;", connectionString);

            // Заполнение набора данных данными из таблицы "service_category"
            serviceCategoryAdapter.Fill(dataSet, "serviceCategory");

            // Создание строителя команд для адаптера "service_category"
            serviceCategoryBuilder = new NpgsqlCommandBuilder(serviceCategoryAdapter);

            // Заполнение ComboBox с категориями услуг
            FillServiceCategoryComboBox();

            // Создание адаптера для таблицы "service"
            serviceAdapter = new NpgsqlDataAdapter("select * from service order by service.id asc;", connectionString);

            // Заполнение набора данных данными из таблицы "service"
            serviceAdapter.Fill(dataSet, "service");

            // Создание строителя команд для адаптера "service"
            serviceBuilder = new NpgsqlCommandBuilder(serviceAdapter);

            // Установка источника данных для DataGridView "dataGridViewService"
            dataGridViewService.DataSource = dataSet.Tables["service"];
        }

        // Заполнение ComboBox с категориями услуг
        private void FillServiceCategoryComboBox()
        {
            // Получение колонки ComboBox из DataGridView "dataGridViewService"
            DataGridViewComboBoxColumn comboBox = (DataGridViewComboBoxColumn)dataGridViewService.Columns["ServiceCategoryCol"];

            // Установка источника данных для ComboBox
            comboBox.DataSource = dataSet.Tables["serviceCategory"];

            // Установка отображаемого значения для ComboBox
            comboBox.DisplayMember = "name";

            // Установка значения для ComboBox
            comboBox.ValueMember = "id";

            // Установка источника данных для ComboBox "Report2CategorySelect"
            Report2CategorySelect.DataSource = dataSet.Tables["serviceCategory"];

            // Установка отображаемого значения для ComboBox
            Report2CategorySelect.DisplayMember = "name";

            // Установка значения для ComboBox
            Report2CategorySelect.ValueMember = "id";
        }

        // Обработка события нажатия на кнопку "Сохранить изменения в таблице "client""
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Обновление таблицы "client" в базе данных 
                clientAdapter.Update(dataSet, "client");

                // Отображение сообщения об успешном сохранении изменений
                MessageBox.Show(this, "Changes saved successfully");
            }
            catch
            {
                // Отображение сообщения об ошибке при сохранении изменений
                MessageBox.Show(this, "Something went wrong");
            }
        }

        // Обработка события нажатия на кнопку "Сохранить изменения в таблице "service""
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Обновление таблицы "service" в базе данных 
                serviceAdapter.Update(dataSet, "service");

                // Отображение сообщения об успешном сохранении изменений
                MessageBox.Show(this, "Changes saved successfully");
            }
            catch
            {
                // Отображение сообщения об ошибке при сохранении изменений
                MessageBox.Show(this, "Something went wrong");
            }
        }

        // Обработка события нажатия на кнопку "Создать отчет 1"
        private void button3_Click(object sender, EventArgs e)
        {
            // Создание подключения к базе данных
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                // Создание команды для выполнения запроса к базе данных
                NpgsqlCommand sqlCommand = new NpgsqlCommand("select * from get_clients_by_birth_year($1)", sqlConnection)
                {
                    // Установка параметра для запроса
                    Parameters =
                    {
                        // Создание параметра с именем "$1" и значением из "Report1YearInput"
                        new NpgsqlParameter(){Value = (int)Report1YearInput.Value},
                    }
                };
                // Открытие подключения к базе данных
                sqlConnection.Open();

                // Создание адаптера для выполнения запроса
                var sqlAdapter = new NpgsqlDataAdapter(sqlCommand);

                // Создание таблицы для хранения результатов запроса
                DataTable dataTable = new DataTable("report1");

                // Заполнение таблицы данными из запроса
                sqlAdapter.Fill(dataTable);

                // Установка источника данных для DataGridView "dataGridViewReport1"
                dataGridViewReport1.DataSource = dataTable;
            }
        }

        // Обработка события нажатия на кнопку "Создать отчет 2"
        private void button4_Click(object sender, EventArgs e)
        {
            // Создание подключения к базе данных
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                // Открытие подключения к базе данных
                sqlConnection.Open();

                // Создание команды для выполнения запроса к базе данных
                NpgsqlCommand sqlCommand = new NpgsqlCommand("select * from service where service_category_id = " + Report2CategorySelect.SelectedValue, sqlConnection);

                // Выполнение запроса к базе данных
                NpgsqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Создание таблицы для хранения результатов запроса
                DataTable dataTable = new DataTable("report2");

                // Добавление колонок в таблицу
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Class cost");

                // Чтение данных из результата запроса
                while (sqlDataReader.Read())
                {
                    // Создание новой строки в таблице
                    DataRow row = dataTable.NewRow();

                    // Заполнение строки данными
                    row["Name"] = sqlDataReader["name"];
                    row["Class cost"] = sqlDataReader["class_cost"];

                    // Добавление строки в таблицу
                    dataTable.Rows.Add(row);
                }

                // Закрытие объекта "sqlDataReader"
                sqlDataReader.Close();

                // Установка источника данных для DataGridView "dataGridViewReport2"
                dataGridViewReport2.DataSource = dataTable;
            }
        }
    }
}
