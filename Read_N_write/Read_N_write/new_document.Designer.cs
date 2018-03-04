namespace Read_N_write
{
    partial class new_document
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
            this.doc_box = new System.Windows.Forms.TextBox();
            this.save_doc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni sənəd ";
            // 
            // doc_box
            // 
            this.doc_box.Location = new System.Drawing.Point(31, 80);
            this.doc_box.Multiline = true;
            this.doc_box.Name = "doc_box";
            this.doc_box.Size = new System.Drawing.Size(464, 256);
            this.doc_box.TabIndex = 1;
            // 
            // save_doc
            // 
            this.save_doc.BackColor = System.Drawing.Color.SteelBlue;
            this.save_doc.FlatAppearance.BorderSize = 0;
            this.save_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_doc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.save_doc.Location = new System.Drawing.Point(31, 342);
            this.save_doc.Name = "save_doc";
            this.save_doc.Size = new System.Drawing.Size(134, 54);
            this.save_doc.TabIndex = 2;
            this.save_doc.Text = "Yadda saxla";
            this.save_doc.UseVisualStyleBackColor = false;
            this.save_doc.Click += new System.EventHandler(this.save_doc_Click);
            // 
            // new_document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save_doc);
            this.Controls.Add(this.doc_box);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "new_document";
            this.Size = new System.Drawing.Size(643, 463);
            this.Load += new System.EventHandler(this.new_document_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox doc_box;
        private System.Windows.Forms.Button save_doc;
    }
}
