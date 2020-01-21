namespace SystemForCollectWaste
{
    partial class ArgumentsListForms
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
            this.ArgumentsListGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Attach = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArgumentsListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ArgumentsListGridView
            // 
            this.ArgumentsListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArgumentsListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.ArgumentsListGridView.Location = new System.Drawing.Point(12, 25);
            this.ArgumentsListGridView.Name = "ArgumentsListGridView";
            this.ArgumentsListGridView.RowTemplate.ReadOnly = true;
            this.ArgumentsListGridView.Size = new System.Drawing.Size(407, 217);
            this.ArgumentsListGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Код";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Description";
            this.Column2.HeaderText = "Параметр";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "печать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddDocument_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(12, 297);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(187, 43);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "удалить";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.RemoveArgument_Click);
            // 
            // Attach
            // 
            this.Attach.Location = new System.Drawing.Point(12, 248);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(187, 43);
            this.Attach.TabIndex = 6;
            this.Attach.Text = "добавить";
            this.Attach.UseVisualStyleBackColor = true;
            this.Attach.Click += new System.EventHandler(this.AddArgument_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "---";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 43);
            this.button4.TabIndex = 11;
            this.button4.Text = "отмена";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Close_Click);
            // 
            // ArgumentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 346);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.ArgumentsListGridView);
            this.Name = "ArgumentList";
            this.Text = "Параметры объектов";
            this.Load += new System.EventHandler(this.ArgumentListForm_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.ArgumentsListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ArgumentsListGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Attach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}