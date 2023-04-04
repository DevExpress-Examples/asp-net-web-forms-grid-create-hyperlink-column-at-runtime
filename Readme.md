<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128538710/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E308)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to create and configure a HyperLink column at runtime
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e308/)**
<!-- run online end -->


<p>This example demonstrates how to create a grid column of the type GridViewDataHyperLinkColumn programmatically. Columns are created on the first Page_Init event. Then, the grid automatically recreates columns from the view state on a callback or post back.</p>

![Hyperlink Column](hyperlink-column.png)

To create the HyperLink column at runtime follow the steps below.

1. Create an object of the [GridViewDataHyperLinkColumn](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewDataHyperLinkColumn) type.
2. Use the object's [PropertiesHyperLinkEdit](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewDataHyperLinkColumn.PropertiesHyperLinkEdit) property to customize the settings of the column's hyperlink editor.
3. Call the [Add](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewColumnCollection.Add(DevExpress.Web.GridViewColumn)) or [Insert](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewColumnCollection.Insert(System.Int32-DevExpress.Web.GridViewColumn)) method to add the newly created column to the grid column collection.

```cs
protected void Page_Init(object sender, EventArgs e) {
    ASPxGridView1.KeyFieldName = "ID";
    ASPxGridView1.DataSource = GetData();
    if (!IsPostBack && !IsCallback) {
        PopulateColumns();
        ASPxGridView1.DataBind();
    }
}

public void PopulateColumns() {
    // ...
    GridViewDataHyperLinkColumn colItemName = new GridViewDataHyperLinkColumn();
    colItemName.FieldName = "ItemName";
    colItemName.PropertiesHyperLinkEdit.NavigateUrlFormatString = "~/details.aspx?Device={0}";
    colItemName.PropertiesHyperLinkEdit.TextFormatString = "Get details about device {0}";
    colItemName.PropertiesHyperLinkEdit.TextField = "ItemName";
    ASPxGridView1.Columns.Add(colItemName);
}



```

https://github.com/LanaDX/how-to-create-and-configure-a-hyperlink-column-at-runtime-e308/blob/177a467c030babeffbe760b186028156557ae93a/CS/Default.aspx.cs#L40-L45

## Files to Review

* [Default.aspx.cs](./CS/Default.aspx.cs#L40-L45) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
