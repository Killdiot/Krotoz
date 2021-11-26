
namespace Krotoz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_archivo_nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_archivo_abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_archivo_guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_archivo_guardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Edicion = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Formato = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Lexico = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Fases_Lexico = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Fases_Sintaxis = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Fases_Semantico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSintaxis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLexico = new System.Windows.Forms.DataGridView();
            this.lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new ns1.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexico)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblFileName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(639, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 38);
            this.panel5.TabIndex = 4;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblFileName.Location = new System.Drawing.Point(22, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(79, 20);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "New File *";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(639, 38);
            this.panel4.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Archivo,
            this.menu_Edicion,
            this.menu_Formato,
            this.menu_Lexico,
            this.menuSintaxis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_Archivo
            // 
            this.menu_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_archivo_nuevo,
            this.menu_archivo_abrir,
            this.menu_archivo_guardar,
            this.menu_archivo_guardarComo});
            this.menu_Archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Archivo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menu_Archivo.Name = "menu_Archivo";
            this.menu_Archivo.Size = new System.Drawing.Size(86, 34);
            this.menu_Archivo.Text = "Archivo";
            // 
            // menu_archivo_nuevo
            // 
            this.menu_archivo_nuevo.Name = "menu_archivo_nuevo";
            this.menu_archivo_nuevo.Size = new System.Drawing.Size(219, 28);
            this.menu_archivo_nuevo.Text = "Nuevo...";
            this.menu_archivo_nuevo.Click += new System.EventHandler(this.menu_archivo_nuevo_Click);
            // 
            // menu_archivo_abrir
            // 
            this.menu_archivo_abrir.Name = "menu_archivo_abrir";
            this.menu_archivo_abrir.Size = new System.Drawing.Size(219, 28);
            this.menu_archivo_abrir.Text = "Abrir";
            this.menu_archivo_abrir.Click += new System.EventHandler(this.menu_archivo_abrir_Click);
            // 
            // menu_archivo_guardar
            // 
            this.menu_archivo_guardar.Name = "menu_archivo_guardar";
            this.menu_archivo_guardar.Size = new System.Drawing.Size(219, 28);
            this.menu_archivo_guardar.Text = "Guardar";
            this.menu_archivo_guardar.Click += new System.EventHandler(this.menu_archivo_guardar_Click);
            // 
            // menu_archivo_guardarComo
            // 
            this.menu_archivo_guardarComo.Name = "menu_archivo_guardarComo";
            this.menu_archivo_guardarComo.Size = new System.Drawing.Size(219, 28);
            this.menu_archivo_guardarComo.Text = "Guardar Como...";
            this.menu_archivo_guardarComo.Click += new System.EventHandler(this.menu_archivo_guardarComo_Click);
            // 
            // menu_Edicion
            // 
            this.menu_Edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.menu_Edicion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menu_Edicion.Name = "menu_Edicion";
            this.menu_Edicion.Size = new System.Drawing.Size(86, 34);
            this.menu_Edicion.Text = "Edicion";
            // 
            // menu_Formato
            // 
            this.menu_Formato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.menu_Formato.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menu_Formato.Name = "menu_Formato";
            this.menu_Formato.Size = new System.Drawing.Size(92, 34);
            this.menu_Formato.Text = "Formato";
            // 
            // menu_Lexico
            // 
            this.menu_Lexico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Fases_Lexico,
            this.menu_Fases_Sintaxis,
            this.menu_Fases_Semantico});
            this.menu_Lexico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.menu_Lexico.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menu_Lexico.Name = "menu_Lexico";
            this.menu_Lexico.Size = new System.Drawing.Size(73, 34);
            this.menu_Lexico.Text = "Fases";
            // 
            // menu_Fases_Lexico
            // 
            this.menu_Fases_Lexico.Name = "menu_Fases_Lexico";
            this.menu_Fases_Lexico.Size = new System.Drawing.Size(169, 28);
            this.menu_Fases_Lexico.Text = "Léxico";
            this.menu_Fases_Lexico.Click += new System.EventHandler(this.menu_Lexico_Click);
            // 
            // menu_Fases_Sintaxis
            // 
            this.menu_Fases_Sintaxis.Name = "menu_Fases_Sintaxis";
            this.menu_Fases_Sintaxis.Size = new System.Drawing.Size(169, 28);
            this.menu_Fases_Sintaxis.Text = "Sintaxis";
            this.menu_Fases_Sintaxis.Click += new System.EventHandler(this.menuSintaxis_Click);
            // 
            // menu_Fases_Semantico
            // 
            this.menu_Fases_Semantico.Name = "menu_Fases_Semantico";
            this.menu_Fases_Semantico.Size = new System.Drawing.Size(169, 28);
            this.menu_Fases_Semantico.Text = "Semántico";
            this.menu_Fases_Semantico.Click += new System.EventHandler(this.menu_semantico_Click);
            // 
            // menuSintaxis
            // 
            this.menuSintaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.menuSintaxis.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menuSintaxis.Name = "menuSintaxis";
            this.menuSintaxis.Size = new System.Drawing.Size(112, 34);
            this.menuSintaxis.Text = "Ensamblar";
            this.menuSintaxis.Click += new System.EventHandler(this.menuSintaxis_Click_1);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnMin.Location = new System.Drawing.Point(920, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 38);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Gold;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnMax.Location = new System.Drawing.Point(960, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 38);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnClose.Location = new System.Drawing.Point(1000, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.dgvVariables);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvErrores);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvLexico);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(815, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 602);
            this.panel2.TabIndex = 1;
            // 
            // dgvVariables
            // 
            this.dgvVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVariables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvVariables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.variable,
            this.tipo,
            this.valorIn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVariables.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVariables.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVariables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dgvVariables.Location = new System.Drawing.Point(0, 352);
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.RowHeadersVisible = false;
            this.dgvVariables.Size = new System.Drawing.Size(225, 204);
            this.dgvVariables.TabIndex = 5;
            // 
            // variable
            // 
            this.variable.HeaderText = "Variable";
            this.variable.Name = "variable";
            this.variable.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // valorIn
            // 
            this.valorIn.HeaderText = "Valor Inicial";
            this.valorIn.Name = "valorIn";
            this.valorIn.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Variables";
            // 
            // dgvErrores
            // 
            this.dgvErrores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvErrores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvErrores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.error,
            this.descripcion,
            this.lineaError});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvErrores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvErrores.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvErrores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dgvErrores.Location = new System.Drawing.Point(0, 176);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.RowHeadersVisible = false;
            this.dgvErrores.Size = new System.Drawing.Size(225, 163);
            this.dgvErrores.TabIndex = 3;
            // 
            // error
            // 
            this.error.HeaderText = "Error";
            this.error.Name = "error";
            this.error.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // lineaError
            // 
            this.lineaError.HeaderText = "Linea";
            this.lineaError.Name = "lineaError";
            this.lineaError.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Errores";
            // 
            // dgvLexico
            // 
            this.dgvLexico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLexico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvLexico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLexico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvLexico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLexico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLexico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lexema,
            this.token,
            this.linea});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLexico.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLexico.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLexico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dgvLexico.Location = new System.Drawing.Point(0, 13);
            this.dgvLexico.Name = "dgvLexico";
            this.dgvLexico.RowHeadersVisible = false;
            this.dgvLexico.Size = new System.Drawing.Size(225, 150);
            this.dgvLexico.TabIndex = 1;
            // 
            // lexema
            // 
            this.lexema.HeaderText = "Lexema";
            this.lexema.Name = "lexema";
            this.lexema.ReadOnly = true;
            // 
            // token
            // 
            this.token.HeaderText = "Token";
            this.token.Name = "token";
            this.token.ReadOnly = true;
            // 
            // linea
            // 
            this.linea.HeaderText = "Linea";
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lexema";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.panel3.Controls.Add(this.txtEditor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.panel3.Size = new System.Drawing.Size(815, 602);
            this.panel3.TabIndex = 2;
            // 
            // txtEditor
            // 
            this.txtEditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtEditor.Location = new System.Drawing.Point(15, 15);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditor.Size = new System.Drawing.Size(800, 572);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.WordWrap = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel5;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblFileName;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.menuStrip1;
            this.bunifuDragControl3.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexico)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_Archivo;
        private System.Windows.Forms.ToolStripMenuItem menu_Edicion;
        private System.Windows.Forms.ToolStripMenuItem menu_Formato;
        private System.Windows.Forms.ToolStripMenuItem menu_Lexico;
        private System.Windows.Forms.ToolStripMenuItem menuSintaxis;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ToolStripMenuItem menu_archivo_nuevo;
        private System.Windows.Forms.ToolStripMenuItem menu_archivo_abrir;
        private System.Windows.Forms.ToolStripMenuItem menu_archivo_guardar;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.ToolStripMenuItem menu_archivo_guardarComo;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLexico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaError;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn token;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea;
        private System.Windows.Forms.DataGridView dgvVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem menu_Fases_Lexico;
        private System.Windows.Forms.ToolStripMenuItem menu_Fases_Sintaxis;
        private System.Windows.Forms.ToolStripMenuItem menu_Fases_Semantico;
    }
}

