namespace XStudentsChipApp
{
    partial class UCReading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReading));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_RFID_UCRead = new System.Windows.Forms.TextBox();
            this.TXT_User_UCRead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_search_UCRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(353, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Четене";
            // 
            // TXT_RFID_UCRead
            // 
            this.TXT_RFID_UCRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXT_RFID_UCRead.Location = new System.Drawing.Point(437, 196);
            this.TXT_RFID_UCRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_RFID_UCRead.Name = "TXT_RFID_UCRead";
            this.TXT_RFID_UCRead.Size = new System.Drawing.Size(355, 44);
            this.TXT_RFID_UCRead.TabIndex = 1;
            // 
            // TXT_User_UCRead
            // 
            this.TXT_User_UCRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXT_User_UCRead.Location = new System.Drawing.Point(437, 271);
            this.TXT_User_UCRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_User_UCRead.Name = "TXT_User_UCRead";
            this.TXT_User_UCRead.Size = new System.Drawing.Size(355, 44);
            this.TXT_User_UCRead.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(283, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пин код:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(97, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Потребителско име:";
            // 
            // BTN_search_UCRead
            // 
            this.BTN_search_UCRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.BTN_search_UCRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_search_UCRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_search_UCRead.ForeColor = System.Drawing.Color.White;
            this.BTN_search_UCRead.Image = ((System.Drawing.Image)(resources.GetObject("BTN_search_UCRead.Image")));
            this.BTN_search_UCRead.Location = new System.Drawing.Point(360, 406);
            this.BTN_search_UCRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_search_UCRead.Name = "BTN_search_UCRead";
            this.BTN_search_UCRead.Size = new System.Drawing.Size(169, 52);
            this.BTN_search_UCRead.TabIndex = 10;
            this.BTN_search_UCRead.Text = "Търсене";
            this.BTN_search_UCRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_search_UCRead.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_search_UCRead.UseVisualStyleBackColor = false;
            // 
            // UCReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.BTN_search_UCRead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_User_UCRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_RFID_UCRead);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCReading";
            this.Size = new System.Drawing.Size(843, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_RFID_UCRead;
        private System.Windows.Forms.TextBox TXT_User_UCRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_search_UCRead;
    }
}
