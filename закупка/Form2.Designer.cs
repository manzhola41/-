namespace закупка
{
    partial class Form2
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
            System.Windows.Forms.Label код_магазинаLabel;
            System.Windows.Forms.Label ___заказаLabel;
            System.Windows.Forms.Label код_товараLabel;
            System.Windows.Forms.Label количество_товаровLabel;
            System.Windows.Forms.Label дата_заказаLabel;
            System.Windows.Forms.Label тип_оплатыLabel;
            System.Windows.Forms.Label доставкаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.закупкаDataSet = new закупка.закупкаDataSet();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new закупка.закупкаDataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new закупка.закупкаDataSetTableAdapters.TableAdapterManager();
            this.заказыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заказыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.заказыDataGridView = new System.Windows.Forms.DataGridView();
            this.код_магазинаTextBox = new System.Windows.Forms.TextBox();
            this.___заказаTextBox = new System.Windows.Forms.TextBox();
            this.код_товараTextBox = new System.Windows.Forms.TextBox();
            this.количество_товаровTextBox = new System.Windows.Forms.TextBox();
            this.дата_заказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.тип_оплатыTextBox = new System.Windows.Forms.TextBox();
            this.доставкаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_магазинаLabel = new System.Windows.Forms.Label();
            ___заказаLabel = new System.Windows.Forms.Label();
            код_товараLabel = new System.Windows.Forms.Label();
            количество_товаровLabel = new System.Windows.Forms.Label();
            дата_заказаLabel = new System.Windows.Forms.Label();
            тип_оплатыLabel = new System.Windows.Forms.Label();
            доставкаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).BeginInit();
            this.заказыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_магазинаLabel
            // 
            код_магазинаLabel.AutoSize = true;
            код_магазинаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            код_магазинаLabel.Location = new System.Drawing.Point(37, 298);
            код_магазинаLabel.Name = "код_магазинаLabel";
            код_магазинаLabel.Size = new System.Drawing.Size(100, 16);
            код_магазинаLabel.TabIndex = 2;
            код_магазинаLabel.Text = "Код магазина:";
            // 
            // ___заказаLabel
            // 
            ___заказаLabel.AutoSize = true;
            ___заказаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            ___заказаLabel.Location = new System.Drawing.Point(37, 326);
            ___заказаLabel.Name = "___заказаLabel";
            ___заказаLabel.Size = new System.Drawing.Size(74, 16);
            ___заказаLabel.TabIndex = 4;
            ___заказаLabel.Text = "№ заказа:";
            // 
            // код_товараLabel
            // 
            код_товараLabel.AutoSize = true;
            код_товараLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            код_товараLabel.Location = new System.Drawing.Point(37, 354);
            код_товараLabel.Name = "код_товараLabel";
            код_товараLabel.Size = new System.Drawing.Size(84, 16);
            код_товараLabel.TabIndex = 6;
            код_товараLabel.Text = "Код товара:";
            // 
            // количество_товаровLabel
            // 
            количество_товаровLabel.AutoSize = true;
            количество_товаровLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            количество_товаровLabel.Location = new System.Drawing.Point(37, 382);
            количество_товаровLabel.Name = "количество_товаровLabel";
            количество_товаровLabel.Size = new System.Drawing.Size(146, 16);
            количество_товаровLabel.TabIndex = 8;
            количество_товаровLabel.Text = "Количество товаров:";
            // 
            // дата_заказаLabel
            // 
            дата_заказаLabel.AutoSize = true;
            дата_заказаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            дата_заказаLabel.Location = new System.Drawing.Point(37, 411);
            дата_заказаLabel.Name = "дата_заказаLabel";
            дата_заказаLabel.Size = new System.Drawing.Size(92, 16);
            дата_заказаLabel.TabIndex = 10;
            дата_заказаLabel.Text = "Дата заказа:";
            // 
            // тип_оплатыLabel
            // 
            тип_оплатыLabel.AutoSize = true;
            тип_оплатыLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            тип_оплатыLabel.Location = new System.Drawing.Point(37, 438);
            тип_оплатыLabel.Name = "тип_оплатыLabel";
            тип_оплатыLabel.Size = new System.Drawing.Size(86, 16);
            тип_оплатыLabel.TabIndex = 12;
            тип_оплатыLabel.Text = "Тип оплаты:";
            // 
            // доставкаLabel
            // 
            доставкаLabel.AutoSize = true;
            доставкаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            доставкаLabel.Location = new System.Drawing.Point(37, 467);
            доставкаLabel.Name = "доставкаLabel";
            доставкаLabel.Size = new System.Drawing.Size(72, 16);
            доставкаLabel.TabIndex = 14;
            доставкаLabel.Text = "Доставка:";
            // 
            // закупкаDataSet
            // 
            this.закупкаDataSet.DataSetName = "закупкаDataSet";
            this.закупкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.закупкаDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = закупка.закупкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Адреса_магазиновTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.ЗакупкиTableAdapter = null;
            this.tableAdapterManager.Контактное_лицоTableAdapter = null;
            this.tableAdapterManager.МагазиныTableAdapter = null;
            this.tableAdapterManager.ПродукцияTableAdapter = null;
            // 
            // заказыBindingNavigator
            // 
            this.заказыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказыBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.заказыBindingNavigator.BindingSource = this.заказыBindingSource;
            this.заказыBindingNavigator.CountItem = null;
            this.заказыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.заказыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.заказыBindingNavigatorSaveItem});
            this.заказыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказыBindingNavigator.MoveFirstItem = null;
            this.заказыBindingNavigator.MoveLastItem = null;
            this.заказыBindingNavigator.MoveNextItem = null;
            this.заказыBindingNavigator.MovePreviousItem = null;
            this.заказыBindingNavigator.Name = "заказыBindingNavigator";
            this.заказыBindingNavigator.PositionItem = null;
            this.заказыBindingNavigator.Size = new System.Drawing.Size(925, 27);
            this.заказыBindingNavigator.TabIndex = 0;
            this.заказыBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(69, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // заказыBindingNavigatorSaveItem
            // 
            this.заказыBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.заказыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.заказыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыBindingNavigatorSaveItem.Image")));
            this.заказыBindingNavigatorSaveItem.Name = "заказыBindingNavigatorSaveItem";
            this.заказыBindingNavigatorSaveItem.Size = new System.Drawing.Size(144, 24);
            this.заказыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказыBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказыBindingNavigatorSaveItem_Click);
            // 
            // заказыDataGridView
            // 
            this.заказыDataGridView.AutoGenerateColumns = false;
            this.заказыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заказыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.заказыDataGridView.DataSource = this.заказыBindingSource;
            this.заказыDataGridView.Location = new System.Drawing.Point(0, 56);
            this.заказыDataGridView.Name = "заказыDataGridView";
            this.заказыDataGridView.RowHeadersWidth = 51;
            this.заказыDataGridView.RowTemplate.Height = 24;
            this.заказыDataGridView.Size = new System.Drawing.Size(940, 216);
            this.заказыDataGridView.TabIndex = 1;
            // 
            // код_магазинаTextBox
            // 
            this.код_магазинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код магазина", true));
            this.код_магазинаTextBox.Location = new System.Drawing.Point(189, 295);
            this.код_магазинаTextBox.Name = "код_магазинаTextBox";
            this.код_магазинаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_магазинаTextBox.TabIndex = 3;
            // 
            // ___заказаTextBox
            // 
            this.___заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "№ заказа", true));
            this.___заказаTextBox.Location = new System.Drawing.Point(189, 323);
            this.___заказаTextBox.Name = "___заказаTextBox";
            this.___заказаTextBox.Size = new System.Drawing.Size(200, 22);
            this.___заказаTextBox.TabIndex = 5;
            // 
            // код_товараTextBox
            // 
            this.код_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код товара", true));
            this.код_товараTextBox.Location = new System.Drawing.Point(189, 351);
            this.код_товараTextBox.Name = "код_товараTextBox";
            this.код_товараTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_товараTextBox.TabIndex = 7;
            // 
            // количество_товаровTextBox
            // 
            this.количество_товаровTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Количество товаров", true));
            this.количество_товаровTextBox.Location = new System.Drawing.Point(189, 379);
            this.количество_товаровTextBox.Name = "количество_товаровTextBox";
            this.количество_товаровTextBox.Size = new System.Drawing.Size(200, 22);
            this.количество_товаровTextBox.TabIndex = 9;
            // 
            // дата_заказаDateTimePicker
            // 
            this.дата_заказаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Дата заказа", true));
            this.дата_заказаDateTimePicker.Location = new System.Drawing.Point(189, 407);
            this.дата_заказаDateTimePicker.Name = "дата_заказаDateTimePicker";
            this.дата_заказаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_заказаDateTimePicker.TabIndex = 11;
            // 
            // тип_оплатыTextBox
            // 
            this.тип_оплатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Тип оплаты", true));
            this.тип_оплатыTextBox.Location = new System.Drawing.Point(189, 435);
            this.тип_оплатыTextBox.Name = "тип_оплатыTextBox";
            this.тип_оплатыTextBox.Size = new System.Drawing.Size(200, 22);
            this.тип_оплатыTextBox.TabIndex = 13;
            // 
            // доставкаDateTimePicker
            // 
            this.доставкаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Доставка", true));
            this.доставкаDateTimePicker.Location = new System.Drawing.Point(189, 463);
            this.доставкаDateTimePicker.Name = "доставкаDateTimePicker";
            this.доставкаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.доставкаDateTimePicker.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(802, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "НАЗАД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код магазина";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код магазина";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "№ заказа";
            this.dataGridViewTextBoxColumn2.HeaderText = "№ заказа";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код товара";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код товара";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Количество товаров";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество товаров";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата заказа";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата заказа";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Тип оплаты";
            this.dataGridViewTextBoxColumn6.HeaderText = "Тип оплаты";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Доставка";
            this.dataGridViewTextBoxColumn7.HeaderText = "Доставка";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_магазинаLabel);
            this.Controls.Add(this.код_магазинаTextBox);
            this.Controls.Add(___заказаLabel);
            this.Controls.Add(this.___заказаTextBox);
            this.Controls.Add(код_товараLabel);
            this.Controls.Add(this.код_товараTextBox);
            this.Controls.Add(количество_товаровLabel);
            this.Controls.Add(this.количество_товаровTextBox);
            this.Controls.Add(дата_заказаLabel);
            this.Controls.Add(this.дата_заказаDateTimePicker);
            this.Controls.Add(тип_оплатыLabel);
            this.Controls.Add(this.тип_оплатыTextBox);
            this.Controls.Add(доставкаLabel);
            this.Controls.Add(this.доставкаDateTimePicker);
            this.Controls.Add(this.заказыDataGridView);
            this.Controls.Add(this.заказыBindingNavigator);
            this.Name = "Form2";
            this.Text = "ЗАКАЗЫ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).EndInit();
            this.заказыBindingNavigator.ResumeLayout(false);
            this.заказыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private закупкаDataSet закупкаDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private закупкаDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private закупкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton заказыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView заказыDataGridView;
        private System.Windows.Forms.TextBox код_магазинаTextBox;
        private System.Windows.Forms.TextBox ___заказаTextBox;
        private System.Windows.Forms.TextBox код_товараTextBox;
        private System.Windows.Forms.TextBox количество_товаровTextBox;
        private System.Windows.Forms.DateTimePicker дата_заказаDateTimePicker;
        private System.Windows.Forms.TextBox тип_оплатыTextBox;
        private System.Windows.Forms.DateTimePicker доставкаDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}