namespace ParkingWFP.View
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_authentication = new System.Windows.Forms.Label();
            this.grid_parking = new System.Windows.Forms.DataGridView();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilanizedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanceledAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Increase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_truncateParking = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_categories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_startParking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_categories = new System.Windows.Forms.Button();
            this.btn_models = new System.Windows.Forms.Button();
            this.btn_colors = new System.Windows.Forms.Button();
            this.cbx_models = new System.Windows.Forms.ComboBox();
            this.cbx_colors = new System.Windows.Forms.ComboBox();
            this.tbx_plate = new System.Windows.Forms.TextBox();
            this.btn_clearStartForm = new System.Windows.Forms.Button();
            this.btn_cancelParking = new System.Windows.Forms.Button();
            this.btn_finishParking = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_ModelDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_categoryDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_colorDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_plate = new System.Windows.Forms.ComboBox();
            this.btn_clearFinishForm = new System.Windows.Forms.Button();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.tbx_filter = new System.Windows.Forms.TextBox();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_parking)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_title.Controls.Add(this.label_authentication);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.ForeColor = System.Drawing.Color.White;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Margin = new System.Windows.Forms.Padding(4);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1077, 55);
            this.panel_title.TabIndex = 24;
            // 
            // label_authentication
            // 
            this.label_authentication.AutoSize = true;
            this.label_authentication.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_authentication.ForeColor = System.Drawing.Color.White;
            this.label_authentication.Location = new System.Drawing.Point(30, 13);
            this.label_authentication.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_authentication.Name = "label_authentication";
            this.label_authentication.Size = new System.Drawing.Size(227, 35);
            this.label_authentication.TabIndex = 2;
            this.label_authentication.Text = "Estacionamento";
            // 
            // grid_parking
            // 
            this.grid_parking.AllowUserToAddRows = false;
            this.grid_parking.AllowUserToDeleteRows = false;
            this.grid_parking.AllowUserToOrderColumns = true;
            this.grid_parking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_parking.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_parking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plate,
            this.Model,
            this.Color,
            this.Category,
            this.Status,
            this.TotalValue,
            this.StartAt,
            this.FilanizedAt,
            this.CanceledAt,
            this.Increase,
            this.Discount,
            this.Code});
            this.grid_parking.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_parking.Location = new System.Drawing.Point(34, 515);
            this.grid_parking.Margin = new System.Windows.Forms.Padding(4);
            this.grid_parking.Name = "grid_parking";
            this.grid_parking.ReadOnly = true;
            this.grid_parking.RowTemplate.Height = 24;
            this.grid_parking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_parking.Size = new System.Drawing.Size(1007, 204);
            this.grid_parking.TabIndex = 11;
            this.grid_parking.Click += new System.EventHandler(this.grid_parking_Click);
            // 
            // Plate
            // 
            this.Plate.DataPropertyName = "Plate";
            this.Plate.HeaderText = "Placa";
            this.Plate.Name = "Plate";
            this.Plate.ReadOnly = true;
            this.Plate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Plate.Width = 150;
            // 
            // Model
            // 
            this.Model.HeaderText = "Modelo";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Model.Width = 80;
            // 
            // Color
            // 
            this.Color.HeaderText = "Cor";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Color.Width = 80;
            // 
            // Category
            // 
            this.Category.HeaderText = "Categoria";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Category.Width = 85;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Situação";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalValue
            // 
            this.TotalValue.DataPropertyName = "TotalValue";
            dataGridViewCellStyle29.Format = "C2";
            dataGridViewCellStyle29.NullValue = null;
            this.TotalValue.DefaultCellStyle = dataGridViewCellStyle29;
            this.TotalValue.HeaderText = "Valor Total";
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.ReadOnly = true;
            this.TotalValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalValue.Width = 150;
            // 
            // StartAt
            // 
            this.StartAt.DataPropertyName = "StartedAt";
            dataGridViewCellStyle30.Format = "t";
            dataGridViewCellStyle30.NullValue = "--:--";
            this.StartAt.DefaultCellStyle = dataGridViewCellStyle30;
            this.StartAt.HeaderText = "Entrada";
            this.StartAt.Name = "StartAt";
            this.StartAt.ReadOnly = true;
            this.StartAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.StartAt.Width = 150;
            // 
            // FilanizedAt
            // 
            this.FilanizedAt.DataPropertyName = "FinalizedAt";
            dataGridViewCellStyle31.Format = "t";
            dataGridViewCellStyle31.NullValue = "--:--";
            this.FilanizedAt.DefaultCellStyle = dataGridViewCellStyle31;
            this.FilanizedAt.HeaderText = "Saida";
            this.FilanizedAt.Name = "FilanizedAt";
            this.FilanizedAt.ReadOnly = true;
            this.FilanizedAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FilanizedAt.Width = 150;
            // 
            // CanceledAt
            // 
            this.CanceledAt.DataPropertyName = "CanceledAt";
            dataGridViewCellStyle32.Format = "t";
            dataGridViewCellStyle32.NullValue = "--:--";
            this.CanceledAt.DefaultCellStyle = dataGridViewCellStyle32;
            this.CanceledAt.HeaderText = "Desistencia";
            this.CanceledAt.Name = "CanceledAt";
            this.CanceledAt.ReadOnly = true;
            this.CanceledAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CanceledAt.Width = 150;
            // 
            // Increase
            // 
            this.Increase.DataPropertyName = "Increase";
            this.Increase.HeaderText = "Acréscimo";
            this.Increase.Name = "Increase";
            this.Increase.ReadOnly = true;
            this.Increase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Increase.Width = 90;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Desconto";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Discount.Width = 80;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Código";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_truncateParking
            // 
            this.btn_truncateParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_truncateParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_truncateParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_truncateParking.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_truncateParking.ForeColor = System.Drawing.Color.White;
            this.btn_truncateParking.Location = new System.Drawing.Point(835, 727);
            this.btn_truncateParking.Margin = new System.Windows.Forms.Padding(4);
            this.btn_truncateParking.Name = "btn_truncateParking";
            this.btn_truncateParking.Size = new System.Drawing.Size(207, 50);
            this.btn_truncateParking.TabIndex = 29;
            this.btn_truncateParking.Text = "Remover";
            this.btn_truncateParking.UseVisualStyleBackColor = false;
            this.btn_truncateParking.Click += new System.EventHandler(this.btn_truncateParking_Click);
            // 
            // btn_report
            // 
            this.btn_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Location = new System.Drawing.Point(34, 727);
            this.btn_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(216, 50);
            this.btn_report.TabIndex = 37;
            this.btn_report.Text = "Relatório";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria:";
            // 
            // cbx_categories
            // 
            this.cbx_categories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_categories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_categories.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categories.FormattingEnabled = true;
            this.cbx_categories.Location = new System.Drawing.Point(32, 234);
            this.cbx_categories.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_categories.Name = "cbx_categories";
            this.cbx_categories.Size = new System.Drawing.Size(450, 34);
            this.cbx_categories.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Placa:";
            // 
            // btn_startParking
            // 
            this.btn_startParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(204)))));
            this.btn_startParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startParking.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startParking.ForeColor = System.Drawing.Color.White;
            this.btn_startParking.Location = new System.Drawing.Point(258, 345);
            this.btn_startParking.Margin = new System.Windows.Forms.Padding(4);
            this.btn_startParking.Name = "btn_startParking";
            this.btn_startParking.Size = new System.Drawing.Size(222, 50);
            this.btn_startParking.TabIndex = 5;
            this.btn_startParking.Text = "Entrar";
            this.btn_startParking.UseVisualStyleBackColor = false;
            this.btn_startParking.Click += new System.EventHandler(this.btn_startParking_Click);
            this.btn_startParking.Enter += new System.EventHandler(this.btn_startParking_Enter);
            this.btn_startParking.Leave += new System.EventHandler(this.btn_startParking_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modelo:";
            // 
            // btn_categories
            // 
            this.btn_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categories.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories.ForeColor = System.Drawing.Color.White;
            this.btn_categories.Location = new System.Drawing.Point(490, 233);
            this.btn_categories.Margin = new System.Windows.Forms.Padding(4);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Size = new System.Drawing.Size(53, 35);
            this.btn_categories.TabIndex = 16;
            this.btn_categories.Text = "+";
            this.btn_categories.UseVisualStyleBackColor = false;
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // btn_models
            // 
            this.btn_models.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_models.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_models.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_models.ForeColor = System.Drawing.Color.White;
            this.btn_models.Location = new System.Drawing.Point(490, 165);
            this.btn_models.Margin = new System.Windows.Forms.Padding(4);
            this.btn_models.Name = "btn_models";
            this.btn_models.Size = new System.Drawing.Size(55, 34);
            this.btn_models.TabIndex = 15;
            this.btn_models.Text = "+";
            this.btn_models.UseVisualStyleBackColor = false;
            this.btn_models.Click += new System.EventHandler(this.btn_models_Click);
            // 
            // btn_colors
            // 
            this.btn_colors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_colors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_colors.ForeColor = System.Drawing.Color.White;
            this.btn_colors.Location = new System.Drawing.Point(490, 303);
            this.btn_colors.Margin = new System.Windows.Forms.Padding(4);
            this.btn_colors.Name = "btn_colors";
            this.btn_colors.Size = new System.Drawing.Size(53, 34);
            this.btn_colors.TabIndex = 17;
            this.btn_colors.Text = "+";
            this.btn_colors.UseVisualStyleBackColor = false;
            this.btn_colors.Click += new System.EventHandler(this.btn_colors_Click);
            // 
            // cbx_models
            // 
            this.cbx_models.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_models.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_models.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_models.FormattingEnabled = true;
            this.cbx_models.Location = new System.Drawing.Point(32, 165);
            this.cbx_models.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_models.Name = "cbx_models";
            this.cbx_models.Size = new System.Drawing.Size(450, 34);
            this.cbx_models.TabIndex = 2;
            this.cbx_models.SelectedIndexChanged += new System.EventHandler(this.cbx_models_SelectedIndexChanged);
            // 
            // cbx_colors
            // 
            this.cbx_colors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_colors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_colors.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_colors.FormattingEnabled = true;
            this.cbx_colors.Location = new System.Drawing.Point(32, 303);
            this.cbx_colors.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_colors.Name = "cbx_colors";
            this.cbx_colors.Size = new System.Drawing.Size(450, 34);
            this.cbx_colors.TabIndex = 4;
            // 
            // tbx_plate
            // 
            this.tbx_plate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_plate.Location = new System.Drawing.Point(32, 90);
            this.tbx_plate.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_plate.Name = "tbx_plate";
            this.tbx_plate.Size = new System.Drawing.Size(450, 34);
            this.tbx_plate.TabIndex = 1;
            this.tbx_plate.TextChanged += new System.EventHandler(this.tbx_plate_TextChanged);
            this.tbx_plate.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_plate_Validating);
            // 
            // btn_clearStartForm
            // 
            this.btn_clearStartForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_clearStartForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearStartForm.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearStartForm.ForeColor = System.Drawing.Color.White;
            this.btn_clearStartForm.Location = new System.Drawing.Point(32, 345);
            this.btn_clearStartForm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearStartForm.Name = "btn_clearStartForm";
            this.btn_clearStartForm.Size = new System.Drawing.Size(218, 50);
            this.btn_clearStartForm.TabIndex = 28;
            this.btn_clearStartForm.Text = "Limpar";
            this.btn_clearStartForm.UseVisualStyleBackColor = false;
            this.btn_clearStartForm.Click += new System.EventHandler(this.btn_clearStartForm_Click);
            this.btn_clearStartForm.Enter += new System.EventHandler(this.btn_clearStartForm_Enter);
            this.btn_clearStartForm.Leave += new System.EventHandler(this.btn_clearStartForm_Leave);
            // 
            // btn_cancelParking
            // 
            this.btn_cancelParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_cancelParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelParking.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelParking.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancelParking.Location = new System.Drawing.Point(717, 345);
            this.btn_cancelParking.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelParking.Name = "btn_cancelParking";
            this.btn_cancelParking.Size = new System.Drawing.Size(173, 50);
            this.btn_cancelParking.TabIndex = 9;
            this.btn_cancelParking.Text = "Desistência";
            this.btn_cancelParking.UseVisualStyleBackColor = false;
            this.btn_cancelParking.Click += new System.EventHandler(this.btn_cancelParking_Click);
            this.btn_cancelParking.Enter += new System.EventHandler(this.btn_cancelParking_Enter);
            this.btn_cancelParking.Leave += new System.EventHandler(this.btn_cancelParking_Leave);
            // 
            // btn_finishParking
            // 
            this.btn_finishParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_finishParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(204)))));
            this.btn_finishParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finishParking.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finishParking.ForeColor = System.Drawing.Color.White;
            this.btn_finishParking.Location = new System.Drawing.Point(898, 345);
            this.btn_finishParking.Margin = new System.Windows.Forms.Padding(4);
            this.btn_finishParking.Name = "btn_finishParking";
            this.btn_finishParking.Size = new System.Drawing.Size(143, 50);
            this.btn_finishParking.TabIndex = 8;
            this.btn_finishParking.Text = "Finalizar";
            this.btn_finishParking.UseVisualStyleBackColor = false;
            this.btn_finishParking.Click += new System.EventHandler(this.btn_finishParking_Click);
            this.btn_finishParking.Enter += new System.EventHandler(this.btn_finishParking_Enter);
            this.btn_finishParking.Leave += new System.EventHandler(this.btn_finishParking_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(590, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 27);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cor:";
            // 
            // tbx_ModelDescription
            // 
            this.tbx_ModelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_ModelDescription.Enabled = false;
            this.tbx_ModelDescription.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ModelDescription.Location = new System.Drawing.Point(593, 165);
            this.tbx_ModelDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ModelDescription.Name = "tbx_ModelDescription";
            this.tbx_ModelDescription.Size = new System.Drawing.Size(449, 34);
            this.tbx_ModelDescription.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(590, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Categoria:";
            // 
            // tbx_categoryDescription
            // 
            this.tbx_categoryDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_categoryDescription.Enabled = false;
            this.tbx_categoryDescription.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_categoryDescription.Location = new System.Drawing.Point(591, 234);
            this.tbx_categoryDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_categoryDescription.Name = "tbx_categoryDescription";
            this.tbx_categoryDescription.Size = new System.Drawing.Size(450, 34);
            this.tbx_categoryDescription.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Modelo:";
            // 
            // tbx_colorDescription
            // 
            this.tbx_colorDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_colorDescription.Enabled = false;
            this.tbx_colorDescription.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_colorDescription.Location = new System.Drawing.Point(592, 303);
            this.tbx_colorDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_colorDescription.Name = "tbx_colorDescription";
            this.tbx_colorDescription.Size = new System.Drawing.Size(450, 34);
            this.tbx_colorDescription.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(587, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Placa:";
            // 
            // cbx_plate
            // 
            this.cbx_plate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_plate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_plate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_plate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_plate.FormattingEnabled = true;
            this.cbx_plate.Location = new System.Drawing.Point(592, 90);
            this.cbx_plate.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_plate.Name = "cbx_plate";
            this.cbx_plate.Size = new System.Drawing.Size(220, 34);
            this.cbx_plate.TabIndex = 6;
            this.cbx_plate.SelectedValueChanged += new System.EventHandler(this.cbx_plate_SelectedValueChanged);
            // 
            // btn_clearFinishForm
            // 
            this.btn_clearFinishForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clearFinishForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_clearFinishForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearFinishForm.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearFinishForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clearFinishForm.Location = new System.Drawing.Point(591, 345);
            this.btn_clearFinishForm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearFinishForm.Name = "btn_clearFinishForm";
            this.btn_clearFinishForm.Size = new System.Drawing.Size(118, 50);
            this.btn_clearFinishForm.TabIndex = 10;
            this.btn_clearFinishForm.Text = "Limpar";
            this.btn_clearFinishForm.UseVisualStyleBackColor = false;
            this.btn_clearFinishForm.Click += new System.EventHandler(this.btn_clearFinishForm_Click);
            this.btn_clearFinishForm.Enter += new System.EventHandler(this.btn_clearFinishForm_Enter);
            this.btn_clearFinishForm.Leave += new System.EventHandler(this.btn_clearFinishForm_Leave);
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filter.Location = new System.Drawing.Point(31, 452);
            this.lbl_filter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(81, 27);
            this.lbl_filter.TabIndex = 39;
            this.lbl_filter.Text = "Filtrar:";
            // 
            // tbx_filter
            // 
            this.tbx_filter.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_filter.Location = new System.Drawing.Point(34, 478);
            this.tbx_filter.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_filter.Name = "tbx_filter";
            this.tbx_filter.Size = new System.Drawing.Size(448, 34);
            this.tbx_filter.TabIndex = 40;
            this.tbx_filter.TextChanged += new System.EventHandler(this.tbx_filter_TextChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(1077, 790);
            this.Controls.Add(this.tbx_filter);
            this.Controls.Add(this.lbl_filter);
            this.Controls.Add(this.btn_clearFinishForm);
            this.Controls.Add(this.btn_clearStartForm);
            this.Controls.Add(this.cbx_plate);
            this.Controls.Add(this.tbx_plate);
            this.Controls.Add(this.cbx_colors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.tbx_colorDescription);
            this.Controls.Add(this.cbx_models);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_categoryDescription);
            this.Controls.Add(this.btn_colors);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_truncateParking);
            this.Controls.Add(this.tbx_ModelDescription);
            this.Controls.Add(this.btn_models);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grid_parking);
            this.Controls.Add(this.btn_finishParking);
            this.Controls.Add(this.btn_cancelParking);
            this.Controls.Add(this.btn_categories);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_startParking);
            this.Controls.Add(this.cbx_categories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1055, 750);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Shown += new System.EventHandler(this.Dashboard_Shown);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_parking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label_authentication;
        private System.Windows.Forms.DataGridView grid_parking;
        private System.Windows.Forms.Button btn_truncateParking;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_categories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_startParking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_categories;
        private System.Windows.Forms.Button btn_models;
        private System.Windows.Forms.Button btn_colors;
        private System.Windows.Forms.ComboBox cbx_models;
        private System.Windows.Forms.ComboBox cbx_colors;
        private System.Windows.Forms.TextBox tbx_plate;
        private System.Windows.Forms.Button btn_clearStartForm;
        private System.Windows.Forms.Button btn_cancelParking;
        private System.Windows.Forms.Button btn_finishParking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_ModelDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_categoryDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_colorDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_plate;
        private System.Windows.Forms.Button btn_clearFinishForm;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.TextBox tbx_filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilanizedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanceledAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Increase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
    }
}