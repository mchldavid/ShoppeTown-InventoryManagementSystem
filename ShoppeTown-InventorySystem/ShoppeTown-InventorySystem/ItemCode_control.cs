using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppeTown_InventorySystem
{
    public partial class ItemCode_control : UserControl
    {
        public ItemCode_control()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void btnAddItemCode_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            defaultSetting();

            for (int x = 0; x < md.showCategory().Length; x++)//for listing ng mga category name
            {
                if(md.showCategory().GetValue(x).ToString() != "")
                    cboCategoryName.Items.Add(md.showCategory().GetValue(x).ToString());
            }
            pnlRegisterItemCode.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlRegisterItemCode.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            md.RegisterItemCode(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text, cboBrand.Text, cboModel.Text, txtDescription.Text);
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            if (btnCreate1.Text == "New")
            {
                cboCategoryName.Visible = false;
                txtNewCode.Visible = true;
                btnCreate1.Text = "Save";
                btnCancel1.Visible = true;
                txtNewCode.Text = "";
            }
            else
            {
                defaultSetting();//to default registration of item code

                btnCancel1.Visible = false;
                btnCreate1.Text = "New";

                md.InsertCategory(txtCategoryName.Text, txtNewCode.Text);//inserting category
                cboCategoryName.Items.Clear();
                cboCategoryName.Visible = true;
                for (int x = 0; x < md.showCategory().Length; x++)//for listing ng mga category name
                {
                    if (md.showCategory().GetValue(x).ToString() != "")
                        cboCategoryName.Items.Add(md.showCategory().GetValue(x).ToString());
                }

                txtNewCode.Visible = false;
                cboCategoryName.Text = txtCategoryName.Text;
                txtCategoryName.Text = "";

                cboCategoryName_SelectedIndexChanged(sender, e);
            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            btnCreate1.Text = "New";
            cboCategoryName.Visible = true;
            txtNewCode.Visible= false;
            btnCancel1.Visible = false;
        }

        private void cboCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate2.Visible = true;
            cboSubCat.Visible = true;
            cboSubCat.Items.Clear();
            lblSubcat.Visible = true;
            txtCode.Text = md.sCode(cboCategoryName.Text);
            for (int x = 0; x < md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).Length; x++)//for listing ng mga category name
            {
                if (md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).GetValue(x).ToString() != "")
                    cboSubCat.Items.Add(md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).GetValue(x).ToString());
            }

            regItemCode.previewCode_1 = txtCode.Text;
            lblPreviewItemCode.Text = regItemCode.previewCode_1;
        }

        public void defaultSetting()
        {
            cboCategoryName.Items.Clear();
            cboSubCat.Items.Clear();
            cboItemName.Items.Clear();
            cboBrand.Items.Clear();
            cboModel.Items.Clear();
            txtDescription.Text = "";

            txtNewSubCategory.Visible = false;
            txtNewItemName.Visible = false;
            txtNewBrand.Visible = false;

            cboSubCat.Visible = false;
            cboItemName.Visible = false;
            cboBrand.Visible = false;
            cboModel.Visible = false;
            txtDescription.Visible = false;

            btnCreate2.Visible = false;
            btnCreate3.Visible = false;
            btnCreate4.Visible = false;

            btnCancel2.Visible = false;
            btnCancel3.Visible = false;
            btnCancel4.Visible = false;

            lblSubcat.Visible = false;
            lblitemname.Visible = false;
            lblBrand.Visible = false;
            lblModel.Visible = false;
            lblDescription.Visible = false;
            lblPreviewItemCode.Text = "------";
        }

        private void btnCreate2_Click(object sender, EventArgs e)
        {
            if (btnCreate2.Text == "New")
            {
                txtNewSubCategory.Visible = true;
                btnCreate2.Text = "Save";
                btnCancel2.Visible = true;;
            }
            else
            {
                btnCreate2.Text = "New";
                txtNewSubCategory.Visible = false;
                btnCancel2.Visible = false;
                md.InsertSubCategory(cboCategoryName.Text, txtCode.Text, txtNewSubCategory.Text);//inserting new subcategory
                cboSubCat.Items.Clear();
                for (int x = 0; x < md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).Length; x++)//for listing ng mga category name
                {
                    if (md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).GetValue(x).ToString() != "")
                        cboSubCat.Items.Add(md.ShowSubCategory(cboCategoryName.Text, txtCode.Text).GetValue(x).ToString());
                }
                cboSubCat_SelectedIndexChanged(sender, e);
                cboSubCat.Text = txtNewSubCategory.Text;
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            btnCancel2.Visible = false;
            btnCreate2.Text = "New";
            txtNewSubCategory.Visible = false;
        }

        private void cboSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate3.Visible = true;
            cboItemName.Visible = true;
            cboItemName.Items.Clear();
            lblitemname.Visible = true;
            for (int x = 0; x < md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).Length; x++)//for listing ng mga item name
            {
                if (md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).GetValue(x).ToString() != "")
                    cboItemName.Items.Add(md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).GetValue(x).ToString());
            }

            regItemCode.previewCode_2 = md.sSubCat(cboCategoryName.Text, txtCode.Text, cboSubCat.Text);
            lblPreviewItemCode.Text = regItemCode.previewCode_1 + regItemCode.previewCode_2;
        }

        private void btnCreate3_Click(object sender, EventArgs e)
        {
            if (btnCreate3.Text == "New")
            {
                txtNewItemName.Visible = true;
                btnCreate3.Text = "Save";
                btnCancel3.Visible = true; ;
            }
            else
            {
                btnCreate3.Text = "New";
                txtNewItemName.Visible = false;
                btnCancel3.Visible = false;
                md.InsertItemName(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, txtNewItemName.Text);//inserting new ITEMNAME
                cboItemName.Items.Clear();
                for (int x = 0; x < md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).Length; x++)//for listing ng mga ITEM name
                {
                    if (md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).GetValue(x).ToString() != "")
                        cboItemName.Items.Add(md.ShowItems(cboCategoryName.Text, txtCode.Text, cboSubCat.Text).GetValue(x).ToString());
                }
                cboItemName_SelectedIndexChanged(sender, e);
                cboItemName.Text = txtNewItemName.Text;
            }
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            btnCancel3.Visible = false;
            btnCreate3.Text = "New";
            txtNewItemName.Visible = false;
        }

        private void cboItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate4.Visible = true;
            cboBrand.Visible = true;
            cboBrand.Items.Clear();
            cboBrand.Items.Add("Generic");
            cboBrand.SelectedIndex = 0;
            lblBrand.Visible = true;
            for (int x = 0; x < md.ShowBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text).Length; x++)//for listing ng mga item name
            {
                if (md.ShowBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text).GetValue(x).ToString() != "")
                    cboBrand.Items.Add(md.ShowBrand(cboCategoryName.Text, txtCode.Text, cboSubCat.Text, cboItemName.Text).GetValue(x).ToString());
            }

            regItemCode.previewCode_2 = md.sSubCat(cboCategoryName.Text, txtCode.Text, cboSubCat.Text);
            lblPreviewItemCode.Text = regItemCode.previewCode_1 + regItemCode.previewCode_2;
        }

        private void btnCreate4_Click(object sender, EventArgs e)
        {

        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
