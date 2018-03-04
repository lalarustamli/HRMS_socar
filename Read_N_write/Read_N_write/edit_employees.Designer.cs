namespace Read_N_write
{
    partial class edit_employees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.employe_list = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edit_surname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edit_text = new System.Windows.Forms.TextBox();
            this.edit_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşçi məlumatlarını dəyişdir";
            // 
            // employe_list
            // 
            this.employe_list.FormattingEnabled = true;
            this.employe_list.Location = new System.Drawing.Point(71, 116);
            this.employe_list.Name = "employe_list";
            this.employe_list.Size = new System.Drawing.Size(231, 29);
            this.employe_list.TabIndex = 1;
            this.employe_list.SelectedIndexChanged += new System.EventHandler(this.employe_list_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşçini seçin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad";
            // 
            // edit_name
            // 
            this.edit_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edit_name.Location = new System.Drawing.Point(71, 185);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(130, 27);
            this.edit_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad";
            // 
            // edit_surname
            // 
            this.edit_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edit_surname.Location = new System.Drawing.Point(71, 260);
            this.edit_surname.Name = "edit_surname";
            this.edit_surname.Size = new System.Drawing.Size(130, 27);
            this.edit_surname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ünvan";
            // 
            // edit_text
            // 
            this.edit_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edit_text.Location = new System.Drawing.Point(71, 333);
            this.edit_text.Name = "edit_text";
            this.edit_text.Size = new System.Drawing.Size(130, 27);
            this.edit_text.TabIndex = 8;
            // 
            // edit_save
            // 
            this.edit_save.BackColor = System.Drawing.Color.SteelBlue;
            this.edit_save.FlatAppearance.BorderSize = 0;
            this.edit_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edit_save.Location = new System.Drawing.Point(250, 314);
            this.edit_save.Name = "edit_save";
            this.edit_save.Size = new System.Drawing.Size(136, 46);
            this.edit_save.TabIndex = 9;
            this.edit_save.Text = "Yadda saxla";
            this.edit_save.UseVisualStyleBackColor = false;
            this.edit_save.Click += new System.EventHandler(this.edit_save_Click);
            // 
            // edit_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edit_save);
            this.Controls.Add(this.edit_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edit_surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employe_list);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "edit_employees";
            this.Size = new System.Drawing.Size(598, 423);
            this.Load += new System.EventHandler(this.edit_employees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox employe_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edit_surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edit_text;
        private System.Windows.Forms.Button edit_save;
    }
}
