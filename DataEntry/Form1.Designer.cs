namespace DataEntry
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gvFamilies = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsConversorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsConversor = new DataEntry.Data.dsConversor();
            this.btnSaveFamily = new System.Windows.Forms.Button();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbFamily = new System.Windows.Forms.ComboBox();
            this.familiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.gvUnitTypes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measuretypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveUnitTypes = new System.Windows.Forms.Button();
            this.txtUnitTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbUnitType = new System.Windows.Forms.ComboBox();
            this.measuretypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.gvSubCategs = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubCategName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.measuretypesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSubCateg = new System.Windows.Forms.ComboBox();
            this.gvUnits = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveUnits = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbCategs2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbMeasureType2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.familiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.gvEquivalences = new System.Windows.Forms.DataGridView();
            this.equivalencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveEquivalence = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUnitTo = new System.Windows.Forms.ComboBox();
            this.measuresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUnitFrom = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.subcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familiesTableAdapter = new DataEntry.Data.dsConversorTableAdapters.familiesTableAdapter();
            this.measure_typesTableAdapter = new DataEntry.Data.dsConversorTableAdapters.measure_typesTableAdapter();
            this.measuresTableAdapter = new DataEntry.Data.dsConversorTableAdapters.measuresTableAdapter();
            this.equivalencesTableAdapter = new DataEntry.Data.dsConversorTableAdapters.equivalencesTableAdapter();
            this.sub_categoriesTableAdapter = new DataEntry.Data.dsConversorTableAdapters.sub_categoriesTableAdapter();
            this.subcategories1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sub_categories1TableAdapter = new DataEntry.Data.dsConversorTableAdapters.sub_categories1TableAdapter();
            this.measuretypesbyfamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measure_types_by_familyTableAdapter = new DataEntry.Data.dsConversorTableAdapters.measure_types_by_familyTableAdapter();
            this.fromUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFamilies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConversorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConversor)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnitTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuretypesBindingSource1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measuretypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubCategs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriesBindingSource1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measuretypesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuresBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familiesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquivalences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equivalencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategories1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuretypesbyfamilyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gvFamilies);
            this.tabPage1.Controls.Add(this.btnSaveFamily);
            this.tabPage1.Controls.Add(this.txtFamilyName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Familia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gvFamilies
            // 
            this.gvFamilies.AllowUserToAddRows = false;
            this.gvFamilies.AllowUserToDeleteRows = false;
            this.gvFamilies.AutoGenerateColumns = false;
            this.gvFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFamilies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.familynameDataGridViewTextBoxColumn});
            this.gvFamilies.DataSource = this.familiesBindingSource;
            this.gvFamilies.Location = new System.Drawing.Point(43, 96);
            this.gvFamilies.Name = "gvFamilies";
            this.gvFamilies.ReadOnly = true;
            this.gvFamilies.Size = new System.Drawing.Size(299, 272);
            this.gvFamilies.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // familynameDataGridViewTextBoxColumn
            // 
            this.familynameDataGridViewTextBoxColumn.DataPropertyName = "family_name";
            this.familynameDataGridViewTextBoxColumn.HeaderText = "family_name";
            this.familynameDataGridViewTextBoxColumn.Name = "familynameDataGridViewTextBoxColumn";
            this.familynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.familynameDataGridViewTextBoxColumn.Width = 200;
            // 
            // familiesBindingSource
            // 
            this.familiesBindingSource.DataMember = "families";
            this.familiesBindingSource.DataSource = this.dsConversorBindingSource;
            // 
            // dsConversorBindingSource
            // 
            this.dsConversorBindingSource.DataSource = this.dsConversor;
            this.dsConversorBindingSource.Position = 0;
            // 
            // dsConversor
            // 
            this.dsConversor.DataSetName = "dsConversor";
            this.dsConversor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveFamily
            // 
            this.btnSaveFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFamily.Location = new System.Drawing.Point(136, 45);
            this.btnSaveFamily.Name = "btnSaveFamily";
            this.btnSaveFamily.Size = new System.Drawing.Size(154, 32);
            this.btnSaveFamily.TabIndex = 2;
            this.btnSaveFamily.Text = "Salvar";
            this.btnSaveFamily.UseVisualStyleBackColor = true;
            this.btnSaveFamily.Click += new System.EventHandler(this.btnSaveFamily_Click);
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilyName.Location = new System.Drawing.Point(102, 13);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(358, 26);
            this.txtFamilyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbFamily);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.gvUnitTypes);
            this.tabPage2.Controls.Add(this.btnSaveUnitTypes);
            this.tabPage2.Controls.Add(this.txtUnitTypeName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipos de Medida";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbFamily
            // 
            this.cmbFamily.DataSource = this.familiesBindingSource1;
            this.cmbFamily.DisplayMember = "family_name";
            this.cmbFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFamily.FormattingEnabled = true;
            this.cmbFamily.Location = new System.Drawing.Point(105, 52);
            this.cmbFamily.Name = "cmbFamily";
            this.cmbFamily.Size = new System.Drawing.Size(281, 28);
            this.cmbFamily.TabIndex = 5;
            this.cmbFamily.ValueMember = "id";
            // 
            // familiesBindingSource1
            // 
            this.familiesBindingSource1.DataMember = "families";
            this.familiesBindingSource1.DataSource = this.dsConversorBindingSource;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Familia";
            // 
            // gvUnitTypes
            // 
            this.gvUnitTypes.AllowUserToAddRows = false;
            this.gvUnitTypes.AllowUserToDeleteRows = false;
            this.gvUnitTypes.AutoGenerateColumns = false;
            this.gvUnitTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUnitTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.familynameDataGridViewTextBoxColumn1});
            this.gvUnitTypes.DataSource = this.measuretypesBindingSource1;
            this.gvUnitTypes.Location = new System.Drawing.Point(48, 100);
            this.gvUnitTypes.Name = "gvUnitTypes";
            this.gvUnitTypes.ReadOnly = true;
            this.gvUnitTypes.Size = new System.Drawing.Size(353, 268);
            this.gvUnitTypes.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familynameDataGridViewTextBoxColumn1
            // 
            this.familynameDataGridViewTextBoxColumn1.DataPropertyName = "family_name";
            this.familynameDataGridViewTextBoxColumn1.HeaderText = "family_name";
            this.familynameDataGridViewTextBoxColumn1.Name = "familynameDataGridViewTextBoxColumn1";
            this.familynameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // measuretypesBindingSource1
            // 
            this.measuretypesBindingSource1.DataMember = "measure_types";
            this.measuretypesBindingSource1.DataSource = this.dsConversorBindingSource;
            // 
            // btnSaveUnitTypes
            // 
            this.btnSaveUnitTypes.Location = new System.Drawing.Point(407, 32);
            this.btnSaveUnitTypes.Name = "btnSaveUnitTypes";
            this.btnSaveUnitTypes.Size = new System.Drawing.Size(57, 23);
            this.btnSaveUnitTypes.TabIndex = 2;
            this.btnSaveUnitTypes.Text = "Salvar";
            this.btnSaveUnitTypes.UseVisualStyleBackColor = true;
            this.btnSaveUnitTypes.Click += new System.EventHandler(this.btnSaveUnitTypes_Click);
            // 
            // txtUnitTypeName
            // 
            this.txtUnitTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitTypeName.Location = new System.Drawing.Point(105, 18);
            this.txtUnitTypeName.Name = "txtUnitTypeName";
            this.txtUnitTypeName.Size = new System.Drawing.Size(281, 26);
            this.txtUnitTypeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbUnitType);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.gvSubCategs);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.txtSubCategName);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(635, 401);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sub-Categorias";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.DataSource = this.measuretypesBindingSource;
            this.cmbUnitType.DisplayMember = "name";
            this.cmbUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.Location = new System.Drawing.Point(140, 52);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(253, 28);
            this.cmbUnitType.TabIndex = 5;
            this.cmbUnitType.ValueMember = "id";
            // 
            // measuretypesBindingSource
            // 
            this.measuretypesBindingSource.DataMember = "measure_types";
            this.measuretypesBindingSource.DataSource = this.dsConversorBindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Medida";
            // 
            // gvSubCategs
            // 
            this.gvSubCategs.AllowUserToAddRows = false;
            this.gvSubCategs.AllowUserToDeleteRows = false;
            this.gvSubCategs.AutoGenerateColumns = false;
            this.gvSubCategs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSubCategs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1,
            this.measureTypeNameDataGridViewTextBoxColumn});
            this.gvSubCategs.DataSource = this.subcategoriesBindingSource1;
            this.gvSubCategs.Location = new System.Drawing.Point(14, 109);
            this.gvSubCategs.Name = "gvSubCategs";
            this.gvSubCategs.ReadOnly = true;
            this.gvSubCategs.Size = new System.Drawing.Size(454, 248);
            this.gvSubCategs.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // measureTypeNameDataGridViewTextBoxColumn
            // 
            this.measureTypeNameDataGridViewTextBoxColumn.DataPropertyName = "MeasureTypeName";
            this.measureTypeNameDataGridViewTextBoxColumn.HeaderText = "MeasureTypeName";
            this.measureTypeNameDataGridViewTextBoxColumn.Name = "measureTypeNameDataGridViewTextBoxColumn";
            this.measureTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subcategoriesBindingSource1
            // 
            this.subcategoriesBindingSource1.DataMember = "sub_categories";
            this.subcategoriesBindingSource1.DataSource = this.dsConversorBindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(414, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSubCategName
            // 
            this.txtSubCategName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCategName.Location = new System.Drawing.Point(140, 14);
            this.txtSubCategName.Name = "txtSubCategName";
            this.txtSubCategName.Size = new System.Drawing.Size(253, 26);
            this.txtSubCategName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBox1);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.cmbSubCateg);
            this.tabPage5.Controls.Add(this.gvUnits);
            this.tabPage5.Controls.Add(this.btnSaveUnits);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.txtUnitName);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(635, 401);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Unidades";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.measuretypesBindingSource2;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // measuretypesBindingSource2
            // 
            this.measuretypesBindingSource2.DataMember = "measure_types";
            this.measuretypesBindingSource2.DataSource = this.dsConversorBindingSource;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tipo Medida";
            // 
            // cmbSubCateg
            // 
            this.cmbSubCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubCateg.FormattingEnabled = true;
            this.cmbSubCateg.Location = new System.Drawing.Point(134, 97);
            this.cmbSubCateg.Name = "cmbSubCateg";
            this.cmbSubCateg.Size = new System.Drawing.Size(250, 28);
            this.cmbSubCateg.TabIndex = 6;
            // 
            // gvUnits
            // 
            this.gvUnits.AllowUserToAddRows = false;
            this.gvUnits.AllowUserToDeleteRows = false;
            this.gvUnits.AutoGenerateColumns = false;
            this.gvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn2,
            this.categNameDataGridViewTextBoxColumn});
            this.gvUnits.DataSource = this.measuresBindingSource;
            this.gvUnits.Location = new System.Drawing.Point(18, 160);
            this.gvUnits.Name = "gvUnits";
            this.gvUnits.ReadOnly = true;
            this.gvUnits.Size = new System.Drawing.Size(434, 197);
            this.gvUnits.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // categNameDataGridViewTextBoxColumn
            // 
            this.categNameDataGridViewTextBoxColumn.DataPropertyName = "CategName";
            this.categNameDataGridViewTextBoxColumn.HeaderText = "CategName";
            this.categNameDataGridViewTextBoxColumn.Name = "categNameDataGridViewTextBoxColumn";
            this.categNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measuresBindingSource
            // 
            this.measuresBindingSource.DataMember = "measures";
            this.measuresBindingSource.DataSource = this.dsConversorBindingSource;
            // 
            // btnSaveUnits
            // 
            this.btnSaveUnits.Location = new System.Drawing.Point(400, 39);
            this.btnSaveUnits.Name = "btnSaveUnits";
            this.btnSaveUnits.Size = new System.Drawing.Size(61, 23);
            this.btnSaveUnits.TabIndex = 4;
            this.btnSaveUnits.Text = "Salvar";
            this.btnSaveUnits.UseVisualStyleBackColor = true;
            this.btnSaveUnits.Click += new System.EventHandler(this.btnSaveUnits_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sub-Categ";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitName.Location = new System.Drawing.Point(134, 22);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(250, 26);
            this.txtUnitName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbCategs2);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.cmbMeasureType2);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.gvEquivalences);
            this.tabPage3.Controls.Add(this.btnSaveEquivalence);
            this.tabPage3.Controls.Add(this.txtValue);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cmbUnitTo);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cmbUnitFrom);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(551, 401);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Equivalencias";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbCategs2
            // 
            this.cmbCategs2.FormattingEnabled = true;
            this.cmbCategs2.Location = new System.Drawing.Point(108, 69);
            this.cmbCategs2.Name = "cmbCategs2";
            this.cmbCategs2.Size = new System.Drawing.Size(212, 21);
            this.cmbCategs2.TabIndex = 13;
            this.cmbCategs2.SelectedIndexChanged += new System.EventHandler(this.cmbCategs2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Categorias";
            // 
            // cmbMeasureType2
            // 
            this.cmbMeasureType2.FormattingEnabled = true;
            this.cmbMeasureType2.Location = new System.Drawing.Point(108, 39);
            this.cmbMeasureType2.Name = "cmbMeasureType2";
            this.cmbMeasureType2.Size = new System.Drawing.Size(212, 21);
            this.cmbMeasureType2.TabIndex = 11;
            this.cmbMeasureType2.SelectedIndexChanged += new System.EventHandler(this.cmbMeasureType2_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tipo Medida";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.familiesBindingSource2;
            this.comboBox2.DisplayMember = "family_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(108, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // familiesBindingSource2
            // 
            this.familiesBindingSource2.DataMember = "families";
            this.familiesBindingSource2.DataSource = this.dsConversorBindingSource;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Familia";
            // 
            // gvEquivalences
            // 
            this.gvEquivalences.AllowUserToAddRows = false;
            this.gvEquivalences.AllowUserToDeleteRows = false;
            this.gvEquivalences.AutoGenerateColumns = false;
            this.gvEquivalences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEquivalences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromUnitDataGridViewTextBoxColumn,
            this.toUnitDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.gvEquivalences.DataSource = this.equivalencesBindingSource;
            this.gvEquivalences.Location = new System.Drawing.Point(15, 231);
            this.gvEquivalences.Name = "gvEquivalences";
            this.gvEquivalences.ReadOnly = true;
            this.gvEquivalences.Size = new System.Drawing.Size(522, 161);
            this.gvEquivalences.TabIndex = 7;
            // 
            // equivalencesBindingSource
            // 
            this.equivalencesBindingSource.DataMember = "equivalences";
            this.equivalencesBindingSource.DataSource = this.dsConversorBindingSource;
            // 
            // btnSaveEquivalence
            // 
            this.btnSaveEquivalence.Location = new System.Drawing.Point(387, 202);
            this.btnSaveEquivalence.Name = "btnSaveEquivalence";
            this.btnSaveEquivalence.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEquivalence.TabIndex = 6;
            this.btnSaveEquivalence.Text = "Salvar";
            this.btnSaveEquivalence.UseVisualStyleBackColor = true;
            this.btnSaveEquivalence.Click += new System.EventHandler(this.btnSaveEquivalence_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(359, 145);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(178, 26);
            this.txtValue.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(335, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "=";
            // 
            // cmbUnitTo
            // 
            this.cmbUnitTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitTo.FormattingEnabled = true;
            this.cmbUnitTo.Location = new System.Drawing.Point(65, 175);
            this.cmbUnitTo.Name = "cmbUnitTo";
            this.cmbUnitTo.Size = new System.Drawing.Size(255, 24);
            this.cmbUnitTo.TabIndex = 3;
            // 
            // measuresBindingSource1
            // 
            this.measuresBindingSource1.DataMember = "measures";
            this.measuresBindingSource1.DataSource = this.dsConversorBindingSource;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "A";
            // 
            // cmbUnitFrom
            // 
            this.cmbUnitFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitFrom.FormattingEnabled = true;
            this.cmbUnitFrom.Location = new System.Drawing.Point(65, 120);
            this.cmbUnitFrom.Name = "cmbUnitFrom";
            this.cmbUnitFrom.Size = new System.Drawing.Size(255, 24);
            this.cmbUnitFrom.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(17, 118);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(37, 23);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "1";
            // 
            // subcategoriesBindingSource
            // 
            this.subcategoriesBindingSource.DataMember = "sub_categories";
            this.subcategoriesBindingSource.DataSource = this.dsConversorBindingSource;
            // 
            // familiesTableAdapter
            // 
            this.familiesTableAdapter.ClearBeforeFill = true;
            // 
            // measure_typesTableAdapter
            // 
            this.measure_typesTableAdapter.ClearBeforeFill = true;
            // 
            // measuresTableAdapter
            // 
            this.measuresTableAdapter.ClearBeforeFill = true;
            // 
            // equivalencesTableAdapter
            // 
            this.equivalencesTableAdapter.ClearBeforeFill = true;
            // 
            // sub_categoriesTableAdapter
            // 
            this.sub_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // subcategories1BindingSource
            // 
            this.subcategories1BindingSource.DataMember = "sub_categories1";
            this.subcategories1BindingSource.DataSource = this.dsConversorBindingSource;
            // 
            // sub_categories1TableAdapter
            // 
            this.sub_categories1TableAdapter.ClearBeforeFill = true;
            // 
            // measuretypesbyfamilyBindingSource
            // 
            this.measuretypesbyfamilyBindingSource.DataMember = "measure_types_by_family";
            this.measuretypesbyfamilyBindingSource.DataSource = this.dsConversorBindingSource;
            // 
            // measure_types_by_familyTableAdapter
            // 
            this.measure_types_by_familyTableAdapter.ClearBeforeFill = true;
            // 
            // fromUnitDataGridViewTextBoxColumn
            // 
            this.fromUnitDataGridViewTextBoxColumn.DataPropertyName = "FromUnit";
            this.fromUnitDataGridViewTextBoxColumn.HeaderText = "FromUnit";
            this.fromUnitDataGridViewTextBoxColumn.Name = "fromUnitDataGridViewTextBoxColumn";
            this.fromUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromUnitDataGridViewTextBoxColumn.Width = 150;
            // 
            // toUnitDataGridViewTextBoxColumn
            // 
            this.toUnitDataGridViewTextBoxColumn.DataPropertyName = "ToUnit";
            this.toUnitDataGridViewTextBoxColumn.HeaderText = "ToUnit";
            this.toUnitDataGridViewTextBoxColumn.Name = "toUnitDataGridViewTextBoxColumn";
            this.toUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.toUnitDataGridViewTextBoxColumn.Width = 150;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            dataGridViewCellStyle1.Format = "0.00#######";
            dataGridViewCellStyle1.NullValue = null;
            this.valueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            this.valueDataGridViewTextBoxColumn.Width = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFamilies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConversorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConversor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnitTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuretypesBindingSource1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measuretypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubCategs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriesBindingSource1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measuretypesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuresBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familiesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquivalences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equivalencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategories1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuretypesbyfamilyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSaveFamily;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gvUnitTypes;
        private System.Windows.Forms.Button btnSaveUnitTypes;
        private System.Windows.Forms.TextBox txtUnitTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView gvSubCategs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSubCategName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbFamily;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUnitType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvUnits;
        private System.Windows.Forms.Button btnSaveUnits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvEquivalences;
        private System.Windows.Forms.Button btnSaveEquivalence;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUnitTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUnitFrom;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView gvFamilies;
        private System.Windows.Forms.BindingSource dsConversorBindingSource;
        private Data.dsConversor dsConversor;
        private System.Windows.Forms.BindingSource familiesBindingSource;
        private Data.dsConversorTableAdapters.familiesTableAdapter familiesTableAdapter;
        private Data.dsConversorTableAdapters.measure_typesTableAdapter measure_typesTableAdapter;
        private System.Windows.Forms.BindingSource measuretypesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource measuresBindingSource;
        private Data.dsConversorTableAdapters.measuresTableAdapter measuresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource equivalencesBindingSource;
        private Data.dsConversorTableAdapters.equivalencesTableAdapter equivalencesTableAdapter;
        private System.Windows.Forms.BindingSource familiesBindingSource1;
        private System.Windows.Forms.BindingSource measuretypesBindingSource;
        private System.Windows.Forms.ComboBox cmbSubCateg;
        private System.Windows.Forms.BindingSource subcategoriesBindingSource1;
        private System.Windows.Forms.BindingSource subcategoriesBindingSource;
        private Data.dsConversorTableAdapters.sub_categoriesTableAdapter sub_categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource measuresBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource measuretypesBindingSource2;
        private System.Windows.Forms.BindingSource subcategories1BindingSource;
        private Data.dsConversorTableAdapters.sub_categories1TableAdapter sub_categories1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbCategs2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbMeasureType2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource familiesBindingSource2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource measuretypesbyfamilyBindingSource;
        private Data.dsConversorTableAdapters.measure_types_by_familyTableAdapter measure_types_by_familyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}

