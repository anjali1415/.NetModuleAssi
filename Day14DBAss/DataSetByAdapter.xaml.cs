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
using System.Windows.Shapes;

namespace DataBseExample
{
    /// <summary>
    /// Interaction logic for DataSetByAdapter.xaml
    /// </summary>
    public partial class DataSetByAdapter : Window
    {
        public DataSetByAdapter()
        {
            InitializeComponent();
        }
        DataSet ds;
        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString= @"Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = jkDac20;
             Integrated Security = True;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee2";

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;// selecting from DB as per query
             ds = new DataSet();
            adp.Fill(ds, "Emp");// adding record with table name emp in dataset
            dsGrid.ItemsSource = ds.Tables["Emp"].DefaultView;
           

            //cmd.CommandText = "select * from department";
            //adp.SelectCommand = cmd;
           // adp.Fill(ds, "Dept");
            //dsGrid.ItemsSource = ds.Tables["Dept"].DefaultView;

            // Pk validation
           /* DataColumn[] dc = new DataColumn[1];// as one pk
            dc[0] = ds.Tables["Emp"].Columns["EmpNo"];
            ds.Tables["Emp"].PrimaryKey = dc;
            //fk validation
            ds.Relations.Add(ds.Tables["Dept"].Columns["DeptNo"], ds.Tables["Emp"].Columns["DeptNo"]);
            */
            con.Close();
        }

        private void tbnUpDelIns_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = jkDac20; Integrated Security = True;";
            con.Open();
            //update
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update employee2 set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";
            /*SqlParameter p = new SqlParameter();
            p.ParameterName = "@Name";
            p.SourceColumn =  "Name";
            p.SourceVersion = DataRowVersion.Current;
            cmd.Parameters.Add(p);*/
            //or
            
            cmd.Parameters.Add(new SqlParameter { ParameterName="@Name",SourceColumn="Name",SourceVersion=DataRowVersion.Current });
            //cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName="@Basic",SourceVersion=DataRowVersion.Current,SourceColumn="Basic"});
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

            //delete
            SqlCommand cmdDel = new SqlCommand();
            cmdDel.Connection = con;
            cmdDel.CommandType = CommandType.Text;
            cmdDel.CommandText = "delete from employee2 where EmpNo=@EmpNo";

            cmdDel.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });
            //insert
            SqlCommand cmdInsert = new SqlCommand();
             cmdInsert.Connection = con;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = "Insert into Employee2 values (@EmpNo,@Name,@Basic,@DeptNo)";

            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceVersion = DataRowVersion.Current, SourceColumn = "Name" });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceVersion = DataRowVersion.Current, SourceColumn = "Basic" });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceVersion = DataRowVersion.Current, SourceColumn = "DeptNo" });
            
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.UpdateCommand = cmd;
            adp.DeleteCommand = cmdDel;
            adp.InsertCommand = cmdInsert;
            adp.Update(ds, "Emp");

           
           // adp.Update(ds,"Emp");
        }

        private void btnByGetChanges_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = jkDac20; Integrated Security = True;";
            con.Open();
            //update
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update employee2 set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";
            

            cmd.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            //cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceVersion = DataRowVersion.Current, SourceColumn = "Basic" });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

            //delete
            SqlCommand cmdDel = new SqlCommand();
            cmdDel.Connection = con;
            cmdDel.CommandType = CommandType.Text;
            cmdDel.CommandText = "delete from employee2 where EmpNo=@EmpNo";

            cmdDel.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });
            //insert
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = con;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = "Insert into Employee2 values (@EmpNo,@Name,@Basic,@DeptNo)";

            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceVersion = DataRowVersion.Current, SourceColumn = "Name" });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceVersion = DataRowVersion.Current, SourceColumn = "Basic" });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceVersion = DataRowVersion.Current, SourceColumn = "DeptNo" });

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.UpdateCommand = cmd;
            adp.DeleteCommand = cmdDel;
            adp.InsertCommand = cmdInsert;
             adp.Update(ds, "Emp");
            DataSet ds2 = ds.GetChanges();//
            //DataSet ds2 = ds.GetChanges(DataRowState.Modified);// Get only modified rows from dataset 
            //so no need to search for all
             adp.Update(ds2, "Emp");
              ds.AcceptChanges();//commit all changes
            //ds.RejectChanges();
            //adp.ModifiedChanges();
            //adp.modifiedcha




        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            DataView dv = new DataView();

            ds.Tables["Emp"].DefaultView.RowFilter = "DeptNo=" + txtBoxFltr.Text;

            //DataView dv = new DataView(ds.Tables["Emps"]);
            //dv.RowFilter = "DeptNo=" + txtDeptNo.Text;  //where clause
            //                                            //dv.Sort = "Name"; // order by clause
            //dgEmps.ItemsSource = dv;


            //ds.Tables["Emps"].DefaultView.RowFilter = "DeptNo=" + txtDeptNo.Text;
            //ds.Tables["Emps"].DefaultView.RowFilter = "";
        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
           // ds.Tables["Emp"].DefaultView.Sort = "Name";
            ds.Tables["Emp"].DefaultView.Sort = txtBoxSort.Text;
           
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // for taking data in Xml format 
            //MessageBox.Show(ds.GetXml()); Get in xml format
            //MessageBox.Show( ds.GetXmlSchema()); Get in xml with constraint
             
            //ds.WriteXmlSchema("a.xsd");
            ds.WriteXml("abc.xml", XmlWriteMode.DiffGram);
        }
    }
}
