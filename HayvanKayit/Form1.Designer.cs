namespace HayvanKayit
{
    partial class Form1
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
            this.NameTxtB = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TypeTxtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NameLbl = new System.Windows.Forms.Label();
            this.KindLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.NamesComB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hayvanın Adı:";
            // 
            // NameTxtB
            // 
            this.NameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameTxtB.Location = new System.Drawing.Point(189, 26);
            this.NameTxtB.Name = "NameTxtB";
            this.NameTxtB.Size = new System.Drawing.Size(100, 32);
            this.NameTxtB.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveBtn.Location = new System.Drawing.Point(85, 234);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(124, 44);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "KAYDET";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TypeTxtB
            // 
            this.TypeTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TypeTxtB.Location = new System.Drawing.Point(189, 83);
            this.TypeTxtB.Name = "TypeTxtB";
            this.TypeTxtB.Size = new System.Drawing.Size(100, 32);
            this.TypeTxtB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hayvanın Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.Color.Red;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLbl.Location = new System.Drawing.Point(620, 38);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(115, 20);
            this.NameLbl.TabIndex = 7;
            this.NameLbl.Text = "Hayvan İsimleri";
            // 
            // KindLbl
            // 
            this.KindLbl.AutoSize = true;
            this.KindLbl.BackColor = System.Drawing.Color.Salmon;
            this.KindLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KindLbl.Location = new System.Drawing.Point(754, 115);
            this.KindLbl.Name = "KindLbl";
            this.KindLbl.Size = new System.Drawing.Size(13, 20);
            this.KindLbl.TabIndex = 8;
            this.KindLbl.Text = " ";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.Color.LightCoral;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DateLbl.Location = new System.Drawing.Point(754, 176);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(13, 20);
            this.DateLbl.TabIndex = 9;
            this.DateLbl.Text = " ";
            // 
            // NamesComB
            // 
            this.NamesComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NamesComB.FormattingEnabled = true;
            this.NamesComB.Location = new System.Drawing.Point(788, 37);
            this.NamesComB.Name = "NamesComB";
            this.NamesComB.Size = new System.Drawing.Size(121, 21);
            this.NamesComB.TabIndex = 10;
            this.NamesComB.SelectedIndexChanged += new System.EventHandler(this.NamesComB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 695);
            this.Controls.Add(this.NamesComB);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.KindLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeTxtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NameTxtB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hayvan Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxtB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox TypeTxtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label KindLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.ComboBox NamesComB;
    }
}

