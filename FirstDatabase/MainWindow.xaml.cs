//NAME: Cole Weston
//DATE: 2/12/2019
//FILE NAME: MainWindow.xaml.cs
//FILE PURPOSE: Demonstrate Access Database Retrieval 
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace FirstDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection cn;
        public MainWindow()
        {
            cn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\\Users\\colew\\Source\\Repos\\MyFirstDatabase\\FirstDatabase\\CloneDataBase.accdb");
            //InitializeComponent();
            
        }

        private void See_Assets_Click(object sender, RoutedEventArgs e)
        {
            string query = "select* from Assets"; 
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";
            string dataTwo = "";
            string dataThree = "";
            while (read.Read())
            {
                data += read[0].ToString() + "\n";
                dataTwo += read[1].ToString() + "\n";
                dataThree += read[2].ToString() + "\n";
            }
            TextArea.Text = data;
            TextArea_Copy.Text = dataTwo;
            TextArea_Copy1.Text = dataThree;
            cn.Close();
        }

        private void DisplayEmployees_Click(object sender, RoutedEventArgs e)
        {
            string query = "select* from Clones";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";
            string dataTwo = "";
            string dataThree = "";
            while (read.Read())
            {
                data += read[0].ToString() + "\n";
                dataTwo += read[1].ToString() + "\n";
                dataThree += read[2].ToString() + "\n";
            }
            TextArea_Copy2.Text = data;
            TextArea_Copy3.Text = dataTwo;
            TextArea_Copy4.Text = dataThree;
            cn.Close();
        }
    }
}
