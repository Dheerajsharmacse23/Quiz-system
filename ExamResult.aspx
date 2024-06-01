<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExamResult.aspx.cs" Inherits="QuizSystem.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
      <div class="container mt-5">
            <h1>Quiz Result</h1>
            <div class="row">
                <asp:Panel ID="resultPanel" runat="server" CssClass="col-md-6"></asp:Panel>
            </div>
            <div class="row mt-3">
                <div class="col-md-6">
                    <p><strong>Correct Answers:</strong> <asp:Label ID="lblCorrectAnswers" runat="server" Text=""></asp:Label></p>
                    <p><strong>Incorrect Answers:</strong> <asp:Label ID="lblIncorrectAnswers" runat="server" Text=""></asp:Label></p>
                    <p><strong>Total Questions Attempted:</strong> <asp:Label ID="lblTotalQuestions" runat="server" Text=""></asp:Label></p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
