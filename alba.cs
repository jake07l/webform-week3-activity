using System;
using System.Windows.Forms;

namespace GradeCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Validate if all inputs are numeric
            if (!double.TryParse(txtQuiz1.Text, out double q1) ||
                !double.TryParse(txtQuiz2.Text, out double q2) ||
                !double.TryParse(txtQuiz3.Text, out double q3))
            {
                MessageBox.Show("Error: Please enter numeric values only.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Compute average
            double average = (q1 + q2 + q3) / 3;

            // Determine letter grade
            string grade;

            if (average >= 90)
                grade = "A";
            else if (average >= 80)
                grade = "B";
            else if (average >= 70)
                grade = "C";
            else if (average >= 60)
                grade = "D";
            else
                grade = "F";

            // Show output
            MessageBox.Show($"Average: {average:F2}\nGrade: {grade}",
                            "Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}