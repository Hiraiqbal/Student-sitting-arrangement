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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoOfColC
            // 
            this.txtNoOfColC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNoOfColC.Location = new System.Drawing.Point(279, 134);
            this.txtNoOfColC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoOfColC.Name = "txtNoOfColC";
            this.txtNoOfColC.Size = new System.Drawing.Size(148, 22);
            this.txtNoOfColC.TabIndex = 0;
            // 
            // txtNoOfRowsC
            // 
            this.txtNoOfRowsC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNoOfRowsC.Location = new System.Drawing.Point(279, 188);
            this.txtNoOfRowsC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoOfRowsC.Name = "txtNoOfRowsC";
            this.txtNoOfRowsC.Size = new System.Drawing.Size(148, 22);
            this.txtNoOfRowsC.TabIndex = 1;
            // 
            // txtNoOfSecS
            // 
            this.txtNoOfSecS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNoOfSecS.Location = new System.Drawing.Point(279, 243);
            this.txtNoOfSecS.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoOfSecS.Name = "txtNoOfSecS";
            this.txtNoOfSecS.Size = new System.Drawing.Size(148, 22);
            this.txtNoOfSecS.TabIndex = 2;
            // 
            // GenrteListS
            // 
            this.GenrteListS.BackColor = System.Drawing.Color.MintCream;
            this.GenrteListS.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GenrteListS.Location = new System.Drawing.Point(297, 356);
            this.GenrteListS.Margin = new System.Windows.Forms.Padding(4);
            this.GenrteListS.Name = "GenrteListS";
            this.GenrteListS.Size = new System.Drawing.Size(112, 28);
            this.GenrteListS.TabIndex = 3;
            this.GenrteListS.Text = "Generate";
            this.GenrteListS.UseVisualStyleBackColor = false;
            this.GenrteListS.Click += new System.EventHandler(this.GenrteListS_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(469, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 417);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ADD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ADD.Location = new System.Drawing.Point(127, 356);
            this.ADD.Margin = new System.Windows.Forms.Padding(4);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(112, 28);
            this.ADD.TabIndex = 5;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // txtsection
            // 
            this.txtsection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtsection.Location = new System.Drawing.Point(279, 293);
            this.txtsection.Margin = new System.Windows.Forms.Padding(4);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(148, 22);
            this.txtsection.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(291, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sitting Arrangement System";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter total number of Columns";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(47, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter total number of Rows";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(47, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter total number of Sections";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(47, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter your Section";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 572);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GenrteListS);
            this.Controls.Add(this.txtNoOfSecS);
            this.Controls.Add(this.txtNoOfRowsC);
            this.Controls.Add(this.txtNoOfColC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

