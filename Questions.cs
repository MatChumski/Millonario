using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Millonario
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            pnlQAyudas.Visible = false;
            tabQuestions.Size = new System.Drawing.Size(788, 452);

            btnQ1.Enabled = false;
            btnQ2.Enabled = false;
            btnQ3.Enabled = false;
            btnQ4.Enabled = false;
            btnQ5.Enabled = false;
            btnQ6.Enabled = false;
        }

        public List<string> selectedAnswers = new List<string>();
        public List<string> correctAnswers = new List<string>()
        {
            "B",
            "C",
            "D",
            "A",
            "C",
            "D"
        };
        public List<string> clues = new List<string>()
        {
            "El presidente era popular por su barba peculiar",
            "También fue causante de la primera",
            "Su mascota es un payaso",
            "Fue escrita por Albert Einstein, involucra la velocidad de la luz",
            "Es un agente secreto en una caricatura",
            "Conocido como Heisenberg, su apellido incluye un color"
        };

        public TabPage nextQuestion;
        public TabPage currentQuestion;

        public bool bonus = false;
        public int skipped = -1;


        private void Questions_Load(object sender, EventArgs e)
        {

        }

        private void tabQ1_Click(object sender, EventArgs e)
        {

        }

        private void lblQInicioComenzar_Click(object sender, EventArgs e)
        {
            tabQuestions.Size = new System.Drawing.Size(645, 452);
            pnlQAyudas.Visible = true;

            currentQuestion = tabQ1;
            nextQuestion = tabQ2;
            tabQuestions.SelectedTab = currentQuestion;
        }

        private void GetAnswer(RadioButton rbA, RadioButton rbB, RadioButton rbC, RadioButton rbD)
        {
            string selected = "";

            if (rbA.Checked)
            {
                selected = "A";
            }
            else if (rbB.Checked)
            {
                selected = "B";
            }
            else if (rbC.Checked)
            {
                selected = "C";
            }
            else if (rbD.Checked)
            {
                selected = "D";
            }

            selectedAnswers.Add(selected);
        }

        /*
         * QUESTION 1
         */
        private void btnQ1_Click(object sender, EventArgs e)
        {
            GetAnswer(rbQ1A, rbQ1B, rbQ1C, rbQ1D);
            currentQuestion = nextQuestion;
            tabQuestions.SelectedTab = nextQuestion;
            nextQuestion = tabQ3;
        }
        private void rbQ1_CheckedChanged(object sender, EventArgs e)
        {
            btnQ1.Enabled = true;
        }

        /*
         * QUESTION 2
         */
        private void btnQ2_Click(object sender, EventArgs e)
        {
            GetAnswer(rbQ2A, rbQ2B, rbQ2C, rbQ2D);
            currentQuestion = nextQuestion;
            tabQuestions.SelectedTab = nextQuestion;
            nextQuestion = tabQ4;
        }
        private void rbQ2_CheckedChanged(object sender, EventArgs e)
        {
            btnQ2.Enabled = true;
        }

        /*
         * QUESTION 3
         */
        private void btnQ3_Click(object sender, EventArgs e)
        {
            GetAnswer(rbQ3A, rbQ3B, rbQ3C, rbQ3D);
            currentQuestion = nextQuestion;
            tabQuestions.SelectedTab = nextQuestion;
            nextQuestion = tabQ5;
        }
        private void rbQ3_CheckedChanged(object sender, EventArgs e)
        {
            btnQ3.Enabled = true;
        }

        /*
         * QUESTION 4
         */
        private void btnQ4_Click(object sender, EventArgs e)
        {
            GetAnswer(rbQ4A, rbQ4B, rbQ4C, rbQ4D);
            currentQuestion = nextQuestion;
            tabQuestions.SelectedTab = nextQuestion;
            nextQuestion = tabResults;
        }
        private void rbQ4_CheckedChanged(object sender, EventArgs e)
        {
            btnQ4.Enabled = true;
        }

        /*
         * QUESTION 5
         */
        private void btnQ5_Click(object sender, EventArgs e)
        {
            GetAnswer(rbQ5A, rbQ5B, rbQ5C, rbQ5D);
            tabQuestions.SelectedTab = nextQuestion;
            tabQuestions.Size = new System.Drawing.Size(788, 452);
            pnlQAyudas.Visible = false;
            SetResults();
        }
        private void rbQ5_CheckedChanged(object sender, EventArgs e)
        {
            btnQ5.Enabled = true;
        }

        /*
         * QUESTION 6 - BONUS
         */
        private void btnQ6_Click(object sender, EventArgs e)
        {
            GetAnswer(rbQ6A, rbQ6B, rbQ6C, rbQ6D);
            currentQuestion = nextQuestion;
            tabQuestions.SelectedTab = nextQuestion;
            if (nextQuestion == tabResults)
            {
                tabQuestions.Size = new System.Drawing.Size(788, 452);
                pnlQAyudas.Visible = false;
                SetResults();
            }
            else if (nextQuestion == tabQ1)
            { 
                nextQuestion = tabQ2;
            }
            else if (currentQuestion == tabQ2)
            {
                nextQuestion = tabQ3;
            }
            else if (currentQuestion == tabQ3)
            {
                nextQuestion = tabQ4;
            }
            else if (currentQuestion == tabQ4)
            {
                nextQuestion = tabQ5;
            } 
            else if (currentQuestion == tabQ5)
            {
                nextQuestion = tabResults;
            }
            
        }
        private void rbQ6_CheckedChanged(object sender, EventArgs e)
        {
            btnQ6.Enabled = true;
        }

        private void SetResults()
        {
            string answersResult = "";
            string rightAnswers = "";

            int count = 0;

            for (int i = 0; i < selectedAnswers.Count(); i++)
            {
                if (i != 5)
                {
                    if (i == skipped)
                    {
                        rightAnswers += correctAnswers[correctAnswers.Count - 1] + " ";
                        if (selectedAnswers[i] == correctAnswers[correctAnswers.Count - 1])
                        {
                            count++;
                        }
                    }
                    else
                    {
                        rightAnswers += correctAnswers[i] + " ";                        
                    }
                    answersResult += selectedAnswers[i] + " ";

                } else if (bonus)
                {
                    answersResult += selectedAnswers[i] + " ";
                    rightAnswers += correctAnswers[i] + " ";
                }

                if (selectedAnswers[i] == correctAnswers[i])
                {
                    count++;
                }
            }

            lblRespuestasJugador.Text = answersResult;
            lblRespuestasCorrectas.Text = rightAnswers;
            lblTotal.Text = count.ToString() + "/5";

        }

        private void lblCambio_Click(object sender, EventArgs e)
        {
            if (currentQuestion == tabQ1)
            {
                skipped = 0;
                nextQuestion = tabQ2;
            } 
            else if (currentQuestion == tabQ2)
            {
                skipped = 1;
                nextQuestion = tabQ3;
            } 
            else if (currentQuestion == tabQ3)
            {
                skipped = 2;
                nextQuestion = tabQ4;
            }
            else if (currentQuestion == tabQ4)
            {
                skipped = 3;
                nextQuestion = tabQ5;
            }
            else if (currentQuestion == tabQ5)
            {
                skipped = 4;
                nextQuestion = tabResults;
            }

            currentQuestion = tabQ6;
            tabQuestions.SelectedTab = currentQuestion;
            bonus = true;
            lblCambio.Enabled = false;
        }

        private void ShowClue(string message)
        {
            string caption = "Pista";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
        }

        private void lblPista_Click(object sender, EventArgs e)
        {
            string message = "";
            if (currentQuestion == tabQ1)
            {
                message = clues[0];
            }
            else if (currentQuestion == tabQ2)
            {
                message = clues[1];
            }
            else if (currentQuestion == tabQ3)
            {
                message = clues[2];
            }
            else if (currentQuestion == tabQ4)
            {
                message = clues[3];
            }
            else if (currentQuestion == tabQ5)
            {
                message = clues[4];
            } 
            else if (currentQuestion == tabQ6)
            {
                message = clues[5];
            }

            ShowClue(message);
            lblPista.Enabled = false;
                
        }

        private void HideOptions(RadioButton option1, RadioButton option2)
        {
            option1.Enabled = false;
            option2.Enabled = false;
        }
        private void lbl50_Click(object sender, EventArgs e)
        {
            if (currentQuestion == tabQ1)
            {
                HideOptions(rbQ1C, rbQ1D);
            }
            else if (currentQuestion == tabQ2)
            {
                HideOptions(rbQ2B, rbQ2D);
            }
            else if (currentQuestion == tabQ3)
            {
                HideOptions(rbQ3A, rbQ3C);
            }
            else if (currentQuestion == tabQ4)
            {
                HideOptions(rbQ4B, rbQ4C);
            }
            else if (currentQuestion == tabQ5)
            {
                HideOptions(rbQ5B, rbQ5D);
            }
            else if (currentQuestion == tabQ6)
            {
                HideOptions(rbQ6B, rbQ6C);
            }

            lbl50.Enabled = false;
        }
    }
}
