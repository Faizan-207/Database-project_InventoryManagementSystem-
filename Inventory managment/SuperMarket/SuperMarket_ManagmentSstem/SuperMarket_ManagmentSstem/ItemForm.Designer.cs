namespace SuperMarket_ManagmentSstem
{
    partial class ItemForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.itemGv = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemGv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Goldenrod;
            this.button2.Location = new System.Drawing.Point(15, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(908, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // itemGv
            // 
            this.itemGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGv.Location = new System.Drawing.Point(149, 95);
            this.itemGv.Name = "itemGv";
            this.itemGv.Size = new System.Drawing.Size(612, 424);
            this.itemGv.TabIndex = 4;
            this.itemGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGv_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Food",
            "Cold Drinks",
            "Ice-Cream",
            "Bakery ",
            "Dry fruits",
            "Laundry ",
            "Cosmetic",
            "Cooking "});
            this.comboBox1.Location = new System.Drawing.Point(18, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 27);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Categories";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(361, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Items";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.itemGv);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(163, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 533);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(20, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 34);
            this.button3.TabIndex = 22;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Goldenrod;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(20, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 34);
            this.button6.TabIndex = 20;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(16, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Item Price";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(16, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Item Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox6.Location = new System.Drawing.Point(19, 259);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(106, 29);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox5.Location = new System.Drawing.Point(19, 162);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 29);
            this.textBox5.TabIndex = 18;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox4.Location = new System.Drawing.Point(19, 111);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 29);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Item Num";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(377, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Item List";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Goldenrod;
            this.button5.Location = new System.Drawing.Point(15, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 31);
            this.button5.TabIndex = 17;
            this.button5.Text = "Orders";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Goldenrod;
            this.button4.Location = new System.Drawing.Point(15, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 31);
            this.button4.TabIndex = 16;
            this.button4.Text = "Users";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(937, 570);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.itemGv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView itemGv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}