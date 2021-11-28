using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonArr_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDownCount.Value);
            int[] arr = new int[n];
            ArrayLibrary.Array.FillArrayByRandomValue(arr);
            dataGridViewArr.ColumnCount = n;
            dataGridViewArr.RowCount = 1;
            for(int i=0;i<arr.Length;i++)
            {
                dataGridViewArr.Columns[i].HeaderText = i.ToString();
                dataGridViewArr[i, 0].Value = arr[i];
            }
            
            labelSumNegElement.Text = Convert.ToString(ArrayLibrary.Array.SumNegElement(arr));
            labeltask1.Visible = true;
            labelSumNegElement.Visible = true;
            labelMaxEvenElement.Text = Convert.ToString(ArrayLibrary.Array.MaxEvenElement(arr));
            labeltask2.Visible = true;
            labelMaxEvenElement.Visible = true;
            labelDobElementEvenIndex.Text = Convert.ToString(ArrayLibrary.Array.DobElementEvenIndex(arr));
            labelDobElementEvenIndex.Visible = true;
            labeltask3.Visible = true;
            labelIndexMaxElement.Text = Convert.ToString(ArrayLibrary.Array.IndexMaxElement(arr));
            labelIndexMaxElement.Visible = true;
            labeltask4.Visible = true;
            labelMaxAbsElement.Text = Convert.ToString(ArrayLibrary.Array.MaxAbsElement(arr));
            labelMaxAbsElement.Visible = true;
            labeltask5.Visible = true;
            label1.Text = Convert.ToString(Math.Abs(ArrayLibrary.Array.MaxAbsElement(arr)));
            label.Visible = true;
            label1.Visible = true;
            labelSumIndexPositiveElement.Text = Convert.ToString(ArrayLibrary.Array.SumIndexPositiveElement(arr));
            labelSumIndexPositiveElement.Visible = true;
            labeltask6.Visible = true;
            labelNUnpairedElement.Text = Convert.ToString(ArrayLibrary.Array.NUnpairedElement(arr));
            labeltask7.Visible = true;
            labelNUnpairedElement.Visible = true;
        }

        private void dataGridViewArr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonRes_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelMaxAbsElement_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelMaxEvenElement_Click(object sender, EventArgs e)
        {

        }
    }
}
