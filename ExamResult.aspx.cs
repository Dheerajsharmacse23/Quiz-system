using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace QuizSystem
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CorrectAnswers"] != null && Session["IncorrectAnswers"] != null && Session["UserSelections"] != null)
                {
                    int correctAnswers = (int)Session["CorrectAnswers"];
                    int incorrectAnswers = (int)Session["IncorrectAnswers"];
                  
                    List<string> userSelections = Session["UserSelections"] as List<string>;


               
                    int totalQuestions = correctAnswers + incorrectAnswers;

                    
                    lblCorrectAnswers.Text = correctAnswers.ToString();
                    lblIncorrectAnswers.Text = incorrectAnswers.ToString();
                    lblTotalQuestions.Text = totalQuestions.ToString();

   
                    for (int i = 0; i < userSelections.Count; i++)
                    {
                        int Id = i + 1;
                        string userAnswer = userSelections[i];
                        string correctAnswer = GetCorrectAnswerForQuestion(Id); 
                        string questionText = GetQuestionTextForQuestion(Id);
                        
                        Panel cardPanel = new Panel();
                        cardPanel.CssClass = "card";

                        Panel bodyPanel = new Panel();
                        bodyPanel.CssClass = "card-body";

                        Label lblQuestionText = new Label();
                        lblQuestionText.Text = "Question: " + questionText +"<br/>";
                        bodyPanel.Controls.Add(lblQuestionText);

                        
                        Label lblUserAnswer = new Label();
                        lblUserAnswer.Text = "Your Answer: " + userAnswer +"<br/>";
                        bodyPanel.Controls.Add(lblUserAnswer);

                        Label lblCorrectAnswer = new Label();
                        lblCorrectAnswer.Text = "Correct Answer: " + correctAnswer +"<br/>";
                        bodyPanel.Controls.Add(lblCorrectAnswer);

                        cardPanel.Controls.Add(bodyPanel);

                    
                        resultPanel.Controls.Add(cardPanel);

                        resultPanel.Controls.Add(new LiteralControl("<br />"));
                    }
                }

            }
        }
   
        private string GetCorrectAnswerForQuestion(int questionID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            string query = "SELECT CorrectAnswer FROM Questions WHERE ID = @ID";

            string correctAnswer = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", questionID);

                    connection.Open();
                    correctAnswer = (string)command.ExecuteScalar();
                }
            }

            return correctAnswer;
        }
        private string GetQuestionTextForQuestion(int questionID) 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            string query = "SELECT QuestionText FROM Questions WHERE ID = @ID";
            string questionstext = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", questionID);

                    connection.Open();
                    questionstext = (string)command.ExecuteScalar();
                }
            }

            return questionstext;
        }
    }
}