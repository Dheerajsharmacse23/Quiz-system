<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionsPage.aspx.cs" Inherits="QuizSystem.MCQ_Questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body style="overflow: auto">
    <form id="form1" runat="server">
        <div class="container col-md-6 mt-2 mb-2">
            <asp:Button runat="server" Text="" ID="btnemail" />
            <div class="card">
                <div class="card-header">

                    <asp:Label ID="lblQuestion" runat="server" Text=""></asp:Label>
                </div>
                <div class="card-body">
                    <asp:RadioButtonList runat="server" ID="radiobtnlist1" RepeatDirection="Vertical">
                    </asp:RadioButtonList>

                </div>
                <div class="card-footer">
                    <asp:Button runat="server" ID="btnnext" Text="Next" CssClass="btn btn-primary mt-2" OnClick="btnnext_Click" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>
