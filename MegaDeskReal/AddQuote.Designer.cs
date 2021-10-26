
namespace MegaDeskReal
{
    partial class AddQuote
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
            this.AddQuoteHeading = new System.Windows.Forms.Label();
            this.AddQuoteForm = new System.Windows.Forms.Button();
            this.surfaceMaterialsCmb = new System.Windows.Forms.ComboBox();
            this.shippingTypeCmb = new System.Windows.Forms.ComboBox();
            this.widthWarningLabel = new System.Windows.Forms.Label();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.ShippingTypeLabel = new System.Windows.Forms.Label();
            this.NumbOfDrawersLabel = new System.Windows.Forms.Label();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depthWarningLabel = new System.Windows.Forms.Label();
            this.widthNumeric = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.depthNumeric = new System.Windows.Forms.NumericUpDown();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.warningDepthLabel = new System.Windows.Forms.Label();
            this.warningWidthLabel = new System.Windows.Forms.Label();
            this.numOfDrawersNumeric = new System.Windows.Forms.NumericUpDown();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.missingInfoWarning = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDrawersNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuoteHeading
            // 
            this.AddQuoteHeading.AutoSize = true;
            this.AddQuoteHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteHeading.Location = new System.Drawing.Point(375, 42);
            this.AddQuoteHeading.Name = "AddQuoteHeading";
            this.AddQuoteHeading.Size = new System.Drawing.Size(211, 46);
            this.AddQuoteHeading.TabIndex = 0;
            this.AddQuoteHeading.Text = "Add Quote";
            // 
            // AddQuoteForm
            // 
            this.AddQuoteForm.Location = new System.Drawing.Point(299, 512);
            this.AddQuoteForm.Name = "AddQuoteForm";
            this.AddQuoteForm.Size = new System.Drawing.Size(343, 57);
            this.AddQuoteForm.TabIndex = 1;
            this.AddQuoteForm.Text = "Add Quote";
            this.AddQuoteForm.UseVisualStyleBackColor = true;
            this.AddQuoteForm.Click += new System.EventHandler(this.AddQuoteForm_Click);
            // 
            // surfaceMaterialsCmb
            // 
            this.surfaceMaterialsCmb.FormattingEnabled = true;
            this.surfaceMaterialsCmb.Location = new System.Drawing.Point(30, 54);
            this.surfaceMaterialsCmb.Name = "surfaceMaterialsCmb";
            this.surfaceMaterialsCmb.Size = new System.Drawing.Size(221, 33);
            this.surfaceMaterialsCmb.TabIndex = 2;
            // 
            // shippingTypeCmb
            // 
            this.shippingTypeCmb.FormattingEnabled = true;
            this.shippingTypeCmb.Location = new System.Drawing.Point(30, 142);
            this.shippingTypeCmb.Name = "shippingTypeCmb";
            this.shippingTypeCmb.Size = new System.Drawing.Size(221, 33);
            this.shippingTypeCmb.TabIndex = 3;
            // 
            // widthWarningLabel
            // 
            this.widthWarningLabel.AutoSize = true;
            this.widthWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthWarningLabel.Location = new System.Drawing.Point(250, 371);
            this.widthWarningLabel.Name = "widthWarningLabel";
            this.widthWarningLabel.Size = new System.Drawing.Size(0, 25);
            this.widthWarningLabel.TabIndex = 11;
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(25, 24);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(169, 25);
            this.surfaceMaterialLabel.TabIndex = 12;
            this.surfaceMaterialLabel.Text = "Surface Material";
            // 
            // ShippingTypeLabel
            // 
            this.ShippingTypeLabel.AutoSize = true;
            this.ShippingTypeLabel.Location = new System.Drawing.Point(25, 114);
            this.ShippingTypeLabel.Name = "ShippingTypeLabel";
            this.ShippingTypeLabel.Size = new System.Drawing.Size(150, 25);
            this.ShippingTypeLabel.TabIndex = 13;
            this.ShippingTypeLabel.Text = "Shipping Type";
            // 
            // NumbOfDrawersLabel
            // 
            this.NumbOfDrawersLabel.AutoSize = true;
            this.NumbOfDrawersLabel.Location = new System.Drawing.Point(25, 200);
            this.NumbOfDrawersLabel.Name = "NumbOfDrawersLabel";
            this.NumbOfDrawersLabel.Size = new System.Drawing.Size(196, 25);
            this.NumbOfDrawersLabel.TabIndex = 14;
            this.NumbOfDrawersLabel.Text = "Number of Drawers";
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(12, 12);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(181, 39);
            this.mainMenuBtn.TabIndex = 15;
            this.mainMenuBtn.Text = "Back to Main Menu";
            this.mainMenuBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numOfDrawersNumeric);
            this.groupBox2.Controls.Add(this.surfaceMaterialLabel);
            this.groupBox2.Controls.Add(this.ShippingTypeLabel);
            this.groupBox2.Controls.Add(this.NumbOfDrawersLabel);
            this.groupBox2.Controls.Add(this.shippingTypeCmb);
            this.groupBox2.Controls.Add(this.surfaceMaterialsCmb);
            this.groupBox2.Location = new System.Drawing.Point(523, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 299);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // depthWarningLabel
            // 
            this.depthWarningLabel.AutoSize = true;
            this.depthWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthWarningLabel.Location = new System.Drawing.Point(250, 241);
            this.depthWarningLabel.Name = "depthWarningLabel";
            this.depthWarningLabel.Size = new System.Drawing.Size(0, 25);
            this.depthWarningLabel.TabIndex = 10;
            this.depthWarningLabel.Click += new System.EventHandler(this.depthWarningLabel_Click);
            // 
            // widthNumeric
            // 
            this.widthNumeric.Location = new System.Drawing.Point(30, 181);
            this.widthNumeric.Name = "widthNumeric";
            this.widthNumeric.Size = new System.Drawing.Size(194, 31);
            this.widthNumeric.TabIndex = 6;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(25, 153);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(67, 25);
            this.WidthLabel.TabIndex = 9;
            this.WidthLabel.Text = "Width";
            // 
            // depthNumeric
            // 
            this.depthNumeric.Location = new System.Drawing.Point(30, 61);
            this.depthNumeric.Name = "depthNumeric";
            this.depthNumeric.Size = new System.Drawing.Size(194, 31);
            this.depthNumeric.TabIndex = 5;
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(25, 27);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(69, 25);
            this.DepthLabel.TabIndex = 8;
            this.DepthLabel.Text = "Depth";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.warningWidthLabel);
            this.groupBox1.Controls.Add(this.warningDepthLabel);
            this.groupBox1.Controls.Add(this.DepthLabel);
            this.groupBox1.Controls.Add(this.depthNumeric);
            this.groupBox1.Controls.Add(this.WidthLabel);
            this.groupBox1.Controls.Add(this.widthNumeric);
            this.groupBox1.Location = new System.Drawing.Point(185, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 302);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // warningDepthLabel
            // 
            this.warningDepthLabel.AutoSize = true;
            this.warningDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningDepthLabel.Location = new System.Drawing.Point(25, 95);
            this.warningDepthLabel.Name = "warningDepthLabel";
            this.warningDepthLabel.Size = new System.Drawing.Size(0, 20);
            this.warningDepthLabel.TabIndex = 10;
            // 
            // warningWidthLabel
            // 
            this.warningWidthLabel.AutoSize = true;
            this.warningWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningWidthLabel.Location = new System.Drawing.Point(29, 219);
            this.warningWidthLabel.Name = "warningWidthLabel";
            this.warningWidthLabel.Size = new System.Drawing.Size(0, 20);
            this.warningWidthLabel.TabIndex = 11;
            // 
            // numOfDrawersNumeric
            // 
            this.numOfDrawersNumeric.Location = new System.Drawing.Point(30, 237);
            this.numOfDrawersNumeric.Name = "numOfDrawersNumeric";
            this.numOfDrawersNumeric.Size = new System.Drawing.Size(221, 31);
            this.numOfDrawersNumeric.TabIndex = 0;
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(299, 138);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(343, 31);
            this.customerNameBox.TabIndex = 18;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(294, 110);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(166, 25);
            this.customerNameLabel.TabIndex = 12;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // missingInfoWarning
            // 
            this.missingInfoWarning.AutoSize = true;
            this.missingInfoWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingInfoWarning.Location = new System.Drawing.Point(443, 576);
            this.missingInfoWarning.Name = "missingInfoWarning";
            this.missingInfoWarning.Size = new System.Drawing.Size(0, 17);
            this.missingInfoWarning.TabIndex = 19;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 629);
            this.Controls.Add(this.missingInfoWarning);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.widthWarningLabel);
            this.Controls.Add(this.depthWarningLabel);
            this.Controls.Add(this.AddQuoteForm);
            this.Controls.Add(this.AddQuoteHeading);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDrawersNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddQuoteHeading;
        private System.Windows.Forms.Button AddQuoteForm;
        private System.Windows.Forms.ComboBox surfaceMaterialsCmb;
        private System.Windows.Forms.ComboBox shippingTypeCmb;
        private System.Windows.Forms.Label widthWarningLabel;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.Label ShippingTypeLabel;
        private System.Windows.Forms.Label NumbOfDrawersLabel;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label depthWarningLabel;
        private System.Windows.Forms.NumericUpDown widthNumeric;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown depthNumeric;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label warningDepthLabel;
        private System.Windows.Forms.Label warningWidthLabel;
        private System.Windows.Forms.NumericUpDown numOfDrawersNumeric;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label missingInfoWarning;
    }
}