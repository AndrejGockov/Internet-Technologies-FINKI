<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="First_Midterm_Exam.Najava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="nameValidator" runat="server" ControlToValidate="nameBox" ErrorMessage="Името е задолжително." ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="passwordBox" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="nameValidator0" runat="server" ControlToValidate="passwordBox" ErrorMessage="Лозинката е задолжителна." ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="emailBox" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="emailBox" ErrorMessage="Емаилот е задолжителен" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailBox" ErrorMessage="Невалиден формат" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            Најави се на факултет по:<br />
            <asp:Button ID="mathBtn" runat="server" OnClick="mathBtn_Click" Text="Математика" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="physicsBtn" runat="server" OnClick="physicsBtn_Click" Text="Физика" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="informaticsBtn" runat="server" OnClick="informaticsBtn_Click" Text="Информатика" />
        </div>
    </form>
</body>
</html>
