namespace Read_N_write
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.side_panel = new System.Windows.Forms.Panel();
            this.main_page_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.create = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.create_doc = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.edit_employees1 = new Read_N_write.edit_employees();
            
            this.new_document1 = new Read_N_write.new_document();
            this.employee_list1 = new Read_N_write.employee_list();
            this.main_page1 = new Read_N_write.main_page();
            this.new_employee1 = new Read_N_write.new_employee();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.side_panel);
            this.panel2.Controls.Add(this.main_page_button);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.create);
            this.panel2.Controls.Add(this.read);
            this.panel2.Controls.Add(this.edit);
            this.panel2.Controls.Add(this.create_doc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 508);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.side_panel.Location = new System.Drawing.Point(0, 92);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(10, 60);
            this.side_panel.TabIndex = 6;
            // 
            // main_page_button
            // 
            this.main_page_button.BackColor = System.Drawing.Color.DimGray;
            this.main_page_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_page_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.main_page_button.FlatAppearance.BorderSize = 0;
            this.main_page_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.main_page_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_page_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_page_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.main_page_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.main_page_button.Location = new System.Drawing.Point(12, 92);
            this.main_page_button.Name = "main_page_button";
            this.main_page_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.main_page_button.Size = new System.Drawing.Size(250, 60);
            this.main_page_button.TabIndex = 5;
            this.main_page_button.Text = "Əsas səhifə";
            this.main_page_button.UseVisualStyleBackColor = false;
            this.main_page_button.Click += new System.EventHandler(this.main_page_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.DimGray;
            this.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.create.Image = ((System.Drawing.Image)(resources.GetObject("create.Image")));
            this.create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create.Location = new System.Drawing.Point(3, 158);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(259, 60);
            this.create.TabIndex = 0;
            this.create.Text = "Yeni işçi";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.DimGray;
            this.read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.read.FlatAppearance.BorderSize = 0;
            this.read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.read.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.read.Image = ((System.Drawing.Image)(resources.GetObject("read.Image")));
            this.read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.read.Location = new System.Drawing.Point(3, 224);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(259, 62);
            this.read.TabIndex = 1;
            this.read.Text = "İşçi siyahısı";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DimGray;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Location = new System.Drawing.Point(3, 292);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(259, 62);
            this.edit.TabIndex = 2;
            this.edit.Text = "İşçi məlumatlarını dəyişdir";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // create_doc
            // 
            this.create_doc.BackColor = System.Drawing.Color.DimGray;
            this.create_doc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_doc.FlatAppearance.BorderSize = 0;
            this.create_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_doc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_doc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.create_doc.Image = ((System.Drawing.Image)(resources.GetObject("create_doc.Image")));
            this.create_doc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create_doc.Location = new System.Drawing.Point(3, 360);
            this.create_doc.Name = "create_doc";
            this.create_doc.Size = new System.Drawing.Size(259, 60);
            this.create_doc.TabIndex = 3;
            this.create_doc.Text = "Yeni sənəd";
            this.create_doc.UseVisualStyleBackColor = false;
            this.create_doc.Click += new System.EventHandler(this.create_doc_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(265, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(589, 14);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(799, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // edit_employees1
            // 
            this.edit_employees1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_employees1.Location = new System.Drawing.Point(271, 62);
            this.edit_employees1.Margin = new System.Windows.Forms.Padding(5);
            this.edit_employees1.Name = "edit_employees1";
            this.edit_employees1.Size = new System.Drawing.Size(569, 429);
            this.edit_employees1.TabIndex = 18;
            // 
            // login1
            // 
            //this.login1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.login1.Location = new System.Drawing.Point(274, 62);
            //this.login1.Margin = new System.Windows.Forms.Padding(5);
            //this.login1.Name = "login1";
            //this.login1.Size = new System.Drawing.Size(566, 429);
            //this.login1.TabIndex = 17;
            // 
            // new_document1
            // 
            this.new_document1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_document1.Location = new System.Drawing.Point(274, 62);
            this.new_document1.Margin = new System.Windows.Forms.Padding(5);
            this.new_document1.Name = "new_document1";
            this.new_document1.Size = new System.Drawing.Size(566, 435);
            this.new_document1.TabIndex = 16;
            // 
            // employee_list1
            // 
            this.employee_list1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_list1.Location = new System.Drawing.Point(273, 62);
            this.employee_list1.Margin = new System.Windows.Forms.Padding(5);
            this.employee_list1.Name = "employee_list1";
            this.employee_list1.Size = new System.Drawing.Size(559, 429);
            this.employee_list1.TabIndex = 15;
            // 
            // main_page1
            // 
            this.main_page1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_page1.Location = new System.Drawing.Point(272, 70);
            this.main_page1.Margin = new System.Windows.Forms.Padding(7);
            this.main_page1.Name = "main_page1";
            this.main_page1.Size = new System.Drawing.Size(559, 427);
            this.main_page1.TabIndex = 14;
            // 
            // new_employee1
            // 
            this.new_employee1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_employee1.Location = new System.Drawing.Point(273, 62);
            this.new_employee1.Margin = new System.Windows.Forms.Padding(5);
            this.new_employee1.Name = "new_employee1";
            this.new_employee1.Size = new System.Drawing.Size(567, 432);
            this.new_employee1.TabIndex = 13;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 508);
            this.Controls.Add(this.edit_employees1);
            //this.Controls.Add(this.login1);
            this.Controls.Add(this.new_document1);
            this.Controls.Add(this.employee_list1);
            this.Controls.Add(this.main_page1);
            this.Controls.Add(this.new_employee1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Əsas səhifə";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button create_doc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button main_page_button;
        private new_employee new_employee1;
        private main_page main_page1;
        private employee_list employee_list1;
        private new_document new_document1;
        
        private edit_employees edit_employees1;
    }
}

