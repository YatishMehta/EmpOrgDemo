using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Vaultex_WebApplication
{
    public partial class OrganisationDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGridOrg();
            }          
        }

        private void BindGridOrg()
        {
            string constr = ConfigurationManager.ConnectionStrings["sqlvaultex"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                SqlCommand cmd = new SqlCommand("_GetAllDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GridType", "Organisation");
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                GridOrganisation.DataSource = ds;
                GridOrganisation.DataBind();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        protected void GridOrganisation_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridOrganisation.PageIndex = e.NewPageIndex;
            GridOrganisation.DataBind();
        }
    }

    
}