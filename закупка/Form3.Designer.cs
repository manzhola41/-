namespace закупка
{
    partial class Form3
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
            System.Windows.Forms.Label код_товараLabel;
            System.Windows.Forms.Label наименование_товараLabel;
            System.Windows.Forms.Label масса_объемLabel;
            System.Windows.Forms.Label артикулLabel;
            System.Windows.Forms.Label производительLabel;
            System.Windows.Forms.Label единица_измеренияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label количество_товаров_на_складеLabel;
            this.закупкаDataSet = new закупка.закупкаDataSet();
            this.продукцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продукцияTableAdapter = new закупка.закупкаDataSetTableAdapters.ПродукцияTableAdapter();
            this.tableAdapterManager = new закупка.закупкаDataSetTableAdapters.TableAdapterManager();
            this.продукцияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.продукцияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.продукцияDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единица_измеренияTextBox = new System.Windows.Forms.TextBox();
            this.количество_товаров_на_складеTextBox = new System.Windows.Forms.TextBox();
            this.производительTextBox = new System.Windows.Forms.TextBox();
            this.артикулTextBox = new System.Windows.Forms.TextBox();
            this.масса_объемTextBox = new System.Windows.Forms.TextBox();
            this.наименование_товараTextBox = new System.Windows.Forms.TextBox();
            this.код_товараComboBox = new System.Windows.Forms.ComboBox();
            код_товараLabel = new System.Windows.Forms.Label();
            наименование_товараLabel = new System.Windows.Forms.Label();
            масса_объемLabel = new System.Windows.Forms.Label();
            артикулLabel = new System.Windows.Forms.Label();
            производительLabel = new System.Windows.Forms.Label();
            единица_измеренияLabel = new System.Windows.Forms.Label();
            количество_товаров_на_складеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingNavigator)).BeginInit();
            this.продукцияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_товараLabel
            // 
            код_товараLabel.AutoSize = true;
            код_товараLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            код_товараLabel.Location = new System.Drawing.Point(61, 312);
            код_товараLabel.Name = "код_товараLabel";
            код_товараLabel.Size = new System.Drawing.Size(84, 16);
            код_товараLabel.TabIndex = 2;
            код_товараLabel.Text = "Код товара:";
            // 
            // наименование_товараLabel
            // 
            наименование_товараLabel.AutoSize = true;
            наименование_товараLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            наименование_товараLabel.Location = new System.Drawing.Point(61, 342);
            наименование_товараLabel.Name = "наименование_товараLabel";
            наименование_товараLabel.Size = new System.Drawing.Size(159, 16);
            наименование_товараLabel.TabIndex = 4;
            наименование_товараLabel.Text = "Наименование товара:";
            // 
            // масса_объемLabel
            // 
            масса_объемLabel.AutoSize = true;
            масса_объемLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            масса_объемLabel.Location = new System.Drawing.Point(61, 370);
            масса_объемLabel.Name = "масса_объемLabel";
            масса_объемLabel.Size = new System.Drawing.Size(97, 16);
            масса_объемLabel.TabIndex = 6;
            масса_объемLabel.Text = "Масса/объем:";
            // 
            // артикулLabel
            // 
            артикулLabel.AutoSize = true;
            артикулLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            артикулLabel.Location = new System.Drawing.Point(61, 398);
            артикулLabel.Name = "артикулLabel";
            артикулLabel.Size = new System.Drawing.Size(65, 16);
            артикулLabel.TabIndex = 8;
            артикулLabel.Text = "Артикул:";
            // 
            // производительLabel
            // 
            производительLabel.AutoSize = true;
            производительLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            производительLabel.Location = new System.Drawing.Point(61, 426);
            производительLabel.Name = "производительLabel";
            производительLabel.Size = new System.Drawing.Size(114, 16);
            производительLabel.TabIndex = 10;
            производительLabel.Text = "Производитель:";
            // 
            // единица_измеренияLabel
            // 
            единица_измеренияLabel.AutoSize = true;
            единица_измеренияLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            единица_измеренияLabel.Location = new System.Drawing.Point(61, 482);
            единица_измеренияLabel.Name = "единица_измеренияLabel";
            единица_измеренияLabel.Size = new System.Drawing.Size(144, 16);
            единица_измеренияLabel.TabIndex = 14;
            единица_измеренияLabel.Text = "Единица измерения:";
            // 
            // закупкаDataSet
            // 
            this.закупкаDataSet.DataSetName = "закупкаDataSet";
            this.закупкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продукцияBindingSource
            // 
            this.продукцияBindingSource.DataMember = "Продукция";
            this.продукцияBindingSource.DataSource = this.закупкаDataSet;
            // 
            // продукцияTableAdapter
            // 
            this.продукцияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = закупка.закупкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Адреса_магазиновTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.ЗакупкиTableAdapter = null;
            this.tableAdapterManager.Контактное_лицоTableAdapter = null;
            this.tableAdapterManager.МагазиныTableAdapter = null;
            this.tableAdapterManager.ПродукцияTableAdapter = this.продукцияTableAdapter;
            // 
            // продукцияBindingNavigator
            // 
            this.продукцияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.продукцияBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.продукцияBindingNavigator.BindingSource = this.продукцияBindingSource;
            this.продукцияBindingNavigator.CountItem = null;
            this.продукцияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.продукцияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.продукцияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.продукцияBindingNavigatorSaveItem});
            this.продукцияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.продукцияBindingNavigator.MoveFirstItem = null;
            this.продукцияBindingNavigator.MoveLastItem = null;
            this.продукцияBindingNavigator.MoveNextItem = null;
            this.продукцияBindingNavigator.MovePreviousItem = null;
            this.продукцияBindingNavigator.Name = "продукцияBindingNavigator";
            this.продукцияBindingNavigator.PositionItem = null;
            this.продукцияBindingNavigator.Size = new System.Drawing.Size(926, 27);
            this.продукцияBindingNavigator.TabIndex = 0;
            this.продукцияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(80, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(69, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // продукцияBindingNavigatorSaveItem
            // 
            this.продукцияBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.продукцияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.продукцияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("продукцияBindingNavigatorSaveItem.Image")));
            this.продукцияBindingNavigatorSaveItem.Name = "продукцияBindingNavigatorSaveItem";
            this.продукцияBindingNavigatorSaveItem.Size = new System.Drawing.Size(144, 28);
            this.продукцияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.продукцияBindingNavigatorSaveItem.Click += new System.EventHandler(this.продукцияBindingNavigatorSaveItem_Click);
            // 
            // продукцияDataGridView
            // 
            this.продукцияDataGridView.AutoGenerateColumns = false;
            this.продукцияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.продукцияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.продукцияDataGridView.DataSource = this.продукцияBindingSource;
            this.продукцияDataGridView.Location = new System.Drawing.Point(0, 58);
            this.продукцияDataGridView.Name = "продукцияDataGridView";
            this.продукцияDataGridView.RowHeadersWidth = 51;
            this.продукцияDataGridView.RowTemplate.Height = 24;
            this.продукцияDataGridView.Size = new System.Drawing.Size(936, 218);
            this.продукцияDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(786, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "НАЗАД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код товара";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код товара";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование товара";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование товара";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Масса/объем";
            this.dataGridViewTextBoxColumn3.HeaderText = "Масса/объем";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Артикул";
            this.dataGridViewTextBoxColumn4.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Производитель";
            this.dataGridViewTextBoxColumn5.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Количество товаров на складе";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество товаров на складе";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Единица измерения";
            this.dataGridViewTextBoxColumn7.HeaderText = "Единица измерения";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // единица_измеренияTextBox
            // 
            this.единица_измеренияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Единица измерения", true));
            this.единица_измеренияTextBox.Location = new System.Drawing.Point(281, 479);
            this.единица_измеренияTextBox.Name = "единица_измеренияTextBox";
            this.единица_измеренияTextBox.Size = new System.Drawing.Size(121, 22);
            this.единица_измеренияTextBox.TabIndex = 15;
            // 
            // количество_товаров_на_складеTextBox
            // 
            this.количество_товаров_на_складеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Количество товаров на складе", true));
            this.количество_товаров_на_складеTextBox.Location = new System.Drawing.Point(281, 451);
            this.количество_товаров_на_складеTextBox.Name = "количество_товаров_на_складеTextBox";
            this.количество_товаров_на_складеTextBox.Size = new System.Drawing.Size(121, 22);
            this.количество_товаров_на_складеTextBox.TabIndex = 13;
            // 
            // количество_товаров_на_складеLabel
            // 
            количество_товаров_на_складеLabel.AutoSize = true;
            количество_товаров_на_складеLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            количество_товаров_на_складеLabel.Location = new System.Drawing.Point(61, 454);
            количество_товаров_на_складеLabel.Name = "количество_товаров_на_складеLabel";
            количество_товаров_на_складеLabel.Size = new System.Drawing.Size(214, 16);
            количество_товаров_на_складеLabel.TabIndex = 12;
            количество_товаров_на_складеLabel.Text = "Количество товаров на складе:";
            // 
            // производительTextBox
            // 
            this.производительTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Производитель", true));
            this.производительTextBox.Location = new System.Drawing.Point(281, 423);
            this.производительTextBox.Name = "производительTextBox";
            this.производительTextBox.Size = new System.Drawing.Size(121, 22);
            this.производительTextBox.TabIndex = 11;
            // 
            // артикулTextBox
            // 
            this.артикулTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Артикул", true));
            this.артикулTextBox.Location = new System.Drawing.Point(281, 395);
            this.артикулTextBox.Name = "артикулTextBox";
            this.артикулTextBox.Size = new System.Drawing.Size(121, 22);
            this.артикулTextBox.TabIndex = 9;
            // 
            // масса_объемTextBox
            // 
            this.масса_объемTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Масса/объем", true));
            this.масса_объемTextBox.Location = new System.Drawing.Point(281, 367);
            this.масса_объемTextBox.Name = "масса_объемTextBox";
            this.масса_объемTextBox.Size = new System.Drawing.Size(121, 22);
            this.масса_объемTextBox.TabIndex = 7;
            // 
            // наименование_товараTextBox
            // 
            this.наименование_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Наименование товара", true));
            this.наименование_товараTextBox.Location = new System.Drawing.Point(281, 339);
            this.наименование_товараTextBox.Name = "наименование_товараTextBox";
            this.наименование_товараTextBox.Size = new System.Drawing.Size(121, 22);
            this.наименование_товараTextBox.TabIndex = 5;
            // 
            // код_товараComboBox
            // 
            this.код_товараComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продукцияBindingSource, "Код товара", true));
            this.код_товараComboBox.FormattingEnabled = true;
            this.код_товараComboBox.Location = new System.Drawing.Point(281, 309);
            this.код_товараComboBox.Name = "код_товараComboBox";
            this.код_товараComboBox.Size = new System.Drawing.Size(121, 24);
            this.код_товараComboBox.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_товараLabel);
            this.Controls.Add(this.код_товараComboBox);
            this.Controls.Add(наименование_товараLabel);
            this.Controls.Add(this.наименование_товараTextBox);
            this.Controls.Add(масса_объемLabel);
            this.Controls.Add(this.масса_объемTextBox);
            this.Controls.Add(артикулLabel);
            this.Controls.Add(this.артикулTextBox);
            this.Controls.Add(производительLabel);
            this.Controls.Add(this.производительTextBox);
            this.Controls.Add(количество_товаров_на_складеLabel);
            this.Controls.Add(this.количество_товаров_на_складеTextBox);
            this.Controls.Add(единица_измеренияLabel);
            this.Controls.Add(this.единица_измеренияTextBox);
            this.Controls.Add(this.продукцияDataGridView);
            this.Controls.Add(this.продукцияBindingNavigator);
            this.Name = "Form3";
            this.Text = "ПРОДУКЦИЯ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingNavigator)).EndInit();
            this.продукцияBindingNavigator.ResumeLayout(false);
            this.продукцияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private закупкаDataSet закупкаDataSet;
        private System.Windows.Forms.BindingSource продукцияBindingSource;
        private закупкаDataSetTableAdapters.ПродукцияTableAdapter продукцияTableAdapter;
        private закупкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator продукцияBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton продукцияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView продукцияDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox единица_измеренияTextBox;
        private System.Windows.Forms.TextBox количество_товаров_на_складеTextBox;
        private System.Windows.Forms.TextBox производительTextBox;
        private System.Windows.Forms.TextBox артикулTextBox;
        private System.Windows.Forms.TextBox масса_объемTextBox;
        private System.Windows.Forms.TextBox наименование_товараTextBox;
        private System.Windows.Forms.ComboBox код_товараComboBox;
    }
}