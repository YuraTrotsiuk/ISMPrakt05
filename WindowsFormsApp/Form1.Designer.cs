
namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonArr = new System.Windows.Forms.Button();
            this.dataGridViewArr = new System.Windows.Forms.DataGridView();
            this.labelN = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.labeltask1 = new System.Windows.Forms.Label();
            this.labelSumNegElement = new System.Windows.Forms.Label();
            this.labeltask2 = new System.Windows.Forms.Label();
            this.labelMaxEvenElement = new System.Windows.Forms.Label();
            this.labeltask3 = new System.Windows.Forms.Label();
            this.labelDobElementEvenIndex = new System.Windows.Forms.Label();
            this.labeltask4 = new System.Windows.Forms.Label();
            this.labelIndexMaxElement = new System.Windows.Forms.Label();
            this.labeltask5 = new System.Windows.Forms.Label();
            this.labelMaxAbsElement = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltask6 = new System.Windows.Forms.Label();
            this.labelSumIndexPositiveElement = new System.Windows.Forms.Label();
            this.labeltask7 = new System.Windows.Forms.Label();
            this.labelNUnpairedElement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonArr
            // 
            this.buttonArr.Location = new System.Drawing.Point(37, 79);
            this.buttonArr.Name = "buttonArr";
            this.buttonArr.Size = new System.Drawing.Size(277, 35);
            this.buttonArr.TabIndex = 0;
            this.buttonArr.Text = "Сформувати масив та обрахувати";
            this.buttonArr.UseVisualStyleBackColor = true;
            this.buttonArr.Click += new System.EventHandler(this.buttonArr_Click);
            // 
            // dataGridViewArr
            // 
            this.dataGridViewArr.AllowUserToAddRows = false;
            this.dataGridViewArr.AllowUserToDeleteRows = false;
            this.dataGridViewArr.AllowUserToOrderColumns = true;
            this.dataGridViewArr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArr.Location = new System.Drawing.Point(12, 330);
            this.dataGridViewArr.Name = "dataGridViewArr";
            this.dataGridViewArr.RowHeadersWidth = 51;
            this.dataGridViewArr.RowTemplate.Height = 24;
            this.dataGridViewArr.Size = new System.Drawing.Size(960, 108);
            this.dataGridViewArr.TabIndex = 1;
            this.dataGridViewArr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArr_CellContentClick);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(12, 51);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(200, 18);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Кількість елементів масиву";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(218, 51);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCount.TabIndex = 3;
            // 
            // labeltask1
            // 
            this.labeltask1.AutoSize = true;
            this.labeltask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltask1.Location = new System.Drawing.Point(329, 124);
            this.labeltask1.Name = "labeltask1";
            this.labeltask1.Size = new System.Drawing.Size(178, 17);
            this.labeltask1.TabIndex = 4;
            this.labeltask1.Text = "Сума від\'ємних елементів:";
            this.labeltask1.Visible = false;
            // 
            // labelSumNegElement
            // 
            this.labelSumNegElement.AutoSize = true;
            this.labelSumNegElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumNegElement.Location = new System.Drawing.Point(513, 124);
            this.labelSumNegElement.Name = "labelSumNegElement";
            this.labelSumNegElement.Size = new System.Drawing.Size(46, 17);
            this.labelSumNegElement.TabIndex = 5;
            this.labelSumNegElement.Text = "label2";
            this.labelSumNegElement.Visible = false;
            // 
            // labeltask2
            // 
            this.labeltask2.AutoSize = true;
            this.labeltask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltask2.Location = new System.Drawing.Point(329, 141);
            this.labeltask2.Name = "labeltask2";
            this.labeltask2.Size = new System.Drawing.Size(272, 17);
            this.labeltask2.TabIndex = 6;
            this.labeltask2.Text = "Максимальний серед парних елементів:";
            this.labeltask2.Visible = false;
            // 
            // labelMaxEvenElement
            // 
            this.labelMaxEvenElement.AutoSize = true;
            this.labelMaxEvenElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxEvenElement.Location = new System.Drawing.Point(612, 140);
            this.labelMaxEvenElement.Name = "labelMaxEvenElement";
            this.labelMaxEvenElement.Size = new System.Drawing.Size(46, 17);
            this.labelMaxEvenElement.TabIndex = 7;
            this.labelMaxEvenElement.Text = "label2";
            this.labelMaxEvenElement.Visible = false;
            this.labelMaxEvenElement.Click += new System.EventHandler(this.labelMaxEvenElement_Click);
            // 
            // labeltask3
            // 
            this.labeltask3.AutoSize = true;
            this.labeltask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltask3.Location = new System.Drawing.Point(329, 157);
            this.labeltask3.Name = "labeltask3";
            this.labeltask3.Size = new System.Drawing.Size(348, 17);
            this.labeltask3.TabIndex = 8;
            this.labeltask3.Text = "Добуток елементів масиву,що мають парні індекси:";
            this.labeltask3.Visible = false;
            // 
            // labelDobElementEvenIndex
            // 
            this.labelDobElementEvenIndex.AutoSize = true;
            this.labelDobElementEvenIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDobElementEvenIndex.Location = new System.Drawing.Point(692, 157);
            this.labelDobElementEvenIndex.Name = "labelDobElementEvenIndex";
            this.labelDobElementEvenIndex.Size = new System.Drawing.Size(46, 17);
            this.labelDobElementEvenIndex.TabIndex = 9;
            this.labelDobElementEvenIndex.Text = "label2";
            this.labelDobElementEvenIndex.Visible = false;
            this.labelDobElementEvenIndex.Click += new System.EventHandler(this.label2_Click);
            // 
            // labeltask4
            // 
            this.labeltask4.AutoSize = true;
            this.labeltask4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltask4.Location = new System.Drawing.Point(329, 175);
            this.labeltask4.Name = "labeltask4";
            this.labeltask4.Size = new System.Drawing.Size(225, 17);
            this.labeltask4.TabIndex = 10;
            this.labeltask4.Text = "Індекс максимального елемента:";
            this.labeltask4.Visible = false;
            // 
            // labelIndexMaxElement
            // 
            this.labelIndexMaxElement.AutoSize = true;
            this.labelIndexMaxElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndexMaxElement.Location = new System.Drawing.Point(570, 174);
            this.labelIndexMaxElement.Name = "labelIndexMaxElement";
            this.labelIndexMaxElement.Size = new System.Drawing.Size(46, 17);
            this.labelIndexMaxElement.TabIndex = 11;
            this.labelIndexMaxElement.Text = "label4";
            this.labelIndexMaxElement.Visible = false;
            // 
            // labeltask5
            // 
            this.labeltask5.AutoSize = true;
            this.labeltask5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltask5.Location = new System.Drawing.Point(329, 193);
            this.labeltask5.Name = "labeltask5";
            this.labeltask5.Size = new System.Drawing.Size(249, 17);
            this.labeltask5.TabIndex = 12;
            this.labeltask5.Text = "Максимальний за модулем елемент:";
            this.labeltask5.Visible = false;
            // 
            // labelMaxAbsElement
            // 
            this.labelMaxAbsElement.AutoSize = true;
            this.labelMaxAbsElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxAbsElement.Location = new System.Drawing.Point(584, 192);
            this.labelMaxAbsElement.Name = "labelMaxAbsElement";
            this.labelMaxAbsElement.Size = new System.Drawing.Size(0, 17);
            this.labelMaxAbsElement.TabIndex = 13;
            this.labelMaxAbsElement.Visible = false;
            this.labelMaxAbsElement.Click += new System.EventHandler(this.labelMaxAbsElement_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(612, 192);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 17);
            this.label.TabIndex = 14;
            this.label.Text = "його модуль:";
            this.label.Visible = false;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(710, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "label4";
            this.label1.Visible = false;
            // 
            // labeltask6
            // 
            this.labeltask6.AutoSize = true;
            this.labeltask6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltask6.Location = new System.Drawing.Point(329, 210);
            this.labeltask6.Name = "labeltask6";
            this.labeltask6.Size = new System.Drawing.Size(235, 17);
            this.labeltask6.TabIndex = 16;
            this.labeltask6.Text = "Сума індексів додатних елементів:";
            this.labeltask6.Visible = false;
            // 
            // labelSumIndexPositiveElement
            // 
            this.labelSumIndexPositiveElement.AutoSize = true;
            this.labelSumIndexPositiveElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumIndexPositiveElement.Location = new System.Drawing.Point(570, 210);
            this.labelSumIndexPositiveElement.Name = "labelSumIndexPositiveElement";
            this.labelSumIndexPositiveElement.Size = new System.Drawing.Size(46, 17);
            this.labelSumIndexPositiveElement.TabIndex = 17;
            this.labelSumIndexPositiveElement.Text = "label6";
            this.labelSumIndexPositiveElement.Visible = false;
            // 
            // labeltask7
            // 
            this.labeltask7.AutoSize = true;
            this.labeltask7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltask7.Location = new System.Drawing.Point(329, 226);
            this.labeltask7.Name = "labeltask7";
            this.labeltask7.Size = new System.Drawing.Size(206, 17);
            this.labeltask7.TabIndex = 18;
            this.labeltask7.Text = "Кількість непарних елементів:";
            this.labeltask7.Visible = false;
            // 
            // labelNUnpairedElement
            // 
            this.labelNUnpairedElement.AutoSize = true;
            this.labelNUnpairedElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNUnpairedElement.Location = new System.Drawing.Point(541, 228);
            this.labelNUnpairedElement.Name = "labelNUnpairedElement";
            this.labelNUnpairedElement.Size = new System.Drawing.Size(46, 17);
            this.labelNUnpairedElement.TabIndex = 19;
            this.labelNUnpairedElement.Text = "label3";
            this.labelNUnpairedElement.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.labelNUnpairedElement);
            this.Controls.Add(this.labeltask7);
            this.Controls.Add(this.labelSumIndexPositiveElement);
            this.Controls.Add(this.labeltask6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelMaxAbsElement);
            this.Controls.Add(this.labeltask5);
            this.Controls.Add(this.labelIndexMaxElement);
            this.Controls.Add(this.labeltask4);
            this.Controls.Add(this.labelDobElementEvenIndex);
            this.Controls.Add(this.labeltask3);
            this.Controls.Add(this.labelMaxEvenElement);
            this.Controls.Add(this.labeltask2);
            this.Controls.Add(this.labelSumNegElement);
            this.Controls.Add(this.labeltask1);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.dataGridViewArr);
            this.Controls.Add(this.buttonArr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArr;
        private System.Windows.Forms.DataGridView dataGridViewArr;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labeltask1;
        private System.Windows.Forms.Label labelSumNegElement;
        private System.Windows.Forms.Label labeltask2;
        private System.Windows.Forms.Label labelMaxEvenElement;
        private System.Windows.Forms.Label labeltask3;
        private System.Windows.Forms.Label labelDobElementEvenIndex;
        private System.Windows.Forms.Label labeltask4;
        private System.Windows.Forms.Label labelIndexMaxElement;
        private System.Windows.Forms.Label labeltask5;
        private System.Windows.Forms.Label labelMaxAbsElement;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltask6;
        private System.Windows.Forms.Label labelSumIndexPositiveElement;
        private System.Windows.Forms.Label labeltask7;
        private System.Windows.Forms.Label labelNUnpairedElement;
    }
}

