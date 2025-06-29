<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Lab_1_Group_A.Glasaj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="62px" ImageUrl="~/Images/Лого-ФИНКИ.jpg" Width="389px" />
            <br />
            <asp:Label ID="nameLabel" runat="server"></asp:Label>
            <br />
            <asp:ListBox ID="lbPredmeti" runat="server" OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Интернет Технологии</asp:ListItem>
                <asp:ListItem>Интернет</asp:ListItem>
                <asp:ListItem>Дигитална Електроника</asp:ListItem>
            </asp:ListBox>
            <asp:ListBox ID="lbKrediti" runat="server" OnSelectedIndexChanged="lbKrediti_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>5.5</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="voteBtn" runat="server" OnClick="voteBtn_Click" Text="Гласајте" />
            <br />
        </div>
    </form>
</body>
</html>
