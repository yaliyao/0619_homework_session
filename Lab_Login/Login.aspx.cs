using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text == "")
        {
            lblPrompt.Text = "請檢查你的用戶名稱，然後再試一次。";
            return;
        }

        Session["userName"] = txtUserName.Text;

        if (Session["userName"] == null)
            Response.Redirect("Default.aspx");
        else
            Response.Redirect("Secret.aspx");
        
    }
}