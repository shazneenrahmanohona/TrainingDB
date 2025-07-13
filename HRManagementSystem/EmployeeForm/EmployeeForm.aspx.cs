using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRManagementSystem.EmployeeForm.aspx
{
    public partial class EmployeeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblEmployeeName.Text = string.Empty;
            lblEmployeeName.Text = txtEmployeeName.Text;
            lblPhoneNumber.Text = string.Empty;
            lblPhoneNumber.Text = txtPhoneNumber.Text;
            lblEmailAddress.Text = string.Empty;
            lblEmailAddress.Text = txtEmailAddress.Text;
        }

       

        protected void BloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}