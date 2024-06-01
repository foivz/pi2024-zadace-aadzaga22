namespace EcoRecycle_Manager
{
    partial class FrmAddTransaction
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
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbCenter = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbWasteType = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(260, 69);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(152, 20);
            this.dtpDateTime.TabIndex = 0;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(260, 107);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(152, 21);
            this.cbCustomer.TabIndex = 1;
            // 
            // cbCenter
            // 
            this.cbCenter.FormattingEnabled = true;
            this.cbCenter.Location = new System.Drawing.Point(260, 148);
            this.cbCenter.Name = "cbCenter";
            this.cbCenter.Size = new System.Drawing.Size(152, 21);
            this.cbCenter.TabIndex = 2;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(260, 187);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(152, 21);
            this.cbEmployee.TabIndex = 3;
            // 
            // cbWasteType
            // 
            this.cbWasteType.FormattingEnabled = true;
            this.cbWasteType.Location = new System.Drawing.Point(260, 229);
            this.cbWasteType.Name = "cbWasteType";
            this.cbWasteType.Size = new System.Drawing.Size(152, 21);
            this.cbWasteType.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(260, 273);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(151, 20);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(260, 317);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(151, 20);
            this.txtUnit.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(678, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cbWasteType);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbCenter);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.dtpDateTime);
            this.Name = "FrmAddTransaction";
            this.Text = "Upravljanje Transakcijama";
            this.Load += new System.EventHandler(this.FrmAddTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbCenter;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbWasteType;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}