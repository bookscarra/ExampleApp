using Microsoft.Ajax.Utilities;
using Serilog;
using ShapeLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppT1
{
    public partial class _Default : Page
    {
        private enum Selection
        {
            Rectangle,
            Square,
            Ellipsis,
            Circle,
            Textbox
        }

        private BillOfMaterial BillOfMaterial
        {
            get
            {
                return (BillOfMaterial)Session["BOM"];
            }
            set
            {
                Session["BOM"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BillOfMaterial = new BillOfMaterial();
                litData.Text = "";
                btnAdd.CommandArgument = Selection.Rectangle.ToString();
            }
        }

        protected void btnRectangle_Click(object sender, EventArgs e)
        {
            lblWidth.Text = "Width:";
            lblHeight.Text = "Height:";
            pnlHeight.Visible = true;
            pnlTExt.Visible = false;
            btnAdd.CommandArgument = Selection.Rectangle.ToString();
            SetSelection((Button)sender);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            BillOfMaterial.Clear();
            litData.Text = "";
            txtReport.Text = "";
        }

        protected void btnSquare_Click(object sender, EventArgs e)
        {
            lblWidth.Text = "Width:";
            pnlHeight.Visible = false;
            pnlTExt.Visible = false;
            btnAdd.CommandArgument = Selection.Square.ToString();
            SetSelection((Button)sender);
        }

        protected void btnElipsis_Click(object sender, EventArgs e)
        {
            lblWidth.Text = "Horizontal Diameter:";
            lblHeight.Text = "Vertical Diameter:";
            pnlHeight.Visible = true;
            pnlTExt.Visible = false;
            btnAdd.CommandArgument = Selection.Ellipsis.ToString();
            SetSelection((Button)sender);
        }

        protected void btnCircle_Click(object sender, EventArgs e)
        {
            lblWidth.Text = "Diameter:";
            pnlHeight.Visible = false;
            pnlTExt.Visible = false;
            btnAdd.CommandArgument = Selection.Circle.ToString();
            SetSelection((Button)sender);
        }

        protected void btnTextbox_Click(object sender, EventArgs e)
        {
            lblWidth.Text = "Width:";
            lblHeight.Text = "Height:";
            pnlHeight.Visible = true;
            pnlTExt.Visible = true;
            txtText.Text = "";
            btnAdd.CommandArgument = Selection.Textbox.ToString();
            SetSelection((Button)sender);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (!Page.IsValid)
                return;

            try
            {
                short posX = short.Parse(txtPositionX.Text);
                short posY = short.Parse(txtPositionY.Text);
                short width = short.Parse(txtWidth.Text);
                short height = short.Parse(txtHeight.Text);


                litData.Text += $"{btnAdd.CommandArgument}<br />";
                switch (Enum.Parse(typeof(Selection), btnAdd.CommandArgument))
                {
                    case Selection.Rectangle:
                        BillOfMaterial.AddShape(new Rectangle(posX, posY, width, height));
                        break;
                    case Selection.Square:
                        BillOfMaterial.AddShape(new Square(posX, posY, width));
                        break;
                    case Selection.Ellipsis:
                        BillOfMaterial.AddShape(new Ellipse(posX, posY, width, height));
                        break;
                    case Selection.Circle:
                        BillOfMaterial.AddShape(new Circle(posX, posY, width));
                        break;
                    case Selection.Textbox:
                        BillOfMaterial.AddShape(new Textbox(posX, posY, width, height, txtText.Text));
                        break;
                    default:
                    break;
                }

            }
            catch (Exception ex)
            {
                Log.Error(ex, "Could not parse data");
                return;
            }


        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            txtReport.Text = BillOfMaterial.GenerateBillOfMaterials().Replace(Environment.NewLine, "<br />");
        }

        protected void SetSelection(Button btn)
        {
            btnCircle.CssClass = "btn btn-default";
            btnSquare.CssClass = "btn btn-default";
            btnTextbox.CssClass = "btn btn-default";
            btnElipsis.CssClass = "btn btn-default";
            btnRectangle.CssClass = "btn btn-default";
            btn.CssClass = "btn btn-primary";
        }

    }
}