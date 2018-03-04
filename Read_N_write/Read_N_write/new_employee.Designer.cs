namespace Read_N_write
{
    partial class new_employee
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.surname_box = new System.Windows.Forms.TextBox();
            this.address_box = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.save_label = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni işçi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ünvan";
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_box.Location = new System.Drawing.Point(30, 96);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(146, 27);
            this.name_box.TabIndex = 4;
            // 
            // surname_box
            // 
            this.surname_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.surname_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surname_box.Location = new System.Drawing.Point(30, 159);
            this.surname_box.Name = "surname_box";
            this.surname_box.Size = new System.Drawing.Size(146, 27);
            this.surname_box.TabIndex = 5;
            // 
            // address_box
            // 
            this.address_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.address_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_box.Location = new System.Drawing.Point(30, 223);
            this.address_box.Multiline = true;
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(146, 63);
            this.address_box.TabIndex = 6;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.SteelBlue;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.save_button.Location = new System.Drawing.Point(30, 315);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(146, 54);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Yadda saxla";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // save_label
            // 
            this.save_label.AutoSize = true;
            this.save_label.ForeColor = System.Drawing.Color.SeaGreen;
            this.save_label.Location = new System.Drawing.Point(218, 332);
            this.save_label.Name = "save_label";
            this.save_label.Size = new System.Drawing.Size(174, 21);
            this.save_label.TabIndex = 8;
            this.save_label.Text = "Yeni işçi əlavə olundu";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(213, 332);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(179, 21);
            this.error_label.TabIndex = 9;
            this.error_label.Text = "Boş xanaları doldurun!";
            // 
            // new_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.save_label);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.surname_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "new_employee";
            this.Size = new System.Drawing.Size(802, 536);
            this.Load += new System.EventHandler(this.new_employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label save_label;
        private System.Windows.Forms.Label error_label;
    }
}
