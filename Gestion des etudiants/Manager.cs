using System.Data;

namespace Gestion_des_etudiants
{
    public partial class Manager : Form
    {
        StudentsDB students = new StudentsDB();
        public Manager()
        {
            InitializeComponent();
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            StudentsData form2 = new StudentsData();
            DataTable studentData = students.GetStudentList();
            form2.LoadData(studentData);
            form2.ShowDialog();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            students.AddStudent(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void vider_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                students.DeleteStudent(int.Parse(textBox1.Text));
            }
            else
            {
                MessageBox.Show("Please enter a student code first.");
            }
        }

        private void modifer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                students.UpdateStudent(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            }
            else
            {
                MessageBox.Show("Please enter a student code first.");
            }
        }

        private void premier_Click(object sender, EventArgs e)
        {
            DataRow firstStudent = students.GetFirstStudent();

            if (firstStudent != null)
            {
                textBox1.Text = firstStudent["Code"].ToString();
                textBox2.Text = firstStudent["Nom"].ToString();
                textBox3.Text = firstStudent["Prenom"].ToString();
                textBox4.Text = firstStudent["Filiere"].ToString();
            }
            else
            {
                MessageBox.Show("No student found.");
            }
        }

        private void precedent_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DataRow previousStudent = students.GetPreviousStudent(int.Parse(textBox1.Text));

                if (previousStudent != null)
                {
                    textBox1.Text = previousStudent["Code"].ToString();
                    textBox2.Text = previousStudent["Nom"].ToString();
                    textBox3.Text = previousStudent["Prenom"].ToString();
                    textBox4.Text = previousStudent["Filiere"].ToString();
                }
                else
                {
                    MessageBox.Show("No student found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a student code first.");
            }
        }

        private void dernier_Click_1(object sender, EventArgs e)
        {
            DataRow lastStudent = students.GetLastStudent();

            if (lastStudent != null)
            {
                textBox1.Text = lastStudent["Code"].ToString();
                textBox2.Text = lastStudent["Nom"].ToString();
                textBox3.Text = lastStudent["Prenom"].ToString();
                textBox4.Text = lastStudent["Filiere"].ToString();
            }
            else
            {
                MessageBox.Show("No student found.");
            }
        }

        private void suivant_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DataRow nextStudent = students.GetNextStudent(int.Parse(textBox1.Text));

                if (nextStudent != null)
                {
                    textBox1.Text = nextStudent["Code"].ToString();
                    textBox2.Text = nextStudent["Nom"].ToString();
                    textBox3.Text = nextStudent["Prenom"].ToString();
                    textBox4.Text = nextStudent["Filiere"].ToString();
                }
                else
                {
                    MessageBox.Show("No student found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a student code first.");
            }
        }

        private void chercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DataRow foundStudent = students.GetStudent(int.Parse(textBox1.Text));

                if (foundStudent != null)
                {
                    textBox1.Text = foundStudent["Code"].ToString();
                    textBox2.Text = foundStudent["Nom"].ToString();
                    textBox3.Text = foundStudent["Prenom"].ToString();
                    textBox4.Text = foundStudent["Filiere"].ToString();
                }
                else
                {
                    MessageBox.Show("No student found with that code");
                }
            }
            else
            {
                MessageBox.Show("Please enter a student code first.");
            }
        }
    }
}