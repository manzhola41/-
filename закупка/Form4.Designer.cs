namespace закупка
{
    partial class Form4
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
            System.Windows.Forms.Label цена_закупочнаяLabel;
            System.Windows.Forms.Label цена_отпускнаяLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.закупкаDataSet = new закупка.закупкаDataSet();
            this.закупкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.закупкиTableAdapter = new закупка.закупкаDataSetTableAdapters.ЗакупкиTableAdapter();
            this.tableAdapterManager = new закупка.закупкаDataSetTableAdapters.TableAdapterManager();
            this.закупкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.закупкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.закупкиDataGridView = new System.Windows.Forms.DataGridView();
            this.код_товараTextBox = new System.Windows.Forms.TextBox();
            this.цена_закупочнаяTextBox = new System.Windows.Forms.TextBox();
            this.цена_отпускнаяTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_товараLabel = new System.Windows.Forms.Label();
            цена_закупочнаяLabel = new System.Windows.Forms.Label();
            цена_отпускнаяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.закупкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.закупкиBindingNavigator)).BeginInit();
            this.закупкиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.закупкиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_товараLabel
            // 
            код_товараLabel.AutoSize = true;
            код_товараLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            код_товараLabel.Location = new System.Drawing.Point(28, 299);
            код_товараLabel.Name = "код_товараLabel";
            код_товараLabel.Size = new System.Drawing.Size(84, 16);
            код_товараLabel.TabIndex = 2;
            код_товараLabel.Text = "Код товара:";
            // 
            // цена_закупочнаяLabel
            // 
            цена_закупочнаяLabel.AutoSize = true;
            цена_закупочнаяLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            цена_закупочнаяLabel.Location = new System.Drawing.Point(28, 327);
            цена_закупочнаяLabel.Name = "цена_закупочнаяLabel";
            цена_закупочнаяLabel.Size = new System.Drawing.Size(124, 16);
            цена_закупочнаяLabel.TabIndex = 4;
            цена_закупочнаяLabel.Text = "Цена закупочная:";
            // 
            // цена_отпускнаяLabel
            // 
            цена_отпускнаяLabel.AutoSize = true;
            цена_отпускнаяLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            цена_отпускнаяLabel.Location = new System.Drawing.Point(28, 355);
            цена_отпускнаяLabel.Name = "цена_отпускнаяLabel";
            цена_отпускнаяLabel.Size = new System.Drawing.Size(114, 16);
            цена_отпускнаяLabel.TabIndex = 6;
            цена_отпускнаяLabel.Text = "Цена отпускная:";
            // 
            // закупкаDataSet
            // 
            this.закупкаDataSet.DataSetName = "закупкаDataSet";
            this.закупкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // закупкиBindingSource
            // 
            this.закупкиBindingSource.DataMember = "Закупки";
            this.закупкиBindingSource.DataSource = this.закупкаDataSet;
            // 
            // закупкиTableAdapter
            // 
            this.закупкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = закупка.закупкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Адреса_магазиновTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.ЗакупкиTableAdapter = this.закупкиTableAdapter;
            this.tableAdapterManager.Контактное_лицоTableAdapter = null;
            this.tableAdapterManager.МагазиныTableAdapter = null;
            this.tableAdapterManager.ПродукцияTableAdapter = null;
            // 
            // закупкиBindingNavigator
            // 
            this.закупкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.закупкиBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.закупкиBindingNavigator.BindingSource = this.закупкиBindingSource;
            this.закупкиBindingNavigator.CountItem = null;
            this.закупкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.закупкиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.закупкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.закупкиBindingNavigatorSaveItem});
            this.закупкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.закупкиBindingNavigator.MoveFirstItem = null;
            this.закупкиBindingNavigator.MoveLastItem = null;
            this.закупкиBindingNavigator.MoveNextItem = null;
            this.закупкиBindingNavigator.MovePreviousItem = null;
            this.закупкиBindingNavigator.Name = "закупкиBindingNavigator";
            this.закупкиBindingNavigator.PositionItem = null;
            this.закупкиBindingNavigator.Size = new System.Drawing.Size(425, 27);
            this.закупкиBindingNavigator.TabIndex = 0;
            this.закупкиBindingNavigator.Text = "bindingNavigator1";
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
            // закупкиBindingNavigatorSaveItem
            // 
            this.закупкиBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.закупкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.закупкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("закупкиBindingNavigatorSaveItem.Image")));
            this.закупкиBindingNavigatorSaveItem.Name = "закупкиBindingNavigatorSaveItem";
            this.закупкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(144, 24);
            this.закупкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.закупкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.закупкиBindingNavigatorSaveItem_Click);
            // 
            // закупкиDataGridView
            // 
            this.закупкиDataGridView.AutoGenerateColumns = false;
            this.закупкиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.закупкиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.закупкиDataGridView.DataSource = this.закупкиBindingSource;
            this.закупкиDataGridView.Location = new System.Drawing.Point(0, 41);
            this.закупкиDataGridView.Name = "закупкиDataGridView";
            this.закупкиDataGridView.RowHeadersWidth = 51;
            this.закупкиDataGridView.RowTemplate.Height = 24;
            this.закупкиDataGridView.Size = new System.Drawing.Size(440, 220);
            this.закупкиDataGridView.TabIndex = 1;
            // 
            // код_товараTextBox
            // 
            this.код_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.закупкиBindingSource, "Код товара", true));
            this.код_товараTextBox.Location = new System.Drawing.Point(158, 293);
            this.код_товараTextBox.Name = "код_товараTextBox";
            this.код_товараTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_товараTextBox.TabIndex = 3;
            // 
            // цена_закупочнаяTextBox
            // 
            this.цена_закупочнаяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.закупкиBindingSource, "Цена закупочная", true));
            this.цена_закупочнаяTextBox.Location = new System.Drawing.Point(158, 324);
            this.цена_закупочнаяTextBox.Name = "цена_закупочнаяTextBox";
            this.цена_закупочнаяTextBox.Size = new System.Drawing.Size(100, 22);
            this.цена_закупочнаяTextBox.TabIndex = 5;
            // 
            // цена_отпускнаяTextBox
            // 
            this.цена_отпускнаяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.закупкиBindingSource, "Цена отпускная", true));
            this.цена_отпускнаяTextBox.Location = new System.Drawing.Point(158, 352);
            this.цена_отпускнаяTextBox.Name = "цена_отпускнаяTextBox";
            this.цена_отпускнаяTextBox.Size = new System.Drawing.Size(100, 22);
            this.цена_отпускнаяTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(323, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 8;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Цена закупочная";
            this.dataGridViewTextBoxColumn2.HeaderText = "Цена закупочная";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Цена отпускная";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена отпускная";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_товараLabel);
            this.Controls.Add(this.код_товараTextBox);
            this.Controls.Add(цена_закупочнаяLabel);
            this.Controls.Add(this.цена_закупочнаяTextBox);
            this.Controls.Add(цена_отпускнаяLabel);
            this.Controls.Add(this.цена_отпускнаяTextBox);
            this.Controls.Add(this.закупкиDataGridView);
            this.Controls.Add(this.закупкиBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form4";
            this.Text = "ЗАКУПКИ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.закупкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.закупкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.закупкиBindingNavigator)).EndInit();
            this.закупкиBindingNavigator.ResumeLayout(false);
            this.закупкиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.закупкиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private закупкаDataSet закупкаDataSet;
        private System.Windows.Forms.BindingSource закупкиBindingSource;
        private закупкаDataSetTableAdapters.ЗакупкиTableAdapter закупкиTableAdapter;
        private закупкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator закупкиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton закупкиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView закупкиDataGridView;
        private System.Windows.Forms.TextBox код_товараTextBox;
        private System.Windows.Forms.TextBox цена_закупочнаяTextBox;
        private System.Windows.Forms.TextBox цена_отпускнаяTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}