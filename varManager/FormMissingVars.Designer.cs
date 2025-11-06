
namespace varManager
{
    partial class FormMissingVars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMissingVars));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.varsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varManagerDataSet = new varManager.varManagerDataSet();
            this.varsTableAdapter = new varManager.varManagerDataSetTableAdapters.varsTableAdapter();
            this.tableAdapterManager = new varManager.varManagerDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.varsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCreater = new System.Windows.Forms.ComboBox();
            this.dataGridViewMissingVars = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveTxt = new System.Windows.Forms.Button();
            this.buttonLoadTxt = new System.Windows.Forms.Button();
            this.buttonLinkto = new System.Windows.Forms.Button();
            this.textBoxLinkVar = new System.Windows.Forms.TextBox();
            this.textBoxMissingVar = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxIgnoreVersion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDependent = new System.Windows.Forms.DataGridView();
            this.openFileDialogLoadTXT = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSaveTxt = new System.Windows.Forms.SaveFileDialog();
            this.ColumnVarname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLinkto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnLink = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnGoogle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumnvarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocateExistVar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDependentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.varsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varManagerDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissingVars)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDependent)).BeginInit();
            this.SuspendLayout();
            // 
            // varsBindingSource
            // 
            this.varsBindingSource.DataMember = "vars";
            this.varsBindingSource.DataSource = this.varManagerDataSet;
            // 
            // varManagerDataSet
            // 
            this.varManagerDataSet.DataSetName = "varManagerDataSet";
            this.varManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varsTableAdapter
            // 
            this.varsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dependenciesTableAdapter = null;
            this.tableAdapterManager.installStatusTableAdapter = null;
            this.tableAdapterManager.savedepensTableAdapter = null;
            this.tableAdapterManager.scenesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = varManager.varManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.varsTableAdapter = this.varsTableAdapter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(500, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(494, 217);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.varsDataGridView);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(494, 217);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已存在 Vars";
            // 
            // varsDataGridView
            // 
            this.varsDataGridView.AllowUserToAddRows = false;
            this.varsDataGridView.AllowUserToDeleteRows = false;
            this.varsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.varsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.varsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnvarName,
            this.varDate,
            this.ColumnLocateExistVar});
            this.varsDataGridView.DataSource = this.varsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.varsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.varsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.varsDataGridView.Location = new System.Drawing.Point(2, 49);
            this.varsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.varsDataGridView.MultiSelect = false;
            this.varsDataGridView.Name = "varsDataGridView";
            this.varsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.varsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.varsDataGridView.RowHeadersWidth = 51;
            this.varsDataGridView.RowTemplate.Height = 27;
            this.varsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.varsDataGridView.Size = new System.Drawing.Size(490, 166);
            this.varsDataGridView.TabIndex = 3;
            this.varsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varsDataGridView_CellContentClick);
            this.varsDataGridView.SelectionChanged += new System.EventHandler(this.varsDataGridView_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxFilter);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBoxCreater);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 33);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "创作者:";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(250, 6);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(148, 21);
            this.textBoxFilter.TabIndex = 7;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "过滤器:";
            // 
            // comboBoxCreater
            // 
            this.comboBoxCreater.AllowDrop = true;
            this.comboBoxCreater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCreater.FormattingEnabled = true;
            this.comboBoxCreater.Location = new System.Drawing.Point(69, 6);
            this.comboBoxCreater.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCreater.Name = "comboBoxCreater";
            this.comboBoxCreater.Size = new System.Drawing.Size(116, 20);
            this.comboBoxCreater.TabIndex = 6;
            this.comboBoxCreater.SelectedIndexChanged += new System.EventHandler(this.comboBoxCreater_SelectedIndexChanged);
            // 
            // dataGridViewMissingVars
            // 
            this.dataGridViewMissingVars.AllowUserToAddRows = false;
            this.dataGridViewMissingVars.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMissingVars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMissingVars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMissingVars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVarname,
            this.ColumnLinkto,
            this.ColumnUnLink,
            this.ColumnGoogle});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMissingVars.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMissingVars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMissingVars.Location = new System.Drawing.Point(2, 16);
            this.dataGridViewMissingVars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMissingVars.MultiSelect = false;
            this.dataGridViewMissingVars.Name = "dataGridViewMissingVars";
            this.dataGridViewMissingVars.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMissingVars.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMissingVars.RowHeadersWidth = 51;
            this.dataGridViewMissingVars.RowTemplate.Height = 27;
            this.dataGridViewMissingVars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMissingVars.Size = new System.Drawing.Size(490, 366);
            this.dataGridViewMissingVars.TabIndex = 0;
            this.dataGridViewMissingVars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMissingVars_CellContentClick);
            this.dataGridViewMissingVars.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMissingVars_RowEnter);
            this.dataGridViewMissingVars.SelectionChanged += new System.EventHandler(this.dataGridViewMissingVars_SelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.buttonSaveTxt);
            this.panel1.Controls.Add(this.buttonLoadTxt);
            this.panel1.Controls.Add(this.buttonLinkto);
            this.panel1.Controls.Add(this.textBoxLinkVar);
            this.panel1.Controls.Add(this.textBoxMissingVar);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 417);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 36);
            this.panel1.TabIndex = 1;
            // 
            // buttonSaveTxt
            // 
            this.buttonSaveTxt.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveTxt.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSaveTxt.Location = new System.Drawing.Point(500, 7);
            this.buttonSaveTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveTxt.Name = "buttonSaveTxt";
            this.buttonSaveTxt.Size = new System.Drawing.Size(88, 22);
            this.buttonSaveTxt.TabIndex = 9;
            this.buttonSaveTxt.Text = "保存文本";
            this.buttonSaveTxt.UseVisualStyleBackColor = true;
            this.buttonSaveTxt.Click += new System.EventHandler(this.buttonSaveTxt_Click);
            // 
            // buttonLoadTxt
            // 
            this.buttonLoadTxt.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLoadTxt.ForeColor = System.Drawing.Color.Sienna;
            this.buttonLoadTxt.Location = new System.Drawing.Point(592, 7);
            this.buttonLoadTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoadTxt.Name = "buttonLoadTxt";
            this.buttonLoadTxt.Size = new System.Drawing.Size(88, 22);
            this.buttonLoadTxt.TabIndex = 10;
            this.buttonLoadTxt.Text = "加载文本";
            this.buttonLoadTxt.UseVisualStyleBackColor = true;
            this.buttonLoadTxt.Click += new System.EventHandler(this.buttonLoadTxt_Click);
            // 
            // buttonLinkto
            // 
            this.buttonLinkto.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLinkto.ForeColor = System.Drawing.Color.Crimson;
            this.buttonLinkto.Location = new System.Drawing.Point(206, 7);
            this.buttonLinkto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLinkto.Name = "buttonLinkto";
            this.buttonLinkto.Size = new System.Drawing.Size(88, 22);
            this.buttonLinkto.TabIndex = 6;
            this.buttonLinkto.Text = "链接到";
            this.buttonLinkto.UseVisualStyleBackColor = true;
            this.buttonLinkto.Click += new System.EventHandler(this.buttonLinkto_Click);
            // 
            // textBoxLinkVar
            // 
            this.textBoxLinkVar.Location = new System.Drawing.Point(303, 9);
            this.textBoxLinkVar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLinkVar.Name = "textBoxLinkVar";
            this.textBoxLinkVar.ReadOnly = true;
            this.textBoxLinkVar.Size = new System.Drawing.Size(194, 21);
            this.textBoxLinkVar.TabIndex = 5;
            // 
            // textBoxMissingVar
            // 
            this.textBoxMissingVar.Location = new System.Drawing.Point(8, 9);
            this.textBoxMissingVar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMissingVar.Name = "textBoxMissingVar";
            this.textBoxMissingVar.ReadOnly = true;
            this.textBoxMissingVar.Size = new System.Drawing.Size(194, 21);
            this.textBoxMissingVar.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(895, 7);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 22);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOK.Location = new System.Drawing.Point(797, 7);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 22);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "好的";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator1,
            this.toolStripComboBoxIgnoreVersion,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "First";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripComboBoxIgnoreVersion
            // 
            this.toolStripComboBoxIgnoreVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxIgnoreVersion.Items.AddRange(new object[] {
            "忽略缺失的版本",
            "所有缺失的vars"});
            this.toolStripComboBoxIgnoreVersion.Name = "toolStripComboBoxIgnoreVersion";
            this.toolStripComboBoxIgnoreVersion.Size = new System.Drawing.Size(151, 27);
            this.toolStripComboBoxIgnoreVersion.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxIgnoreVersion_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewMissingVars);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(494, 384);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "缺失的 Vars";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewDependent);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(500, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(494, 190);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "依赖项";
            // 
            // dataGridViewDependent
            // 
            this.dataGridViewDependent.AllowUserToAddRows = false;
            this.dataGridViewDependent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDependent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDependent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDependent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDependentName,
            this.ColumnLocate});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDependent.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDependent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDependent.Location = new System.Drawing.Point(2, 16);
            this.dataGridViewDependent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDependent.MultiSelect = false;
            this.dataGridViewDependent.Name = "dataGridViewDependent";
            this.dataGridViewDependent.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDependent.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewDependent.RowHeadersWidth = 51;
            this.dataGridViewDependent.RowTemplate.Height = 27;
            this.dataGridViewDependent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDependent.Size = new System.Drawing.Size(490, 172);
            this.dataGridViewDependent.TabIndex = 4;
            this.dataGridViewDependent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDependent_CellContentClick);
            // 
            // openFileDialogLoadTXT
            // 
            this.openFileDialogLoadTXT.DefaultExt = "txt";
            this.openFileDialogLoadTXT.FileName = "missingvarlinks";
            this.openFileDialogLoadTXT.Filter = "text file|*.txt";
            // 
            // saveFileDialogSaveTxt
            // 
            this.saveFileDialogSaveTxt.DefaultExt = "txt";
            this.saveFileDialogSaveTxt.FileName = "missingvarlinks";
            this.saveFileDialogSaveTxt.Filter = "text file|*.txt";
            // 
            // ColumnVarname
            // 
            this.ColumnVarname.HeaderText = "Var名称";
            this.ColumnVarname.MinimumWidth = 6;
            this.ColumnVarname.Name = "ColumnVarname";
            this.ColumnVarname.ReadOnly = true;
            this.ColumnVarname.Width = 180;
            // 
            // ColumnLinkto
            // 
            this.ColumnLinkto.HeaderText = "链接到";
            this.ColumnLinkto.MinimumWidth = 6;
            this.ColumnLinkto.Name = "ColumnLinkto";
            this.ColumnLinkto.ReadOnly = true;
            this.ColumnLinkto.Width = 180;
            // 
            // ColumnUnLink
            // 
            this.ColumnUnLink.HeaderText = "解除链接";
            this.ColumnUnLink.MinimumWidth = 6;
            this.ColumnUnLink.Name = "ColumnUnLink";
            this.ColumnUnLink.ReadOnly = true;
            this.ColumnUnLink.Width = 125;
            // 
            // ColumnGoogle
            // 
            this.ColumnGoogle.HeaderText = "Google";
            this.ColumnGoogle.MinimumWidth = 6;
            this.ColumnGoogle.Name = "ColumnGoogle";
            this.ColumnGoogle.ReadOnly = true;
            this.ColumnGoogle.Width = 125;
            // 
            // dataGridViewTextBoxColumnvarName
            // 
            this.dataGridViewTextBoxColumnvarName.DataPropertyName = "varName";
            this.dataGridViewTextBoxColumnvarName.HeaderText = "var名称";
            this.dataGridViewTextBoxColumnvarName.MinimumWidth = 6;
            this.dataGridViewTextBoxColumnvarName.Name = "dataGridViewTextBoxColumnvarName";
            this.dataGridViewTextBoxColumnvarName.ReadOnly = true;
            this.dataGridViewTextBoxColumnvarName.Width = 200;
            // 
            // varDate
            // 
            this.varDate.DataPropertyName = "varDate";
            this.varDate.HeaderText = "var日期";
            this.varDate.MinimumWidth = 6;
            this.varDate.Name = "varDate";
            this.varDate.ReadOnly = true;
            this.varDate.Width = 125;
            // 
            // ColumnLocateExistVar
            // 
            this.ColumnLocateExistVar.DataPropertyName = "varDate";
            this.ColumnLocateExistVar.HeaderText = "定位";
            this.ColumnLocateExistVar.MinimumWidth = 6;
            this.ColumnLocateExistVar.Name = "ColumnLocateExistVar";
            this.ColumnLocateExistVar.ReadOnly = true;
            this.ColumnLocateExistVar.Text = "定位";
            this.ColumnLocateExistVar.UseColumnTextForButtonValue = true;
            this.ColumnLocateExistVar.Width = 125;
            // 
            // ColumnDependentName
            // 
            this.ColumnDependentName.HeaderText = "依赖项名称";
            this.ColumnDependentName.MinimumWidth = 6;
            this.ColumnDependentName.Name = "ColumnDependentName";
            this.ColumnDependentName.ReadOnly = true;
            this.ColumnDependentName.Width = 200;
            // 
            // ColumnLocate
            // 
            this.ColumnLocate.HeaderText = "定位";
            this.ColumnLocate.MinimumWidth = 6;
            this.ColumnLocate.Name = "ColumnLocate";
            this.ColumnLocate.ReadOnly = true;
            this.ColumnLocate.Width = 125;
            // 
            // FormMissingVars
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(996, 455);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMissingVars";
            this.Text = "缺失的 Vars 表单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMissingVars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.varsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varManagerDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.varsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissingVars)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDependent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private varManagerDataSet varManagerDataSet;
        private System.Windows.Forms.BindingSource varsBindingSource;
        private varManagerDataSetTableAdapters.varsTableAdapter varsTableAdapter;
        private varManagerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxCreater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView varsDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewMissingVars;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLinkto;
        private System.Windows.Forms.TextBox textBoxLinkVar;
        private System.Windows.Forms.TextBox textBoxMissingVar;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.Button buttonSaveTxt;
        private System.Windows.Forms.Button buttonLoadTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadTXT;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveTxt;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxIgnoreVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewDependent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnvarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn varDate;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnLocateExistVar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVarname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLinkto;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnUnLink;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnGoogle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDependentName;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnLocate;
    }
}