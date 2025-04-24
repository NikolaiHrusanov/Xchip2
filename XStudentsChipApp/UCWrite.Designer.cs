namespace XStudentsChipApp
{
    partial class UCWrite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWrite));
            this.BTN_Save_Write = new System.Windows.Forms.Button();
            this.dataGridView_Write = new System.Windows.Forms.DataGridView();
            this.lbl_RFID_Write = new System.Windows.Forms.Label();
            this.lbl_Name_Write = new System.Windows.Forms.Label();
            this.lbl_SurName_Write = new System.Windows.Forms.Label();
            this.lbl_LastName_Write = new System.Windows.Forms.Label();
            this.txt_RFID_Write = new System.Windows.Forms.TextBox();
            this.txt_Name_Write = new System.Windows.Forms.TextBox();
            this.txt_SurName_Write = new System.Windows.Forms.TextBox();
            this.txt_LastName_Write = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Write)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Save_Write
            // 
            this.BTN_Save_Write.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.BTN_Save_Write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Save_Write.ForeColor = System.Drawing.Color.White;
            this.BTN_Save_Write.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Save_Write.Image")));
            this.BTN_Save_Write.Location = new System.Drawing.Point(178, 166);
            this.BTN_Save_Write.Name = "BTN_Save_Write";
            this.BTN_Save_Write.Size = new System.Drawing.Size(134, 45);
            this.BTN_Save_Write.TabIndex = 22;
            this.BTN_Save_Write.Text = "  Запиши";
            this.BTN_Save_Write.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Save_Write.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Save_Write.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Write
            // 
            this.dataGridView_Write.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Write.Location = new System.Drawing.Point(3, 217);
            this.dataGridView_Write.Name = "dataGridView_Write";
            this.dataGridView_Write.RowHeadersWidth = 51;
            this.dataGridView_Write.Size = new System.Drawing.Size(626, 232);
            this.dataGridView_Write.TabIndex = 21;
            // 
            // lbl_RFID_Write
            // 
            this.lbl_RFID_Write.AutoSize = true;
            this.lbl_RFID_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RFID_Write.Location = new System.Drawing.Point(100, 22);
            this.lbl_RFID_Write.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RFID_Write.Name = "lbl_RFID_Write";
            this.lbl_RFID_Write.Size = new System.Drawing.Size(74, 29);
            this.lbl_RFID_Write.TabIndex = 13;
            this.lbl_RFID_Write.Text = "RFID:";
            // 
            // lbl_Name_Write
            // 
            this.lbl_Name_Write.AutoSize = true;
            this.lbl_Name_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name_Write.Location = new System.Drawing.Point(100, 57);
            this.lbl_Name_Write.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name_Write.Name = "lbl_Name_Write";
            this.lbl_Name_Write.Size = new System.Drawing.Size(69, 29);
            this.lbl_Name_Write.TabIndex = 14;
            this.lbl_Name_Write.Text = "Име:";
            // 
            // lbl_SurName_Write
            // 
            this.lbl_SurName_Write.AutoSize = true;
            this.lbl_SurName_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_SurName_Write.Location = new System.Drawing.Point(45, 93);
            this.lbl_SurName_Write.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SurName_Write.Name = "lbl_SurName_Write";
            this.lbl_SurName_Write.Size = new System.Drawing.Size(124, 29);
            this.lbl_SurName_Write.TabIndex = 15;
            this.lbl_SurName_Write.Text = "Презиме:";
            // 
            // lbl_LastName_Write
            // 
            this.lbl_LastName_Write.AutoSize = true;
            this.lbl_LastName_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_LastName_Write.Location = new System.Drawing.Point(40, 129);
            this.lbl_LastName_Write.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LastName_Write.Name = "lbl_LastName_Write";
            this.lbl_LastName_Write.Size = new System.Drawing.Size(129, 29);
            this.lbl_LastName_Write.TabIndex = 16;
            this.lbl_LastName_Write.Text = "Фамилия:";
            // 
            // txt_RFID_Write
            // 
            this.txt_RFID_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_RFID_Write.Location = new System.Drawing.Point(177, 21);
            this.txt_RFID_Write.Margin = new System.Windows.Forms.Padding(2);
            this.txt_RFID_Write.Name = "txt_RFID_Write";
            this.txt_RFID_Write.Size = new System.Drawing.Size(451, 32);
            this.txt_RFID_Write.TabIndex = 17;
            // 
            // txt_Name_Write
            // 
            this.txt_Name_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_Name_Write.Location = new System.Drawing.Point(178, 57);
            this.txt_Name_Write.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Name_Write.Name = "txt_Name_Write";
            this.txt_Name_Write.Size = new System.Drawing.Size(451, 32);
            this.txt_Name_Write.TabIndex = 18;
            // 
            // txt_SurName_Write
            // 
            this.txt_SurName_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_SurName_Write.Location = new System.Drawing.Point(178, 93);
            this.txt_SurName_Write.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SurName_Write.Name = "txt_SurName_Write";
            this.txt_SurName_Write.Size = new System.Drawing.Size(451, 32);
            this.txt_SurName_Write.TabIndex = 19;
            // 
            // txt_LastName_Write
            // 
            this.txt_LastName_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_LastName_Write.Location = new System.Drawing.Point(178, 129);
            this.txt_LastName_Write.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LastName_Write.Name = "txt_LastName_Write";
            this.txt_LastName_Write.Size = new System.Drawing.Size(451, 32);
            this.txt_LastName_Write.TabIndex = 20;
            // 
            // UCWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Save_Write);
            this.Controls.Add(this.dataGridView_Write);
            this.Controls.Add(this.txt_LastName_Write);
            this.Controls.Add(this.txt_SurName_Write);
            this.Controls.Add(this.txt_Name_Write);
            this.Controls.Add(this.txt_RFID_Write);
            this.Controls.Add(this.lbl_LastName_Write);
            this.Controls.Add(this.lbl_SurName_Write);
            this.Controls.Add(this.lbl_Name_Write);
            this.Controls.Add(this.lbl_RFID_Write);
            this.Name = "UCWrite";
            this.Size = new System.Drawing.Size(632, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Write)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Save_Write;
        private System.Windows.Forms.DataGridView dataGridView_Write;
        private System.Windows.Forms.Label lbl_RFID_Write;
        private System.Windows.Forms.Label lbl_Name_Write;
        private System.Windows.Forms.Label lbl_SurName_Write;
        private System.Windows.Forms.Label lbl_LastName_Write;
        private System.Windows.Forms.TextBox txt_RFID_Write;
        private System.Windows.Forms.TextBox txt_Name_Write;
        private System.Windows.Forms.TextBox txt_SurName_Write;
        private System.Windows.Forms.TextBox txt_LastName_Write;
    }
}
