using System.Diagnostics;

namespace AppWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEvalueate_Click(object sender, EventArgs e)
        {
            bool heightIsParsed = Double.TryParse(numUpDownHeight.Value.ToString(), out double height);
            bool weightIsParsed = Double.TryParse(numUpDownWeight.Value.ToString(), out double weight);

            //decimal height = numUpDownHeight.Value;
            //decimal weight = numUpDownWeight.Value;


            double imc = weight / (height * height);
            MessageBox.Show($"El indice de masa corporal es {imc}");

            

            //if (heightIsParsed && weightIsParsed)
            //{
            //    //double imc = weight / (height * height);
            //    //MessageBox.Show($"El indice de masa corporal es {imc}");
            //}
            //else
            //{
            //    lblResult.Visible = true;
            //    lblResult.Text = "Remember you can only enter integer numbers from 0 to 255.";
            //}

        }

        // Body Mass Index (BMI) Calculator

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numUpDownHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }
    }
}