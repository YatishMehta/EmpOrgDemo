using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vaultex_WebApplication
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridEmployee();
            }
        }

        private void BindGridEmployee()
        {
            string constr = ConfigurationManager.ConnectionStrings["sqlvaultex"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                SqlCommand cmd = new SqlCommand("_GetAllDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GridType", "Employee");
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                GridEmployee.DataSource = ds;
                GridEmployee.DataBind();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        protected void GridEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridEmployee.PageIndex = e.NewPageIndex;
            BindGridEmployee();
        }
    }
}