namespace MegaDesk___Rodriguez
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
            this.ViewSecondFormButton = new System.Windows.Forms.Button();
            this.DisplayQuoteButton = new System.Windows.Forms.Button();
            this.ViewAllQuotesButton = new System.Windows.Forms.Button();
            this.ViewSearchQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewSecondFormButton
            // 
            this.ViewSecondFormButton.Location = new System.Drawing.Point(56, 30);
            this.ViewSecondFormButton.Name = "ViewSecondFormButton";
            this.ViewSecondFormButton.Size = new System.Drawing.Size(158, 62);
            this.ViewSecondFormButton.TabIndex = 0;
            this.ViewSecondFormButton.Text = "Add Quote";
            this.ViewSecondFormButton.UseVisualStyleBackColor = true;
            this.ViewSecondFormButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DisplayQuoteButton
            // 
            this.DisplayQuoteButton.Location = new System.Drawing.Point(55, 98);
            this.DisplayQuoteButton.Name = "DisplayQuoteButton";
            this.DisplayQuoteButton.Size = new System.Drawing.Size(158, 62);
            this.DisplayQuoteButton.TabIndex = 1;
            this.DisplayQuoteButton.Text = "Display Quote";
            this.DisplayQuoteButton.UseVisualStyleBackColor = true;
            this.DisplayQuoteButton.Click += new System.EventHandler(this.DisplayQuoteButton_Click);
            // 
            // ViewAllQuotesButton
            // 
            this.ViewAllQuotesButton.Location = new System.Drawing.Point(56, 166);
            this.ViewAllQuotesButton.Name = "ViewAllQuotesButton";
            this.ViewAllQuotesButton.Size = new System.Drawing.Size(158, 62);
            this.ViewAllQuotesButton.TabIndex = 2;
            this.ViewAllQuotesButton.Text = "View All Quotes";
            this.ViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.ViewAllQuotesButton.Click += new System.EventHandler(this.ViewAllQuotes_Click);
            // 
            // ViewSearchQuotesButton
            // 
            this.ViewSearchQuotesButton.Location = new System.Drawing.Point(55, 234);
            this.ViewSearchQuotesButton.Name = "ViewSearchQuotesButton";
            this.ViewSearchQuotesButton.Size = new System.Drawing.Size(158, 62);
            this.ViewSearchQuotesButton.TabIndex = 3;
            this.ViewSearchQuotesButton.Text = "Search Quotes";
            this.ViewSearchQuotesButton.UseVisualStyleBackColor = true;
            this.ViewSearchQuotesButton.Click += new System.EventHandler(this.ViewSearchQuotesButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.ViewSearchQuotesButton);
            this.Controls.Add(this.ViewAllQuotesButton);
            this.Controls.Add(this.DisplayQuoteButton);
            this.Controls.Add(this.ViewSecondFormButton);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewSecondFormButton;
        private System.Windows.Forms.Button DisplayQuoteButton;
        private System.Windows.Forms.Button ViewAllQuotesButton;
        private System.Windows.Forms.Button ViewSearchQuotesButton;
    }
}

