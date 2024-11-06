using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace BusquedaDinamicaDataGridView
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            PopulateComboBox();
        }

        private void LoadData()
        {
            string sCnn = "Server=localhost;Database=pruebaDB;Integrated Security = True;";
            string sSel = "SELECT * FROM Prueba ORDER BY ID";

            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sSel, sCnn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;
            }
        }

        private void PopulateComboBox()
        {
            foreach (DataColumn column in dataTable.Columns)
            {
                comboBoxColumns.Items.Add(column.ColumnName);
            }

            comboBoxColumns.SelectedIndex = 0;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxColumns.SelectedItem.ToString();
            string filterExpression = string.Empty;

            if (selectedColumn.Equals("id"))
            {
                if (int.TryParse(textSearch.Text, out int numericValue))
                    filterExpression = $"{selectedColumn} = {numericValue}";
                else
                {
                    bindingSource.RemoveFilter();
                    return;
                }
            }
            else
                filterExpression = $"{selectedColumn} LIKE '%{textSearch.Text}%'";

            bindingSource.Filter = filterExpression;
        }

    }
}
