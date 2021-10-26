
namespace MegaDeskReal
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuote = new System.Windows.Forms.Button();
            this.ViewAllQuotes = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenuHeading = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuote
            // 
            this.addQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuote.Location = new System.Drawing.Point(39, 134);
            this.addQuote.Name = "addQuote";
            this.addQuote.Size = new System.Drawing.Size(467, 93);
            this.addQuote.TabIndex = 0;
            this.addQuote.Text = "Add A Quote";
            this.addQuote.UseVisualStyleBackColor = true;
            this.addQuote.Click += new System.EventHandler(this.addQuote_Click);
            // 
            // ViewAllQuotes
            // 
            this.ViewAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllQuotes.Location = new System.Drawing.Point(39, 254);
            this.ViewAllQuotes.Name = "ViewAllQuotes";
            this.ViewAllQuotes.Size = new System.Drawing.Size(467, 93);
            this.ViewAllQuotes.TabIndex = 1;
            this.ViewAllQuotes.Text = "View All Quotes";
            this.ViewAllQuotes.UseVisualStyleBackColor = true;
            this.ViewAllQuotes.Click += new System.EventHandler(this.ViewAllQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotes.Location = new System.Drawing.Point(39, 376);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(467, 93);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightPink;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(39, 504);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(467, 63);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(529, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuHeading
            // 
            this.MainMenuHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainMenuHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuHeading.Location = new System.Drawing.Point(39, 34);
            this.MainMenuHeading.Name = "MainMenuHeading";
            this.MainMenuHeading.Size = new System.Drawing.Size(914, 55);
            this.MainMenuHeading.TabIndex = 5;
            this.MainMenuHeading.Text = "Mega Desk 2.0";
            this.MainMenuHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(974, 629);
            this.Controls.Add(this.MainMenuHeading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewAllQuotes);
            this.Controls.Add(this.addQuote);
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuote;
        private System.Windows.Forms.Button ViewAllQuotes;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox MainMenuHeading;
    }
}

