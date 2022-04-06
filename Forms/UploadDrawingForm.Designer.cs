
namespace Forms
{
    partial class UploadDrawingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadDrawingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDrawingID = new System.Windows.Forms.TextBox();
            this.txtDrawingName = new System.Windows.Forms.TextBox();
            this.cmbDrawingType = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pdfUpload = new AxAcroPDFLib.AxAcroPDF();
            this.btnUploadPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pdfUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drawing ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drawing Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drawing Type";
            // 
            // txtDrawingID
            // 
            this.txtDrawingID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrawingID.Location = new System.Drawing.Point(165, 60);
            this.txtDrawingID.Name = "txtDrawingID";
            this.txtDrawingID.ReadOnly = true;
            this.txtDrawingID.Size = new System.Drawing.Size(61, 23);
            this.txtDrawingID.TabIndex = 4;
            this.txtDrawingID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDrawingName
            // 
            this.txtDrawingName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrawingName.Location = new System.Drawing.Point(165, 117);
            this.txtDrawingName.Name = "txtDrawingName";
            this.txtDrawingName.Size = new System.Drawing.Size(209, 23);
            this.txtDrawingName.TabIndex = 5;
            // 
            // cmbDrawingType
            // 
            this.cmbDrawingType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDrawingType.FormattingEnabled = true;
            this.cmbDrawingType.Items.AddRange(new object[] {
            "ELV",
            "HVAC",
            "Electrical",
            "Plumbing"});
            this.cmbDrawingType.Location = new System.Drawing.Point(165, 174);
            this.cmbDrawingType.Name = "cmbDrawingType";
            this.cmbDrawingType.Size = new System.Drawing.Size(149, 24);
            this.cmbDrawingType.TabIndex = 8;
            // 
            // btnSelect
            // 
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(136, 255);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(140, 35);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Select PDF File";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // pdfUpload
            // 
            this.pdfUpload.Enabled = true;
            this.pdfUpload.Location = new System.Drawing.Point(380, 37);
            this.pdfUpload.Name = "pdfUpload";
            this.pdfUpload.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfUpload.OcxState")));
            this.pdfUpload.Size = new System.Drawing.Size(494, 403);
            this.pdfUpload.TabIndex = 11;
            // 
            // btnUploadPDF
            // 
            this.btnUploadPDF.FlatAppearance.BorderSize = 0;
            this.btnUploadPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUploadPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPDF.ForeColor = System.Drawing.Color.White;
            this.btnUploadPDF.Location = new System.Drawing.Point(579, 469);
            this.btnUploadPDF.Name = "btnUploadPDF";
            this.btnUploadPDF.Size = new System.Drawing.Size(140, 35);
            this.btnUploadPDF.TabIndex = 12;
            this.btnUploadPDF.Text = "Upload PDF";
            this.btnUploadPDF.UseVisualStyleBackColor = true;
            // 
            // UploadDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(894, 556);
            this.Controls.Add(this.btnUploadPDF);
            this.Controls.Add(this.pdfUpload);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbDrawingType);
            this.Controls.Add(this.txtDrawingName);
            this.Controls.Add(this.txtDrawingID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UploadDrawingForm";
            this.Text = "UploadDrawingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pdfUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDrawingID;
        private System.Windows.Forms.TextBox txtDrawingName;
        private System.Windows.Forms.ComboBox cmbDrawingType;
        private System.Windows.Forms.Button btnSelect;
        private AxAcroPDFLib.AxAcroPDF pdfUpload;
        private System.Windows.Forms.Button btnUploadPDF;
    }
}