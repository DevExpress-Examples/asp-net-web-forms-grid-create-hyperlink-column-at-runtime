using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;

namespace HyperlinkColumn {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView1.KeyFieldName = "ID";
            ASPxGridView1.DataSource = GetData();
            if (!IsPostBack && !IsCallback) {
                PopulateColumns();
                ASPxGridView1.DataBind();
            }
        }

        public DataTable GetData() {
            DataTable Table = new DataTable();
            Table.Columns.Add("ID", typeof(int));
            Table.Columns.Add("ItemName", typeof(string));
            Table.Rows.Add(1, "A");
            Table.Rows.Add(2, "B");
            return Table;
        }

        public void PopulateColumns() {
            GridViewDataTextColumn colID = new GridViewDataTextColumn();
            colID.FieldName = "ID";
            ASPxGridView1.Columns.Add(colID);

            GridViewDataHyperLinkColumn colItemName = new GridViewDataHyperLinkColumn();
            colItemName.FieldName = "ItemName";
            colItemName.PropertiesHyperLinkEdit.NavigateUrlFormatString = "~/details.aspx?Device={0}";
            colItemName.PropertiesHyperLinkEdit.TextFormatString = "Get details about device {0}";
            colItemName.PropertiesHyperLinkEdit.TextField = "ItemName";
            ASPxGridView1.Columns.Add(colItemName);
        }
    }
}
