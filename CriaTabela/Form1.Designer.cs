namespace CriaTabela
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_cria = new System.Windows.Forms.Button();
            this.tableName = new System.Windows.Forms.TextBox();
            this.fields = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabela = new System.Windows.Forms.Label();
            this.pathName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fields)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cria
            // 
            this.bt_cria.Location = new System.Drawing.Point(173, 279);
            this.bt_cria.Name = "bt_cria";
            this.bt_cria.Size = new System.Drawing.Size(75, 24);
            this.bt_cria.TabIndex = 0;
            this.bt_cria.Text = "Cria Tabela";
            this.bt_cria.UseVisualStyleBackColor = true;
            this.bt_cria.Click += new System.EventHandler(this.criatabela1_Click);
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(116, 44);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(210, 20);
            this.tableName.TabIndex = 1;
            this.tableName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fields
            // 
            this.fields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.tipo,
            this.format});
            this.fields.Location = new System.Drawing.Point(31, 109);
            this.fields.Name = "fields";
            this.fields.Size = new System.Drawing.Size(361, 150);
            this.fields.TabIndex = 2;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Items.AddRange(new object[] {
            "Char",
            "Int",
            "Dec"});
            this.tipo.Name = "tipo";
            this.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // format
            // 
            this.format.HeaderText = "Format";
            this.format.Name = "format";
            // 
            // tabela
            // 
            this.tabela.AutoSize = true;
            this.tabela.Location = new System.Drawing.Point(70, 47);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(40, 13);
            this.tabela.TabIndex = 3;
            this.tabela.Text = "Tabela";
            // 
            // pathName
            // 
            this.pathName.Location = new System.Drawing.Point(116, 71);
            this.pathName.Name = "pathName";
            this.pathName.Size = new System.Drawing.Size(210, 20);
            this.pathName.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pasta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Caminho";
            // 
            // appName
            // 
            this.appName.Location = new System.Drawing.Point(116, 18);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(210, 20);
            this.appName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "App Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathName);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.fields);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.bt_cria);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cria;
        private System.Windows.Forms.TextBox tableName;
        private System.Windows.Forms.DataGridView fields;
        private System.Windows.Forms.Label tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn format;
        private System.Windows.Forms.TextBox pathName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox appName;
        private System.Windows.Forms.Label label2;
    }
}

