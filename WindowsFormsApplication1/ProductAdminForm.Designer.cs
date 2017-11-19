namespace MusicShop
{
    partial class ProductAdminForm
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
            this.components = new System.ComponentModel.Container();
            this.productRatingsDGV = new System.Windows.Forms.DataGridView();
            this.ratingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productRatingsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productRatingsDGV
            // 
            this.productRatingsDGV.AutoGenerateColumns = false;
            this.productRatingsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productRatingsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ratingIDDataGridViewTextBoxColumn,
            this.ratingGradeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn});
            this.productRatingsDGV.DataSource = this.ratingBindingSource;
            this.productRatingsDGV.Location = new System.Drawing.Point(54, 64);
            this.productRatingsDGV.Name = "productRatingsDGV";
            this.productRatingsDGV.Size = new System.Drawing.Size(548, 150);
            this.productRatingsDGV.TabIndex = 0;
            // 
            // ratingIDDataGridViewTextBoxColumn
            // 
            this.ratingIDDataGridViewTextBoxColumn.DataPropertyName = "ratingID";
            this.ratingIDDataGridViewTextBoxColumn.HeaderText = "ratingID";
            this.ratingIDDataGridViewTextBoxColumn.Name = "ratingIDDataGridViewTextBoxColumn";
            // 
            // ratingGradeDataGridViewTextBoxColumn
            // 
            this.ratingGradeDataGridViewTextBoxColumn.DataPropertyName = "ratingGrade";
            this.ratingGradeDataGridViewTextBoxColumn.HeaderText = "ratingGrade";
            this.ratingGradeDataGridViewTextBoxColumn.Name = "ratingGradeDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // ratingBindingSource
            // 
            this.ratingBindingSource.DataSource = typeof(MusicShop.rating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productRatingsDGV);
            this.Name = "ProductAdminForm";
            this.Text = "ProductAdminForm";
            this.Load += new System.EventHandler(this.ProductAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productRatingsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productRatingsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ratingBindingSource;
        private System.Windows.Forms.Button button1;
    }
}