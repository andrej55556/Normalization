namespace Normalization
{
    partial class FormAttributes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAttributes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttributes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAttributes
            // 
            dataGridViewAttributes.AllowUserToOrderColumns = true;
            dataGridViewAttributes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAttributes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewAttributes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttributes.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewAttributes.Dock = DockStyle.Left;
            dataGridViewAttributes.Location = new Point(0, 0);
            dataGridViewAttributes.Name = "dataGridViewAttributes";
            dataGridViewAttributes.RowHeadersWidth = 51;
            dataGridViewAttributes.Size = new Size(552, 869);
            dataGridViewAttributes.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Атрибут";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 94;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(558, 828);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormAttributes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2003, 869);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewAttributes);
            Name = "FormAttributes";
            Text = "Атрибуты";
            Load += FormAttributes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttributes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAttributes;
        private DataGridViewTextBoxColumn Column1;
        private Button buttonSave;
    }
}
