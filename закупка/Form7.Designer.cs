namespace закупка
{
    partial class Form7
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
            System.Windows.Forms.Label индивидуальный_номерLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label полLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.закупкаDataSet = new закупка.закупкаDataSet();
            this.контактное_лицоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.контактное_лицоTableAdapter = new закупка.закупкаDataSetTableAdapters.Контактное_лицоTableAdapter();
            this.tableAdapterManager = new закупка.закупкаDataSetTableAdapters.TableAdapterManager();
            this.контактное_лицоBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.контактное_лицоBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.контактное_лицоDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индивидуальный_номерTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            индивидуальный_номерLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоBindingNavigator)).BeginInit();
            this.контактное_лицоBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // индивидуальный_номерLabel
            // 
            индивидуальный_номерLabel.AutoSize = true;
            индивидуальный_номерLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            индивидуальный_номерLabel.Location = new System.Drawing.Point(55, 331);
            индивидуальный_номерLabel.Name = "индивидуальный_номерLabel";
            индивидуальный_номерLabel.Size = new System.Drawing.Size(168, 16);
            индивидуальный_номерLabel.TabIndex = 2;
            индивидуальный_номерLabel.Text = "Индивидуальный номер:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            фамилияLabel.Location = new System.Drawing.Point(55, 359);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 4;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            имяLabel.Location = new System.Drawing.Point(55, 387);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 6;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            отчествоLabel.Location = new System.Drawing.Point(55, 415);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(73, 16);
            отчествоLabel.TabIndex = 8;
            отчествоLabel.Text = "Отчество:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            дата_рожденияLabel.Location = new System.Drawing.Point(55, 443);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(109, 16);
            дата_рожденияLabel.TabIndex = 10;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            полLabel.Location = new System.Drawing.Point(55, 471);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(36, 16);
            полLabel.TabIndex = 12;
            полLabel.Text = "Пол:";
            // 
            // закупкаDataSet
            // 
            this.закупкаDataSet.DataSetName = "закупкаDataSet";
            this.закупкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // контактное_лицоBindingSource
            // 
            this.контактное_лицоBindingSource.DataMember = "Контактное лицо";
            this.контактное_лицоBindingSource.DataSource = this.закупкаDataSet;
            // 
            // контактное_лицоTableAdapter
            // 
            this.контактное_лицоTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = закупка.закупкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Адреса_магазиновTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.ЗакупкиTableAdapter = null;
            this.tableAdapterManager.Контактное_лицоTableAdapter = this.контактное_лицоTableAdapter;
            this.tableAdapterManager.МагазиныTableAdapter = null;
            this.tableAdapterManager.ПродукцияTableAdapter = null;
            // 
            // контактное_лицоBindingNavigator
            // 
            this.контактное_лицоBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.контактное_лицоBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.контактное_лицоBindingNavigator.BindingSource = this.контактное_лицоBindingSource;
            this.контактное_лицоBindingNavigator.CountItem = null;
            this.контактное_лицоBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.контактное_лицоBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.контактное_лицоBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.контактное_лицоBindingNavigatorSaveItem});
            this.контактное_лицоBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.контактное_лицоBindingNavigator.MoveFirstItem = null;
            this.контактное_лицоBindingNavigator.MoveLastItem = null;
            this.контактное_лицоBindingNavigator.MoveNextItem = null;
            this.контактное_лицоBindingNavigator.MovePreviousItem = null;
            this.контактное_лицоBindingNavigator.Name = "контактное_лицоBindingNavigator";
            this.контактное_лицоBindingNavigator.PositionItem = null;
            this.контактное_лицоBindingNavigator.Size = new System.Drawing.Size(801, 27);
            this.контактное_лицоBindingNavigator.TabIndex = 0;
            this.контактное_лицоBindingNavigator.Text = "bindingNavigator1";
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
            // контактное_лицоBindingNavigatorSaveItem
            // 
            this.контактное_лицоBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.контактное_лицоBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.контактное_лицоBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("контактное_лицоBindingNavigatorSaveItem.Image")));
            this.контактное_лицоBindingNavigatorSaveItem.Name = "контактное_лицоBindingNavigatorSaveItem";
            this.контактное_лицоBindingNavigatorSaveItem.Size = new System.Drawing.Size(144, 24);
            this.контактное_лицоBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.контактное_лицоBindingNavigatorSaveItem.Click += new System.EventHandler(this.контактное_лицоBindingNavigatorSaveItem_Click);
            // 
            // контактное_лицоDataGridView
            // 
            this.контактное_лицоDataGridView.AutoGenerateColumns = false;
            this.контактное_лицоDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.контактное_лицоDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.контактное_лицоDataGridView.DataSource = this.контактное_лицоBindingSource;
            this.контактное_лицоDataGridView.Location = new System.Drawing.Point(0, 72);
            this.контактное_лицоDataGridView.Name = "контактное_лицоDataGridView";
            this.контактное_лицоDataGridView.RowHeadersWidth = 51;
            this.контактное_лицоDataGridView.RowTemplate.Height = 24;
            this.контактное_лицоDataGridView.Size = new System.Drawing.Size(803, 220);
            this.контактное_лицоDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Индивидуальный номер";
            this.dataGridViewTextBoxColumn1.HeaderText = "Индивидуальный номер";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn6.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // индивидуальный_номерTextBox
            // 
            this.индивидуальный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.контактное_лицоBindingSource, "Индивидуальный номер", true));
            this.индивидуальный_номерTextBox.Location = new System.Drawing.Point(229, 328);
            this.индивидуальный_номерTextBox.Name = "индивидуальный_номерTextBox";
            this.индивидуальный_номерTextBox.Size = new System.Drawing.Size(100, 22);
            this.индивидуальный_номерTextBox.TabIndex = 3;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.контактное_лицоBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(229, 356);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(100, 22);
            this.фамилияTextBox.TabIndex = 5;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.контактное_лицоBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(229, 384);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 22);
            this.имяTextBox.TabIndex = 7;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.контактное_лицоBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(229, 412);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(100, 22);
            this.отчествоTextBox.TabIndex = 9;
            // 
            // дата_рожденияTextBox
            // 
            this.дата_рожденияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.контактное_лицоBindingSource, "Дата рождения", true));
            this.дата_рожденияTextBox.Location = new System.Drawing.Point(229, 440);
            this.дата_рожденияTextBox.Name = "дата_рожденияTextBox";
            this.дата_рожденияTextBox.Size = new System.Drawing.Size(100, 22);
            this.дата_рожденияTextBox.TabIndex = 11;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.контактное_лицоBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(229, 468);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(100, 22);
            this.полTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(698, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "НАЗАД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(индивидуальный_номерLabel);
            this.Controls.Add(this.индивидуальный_номерTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(this.контактное_лицоDataGridView);
            this.Controls.Add(this.контактное_лицоBindingNavigator);
            this.Name = "Form7";
            this.Text = "КОНТАКТНОЕ ЛИЦО";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоBindingNavigator)).EndInit();
            this.контактное_лицоBindingNavigator.ResumeLayout(false);
            this.контактное_лицоBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.контактное_лицоDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private закупкаDataSet закупкаDataSet;
        private System.Windows.Forms.BindingSource контактное_лицоBindingSource;
        private закупкаDataSetTableAdapters.Контактное_лицоTableAdapter контактное_лицоTableAdapter;
        private закупкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator контактное_лицоBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton контактное_лицоBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView контактное_лицоDataGridView;
        private System.Windows.Forms.TextBox индивидуальный_номерTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox дата_рожденияTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}