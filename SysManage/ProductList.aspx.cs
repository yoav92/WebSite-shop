﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_ProductList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var ArrProd = Application["ArrP"] as List<Product>;
            RptProds.DataSource = ArrProd;
            RptProds.DataBind();
        }

    }

    
}