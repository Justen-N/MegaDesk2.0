namespace Neeley_MegaDesk1._0
{
    partial class SearchQuotes
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
            this.searchAllQuotesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchAllQuotesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchAllQuotesGridView
            // 
            this.searchAllQuotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchAllQuotesGridView.Location = new System.Drawing.Point(12, 12);
            this.searchAllQuotesGridView.Name = "searchAllQuotesGridView";
            this.searchAllQuotesGridView.Size = new System.Drawing.Size(776, 426);
            this.searchAllQuotesGridView.TabIndex = 0;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchAllQuotesGridView);
            this.Name = "SearchQuotes";
            this.Text = "SearchQoutes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.searchAllQuotesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView searchAllQuotesGridView;
    }
}