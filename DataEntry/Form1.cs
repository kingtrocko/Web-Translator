using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsConversor.measure_types' table. You can move, or remove it, as needed.
            this.measure_typesTableAdapter.Fill(this.dsConversor.measure_types);
            // TODO: This line of code loads data into the 'dsConversor.measures' table. You can move, or remove it, as needed.
            this.measuresTableAdapter.Fill(this.dsConversor.measures);
            // TODO: This line of code loads data into the 'dsConversor.sub_categories' table. You can move, or remove it, as needed.
            this.sub_categoriesTableAdapter.Fill(this.dsConversor.sub_categories);
            // TODO: This line of code loads data into the 'dsConversor.equivalences' table. You can move, or remove it, as needed.
            this.equivalencesTableAdapter.Fill(this.dsConversor.equivalences);
            // TODO: This line of code loads data into the 'dsConversor.measures' table. You can move, or remove it, as needed.
            this.measuresTableAdapter.Fill(this.dsConversor.measures);
            // TODO: This line of code loads data into the 'dsConversor.sub_categories' table. You can move, or remove it, as needed.
            this.sub_categoriesTableAdapter.Fill(this.dsConversor.sub_categories);
            // TODO: This line of code loads data into the 'dsConversor.measure_types' table. You can move, or remove it, as needed.
            this.measure_typesTableAdapter.Fill(this.dsConversor.measure_types);
            // TODO: This line of code loads data into the 'dsConversor.families' table. You can move, or remove it, as needed.
            this.familiesTableAdapter.Fill(this.dsConversor.families);

        }        

        private void btnSaveFamily_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFamilyName.Text))
            {
                Data.dsConversorTableAdapters.familiesTableAdapter f = new Data.dsConversorTableAdapters.familiesTableAdapter();
                f.AddFamily(txtFamilyName.Text);

                txtFamilyName.Text = "";
                gvFamilies.DataSource = f.GetData();
                cmbFamily.DataSource = f.GetData();

                f.Dispose();
            }
            else
                MessageBox.Show("Ingrese nombre de Familia");
        }

        private void btnSaveUnitTypes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnitTypeName.Text) && cmbFamily.SelectedIndex != -1)
            {
                Data.dsConversorTableAdapters.measure_typesTableAdapter m = new Data.dsConversorTableAdapters.measure_typesTableAdapter();
                m.AddMeasureType(txtUnitTypeName.Text, int.Parse(cmbFamily.SelectedValue.ToString()));

                txtUnitTypeName.Text = "";

                gvUnitTypes.DataSource = m.GetData();
                cmbUnitType.DataSource = m.GetData();

                m.Dispose();
            }
            else
                MessageBox.Show("Ingrese nombre de tipo de medida");
        }

        //Sub Categorias Salvar
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubCategName.Text) && cmbUnitType.SelectedIndex != -1)
            {
                try
                {
                    Data.dsConversorTableAdapters.sub_categoriesTableAdapter categ = new Data.dsConversorTableAdapters.sub_categoriesTableAdapter();
                    Data.dsConversorTableAdapters.measure_typesTableAdapter m = new Data.dsConversorTableAdapters.measure_typesTableAdapter();

                    categ.InsertSubCategory(txtSubCategName.Text, Convert.ToInt32(cmbUnitType.SelectedValue.ToString()));

                    txtSubCategName.Text = "";

                    gvSubCategs.DataSource = categ.GetData();
                    comboBox1.DataSource = m.GetData();

                    comboBox1.DisplayMember = "name";
                    comboBox1.ValueMember = "id";

                    cmbSubCateg.DataSource = null;

                    categ.Dispose();
                }
                catch (Exception ex)
                {
                    string s = ex.Message;
                }
            }
            else
                MessageBox.Show("Ingrese el nombre de la categoria");
        }

        private void btnSaveUnits_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnitName.Text) && cmbSubCateg.SelectedIndex != -1)
            {
                Data.dsConversorTableAdapters.measuresTableAdapter m = new Data.dsConversorTableAdapters.measuresTableAdapter();
                m.AddMeasures(txtUnitName.Text, int.Parse(cmbSubCateg.SelectedValue.ToString()));

                txtUnitName.Text = "";

                gvUnits.DataSource = m.GetData();
                cmbUnitFrom.DataSource = cmbUnitTo.DataSource = m.GetData();

                m.Dispose();

            }
            else
                MessageBox.Show("Ingrese el nombre de la unidad");

            txtUnitName.Focus();
        }

        private void btnSaveEquivalence_Click(object sender, EventArgs e)
        {
            if (cmbUnitFrom.SelectedIndex != -1 && cmbUnitTo.SelectedIndex != -1 && !string.IsNullOrEmpty(txtValue.Text))
            {
                Data.dsConversorTableAdapters.equivalencesTableAdapter eq = new Data.dsConversorTableAdapters.equivalencesTableAdapter();

                int From = Convert.ToInt32(cmbUnitFrom.SelectedValue.ToString());
                int To = Convert.ToInt32(cmbUnitTo.SelectedValue.ToString());
                double value = Convert.ToDouble(txtValue.Text);

                eq.AddEquivalence(From, To, Convert.ToDecimal(value));

                gvEquivalences.DataSource = eq.GetData();
                txtValue.Text = "";
                eq.Dispose();
            }
            else
                MessageBox.Show("No se inserto");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex != -1)
            {
                Data.dsConversorTableAdapters.sub_categories1TableAdapter s = new Data.dsConversorTableAdapters.sub_categories1TableAdapter();

                cmbSubCateg.DataSource = null;
                cmbSubCateg.DataSource = s.GetData(int.Parse(cmb.SelectedValue.ToString()));
                cmbSubCateg.DisplayMember = "name";
                cmbSubCateg.ValueMember = "id";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex != -1)
            {
                Data.dsConversorTableAdapters.measure_types_by_familyTableAdapter mt = new Data.dsConversorTableAdapters.measure_types_by_familyTableAdapter();

                cmbMeasureType2.DataSource = null;
                cmbMeasureType2.DataSource = mt.GetMeasureTypesByFamily(Convert.ToInt32(cmb.SelectedValue.ToString()));
                cmbMeasureType2.DisplayMember = "name";
                cmbMeasureType2.ValueMember = "id";


            }
        }

        private void cmbMeasureType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex != -1)
            {
                Data.dsConversorTableAdapters.sub_categories1TableAdapter s = new Data.dsConversorTableAdapters.sub_categories1TableAdapter();

                cmbCategs2.DataSource = null;

                DataRowView oDataRowView = cmb.SelectedItem as DataRowView;

                if (oDataRowView != null)
                    cmbCategs2.DataSource = s.GetData(int.Parse(oDataRowView.Row[0].ToString()));
                else
                    cmbCategs2.DataSource = s.GetData(int.Parse(cmb.SelectedValue.ToString()));

                
                cmbCategs2.DisplayMember = "name";
                cmbCategs2.ValueMember = "id";
            }
        }

        private void cmbCategs2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex != -1)
            {
                Data.dsConversorTableAdapters.measures_by_categoryTableAdapter m = new Data.dsConversorTableAdapters.measures_by_categoryTableAdapter();

                cmbUnitFrom.DataSource = cmbUnitTo.DataSource = null;

                DataRowView oDataRowView = cmb.SelectedItem as DataRowView;

                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();

                if (oDataRowView != null)
                {
                    dt = m.GetMeasuresByCategory(Convert.ToInt32(oDataRowView.Row[0].ToString()));
                    dt2 = m.GetMeasuresByCategory(Convert.ToInt32(oDataRowView.Row[0].ToString()));
                }
                else
                {
                    dt = m.GetMeasuresByCategory(Convert.ToInt32(cmb.SelectedValue.ToString()));
                    dt2 = m.GetMeasuresByCategory(Convert.ToInt32(cmb.SelectedValue.ToString()));
                }

                cmbUnitFrom.DataSource = dt;
                cmbUnitFrom.DisplayMember = "name";
                cmbUnitFrom.ValueMember = "id";

                cmbUnitTo.DataSource = dt2;
                cmbUnitTo.DisplayMember = "name";
                cmbUnitTo.ValueMember = "id";

            }
        }
    }
}