<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BeginTest.aspx.cs" Inherits="QuizSystem.BeginTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container col-md-6 mt-5 p-5">
              
                <div class="card">
                    <asp:Label runat="server" ID="lblerrormsg" Text="" CssClass="text-danger"></asp:Label>
                    <div class="card-header">
                        <h3 class="card-title">Login To Start Your Exam</h3>
                    </div>
                    <div class="card-body">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label>Email</label>
                                <asp:TextBox runat="server" ID="txtemail" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="card-footer">
                        <asp:Button runat="server" Text="Start Your Exam"  ID="btnsubmit" CssClass="btn btn-primary" OnClick="btnsubmit_Click"/>
                    </div>
                </div>
        </div>
    </form>
</body>
</html>
