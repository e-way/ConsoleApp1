namespace ConsoleApp1
{
    partial class LinqToSql
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
            this.txtLinqToSql = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLinqToSql
            // 
            this.txtLinqToSql.Location = new System.Drawing.Point(12, 12);
            this.txtLinqToSql.Multiline = true;
            this.txtLinqToSql.Name = "txtLinqToSql";
            this.txtLinqToSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLinqToSql.Size = new System.Drawing.Size(315, 320);
            this.txtLinqToSql.TabIndex = 0;
            this.txtLinqToSql.TextChanged += new System.EventHandler(this.txtLinqToSql_TextChanged);
            // 
            // LinqToSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 347);
            this.Controls.Add(this.txtLinqToSql);
            this.Name = "LinqToSql";
            this.Text = "LinqToSql";
            this.Load += new System.EventHandler(this.LinqToSql_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinqToSql;
    }
}