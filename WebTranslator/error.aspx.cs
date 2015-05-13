using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTranslator
{
    public partial class error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Exception objErr = Server.GetLastError().GetBaseException();
            string err = "Error Caught \n" +
                    "Error in: " + Request.Url.ToString() +
                    "\nError Message:" + objErr.Message.ToString() +
                    "\nStack Trace:" + objErr.StackTrace.ToString();

            this.msj.InnerText = err;

            Server.ClearError();
        }
    }
}