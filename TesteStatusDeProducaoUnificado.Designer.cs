﻿
namespace PANDOKS_V1._0
{
    partial class TesteStatusDeProducaoUnificado
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
            System.Windows.Forms.Label id_producaoLabel;
            System.Windows.Forms.Label data_producaoLabel;
            System.Windows.Forms.Label time_producaoLabel;
            System.Windows.Forms.Label qtd_producaoLabel;
            System.Windows.Forms.Label kg_producaoLabel;
            System.Windows.Forms.Label un_producaoLabel;
            System.Windows.Forms.Label id_produtoLabel;
            System.Windows.Forms.Label id_colaboradorLabel;
            System.Windows.Forms.Label nome_produtoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TesteStatusDeProducaoUnificado));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnproximo = new System.Windows.Forms.Button();
            this.database_padarianovoDataSet = new PANDOKS_V1._0.database_padarianovoDataSet();
            this.producaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producaoTableAdapter = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.producaoTableAdapter();
            this.tableAdapterManager = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.TableAdapterManager();
            this.producaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.producaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_producaoTextBox = new System.Windows.Forms.TextBox();
            this.data_producaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_producaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qtd_producaoTextBox = new System.Windows.Forms.TextBox();
            this.kg_producaoCheckBox = new System.Windows.Forms.CheckBox();
            this.un_producaoCheckBox = new System.Windows.Forms.CheckBox();
            this.id_produtoTextBox = new System.Windows.Forms.TextBox();
            this.id_colaboradorTextBox = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.produtoTableAdapter();
            this.nome_produtoTextBox = new System.Windows.Forms.TextBox();
            id_producaoLabel = new System.Windows.Forms.Label();
            data_producaoLabel = new System.Windows.Forms.Label();
            time_producaoLabel = new System.Windows.Forms.Label();
            qtd_producaoLabel = new System.Windows.Forms.Label();
            kg_producaoLabel = new System.Windows.Forms.Label();
            un_producaoLabel = new System.Windows.Forms.Label();
            id_produtoLabel = new System.Windows.Forms.Label();
            id_colaboradorLabel = new System.Windows.Forms.Label();
            nome_produtoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingNavigator)).BeginInit();
            this.producaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_producaoLabel
            // 
            id_producaoLabel.AutoSize = true;
            id_producaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            id_producaoLabel.Location = new System.Drawing.Point(35, 103);
            id_producaoLabel.Name = "id_producaoLabel";
            id_producaoLabel.Size = new System.Drawing.Size(175, 33);
            id_producaoLabel.TabIndex = 81;
            id_producaoLabel.Text = "id producao:";
            // 
            // data_producaoLabel
            // 
            data_producaoLabel.AutoSize = true;
            data_producaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            data_producaoLabel.Location = new System.Drawing.Point(35, 151);
            data_producaoLabel.Name = "data_producaoLabel";
            data_producaoLabel.Size = new System.Drawing.Size(208, 33);
            data_producaoLabel.TabIndex = 83;
            data_producaoLabel.Text = "data producao:";
            // 
            // time_producaoLabel
            // 
            time_producaoLabel.AutoSize = true;
            time_producaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            time_producaoLabel.Location = new System.Drawing.Point(35, 205);
            time_producaoLabel.Name = "time_producaoLabel";
            time_producaoLabel.Size = new System.Drawing.Size(208, 33);
            time_producaoLabel.TabIndex = 85;
            time_producaoLabel.Text = "time producao:";
            // 
            // qtd_producaoLabel
            // 
            qtd_producaoLabel.AutoSize = true;
            qtd_producaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            qtd_producaoLabel.Location = new System.Drawing.Point(35, 261);
            qtd_producaoLabel.Name = "qtd_producaoLabel";
            qtd_producaoLabel.Size = new System.Drawing.Size(192, 33);
            qtd_producaoLabel.TabIndex = 87;
            qtd_producaoLabel.Text = "qtd producao:";
            qtd_producaoLabel.Click += new System.EventHandler(this.qtd_producaoLabel_Click);
            // 
            // kg_producaoLabel
            // 
            kg_producaoLabel.AutoSize = true;
            kg_producaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            kg_producaoLabel.Location = new System.Drawing.Point(35, 320);
            kg_producaoLabel.Name = "kg_producaoLabel";
            kg_producaoLabel.Size = new System.Drawing.Size(64, 33);
            kg_producaoLabel.TabIndex = 89;
            kg_producaoLabel.Text = "Kilo";
            kg_producaoLabel.Click += new System.EventHandler(this.kg_producaoLabel_Click);
            // 
            // un_producaoLabel
            // 
            un_producaoLabel.AutoSize = true;
            un_producaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            un_producaoLabel.Location = new System.Drawing.Point(35, 374);
            un_producaoLabel.Name = "un_producaoLabel";
            un_producaoLabel.Size = new System.Drawing.Size(123, 33);
            un_producaoLabel.TabIndex = 91;
            un_producaoLabel.Text = "Unidade";
            un_producaoLabel.Click += new System.EventHandler(this.un_producaoLabel_Click);
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            id_produtoLabel.Location = new System.Drawing.Point(35, 429);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(158, 33);
            id_produtoLabel.TabIndex = 93;
            id_produtoLabel.Text = "ID produto:";
            id_produtoLabel.Click += new System.EventHandler(this.id_produtoLabel_Click);
            // 
            // id_colaboradorLabel
            // 
            id_colaboradorLabel.AutoSize = true;
            id_colaboradorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            id_colaboradorLabel.Location = new System.Drawing.Point(41, 486);
            id_colaboradorLabel.Name = "id_colaboradorLabel";
            id_colaboradorLabel.Size = new System.Drawing.Size(214, 33);
            id_colaboradorLabel.TabIndex = 95;
            id_colaboradorLabel.Text = "ID colaborador:";
            // 
            // nome_produtoLabel
            // 
            nome_produtoLabel.AutoSize = true;
            nome_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            nome_produtoLabel.Location = new System.Drawing.Point(41, 56);
            nome_produtoLabel.Name = "nome_produtoLabel";
            nome_produtoLabel.Size = new System.Drawing.Size(202, 33);
            nome_produtoLabel.TabIndex = 96;
            nome_produtoLabel.Text = "nome produto:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.button3.Image = global::PANDOKS_V1._0.Properties.Resources.undo256_24848;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(586, 555);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 62);
            this.button3.TabIndex = 52;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::PANDOKS_V1._0.Properties.Resources.Folder_Accept256_24860;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(165, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 62);
            this.button2.TabIndex = 51;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.BackColor = System.Drawing.Color.Transparent;
            this.btnanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnanterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.btnanterior.Image = global::PANDOKS_V1._0.Properties.Resources.navigate_left256_24869;
            this.btnanterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnanterior.Location = new System.Drawing.Point(309, 555);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(109, 62);
            this.btnanterior.TabIndex = 80;
            this.btnanterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnanterior.UseVisualStyleBackColor = false;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnproximo
            // 
            this.btnproximo.BackColor = System.Drawing.Color.Transparent;
            this.btnproximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnproximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproximo.Font = new System.Drawing.Font("Forte", 20F, System.Drawing.FontStyle.Bold);
            this.btnproximo.Image = global::PANDOKS_V1._0.Properties.Resources.navigate_right256_24872;
            this.btnproximo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnproximo.Location = new System.Drawing.Point(446, 555);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(109, 62);
            this.btnproximo.TabIndex = 79;
            this.btnproximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnproximo.UseVisualStyleBackColor = false;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // database_padarianovoDataSet
            // 
            this.database_padarianovoDataSet.DataSetName = "database_padarianovoDataSet";
            this.database_padarianovoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producaoBindingSource
            // 
            this.producaoBindingSource.DataMember = "producao";
            this.producaoBindingSource.DataSource = this.database_padarianovoDataSet;
            // 
            // producaoTableAdapter
            // 
            this.producaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cargoTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.colaboradorTableAdapter = null;
            this.tableAdapterManager.pedido_produtoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.producaoTableAdapter = this.producaoTableAdapter;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.tipo_pedidoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PANDOKS_V1._0.database_padarianovoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // producaoBindingNavigator
            // 
            this.producaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.producaoBindingNavigator.BindingSource = this.producaoBindingSource;
            this.producaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.producaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.producaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.producaoBindingNavigatorSaveItem});
            this.producaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.producaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.producaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.producaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.producaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.producaoBindingNavigator.Name = "producaoBindingNavigator";
            this.producaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.producaoBindingNavigator.Size = new System.Drawing.Size(869, 25);
            this.producaoBindingNavigator.TabIndex = 81;
            this.producaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // producaoBindingNavigatorSaveItem
            // 
            this.producaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.producaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("producaoBindingNavigatorSaveItem.Image")));
            this.producaoBindingNavigatorSaveItem.Name = "producaoBindingNavigatorSaveItem";
            this.producaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.producaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.producaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.producaoBindingNavigatorSaveItem_Click);
            // 
            // id_producaoTextBox
            // 
            this.id_producaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producaoBindingSource, "id_producao", true));
            this.id_producaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.id_producaoTextBox.Location = new System.Drawing.Point(258, 100);
            this.id_producaoTextBox.Name = "id_producaoTextBox";
            this.id_producaoTextBox.Size = new System.Drawing.Size(200, 40);
            this.id_producaoTextBox.TabIndex = 82;
            this.id_producaoTextBox.TextChanged += new System.EventHandler(this.id_producaoTextBox_TextChanged);
            // 
            // data_producaoDateTimePicker
            // 
            this.data_producaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.producaoBindingSource, "data_producao", true));
            this.data_producaoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.data_producaoDateTimePicker.Location = new System.Drawing.Point(258, 151);
            this.data_producaoDateTimePicker.Name = "data_producaoDateTimePicker";
            this.data_producaoDateTimePicker.Size = new System.Drawing.Size(575, 40);
            this.data_producaoDateTimePicker.TabIndex = 84;
            // 
            // time_producaoDateTimePicker
            // 
            this.time_producaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.producaoBindingSource, "time_producao", true));
            this.time_producaoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.time_producaoDateTimePicker.Location = new System.Drawing.Point(258, 205);
            this.time_producaoDateTimePicker.Name = "time_producaoDateTimePicker";
            this.time_producaoDateTimePicker.Size = new System.Drawing.Size(575, 40);
            this.time_producaoDateTimePicker.TabIndex = 86;
            // 
            // qtd_producaoTextBox
            // 
            this.qtd_producaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producaoBindingSource, "qtd_producao", true));
            this.qtd_producaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.qtd_producaoTextBox.Location = new System.Drawing.Point(258, 261);
            this.qtd_producaoTextBox.Name = "qtd_producaoTextBox";
            this.qtd_producaoTextBox.Size = new System.Drawing.Size(200, 40);
            this.qtd_producaoTextBox.TabIndex = 88;
            this.qtd_producaoTextBox.TextChanged += new System.EventHandler(this.qtd_producaoTextBox_TextChanged);
            // 
            // kg_producaoCheckBox
            // 
            this.kg_producaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.producaoBindingSource, "kg_producao", true));
            this.kg_producaoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.kg_producaoCheckBox.Location = new System.Drawing.Point(258, 320);
            this.kg_producaoCheckBox.Name = "kg_producaoCheckBox";
            this.kg_producaoCheckBox.Size = new System.Drawing.Size(200, 36);
            this.kg_producaoCheckBox.TabIndex = 90;
            this.kg_producaoCheckBox.UseVisualStyleBackColor = true;
            this.kg_producaoCheckBox.CheckedChanged += new System.EventHandler(this.kg_producaoCheckBox_CheckedChanged);
            // 
            // un_producaoCheckBox
            // 
            this.un_producaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.producaoBindingSource, "un_producao", true));
            this.un_producaoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.un_producaoCheckBox.Location = new System.Drawing.Point(258, 374);
            this.un_producaoCheckBox.Name = "un_producaoCheckBox";
            this.un_producaoCheckBox.Size = new System.Drawing.Size(200, 36);
            this.un_producaoCheckBox.TabIndex = 92;
            this.un_producaoCheckBox.UseVisualStyleBackColor = true;
            this.un_producaoCheckBox.CheckedChanged += new System.EventHandler(this.un_producaoCheckBox_CheckedChanged);
            // 
            // id_produtoTextBox
            // 
            this.id_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producaoBindingSource, "id_produto", true));
            this.id_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.id_produtoTextBox.Location = new System.Drawing.Point(258, 429);
            this.id_produtoTextBox.Name = "id_produtoTextBox";
            this.id_produtoTextBox.Size = new System.Drawing.Size(200, 40);
            this.id_produtoTextBox.TabIndex = 94;
            this.id_produtoTextBox.TextChanged += new System.EventHandler(this.id_produtoTextBox_TextChanged);
            // 
            // id_colaboradorTextBox
            // 
            this.id_colaboradorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producaoBindingSource, "id_colaborador", true));
            this.id_colaboradorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.id_colaboradorTextBox.Location = new System.Drawing.Point(264, 486);
            this.id_colaboradorTextBox.Name = "id_colaboradorTextBox";
            this.id_colaboradorTextBox.Size = new System.Drawing.Size(200, 40);
            this.id_colaboradorTextBox.TabIndex = 96;
            this.id_colaboradorTextBox.TextChanged += new System.EventHandler(this.id_colaboradorTextBox_TextChanged);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.database_padarianovoDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // nome_produtoTextBox
            // 
            this.nome_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome_produto", true));
            this.nome_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.nome_produtoTextBox.Location = new System.Drawing.Point(258, 53);
            this.nome_produtoTextBox.Name = "nome_produtoTextBox";
            this.nome_produtoTextBox.Size = new System.Drawing.Size(200, 40);
            this.nome_produtoTextBox.TabIndex = 97;
            this.nome_produtoTextBox.TextChanged += new System.EventHandler(this.nome_produtoTextBox_TextChanged);
            // 
            // TesteStatusDeProducaoUnificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 657);
            this.Controls.Add(nome_produtoLabel);
            this.Controls.Add(this.nome_produtoTextBox);
            this.Controls.Add(id_producaoLabel);
            this.Controls.Add(this.id_producaoTextBox);
            this.Controls.Add(data_producaoLabel);
            this.Controls.Add(this.data_producaoDateTimePicker);
            this.Controls.Add(time_producaoLabel);
            this.Controls.Add(this.time_producaoDateTimePicker);
            this.Controls.Add(qtd_producaoLabel);
            this.Controls.Add(this.qtd_producaoTextBox);
            this.Controls.Add(kg_producaoLabel);
            this.Controls.Add(this.kg_producaoCheckBox);
            this.Controls.Add(un_producaoLabel);
            this.Controls.Add(this.un_producaoCheckBox);
            this.Controls.Add(id_produtoLabel);
            this.Controls.Add(this.id_produtoTextBox);
            this.Controls.Add(id_colaboradorLabel);
            this.Controls.Add(this.id_colaboradorTextBox);
            this.Controls.Add(this.producaoBindingNavigator);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnproximo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "TesteStatusDeProducaoUnificado";
            this.Text = "TesteStatusDeProducaoUnificado";
            this.Load += new System.EventHandler(this.TesteStatusDeProducaoUnificado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database_padarianovoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoBindingNavigator)).EndInit();
            this.producaoBindingNavigator.ResumeLayout(false);
            this.producaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnproximo;
        private database_padarianovoDataSet database_padarianovoDataSet;
        private System.Windows.Forms.BindingSource producaoBindingSource;
        private database_padarianovoDataSetTableAdapters.producaoTableAdapter producaoTableAdapter;
        private database_padarianovoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator producaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton producaoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_producaoTextBox;
        private System.Windows.Forms.DateTimePicker data_producaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker time_producaoDateTimePicker;
        private System.Windows.Forms.TextBox qtd_producaoTextBox;
        private System.Windows.Forms.CheckBox kg_producaoCheckBox;
        private System.Windows.Forms.CheckBox un_producaoCheckBox;
        private System.Windows.Forms.TextBox id_produtoTextBox;
        private System.Windows.Forms.TextBox id_colaboradorTextBox;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private database_padarianovoDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.TextBox nome_produtoTextBox;
    }
}