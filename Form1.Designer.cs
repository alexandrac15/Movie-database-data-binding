namespace movie_database__data_binding_version
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.directorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDBDataSet = new movie_database__data_binding_version.MDBDataSet();
            this.directorsTableAdapter = new movie_database__data_binding_version.MDBDataSetTableAdapters.DirectorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(332, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 192);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(334, 145);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(416, 192);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 32);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(416, 265);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(112, 32);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(416, 228);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 32);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(394, 55);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(105, 20);
            this.titleTextBox.TabIndex = 5;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(394, 85);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(105, 20);
            this.yearTextBox.TabIndex = 6;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(394, 115);
            this.ratingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(105, 20);
            this.ratingTextBox.TabIndex = 7;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.ratingTextBox_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(512, 56);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(27, 13);
            this.title.TabIndex = 8;
            this.title.Text = "Title";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(513, 89);
            this.year.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(29, 13);
            this.year.TabIndex = 9;
            this.year.Text = "Year";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(512, 115);
            this.Rating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 10;
            this.Rating.Text = "Rating";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(394, 142);
            this.idbox.Margin = new System.Windows.Forms.Padding(2);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(105, 20);
            this.idbox.TabIndex = 11;
            this.idbox.Text = "\r\n\r\n\r\n";
            this.idbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // directorsBindingSource
            // 
            this.directorsBindingSource.DataMember = "Directors";
            this.directorsBindingSource.DataSource = this.mDBDataSet;
            // 
            // mDBDataSet
            // 
            this.mDBDataSet.DataSetName = "MDBDataSet";
            this.mDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorsTableAdapter
            // 
            this.directorsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.year);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.TextBox idbox;
        private MDBDataSet mDBDataSet;
        private System.Windows.Forms.BindingSource directorsBindingSource;
        private MDBDataSetTableAdapters.DirectorsTableAdapter directorsTableAdapter;
    }
}

