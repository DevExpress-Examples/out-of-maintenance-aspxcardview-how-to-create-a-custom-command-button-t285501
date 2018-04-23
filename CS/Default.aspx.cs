using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            (ASPxCardView1.CardLayoutProperties.Items[0] as CardViewCommandLayoutItem).CustomButtons.Add(CreateCustomButton());
        }
    }

    CardViewCustomCommandButton CreateCustomButton()
    {
        CardViewCustomCommandButton customBtn = new CardViewCustomCommandButton();
        customBtn.ID = "FilterBtn";
        customBtn.Text = "Filter";
        return customBtn;
    }
    protected void ASPxCardView1_CustomButtonCallback(object sender, ASPxCardViewCustomButtonCallbackEventArgs e)
    {
        if (e.ButtonID == "FilterBtn")
        {
            ASPxCardView cardview = sender as ASPxCardView;
            cardview.FilterExpression = "[Country] like '%Germany%'";
        }
    }
}