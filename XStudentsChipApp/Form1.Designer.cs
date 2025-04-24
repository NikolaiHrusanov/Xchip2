namespace XStudentsChipApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTN_Install_Form = new System.Windows.Forms.Button();
            this.BTN_Change_Form = new System.Windows.Forms.Button();
            this.BTN_Write_Form = new System.Windows.Forms.Button();
            this.BTN_Read_Form = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_MadeBy_Form = new System.Windows.Forms.Label();
            this.ucDownload2 = new XStudentsChipApp.UCDownload();
            this.ucWrite1 = new XStudentsChipApp.UCWrite();
            this.ucUpdate1 = new XStudentsChipApp.UCUpdate();
            this.ucReading1 = new XStudentsChipApp.UCReading();
            this.ucDownload1 = new XStudentsChipApp.UCDownload();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BTN_Install_Form);
            this.panel1.Controls.Add(this.BTN_Change_Form);
            this.panel1.Controls.Add(this.BTN_Write_Form);
            this.panel1.Controls.Add(this.BTN_Read_Form);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 531);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 336);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // BTN_Install_Form
            // 
            this.BTN_Install_Form.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Install_Form.FlatAppearance.BorderSize = 0;
            this.BTN_Install_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Install_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Install_Form.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTN_Install_Form.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Install_Form.Image")));
            this.BTN_Install_Form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Install_Form.Location = new System.Drawing.Point(0, 252);
            this.BTN_Install_Form.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Install_Form.Name = "BTN_Install_Form";
            this.BTN_Install_Form.Size = new System.Drawing.Size(179, 57);
            this.BTN_Install_Form.TabIndex = 4;
            this.BTN_Install_Form.Text = "Инсталиране";
            this.BTN_Install_Form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Install_Form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Install_Form.UseVisualStyleBackColor = true;
            this.BTN_Install_Form.Click += new System.EventHandler(this.BTN_Install_Form_Click);
            // 
            // BTN_Change_Form
            // 
            this.BTN_Change_Form.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Change_Form.FlatAppearance.BorderSize = 0;
            this.BTN_Change_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Change_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Change_Form.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTN_Change_Form.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Change_Form.Image")));
            this.BTN_Change_Form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Change_Form.Location = new System.Drawing.Point(0, 195);
            this.BTN_Change_Form.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Change_Form.Name = "BTN_Change_Form";
            this.BTN_Change_Form.Size = new System.Drawing.Size(179, 57);
            this.BTN_Change_Form.TabIndex = 3;
            this.BTN_Change_Form.Text = "Промяна";
            this.BTN_Change_Form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Change_Form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Change_Form.UseVisualStyleBackColor = true;
            this.BTN_Change_Form.Click += new System.EventHandler(this.BTN_Change_Form_Click);
            // 
            // BTN_Write_Form
            // 
            this.BTN_Write_Form.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Write_Form.FlatAppearance.BorderSize = 0;
            this.BTN_Write_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Write_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Write_Form.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTN_Write_Form.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Write_Form.Image")));
            this.BTN_Write_Form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Write_Form.Location = new System.Drawing.Point(0, 138);
            this.BTN_Write_Form.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Write_Form.Name = "BTN_Write_Form";
            this.BTN_Write_Form.Size = new System.Drawing.Size(179, 57);
            this.BTN_Write_Form.TabIndex = 2;
            this.BTN_Write_Form.Text = "Добавяне";
            this.BTN_Write_Form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Write_Form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Write_Form.UseVisualStyleBackColor = true;
            this.BTN_Write_Form.Click += new System.EventHandler(this.BTN_Write_Form_Click);
            // 
            // BTN_Read_Form
            // 
            this.BTN_Read_Form.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Read_Form.FlatAppearance.BorderSize = 0;
            this.BTN_Read_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Read_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Read_Form.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTN_Read_Form.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Read_Form.Image")));
            this.BTN_Read_Form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Read_Form.Location = new System.Drawing.Point(0, 81);
            this.BTN_Read_Form.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Read_Form.Name = "BTN_Read_Form";
            this.BTN_Read_Form.Size = new System.Drawing.Size(179, 57);
            this.BTN_Read_Form.TabIndex = 1;
            this.BTN_Read_Form.Text = "Четене";
            this.BTN_Read_Form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Read_Form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Read_Form.UseVisualStyleBackColor = true;
            this.BTN_Read_Form.Click += new System.EventHandler(this.BTN_Read_Form_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 81);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.lbl_Heading);
            this.panel3.Controls.Add(this.ucDownload1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(179, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 81);
            this.panel3.TabIndex = 5;
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Heading.ForeColor = System.Drawing.Color.White;
            this.lbl_Heading.Location = new System.Drawing.Point(212, 28);
            this.lbl_Heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(210, 29);
            this.lbl_Heading.TabIndex = 0;
            this.lbl_Heading.Text = "Четец на чипове";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_MadeBy_Form
            // 
            this.lbl_MadeBy_Form.AutoSize = true;
            this.lbl_MadeBy_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_MadeBy_Form.Location = new System.Drawing.Point(195, 114);
            this.lbl_MadeBy_Form.Name = "lbl_MadeBy_Form";
            this.lbl_MadeBy_Form.Size = new System.Drawing.Size(534, 24);
            this.lbl_MadeBy_Form.TabIndex = 7;
            this.lbl_MadeBy_Form.Text = "Проект на Радимир Василев и Николай Хрусанов 10А клас";
            this.lbl_MadeBy_Form.Click += new System.EventHandler(this.lbl_Project);
            // 
            // ucDownload2
            // 
            this.ucDownload2.Location = new System.Drawing.Point(179, 81);
            this.ucDownload2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucDownload2.Name = "ucDownload2";
            this.ucDownload2.Size = new System.Drawing.Size(632, 449);
            this.ucDownload2.TabIndex = 11;
            // 
            // ucWrite1
            // 
            this.ucWrite1.Location = new System.Drawing.Point(179, 81);
            this.ucWrite1.Name = "ucWrite1";
            this.ucWrite1.Size = new System.Drawing.Size(636, 449);
            this.ucWrite1.TabIndex = 9;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Location = new System.Drawing.Point(179, 81);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(632, 449);
            this.ucUpdate1.TabIndex = 10;
            // 
            // ucReading1
            // 
            this.ucReading1.BackColor = System.Drawing.SystemColors.Control;
            this.ucReading1.Location = new System.Drawing.Point(179, 85);
            this.ucReading1.Margin = new System.Windows.Forms.Padding(2);
            this.ucReading1.Name = "ucReading1";
            this.ucReading1.Size = new System.Drawing.Size(632, 449);
            this.ucReading1.TabIndex = 8;
            // 
            // ucDownload1
            // 
            this.ucDownload1.Location = new System.Drawing.Point(0, 80);
            this.ucDownload1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucDownload1.Name = "ucDownload1";
            this.ucDownload1.Size = new System.Drawing.Size(632, 449);
            this.ucDownload1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.ucDownload2);
            this.Controls.Add(this.ucWrite1);
            this.Controls.Add(this.ucUpdate1);
            this.Controls.Add(this.ucReading1);
            this.Controls.Add(this.lbl_MadeBy_Form);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_Read_Form;
        private System.Windows.Forms.Button BTN_Install_Form;
        private System.Windows.Forms.Button BTN_Change_Form;
        private System.Windows.Forms.Button BTN_Write_Form;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_MadeBy_Form;
        private UCReading ucReading1;
        private UCWrite ucWrite1;
        private UCUpdate ucUpdate1;
        private UCDownload ucDownload1;
        private UCDownload ucDownload2;
    }
}

