﻿namespace BusquedaDinamicaDataGridView
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            textSearch = new TextBox();
            comboBoxColumns = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(548, 358);
            dataGridView1.TabIndex = 0;
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Segoe UI", 12F);
            textSearch.Location = new Point(12, 30);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(371, 29);
            textSearch.TabIndex = 1;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // comboBoxColumns
            // 
            comboBoxColumns.Font = new Font("Segoe UI", 12F);
            comboBoxColumns.FormattingEnabled = true;
            comboBoxColumns.Location = new Point(399, 30);
            comboBoxColumns.Name = "comboBoxColumns";
            comboBoxColumns.Size = new Size(161, 29);
            comboBoxColumns.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 458);
            Controls.Add(comboBoxColumns);
            Controls.Add(textSearch);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textSearch;
        private ComboBox comboBoxColumns;
    }
}
