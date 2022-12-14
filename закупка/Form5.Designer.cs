namespace закупка
{
    partial class Form5
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
            System.Windows.Forms.Label название_магазинаLabel;
            System.Windows.Forms.Label код_магазинаLabel;
            System.Windows.Forms.Label регистационный_номерLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label электронная_почтаLabel;
            System.Windows.Forms.Label индивидуальный_номер_контактного_лицаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.закупкаDataSet = new закупка.закупкаDataSet();
            this.магазиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.магазиныTableAdapter = new закупка.закупкаDataSetTableAdapters.МагазиныTableAdapter();
            this.tableAdapterManager = new закупка.закупкаDataSetTableAdapters.TableAdapterManager();
            this.магазиныBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.магазиныBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.магазиныDataGridView = new System.Windows.Forms.DataGridView();
            this.название_магазинаTextBox = new System.Windows.Forms.TextBox();
            this.код_магазинаTextBox = new System.Windows.Forms.TextBox();
            this.регистационный_номерTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.электронная_почтаTextBox = new System.Windows.Forms.TextBox();
            this.индивидуальный_номер_контактного_лицаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            название_магазинаLabel = new System.Windows.Forms.Label();
            код_магазинаLabel = new System.Windows.Forms.Label();
            регистационный_номерLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            электронная_почтаLabel = new System.Windows.Forms.Label();
            индивидуальный_номер_контактного_лицаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиныBindingNavigator)).BeginInit();
            this.магазиныBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.магазиныDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // название_магазинаLabel
            // 
            название_магазинаLabel.AutoSize = true;
            название_магазинаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            название_магазинаLabel.Location = new System.Drawing.Point(56, 339);
            название_магазинаLabel.Name = "название_магазинаLabel";
            название_магазинаLabel.Size = new System.Drawing.Size(142, 16);
            название_магазинаLabel.TabIndex = 2;
            название_магазинаLabel.Text = "Название магазина:";
            // 
            // код_магазинаLabel
            // 
            код_магазинаLabel.AutoSize = true;
            код_магазинаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            код_магазинаLabel.Location = new System.Drawing.Point(56, 367);
            код_магазинаLabel.Name = "код_магазинаLabel";
            код_магазинаLabel.Size = new System.Drawing.Size(100, 16);
            код_магазинаLabel.TabIndex = 4;
            код_магазинаLabel.Text = "Код магазина:";
            // 
            // регистационный_номерLabel
            // 
            регистационный_номерLabel.AutoSize = true;
            регистационный_номерLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            регистационный_номерLabel.Location = new System.Drawing.Point(56, 395);
            регистационный_номерLabel.Name = "регистационный_номерLabel";
            регистационный_номерLabel.Size = new System.Drawing.Size(164, 16);
            регистационный_номерLabel.TabIndex = 6;
            регистационный_номерLabel.Text = "Регистационный номер:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            телефонLabel.Location = new System.Drawing.Point(56, 423);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 8;
            телефонLabel.Text = "Телефон:";
            // 
            // электронная_почтаLabel
            // 
            электронная_почтаLabel.AutoSize = true;
            электронная_почтаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            электронная_почтаLabel.Location = new System.Drawing.Point(56, 451);
            электронная_почтаLabel.Name = "электронная_почтаLabel";
            электронная_почтаLabel.Size = new System.Drawing.Size(139, 16);
            электронная_почтаLabel.TabIndex = 10;
            электронная_почтаLabel.Text = "Электронная почта:";
            // 
            // индивидуальный_номер_контактного_лицаLabel
            // 
            индивидуальный_номер_контактного_лицаLabel.AutoSize = true;
            индивидуальный_номер_контактного_лицаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            индивидуальный_номер_контактного_лицаLabel.Location = new System.Drawing.Point(56, 479);
            индивидуальный_номер_контактного_лицаLabel.Name = "индивидуальный_номер_контактного_лицаLabel";
            индивидуальный_номер_контактного_лицаLabel.Size = new System.Drawing.Size(288, 16);
            индивидуальный_номер_контактного_лицаLabel.TabIndex = 12;
            индивидуальный_номер_контактного_лицаLabel.Text = "Индивидуальный номер контактного лица:";
            // 
            // закупкаDataSet
            // 
            this.закупкаDataSet.DataSetName = "закупкаDataSet";
            this.закупкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // магазиныBindingSource
            // 
            this.магазиныBindingSource.DataMember = "Магазины";
            this.магазиныBindingSource.DataSource = this.закупкаDataSet;
            // 
            // магазиныTableAdapter
            // 
            this.магазиныTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = закупка.закупкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Адреса_магазиновTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.ЗакупкиTableAdapter = null;
            this.tableAdapterManager.Контактное_лицоTableAdapter = null;
            this.tableAdapterManager.МагазиныTableAdapter = this.магазиныTableAdapter;
            this.tableAdapterManager.ПродукцияTableAdapter = null;
            // 
            // магазиныBindingNavigator
            // 
            this.магазиныBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.магазиныBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.магазиныBindingNavigator.BindingSource = this.магазиныBindingSource;
            this.магазиныBindingNavigator.CountItem = null;
            this.магазиныBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.магазиныBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.магазиныBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.магазиныBindingNavigatorSaveItem});
            this.магазиныBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.магазиныBindingNavigator.MoveFirstItem = null;
            this.магазиныBindingNavigator.MoveLastItem = null;
            this.магазиныBindingNavigator.MoveNextItem = null;
            this.магазиныBindingNavigator.MovePreviousItem = null;
            this.магазиныBindingNavigator.Name = "магазиныBindingNavigator";
            this.магазиныBindingNavigator.PositionItem = null;
            this.магазиныBindingNavigator.Size = new System.Drawing.Size(824, 27);
            this.магазиныBindingNavigator.TabIndex = 0;
            this.магазиныBindingNavigator.Text = "bindingNavigator1";
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
            // магазиныBindingNavigatorSaveItem
            // 
            this.магазиныBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.магазиныBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.магазиныBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("магазиныBindingNavigatorSaveItem.Image")));
            this.магазиныBindingNavigatorSaveItem.Name = "магазиныBindingNavigatorSaveItem";
            this.магазиныBindingNavigatorSaveItem.Size = new System.Drawing.Size(144, 24);
            this.магазиныBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.магазиныBindingNavigatorSaveItem.Click += new System.EventHandler(this.магазиныBindingNavigatorSaveItem_Click);
            // 
            // магазиныDataGridView
            // 
            this.магазиныDataGridView.AutoGenerateColumns = false;
            this.магазиныDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.магазиныDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.магазиныDataGridView.DataSource = this.магазиныBindingSource;
            this.магазиныDataGridView.Location = new System.Drawing.Point(12, 78);
            this.магазиныDataGridView.Name = "магазиныDataGridView";
            this.магазиныDataGridView.RowHeadersWidth = 51;
            this.магазиныDataGridView.RowTemplate.Height = 24;
            this.магазиныDataGridView.Size = new System.Drawing.Size(803, 220);
            this.магазиныDataGridView.TabIndex = 1;
            // 
            // название_магазинаTextBox
            // 
            this.название_магазинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.магазиныBindingSource, "Название магазина", true));
            this.название_магазинаTextBox.Location = new System.Drawing.Point(350, 336);
            this.название_магазинаTextBox.Name = "название_магазинаTextBox";
            this.название_магазинаTextBox.Size = new System.Drawing.Size(100, 22);
            this.название_магазинаTextBox.TabIndex = 3;
            // 
            // код_магазинаTextBox
            // 
            this.код_магазинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.магазиныBindingSource, "Код магазина", true));
            this.код_магазинаTextBox.Location = new System.Drawing.Point(350, 364);
            this.код_магазинаTextBox.Name = "код_магазинаTextBox";
            this.код_магазинаTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_магазинаTextBox.TabIndex = 5;
            // 
            // регистационный_номерTextBox
            // 
            this.регистационный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.магазиныBindingSource, "Регистационный номер", true));
            this.регистационный_номерTextBox.Location = new System.Drawing.Point(350, 392);
            this.регистационный_номерTextBox.Name = "регистационный_номерTextBox";
            this.регистационный_номерTextBox.Size = new System.Drawing.Size(100, 22);
            this.регистационный_номерTextBox.TabIndex = 7;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.магазиныBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(350, 420);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 22);
            this.телефонTextBox.TabIndex = 9;
            // 
            // электронная_почтаTextBox
            // 
            this.электронная_почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.магазиныBindingSource, "Электронная почта", true));
            this.электронная_почтаTextBox.Location = new System.Drawing.Point(350, 448);
            this.электронная_почтаTextBox.Name = "электронная_почтаTextBox";
            this.электронная_почтаTextBox.Size = new System.Drawing.Size(100, 22);
            this.электронная_почтаTextBox.TabIndex = 11;
            // 
            // индивидуальный_номер_контактного_лицаTextBox
            // 
            this.индивидуальный_номер_контактного_лицаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.магазиныBindingSource, "Индивидуальный номер контактного лица", true));
            this.индивидуальный_номер_контактного_лицаTextBox.Location = new System.Drawing.Point(350, 476);
            this.индивидуальный_номер_контактного_лицаTextBox.Name = "индивидуальный_номер_контактного_лицаTextBox";
            this.индивидуальный_номер_контактного_лицаTextBox.Size = new System.Drawing.Size(100, 22);
            this.индивидуальный_номер_контактного_лицаTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(682, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "НАЗАД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название магазина";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название магазина";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код магазина";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код магазина";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Регистационный номер";
            this.dataGridViewTextBoxColumn3.HeaderText = "Регистационный номер";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Электронная почта";
            this.dataGridViewTextBoxColumn5.HeaderText = "Электронная почта";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Индивидуальный номер контактного лица";
            this.dataGridViewTextBoxColumn6.HeaderText = "Индивидуальный номер контактного лица";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(название_магазинаLabel);
            this.Controls.Add(this.название_магазинаTextBox);
            this.Controls.Add(код_магазинаLabel);
            this.Controls.Add(this.код_магазинаTextBox);
            this.Controls.Add(регистационный_номерLabel);
            this.Controls.Add(this.регистационный_номерTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(электронная_почтаLabel);
            this.Controls.Add(this.электронная_почтаTextBox);
            this.Controls.Add(индивидуальный_номер_контактного_лицаLabel);
            this.Controls.Add(this.индивидуальный_номер_контактного_лицаTextBox);
            this.Controls.Add(this.магазиныDataGridView);
            this.Controls.Add(this.магазиныBindingNavigator);
            this.Name = "Form5";
            this.Text = "МАГАЗИНЫ";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиныBindingNavigator)).EndInit();
            this.магазиныBindingNavigator.ResumeLayout(false);
            this.магазиныBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.магазиныDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private закупкаDataSet закупкаDataSet;
        private System.Windows.Forms.BindingSource магазиныBindingSource;
        private закупкаDataSetTableAdapters.МагазиныTableAdapter магазиныTableAdapter;
        private закупкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator магазиныBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton магазиныBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView магазиныDataGridView;
        private System.Windows.Forms.TextBox название_магазинаTextBox;
        private System.Windows.Forms.TextBox код_магазинаTextBox;
        private System.Windows.Forms.TextBox регистационный_номерTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox электронная_почтаTextBox;
        private System.Windows.Forms.TextBox индивидуальный_номер_контактного_лицаTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}