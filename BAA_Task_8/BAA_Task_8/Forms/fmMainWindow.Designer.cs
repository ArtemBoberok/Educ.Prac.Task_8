namespace BAA_Task_8.Forms
{
    partial class fmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNameGood = new System.Windows.Forms.TextBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.labelCountGood = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStripName = new System.Windows.Forms.Label();
            this.labelStripRole = new System.Windows.Forms.Label();
            this.dataGridViewGood = new System.Windows.Forms.DataGridView();
            this.pictureBoxGood = new System.Windows.Forms.PictureBox();
            this.labelNameGood = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(708, 30);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 26);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог товаров";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BAA_Task_8.Properties.Resources.computer;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxNameGood);
            this.panel2.Controls.Add(this.comboBoxSort);
            this.panel2.Controls.Add(this.comboBoxCat);
            this.panel2.Controls.Add(this.labelCountGood);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 2;
            // 
            // textBoxNameGood
            // 
            this.textBoxNameGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameGood.Location = new System.Drawing.Point(356, 9);
            this.textBoxNameGood.Name = "textBoxNameGood";
            this.textBoxNameGood.Size = new System.Drawing.Size(198, 26);
            this.textBoxNameGood.TabIndex = 7;
            this.textBoxNameGood.TextChanged += new System.EventHandler(this.textBoxNameGood_TextChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "по убыванию цены",
            "по возростанию цены",
            "по названию"});
            this.comboBoxSort.Location = new System.Drawing.Point(560, 41);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSort.TabIndex = 6;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(188, 41);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(200, 28);
            this.comboBoxCat.TabIndex = 5;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // labelCountGood
            // 
            this.labelCountGood.AutoSize = true;
            this.labelCountGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountGood.Location = new System.Drawing.Point(12, 80);
            this.labelCountGood.Name = "labelCountGood";
            this.labelCountGood.Size = new System.Drawing.Size(138, 17);
            this.labelCountGood.TabIndex = 3;
            this.labelCountGood.Text = "Результат запроса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(432, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Сортировка по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите категорию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите наименование товара для поиска";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStripName
            // 
            this.labelStripName.AutoSize = true;
            this.labelStripName.Location = new System.Drawing.Point(12, 433);
            this.labelStripName.Name = "labelStripName";
            this.labelStripName.Size = new System.Drawing.Size(83, 13);
            this.labelStripName.TabIndex = 4;
            this.labelStripName.Text = "Пользователь:";
            // 
            // labelStripRole
            // 
            this.labelStripRole.AutoSize = true;
            this.labelStripRole.Location = new System.Drawing.Point(164, 433);
            this.labelStripRole.Name = "labelStripRole";
            this.labelStripRole.Size = new System.Drawing.Size(44, 13);
            this.labelStripRole.TabIndex = 5;
            this.labelStripRole.Text = "Статус:";
            // 
            // dataGridViewGood
            // 
            this.dataGridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGood.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewGood.Location = new System.Drawing.Point(0, 195);
            this.dataGridViewGood.Name = "dataGridViewGood";
            this.dataGridViewGood.Size = new System.Drawing.Size(554, 233);
            this.dataGridViewGood.TabIndex = 6;
            this.dataGridViewGood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGood_CellClick);
            // 
            // pictureBoxGood
            // 
            this.pictureBoxGood.Location = new System.Drawing.Point(561, 201);
            this.pictureBoxGood.Name = "pictureBoxGood";
            this.pictureBoxGood.Size = new System.Drawing.Size(227, 204);
            this.pictureBoxGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGood.TabIndex = 7;
            this.pictureBoxGood.TabStop = false;
            // 
            // labelNameGood
            // 
            this.labelNameGood.AutoSize = true;
            this.labelNameGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameGood.Location = new System.Drawing.Point(560, 408);
            this.labelNameGood.Name = "labelNameGood";
            this.labelNameGood.Size = new System.Drawing.Size(0, 20);
            this.labelNameGood.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(727, 408);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 20);
            this.labelPrice.TabIndex = 9;
            // 
            // fmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelNameGood);
            this.Controls.Add(this.pictureBoxGood);
            this.Controls.Add(this.dataGridViewGood);
            this.Controls.Add(this.labelStripRole);
            this.Controls.Add(this.labelStripName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.fmMainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCountGood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.TextBox textBoxNameGood;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label labelStripName;
        private System.Windows.Forms.Label labelStripRole;
        private System.Windows.Forms.DataGridView dataGridViewGood;
        private System.Windows.Forms.PictureBox pictureBoxGood;
        private System.Windows.Forms.Label labelNameGood;
        private System.Windows.Forms.Label labelPrice;
    }
}