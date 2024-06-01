<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MCQ-Questions.aspx.cs" Inherits="QuizSystem.MCQ_Questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body style="overflow:auto">
    <form id="form1" runat="server">
        <div class="container col-md-6 mt-2 mb-2">
              <asp:Button runat="server" Text="" ID="btnemail" />
            <div class="card">
                <div class="card-header">
                 <%--   <h6 class="card-title">1. What Is The Capital of India </h6>--%>
                    <asp:Label ID="lblQuestion" runat="server" Text=""></asp:Label>
                </div>
                <div class="card-body">
                    <asp:RadioButtonList runat="server" ID="radiobtnlist1" RepeatDirection="Vertical">
          
                    </asp:RadioButtonList>

                </div>
                <div class="card-footer">
                    <asp:Button runat="server" ID="btnnext" Text="Next" CssClass="btn btn-primary mt-2" OnClick="btnnext_Click"/>
                </div>
            </div>
        <%--    <div class="card mt-2">
                <div class="card-header">
                    <h6 class="card-title">2. What Is The Capital Of UP</h6>
                </div>
                <div class="card-body">
                    <asp:RadioButtonList runat="server" ID="radiobtnlist2" RepeatDirection="Vertical">
                        <asp:ListItem Text="A. Mumbai" Value="A"></asp:ListItem>
                        <asp:ListItem Text="B. Delhi" Value="B"></asp:ListItem>
                        <asp:ListItem Text="C. Lucknow" Value="C"></asp:ListItem>
                        <asp:ListItem Text="D. Haridwar" Value="D"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="card mt-2">
                <div class="card-header">
                    <h6 class="card-title">3. What Is The Maharastra</h6>
                </div>
                <div class="card-body">
                    <asp:RadioButtonList runat="server" ID="RadioButtonList3" RepeatDirection="Vertical">
                        <asp:ListItem Text="A. Mumbai" Value="A"></asp:ListItem>
                        <asp:ListItem Text="B. Delhi" Value="B"></asp:ListItem>
                        <asp:ListItem Text="C. Lucknow" Value="C"></asp:ListItem>
                        <asp:ListItem Text="D. Haridwar" Value="D"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="card mt-2">
                <div class="card-header">
                    <h6 class="card-title">4. What Is The Capital Of Uttrakhand</h6>
                </div>
                <div class="card-body">
                    <asp:RadioButtonList runat="server" ID="RadioButtonList4" RepeatDirection="Vertical">
                        <asp:ListItem Text="A. Mumbai" Value="A"></asp:ListItem>
                        <asp:ListItem Text="B. Delhi" Value="B"></asp:ListItem>
                        <asp:ListItem Text="C. Lucknow" Value="C"></asp:ListItem>
                        <asp:ListItem Text="D. Haridwar" Value="D"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
             <div class="card mt-2">
                <div class="card-header">
                    <h6 class="card-title">5. What Is The Formula OF Water</h6>
                </div>
                <div class="card-body">
                    <asp:RadioButtonList runat="server" ID="RadioButtonList5" RepeatDirection="Vertical">
                        <asp:ListItem Text="A. H2O" Value="A"></asp:ListItem>
                        <asp:ListItem Text="B. SO4" Value="B"></asp:ListItem>
                        <asp:ListItem Text="C. H2I" Value="C"></asp:ListItem>
                        <asp:ListItem Text="D. None" Value="D"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>--%>
        </div>
    </form>
</body>
</html>
