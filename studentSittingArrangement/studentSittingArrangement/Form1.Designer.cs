namespace studentSittingArrangement
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
            this.txtNoOfColC = new System.Windows.Forms.TextBox();
            this.txtNoOfRowsC = new System.Windows.Forms.TextBox();
            this.txtNoOfSecS = new System.Windows.Forms.TextBox();
            this.GenrteListS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ADD = new System.Windows.Forms.Button();
            this.txtsection = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoOfColC
            // 
            this.txtNoOfColC.Location = new System.Drawing.Point(35, 28);
            this.txtNoOfColC.Name = "txtNoOfColC";
            this.txtNoOfColC.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfColC.TabIndex = 0;
            // 
            // txtNoOfRowsC
            // 
            this.txtNoOfRowsC.Location = new System.Drawing.Point(35, 73);
            this.txtNoOfRowsC.Name = "txtNoOfRowsC";
            this.txtNoOfRowsC.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfRowsC.TabIndex = 1;
            // 
            // txtNoOfSecS
            // 
            this.txtNoOfSecS.Location = new System.Drawing.Point(35, 118);
            this.txtNoOfSecS.Name = "txtNoOfSecS";
            this.txtNoOfSecS.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfSecS.TabIndex = 2;
            // 
            // GenrteListS
            // 
            this.GenrteListS.Location = new System.Drawing.Point(35, 333);
            this.GenrteListS.Name = "GenrteListS";
            this.GenrteListS.Size = new System.Drawing.Size(75, 23);
            this.GenrteListS.TabIndex = 3;
            this.GenrteListS.Text = "Generate";
            this.GenrteListS.UseVisualStyleBackColor = true;
            this.GenrteListS.Click += new System.EventHandler(this.GenrteListS_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(159, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 409);
            this.dataGridView1.TabIndex = 4;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(35, 234);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 5;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(35, 169);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(100, 20);
            this.txtsection.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 409);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GenrteListS);
            this.Controls.Add(this.txtNoOfSecS);
            this.Controls.Add(this.txtNoOfRowsC);
            this.Controls.Add(this.txtNoOfColC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoOfColC;
        private System.Windows.Forms.TextBox txtNoOfRowsC;
        private System.Windows.Forms.TextBox txtNoOfSecS;
        private System.Windows.Forms.Button GenrteListS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox txtsection;
    }
}

