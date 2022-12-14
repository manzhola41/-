namespace закупка
{
    partial class Form6
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
            System.Windows.Forms.Label индексLabel;
            System.Windows.Forms.Label городLabel;
            System.Windows.Forms.Label улицаLabel;
            System.Windows.Forms.Label номер_домаLabel;
            System.Windows.Forms.Label регистационный_номерLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.закупкаDataSet = new закупка.закупкаDataSet();
            this.адреса_магазиновBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.адреса_магазиновTableAdapter = new закупка.закупкаDataSetTableAdapters.Адреса_магазиновTableAdapter();
            this.tableAdapterManager = new закупка.закупкаDataSetTableAdapters.TableAdapterManager();
            this.адреса_магазиновBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.адреса_магазиновBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.адреса_магазиновDataGridView = new System.Windows.Forms.DataGridView();
            this.индексTextBox = new System.Windows.Forms.TextBox();
            this.городTextBox = new System.Windows.Forms.TextBox();
            this.улицаTextBox = new System.Windows.Forms.TextBox();
            this.номер_домаTextBox = new System.Windows.Forms.TextBox();
            this.регистационный_номерTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            индексLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            улицаLabel = new System.Windows.Forms.Label();
            номер_домаLabel = new System.Windows.Forms.Label();
            регистационный_номерLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адреса_магазиновBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.адреса_магазиновBindingNavigator)).BeginInit();
            this.адреса_магазиновBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.адреса_магазиновDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // индексLabel
            // 
            индексLabel.AutoSize = true;
            индексLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            индексLabel.Location = new System.Drawing.Point(46, 307);
            индексLabel.Name = "индексLabel";
            индексLabel.Size = new System.Drawing.Size(58, 16);
            индексLabel.TabIndex = 2;
            индексLabel.Text = "Индекс:";
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            городLabel.Location = new System.Drawing.Point(46, 335);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(49, 16);
            городLabel.TabIndex = 4;
            городLabel.Text = "Город:";
            // 
            // улицаLabel
            // 
            улицаLabel.AutoSize = true;
            улицаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            улицаLabel.Location = new System.Drawing.Point(46, 363);
            улицаLabel.Name = "улицаLabel";
            улицаLabel.Size = new System.Drawing.Size(51, 16);
            улицаLabel.TabIndex = 6;
            улицаLabel.Text = "Улица:";
            // 
            // номер_домаLabel
            // 
            номер_домаLabel.AutoSize = true;
            номер_домаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            номер_домаLabel.Location = new System.Drawing.Point(46, 391);
            номер_домаLabel.Name = "номер_домаLabel";
            номер_домаLabel.Size = new System.Drawing.Size(89, 16);
            номер_домаLabel.TabIndex = 8;
            номер_домаLabel.Text = "Номер дома:";
            // 
            // регистационный_номерLabel
            // 
            регистационный_номерLabel.AutoSize = true;
            регистационный_номерLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            регистационный_номерLabel.Location = new System.Drawing.Point(46, 419);
            регистационный_номерLabel.Name = "регистационный_номерLabel";
            регистационный_номерLabel.Size = new System.Drawing.Size(164, 16);
            регистационный_номерLabel.TabIndex = 10;
            регистационный_номерLabel.Text = "Регистационный номер:";
            // 
            // закупкаDataSet
            // 
            this.закупкаDataSet.DataSetName = "закупкаDataSet";
            this.закупкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // адреса_магазиновBindingSource
            // 
            this.адреса_магазиновBindingSource.DataMember = "Адреса магазинов";
            this.адреса_магазиновBindingSource.DataSource = this.закупкаDataSet;
            // 
            // адреса_магазиновTableAdapter
            // 
            this.адреса_магазиновTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = закупка.закупкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Адреса_магазиновTableAdapter = this.адреса_магазиновTableAdapter;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.ЗакупкиTableAdapter = null;
            this.tableAdapterManager.Контактное_лицоTableAdapter = null;
            this.tableAdapterManager.МагазиныTableAdapter = null;
            this.tableAdapterManager.ПродукцияTableAdapter = null;
            // 
            // адреса_магазиновBindingNavigator
            // 
            this.адреса_магазиновBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.адреса_магазиновBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.адреса_магазиновBindingNavigator.BindingSource = this.адреса_магазиновBindingSource;
            this.адреса_магазиновBindingNavigator.CountItem = null;
            this.адреса_магазиновBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.адреса_магазиновBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.адреса_магазиновBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.адреса_магазиновBindingNavigatorSaveItem});
            this.адреса_магазиновBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.адреса_магазиновBindingNavigator.MoveFirstItem = null;
            this.адреса_магазиновBindingNavigator.MoveLastItem = null;
            this.адреса_магазиновBindingNavigator.MoveNextItem = null;
            this.адреса_магазиновBindingNavigator.MovePreviousItem = null;
            this.адреса_магазиновBindingNavigator.Name = "адреса_магазиновBindingNavigator";
            this.адреса_магазиновBindingNavigator.PositionItem = null;
            this.адреса_магазиновBindingNavigator.Size = new System.Drawing.Size(674, 27);
            this.адреса_магазиновBindingNavigator.TabIndex = 0;
            this.адреса_магазиновBindingNavigator.Text = "bindingNavigator1";
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
            // адреса_магазиновBindingNavigatorSaveItem
            // 
            this.адреса_магазиновBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.адреса_магазиновBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.адреса_магазиновBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("адреса_магазиновBindingNavigatorSaveItem.Image")));
            this.адреса_магазиновBindingNavigatorSaveItem.Name = "адреса_магазиновBindingNavigatorSaveItem";
            this.адреса_магазиновBindingNavigatorSaveItem.Size = new System.Drawing.Size(144, 24);
            this.адреса_магазиновBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.адреса_магазиновBindingNavigatorSaveItem.Click += new System.EventHandler(this.адреса_магазиновBindingNavigatorSaveItem_Click);
            // 
            // адреса_магазиновDataGridView
            // 
            this.адреса_магазиновDataGridView.AutoGenerateColumns = false;
            this.адреса_магазиновDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.адреса_магазиновDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.адреса_магазиновDataGridView.DataSource = this.адреса_магазиновBindingSource;
            this.адреса_магазиновDataGridView.Location = new System.Drawing.Point(0, 62);
            this.адреса_магазиновDataGridView.Name = "адреса_магазиновDataGridView";
            this.адреса_магазиновDataGridView.RowHeadersWidth = 51;
            this.адреса_магазиновDataGridView.RowTemplate.Height = 24;
            this.адреса_магазиновDataGridView.Size = new System.Drawing.Size(678, 220);
            this.адреса_магазиновDataGridView.TabIndex = 1;
            // 
            // индексTextBox
            // 
            this.индексTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адреса_магазиновBindingSource, "Индекс", true));
            this.индексTextBox.Location = new System.Drawing.Point(216, 304);
            this.индексTextBox.Name = "индексTextBox";
            this.индексTextBox.Size = new System.Drawing.Size(100, 22);
            this.индексTextBox.TabIndex = 3;
            // 
            // городTextBox
            // 
            this.городTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адреса_магазиновBindingSource, "Город", true));
            this.городTextBox.Location = new System.Drawing.Point(216, 332);
            this.городTextBox.Name = "городTextBox";
            this.городTextBox.Size = new System.Drawing.Size(100, 22);
            this.городTextBox.TabIndex = 5;
            // 
            // улицаTextBox
            // 
            this.улицаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адреса_магазиновBindingSource, "Улица", true));
            this.улицаTextBox.Location = new System.Drawing.Point(216, 360);
            this.улицаTextBox.Name = "улицаTextBox";
            this.улицаTextBox.Size = new System.Drawing.Size(100, 22);
            this.улицаTextBox.TabIndex = 7;
            // 
            // номер_домаTextBox
            // 
            this.номер_домаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адреса_магазиновBindingSource, "Номер дома", true));
            this.номер_домаTextBox.Location = new System.Drawing.Point(216, 388);
            this.номер_домаTextBox.Name = "номер_домаTextBox";
            this.номер_домаTextBox.Size = new System.Drawing.Size(100, 22);
            this.номер_домаTextBox.TabIndex = 9;
            // 
            // регистационный_номерTextBox
            // 
            this.регистационный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.адреса_магазиновBindingSource, "Регистационный номер", true));
            this.регистационный_номерTextBox.Location = new System.Drawing.Point(216, 416);
            this.регистационный_номерTextBox.Name = "регистационный_номерTextBox";
            this.регистационный_номерTextBox.Size = new System.Drawing.Size(100, 22);
            this.регистационный_номерTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(568, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "НАЗАД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Индекс";
            this.dataGridViewTextBoxColumn1.HeaderText = "Индекс";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Город";
            this.dataGridViewTextBoxColumn2.HeaderText = "Город";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Улица";
            this.dataGridViewTextBoxColumn3.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер дома";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер дома";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Регистационный номер";
            this.dataGridViewTextBoxColumn5.HeaderText = "Регистационный номер";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(индексLabel);
            this.Controls.Add(this.индексTextBox);
            this.Controls.Add(городLabel);
            this.Controls.Add(this.городTextBox);
            this.Controls.Add(улицаLabel);
            this.Controls.Add(this.улицаTextBox);
            this.Controls.Add(номер_домаLabel);
            this.Controls.Add(this.номер_домаTextBox);
            this.Controls.Add(регистационный_номерLabel);
            this.Controls.Add(this.регистационный_номерTextBox);
            this.Controls.Add(this.адреса_магазиновDataGridView);
            this.Controls.Add(this.адреса_магазиновBindingNavigator);
            this.Name = "Form6";
            this.Text = "АДРЕСА МАГАЗИНОВ";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адреса_магазиновBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.адреса_магазиновBindingNavigator)).EndInit();
            this.адреса_магазиновBindingNavigator.ResumeLayout(false);
            this.адреса_магазиновBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.адреса_магазиновDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private закупкаDataSet закупкаDataSet;
        private System.Windows.Forms.BindingSource адреса_магазиновBindingSource;
        private закупкаDataSetTableAdapters.Адреса_магазиновTableAdapter адреса_магазиновTableAdapter;
        private закупкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator адреса_магазиновBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton адреса_магазиновBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView адреса_магазиновDataGridView;
        private System.Windows.Forms.TextBox индексTextBox;
        private System.Windows.Forms.TextBox городTextBox;
        private System.Windows.Forms.TextBox улицаTextBox;
        private System.Windows.Forms.TextBox номер_домаTextBox;
        private System.Windows.Forms.TextBox регистационный_номерTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}