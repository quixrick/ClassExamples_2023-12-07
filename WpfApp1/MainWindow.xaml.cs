using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        List<string> shapeNames;
        Shapes tempShape;

        public MainWindow()
        {
            InitializeComponent();
            shapeNames = new List<string>();
            GetDataForCombo();
            cmbShapeNames.ItemsSource = shapeNames;
        }

        private void btnGetInfo_Click(object sender, RoutedEventArgs e)
        {
            string nameOfShape = cmbShapeNames.SelectedItem.ToString();
            
        }

        
        private void GetDataForCombo()
        {
            string sqlStr = "SELECT * FROM Volume";
            string connStr = ConfigurationManager.ConnectionStrings["ShapesDB"].ConnectionString;
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand selectCmd = new SqlCommand(sqlStr, conn);
                conn.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while(dr.Read())
                {
                    shapeNames.Add(dr.GetString(1));
                }
            }
        }
        private void GetData(string nameOfShape)
        {
            string sqlLength = "SELECT Length FROM Volume WHERE Name = '" + nameOfShape + "'";
            string sqlWidth = "SELECT Width FROM Volume WHERE Name = '" + nameOfShape + "'";
            string sqlHeight = "SELECT Height FROM Volume WHERE Name = '" + nameOfShape + "'";

            float length, width, height;

            string connStr = ConfigurationManager.ConnectionStrings["ShapesDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand selectCmd = new SqlCommand(sqlLength, conn);
                conn.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();

                dr.Read();
                length = (float)dr.GetDouble(0);
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand selectCmd = new SqlCommand(sqlWidth, conn);
                conn.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();

                dr.Read();
                width = (float)dr.GetDouble(0);
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand selectCmd = new SqlCommand(sqlHeight, conn);
                conn.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();

                dr.Read();
                height = (float)dr.GetDouble(0);
            }
            
            if (nameOfShape == "Cube") {
                tempShape = new Cube(nameOfShape, length, width, height);
            }
            else if (nameOfShape == "Sphere") {
                tempShape = new Sphere(nameOfShape, length, width, height);
            }
            else if (nameOfShape == "Pyramid") {
                tempShape = new Pyramid(nameOfShape, length, width, height);
            }

            txbResults.Text = tempShape.ToString();
        }

        


    }
}
