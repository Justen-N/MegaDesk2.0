namespace Neeley_MegaDesk1._0
{
    partial class ViewAllQuotes
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
            this.viewAllQuotesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllQuotesGridView
            // 
            this.viewAllQuotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllQuotesGridView.Location = new System.Drawing.Point(12, 12);
            this.viewAllQuotesGridView.Name = "viewAllQuotesGridView";
            this.viewAllQuotesGridView.Size = new System.Drawing.Size(776, 426);
            this.viewAllQuotesGridView.TabIndex = 0;
            this.viewAllQuotesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewAllQuotesGridView_CellContentClick);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewAllQuotesGridView);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAllQuotesGridView;
    }
}