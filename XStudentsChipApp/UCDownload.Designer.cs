namespace XStudentsChipApp
{
    partial class UCDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDownload));
            this.label1 = new System.Windows.Forms.Label();
            this.BTN1_downloadLocal_UCExport = new System.Windows.Forms.Button();
            this.BTN_downloadOnline_UCExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(291, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инсталиране";
            // 
            // BTN1_downloadLocal_UCExport
            // 
            this.BTN1_downloadLocal_UCExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.BTN1_downloadLocal_UCExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN1_downloadLocal_UCExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN1_downloadLocal_UCExport.ForeColor = System.Drawing.Color.White;
            this.BTN1_downloadLocal_UCExport.Image = ((System.Drawing.Image)(resources.GetObject("BTN1_downloadLocal_UCExport.Image")));
            this.BTN1_downloadLocal_UCExport.Location = new System.Drawing.Point(105, 390);
            this.BTN1_downloadLocal_UCExport.Name = "BTN1_downloadLocal_UCExport";
            this.BTN1_downloadLocal_UCExport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN1_downloadLocal_UCExport.Size = new System.Drawing.Size(303, 60);
            this.BTN1_downloadLocal_UCExport.TabIndex = 11;
            this.BTN1_downloadLocal_UCExport.Text = " Локално инсталиране";
            this.BTN1_downloadLocal_UCExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN1_downloadLocal_UCExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN1_downloadLocal_UCExport.UseVisualStyleBackColor = false;
            // 
            // BTN_downloadOnline_UCExport
            // 
            this.BTN_downloadOnline_UCExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.BTN_downloadOnline_UCExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_downloadOnline_UCExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_downloadOnline_UCExport.ForeColor = System.Drawing.Color.White;
            this.BTN_downloadOnline_UCExport.Image = ((System.Drawing.Image)(resources.GetObject("BTN_downloadOnline_UCExport.Image")));
            this.BTN_downloadOnline_UCExport.Location = new System.Drawing.Point(448, 390);
            this.BTN_downloadOnline_UCExport.Name = "BTN_downloadOnline_UCExport";
            this.BTN_downloadOnline_UCExport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTN_downloadOnline_UCExport.Size = new System.Drawing.Size(303, 60);
            this.BTN_downloadOnline_UCExport.TabIndex = 12;
            this.BTN_downloadOnline_UCExport.Text = " Онлайн Инсталиране";
            this.BTN_downloadOnline_UCExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_downloadOnline_UCExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_downloadOnline_UCExport.UseVisualStyleBackColor = false;
            // 
            // UCDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_downloadOnline_UCExport);
            this.Controls.Add(this.BTN1_downloadLocal_UCExport);
            this.Controls.Add(this.label1);
            this.Name = "UCDownload";
            this.Size = new System.Drawing.Size(843, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN1_downloadLocal_UCExport;
        private System.Windows.Forms.Button BTN_downloadOnline_UCExport;
    }
}
