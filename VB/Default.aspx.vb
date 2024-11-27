Imports System
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports DevExpress.Web

Namespace HyperlinkColumn

    Public Partial Class _Default
        Inherits Page

        Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
            ASPxGridView1.KeyFieldName = "ID"
            ASPxGridView1.DataSource = GetData()
            If Not IsPostBack AndAlso Not IsCallback Then
                PopulateColumns()
                ASPxGridView1.DataBind()
            End If
        End Sub

        Public Function GetData() As DataTable
            Dim Table As DataTable = New DataTable()
            Table.Columns.Add("ID", GetType(Integer))
            Table.Columns.Add("ItemName", GetType(String))
            Table.Rows.Add(1, "A")
            Table.Rows.Add(2, "B")
            Return Table
        End Function

        Public Sub PopulateColumns()
            Dim colID As GridViewDataTextColumn = New GridViewDataTextColumn()
            colID.FieldName = "ID"
            ASPxGridView1.Columns.Add(colID)
            Dim colItemName As GridViewDataHyperLinkColumn = New GridViewDataHyperLinkColumn()
            colItemName.FieldName = "ItemName"
            colItemName.PropertiesHyperLinkEdit.NavigateUrlFormatString = "~/details.aspx?Device={0}"
            colItemName.PropertiesHyperLinkEdit.TextFormatString = "Get details about device {0}"
            colItemName.PropertiesHyperLinkEdit.TextField = "ItemName"
            ASPxGridView1.Columns.Add(colItemName)
        End Sub
    End Class
End Namespace
