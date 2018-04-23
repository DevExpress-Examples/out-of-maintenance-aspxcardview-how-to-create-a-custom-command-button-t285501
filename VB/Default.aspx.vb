Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            TryCast(ASPxCardView1.CardLayoutProperties.Items(0), CardViewCommandLayoutItem).CustomButtons.Add(CreateCustomButton())
        End If
    End Sub

    Private Function CreateCustomButton() As CardViewCustomCommandButton
        Dim customBtn As New CardViewCustomCommandButton()
        customBtn.ID = "FilterBtn"
        customBtn.Text = "Filter"
        Return customBtn
    End Function
    Protected Sub ASPxCardView1_CustomButtonCallback(ByVal sender As Object, ByVal e As ASPxCardViewCustomButtonCallbackEventArgs)
        If e.ButtonID = "FilterBtn" Then
            Dim cardview As ASPxCardView = TryCast(sender, ASPxCardView)
            cardview.FilterExpression = "[Country] like '%Germany%'"
        End If
    End Sub
End Class