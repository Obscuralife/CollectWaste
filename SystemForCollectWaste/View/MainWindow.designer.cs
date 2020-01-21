using System;
using System.Windows.Forms;

namespace SystemForCollectWaste
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.CollectDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainWindowDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SubjectDropDown = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.EndDateTimeRange = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimeRange = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.CollectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CollectDataGridView
            // 
            this.CollectDataGridView.AllowUserToAddRows = false;
            this.CollectDataGridView.AllowUserToDeleteRows = false;
            this.CollectDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.CollectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CollectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.CollectDataGridView.Location = new System.Drawing.Point(11, 100);
            this.CollectDataGridView.Name = "CollectDataGridView";
            this.CollectDataGridView.ReadOnly = true;
            this.CollectDataGridView.Size = new System.Drawing.Size(862, 208);
            this.CollectDataGridView.StandardTab = true;
            this.CollectDataGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Date";
            this.Column4.HeaderText = "дата сбора";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Subject";
            this.Column5.HeaderText = "объект";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Address";
            this.Column6.HeaderText = "адрес";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Email";
            this.Column7.HeaderText = "e-mail";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SolidWaste";
            this.Column8.HeaderText = "ТБО";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 130;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Description";
            this.Column9.HeaderText = "параметр";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "база не подключена";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(879, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "           Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddNewEntry_ClickAsync);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(879, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 43);
            this.button4.TabIndex = 18;
            this.button4.Text = "       Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RemoveCollect_ClickAsync);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(876, 216);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(176, 43);
            this.button7.TabIndex = 19;
            this.button7.Text = "    Договор";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Agreement_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "объекты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SubjectsList_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "ТБО";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SolidWaste_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(462, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "параметры";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ArgumentList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Объект";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(236, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 28;
            this.button9.Text = "Показать";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ShowConcreteCollect_ClickAsync);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 33;
            // 
            // SubjectDropDown
            // 
            this.SubjectDropDown.FormattingEnabled = true;
            this.SubjectDropDown.Location = new System.Drawing.Point(58, 62);
            this.SubjectDropDown.Name = "SubjectDropDown";
            this.SubjectDropDown.Size = new System.Drawing.Size(151, 21);
            this.SubjectDropDown.TabIndex = 34;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(335, 61);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(93, 23);
            this.button10.TabIndex = 35;
            this.button10.Text = "Показать все";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(675, 12);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(198, 23);
            this.button13.TabIndex = 38;
            this.button13.Text = "сотрудники";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.EmployesList_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(462, 317);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 22);
            this.button16.TabIndex = 44;
            this.button16.Text = "Отменить";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.RestoreTimeRange_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(356, 317);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 43;
            this.button15.Text = "Поиск";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.SetTimeRange_Click);
            // 
            // EndDateTimeRange
            // 
            this.EndDateTimeRange.Location = new System.Drawing.Point(180, 319);
            this.EndDateTimeRange.Name = "EndDateTimeRange";
            this.EndDateTimeRange.Size = new System.Drawing.Size(138, 20);
            this.EndDateTimeRange.TabIndex = 42;
            // 
            // StartDateTimeRange
            // 
            this.StartDateTimeRange.Location = new System.Drawing.Point(12, 320);
            this.StartDateTimeRange.Name = "StartDateTimeRange";
            this.StartDateTimeRange.Size = new System.Drawing.Size(137, 20);
            this.StartDateTimeRange.TabIndex = 41;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 371);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.EndDateTimeRange);
            this.Controls.Add(this.StartDateTimeRange);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.SubjectDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CollectDataGridView);
            this.Name = "MainWindow";
            this.Text = "Автоматизированная система по сбору ТБО Заводского района г. Минска";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.CollectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose(true);
        }

        private async void EmployesList_Click(object sender, EventArgs e)
        {
            new EmployesFormList(dbContext).ShowDialog();
            await ShowDataAsync();
        }

        private void ArgumentList_Click(object sender, EventArgs e)
        {
            new ArgumentsListForms(dbContext).ShowDialog();
        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SubjectDropDown;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DateTimePicker EndDateTimeRange;
        private System.Windows.Forms.DateTimePicker StartDateTimeRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Id;
        private BindingSource mainWindowDataBindingSource;
        private DataGridView CollectDataGridView;
    }
}

