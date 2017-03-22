using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Part17DropDownList
{
    public partial class DropDownXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
           
            string strPhysicalPath = Server.MapPath("FoodMenu.xml");
            DS.ReadXml(strPhysicalPath);
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "calories";
            DropDownList1.DataSource = DS;
            DropDownList1.DataBind();

            ListItem li = new ListItem("Select");
            DropDownList1.Items.Insert(0, li);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}