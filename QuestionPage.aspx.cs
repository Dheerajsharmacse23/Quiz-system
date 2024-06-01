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
    public partial class MCQ_Questions : System.Web.UI.Page
    {
        public DataTable questionsTable;
        protected int CurrentQuestionIndex
        {
            get
            {
                if (ViewState["CurrentQuestionIndex"] != null)
                    return (int)ViewState["CurrentQuestionIndex"];
                else
                    return 0;
            }
            set
            {
                ViewState["CurrentQuestionIndex"] = value;
            }
        }
        private int correctAnswers = 0;
        private int incorrectAnswers = 0;
        private Dictionary<int, string> userSelections = new Dictionary<int, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string email = Session["Email"] as String;
                if (email != null)
                {

                    btnemail.Text = "Welcome, " + email + "!";
                    LoadQuestionsFromDatabase();
                    DisplayQuestion();
                }
              
            }
            else
            {
                // Ensure questionsTable is loaded on postback
                if (ViewState["QuestionsTable"] != null)
                {
                    questionsTable = (DataTable)ViewState["QuestionsTable"];
                }
                else
                {
                    LoadQuestionsFromDatabase();
                }
            }
        }
        private void LoadQuestionsFromDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Questions";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                questionsTable = new DataTable();
                adapter.Fill(questionsTable);
                ViewState["QuestionsTable"] = questionsTable;
            }
        }
        private void DisplayQuestion()
        {
            if (CurrentQuestionIndex < questionsTable.Rows.Count)
            {
                DataRow row = questionsTable.Rows[CurrentQuestionIndex];
                lblQuestion.Text = row["QuestionText"].ToString();
                radiobtnlist1.Items.Clear();
                radiobtnlist1.Items.Add(row["Option1"].ToString());
                radiobtnlist1.Items.Add(row["Option2"].ToString());
                radiobtnlist1.Items.Add(row["Option3"].ToString());
                radiobtnlist1.Items.Add(row["Option4"].ToString());
            }
            else
            {
                // All questions have been answered
                lblQuestion.Text = "All questions have been answered!";
                radiobtnlist1.Visible = false;
                radiobtnlist1.Visible = false;
            }
        }

        private void CheckAnswer()
        {
            if (CurrentQuestionIndex < questionsTable.Rows.Count)
            {
                DataRow row = questionsTable.Rows[CurrentQuestionIndex];
                string correctAnswer = row["CorrectAnswer"].ToString();
                string selectedAnswer = radiobtnlist1.SelectedItem != null ? radiobtnlist1.SelectedItem.Value : "";

                // Session["UserSelections"] = Session["UserSelections"] ?? new Dictionary<int, string>();
                // ((Dictionary<int, string>)Session["UserSelections"]).Add(CurrentQuestionIndex, selectedAnswer);

                //// Store user's selection for this question
                // userSelections[CurrentQuestionIndex] = selectedAnswer;

                List<string> userSelections = Session["UserSelections"] as List<string>;
                if (userSelections == null)
                {
                    userSelections = new List<string>();
                    Session["UserSelections"] = userSelections;
                }

                // Store user's selection for the current question in the list
                userSelections.Add(selectedAnswer);

                if (selectedAnswer == correctAnswer)
                {
                   // correctAnswers++;
                    Session["CorrectAnswers"] = (int)(Session["CorrectAnswers"] ?? 0) + 1;
                }
                else
                {
                  //  incorrectAnswers++;
                    Session["IncorrectAnswers"] = (int)(Session["IncorrectAnswers"] ?? 0) + 1;
                }
            }
        }

        protected void btnnext_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            CurrentQuestionIndex++;
            DisplayQuestion();
            if (CurrentQuestionIndex >= questionsTable.Rows.Count)
            {
                // Store correct and incorrect answers in session for result page
                //Session["CorrectAnswers"] = correctAnswers;
                //Session["IncorrectAnswers"] = incorrectAnswers;

                // Store user selections in session for result page
               // Session["UserSelections"] = userSelections;

                Response.Redirect("Result.aspx");
            }
            
               
            
            
        }
    }
}