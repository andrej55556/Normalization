namespace Normalization
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
            dataGridViewAttributes = new DataGridView();
            Аттрибут = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttributes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAttributes
            // 
            dataGridViewAttributes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttributes.Columns.AddRange(new DataGridViewColumn[] { Аттрибут });
            dataGridViewAttributes.Dock = DockStyle.Left;
            dataGridViewAttributes.Location = new Point(0, 0);
            dataGridViewAttributes.Name = "dataGridViewAttributes";
            dataGridViewAttributes.RowHeadersWidth = 51;
            dataGridViewAttributes.Size = new Size(303, 1007);
            dataGridViewAttributes.TabIndex = 0;
            // 
            // Аттрибут
            // 
            Аттрибут.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Аттрибут.HeaderText = "Атрибут";
            Аттрибут.MinimumWidth = 6;
            Аттрибут.Name = "Аттрибут";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(309, 978);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 1007);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewAttributes);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttributes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAttributes;
        private DataGridViewTextBoxColumn Аттрибут;
        private Button buttonSave;
    }
}