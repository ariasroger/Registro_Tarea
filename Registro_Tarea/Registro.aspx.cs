using Registro_Tarea.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro_Tarea
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            protected void btnLogin_ServerClick(object sender, EventArgs e)
            {
                FirebaseUser user = new FirebaseUser()
                {
                    email = txtEmail.Value,
                    password = txtPwd.Value
                };

                RegistrerController registrerController = new RegistrerController();

                if (registrerController.FirebaseAuth(user))
                {
                    Session["session"] = true;



                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Login approved')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Login denied')", true);
                }

            }

        }
    }
}