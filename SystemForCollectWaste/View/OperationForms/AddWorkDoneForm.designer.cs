namespace SystemForCollectWaste
{
    partial class AddWorkDoneForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SubjectDropDown = new System.Windows.Forms.ComboBox();
            this.WasteDropDownList = new System.Windows.Forms.ComboBox();
            this.EmployeDropDownList = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.AddSubjectEntry = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ArgumentDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WorkDoneDateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объект";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ТБО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Параметр";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Submit_ClickAsync);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubjectDropDown
            // 
            this.SubjectDropDown.FormattingEnabled = true;
            this.SubjectDropDown.Location = new System.Drawing.Point(101, 36);
            this.SubjectDropDown.Name = "SubjectDropDown";
            this.SubjectDropDown.Size = new System.Drawing.Size(152, 21);
            this.SubjectDropDown.TabIndex = 7;
            // 
            // WasteDropDownList
            // 
            this.WasteDropDownList.FormattingEnabled = true;
            this.WasteDropDownList.Location = new System.Drawing.Point(101, 115);
            this.WasteDropDownList.Name = "WasteDropDownList";
            this.WasteDropDownList.Size = new System.Drawing.Size(152, 21);
            this.WasteDropDownList.TabIndex = 8;
            // 
            // EmployeDropDownList
            // 
            this.EmployeDropDownList.FormattingEnabled = true;
            this.EmployeDropDownList.Location = new System.Drawing.Point(114, 90);
            this.EmployeDropDownList.Name = "EmployeDropDownList";
            this.EmployeDropDownList.Size = new System.Drawing.Size(151, 21);
            this.EmployeDropDownList.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(272, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddArgument_ClickAsync);
            // 
            // AddSubjectEntry
            // 
            this.AddSubjectEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSubjectEntry.Location = new System.Drawing.Point(259, 34);
            this.AddSubjectEntry.Name = "AddSubjectEntry";
            this.AddSubjectEntry.Size = new System.Drawing.Size(24, 23);
            this.AddSubjectEntry.TabIndex = 13;
            this.AddSubjectEntry.Text = "+";
            this.AddSubjectEntry.UseVisualStyleBackColor = true;
            this.AddSubjectEntry.Click += new System.EventHandler(this.AddSubject_ClickAsync);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(259, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AddSolidWaste_ClickAsync);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дата сбора";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.AddSubjectEntry);
            this.groupBox1.Controls.Add(this.WasteDropDownList);
            this.groupBox1.Controls.Add(this.SubjectDropDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 187);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.ArgumentDropDown);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.WorkDoneDateTime);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.EmployeDropDownList);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(325, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 136);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(272, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowEmloyes_Click);
            // 
            // ArgumentDropDown
            // 
            this.ArgumentDropDown.FormattingEnabled = true;
            this.ArgumentDropDown.Location = new System.Drawing.Point(114, 55);
            this.ArgumentDropDown.Name = "ArgumentDropDown";
            this.ArgumentDropDown.Size = new System.Drawing.Size(151, 21);
            this.ArgumentDropDown.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Сотрудник";
            // 
            // WorkDoneDateTime
            // 
            this.WorkDoneDateTime.Location = new System.Drawing.Point(114, 20);
            this.WorkDoneDateTime.Name = "WorkDoneDateTime";
            this.WorkDoneDateTime.Size = new System.Drawing.Size(182, 20);
            this.WorkDoneDateTime.TabIndex = 20;
            // 
            // AddWorkDoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 244);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddWorkDoneForm";
            this.Text = "Выполненные работы";
            this.Load += new System.EventHandler(this.WorkDone_LoadAsync);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox SubjectDropDown;
        private System.Windows.Forms.ComboBox WasteDropDownList;
        private System.Windows.Forms.ComboBox EmployeDropDownList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddSubjectEntry;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker WorkDoneDateTime;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox ArgumentDropDown;
        private System.Windows.Forms.Label label4;
    }
}