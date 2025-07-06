<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Popolni.aspx.cs" Inherits="First_Midterm_Exam.Popolni" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="collegeLogo" runat="server" Height="96px" Width="275px" />
            <br />
            <br />
            <asp:Label ID="college" runat="server"></asp:Label>
            <br />
            <br />
            <asp:ListBox ID="subjects" runat="server" OnSelectedIndexChanged="subjects_SelectedIndexChanged"></asp:ListBox>
            <asp:ListBox ID="grades" runat="server"></asp:ListBox>
            <br />
            <br />
            <asp:TextBox ID="grade" runat="server" TextMode="Number" Width="143px"></asp:TextBox>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="grade" ForeColor="Red" MaximumValue="10" MinimumValue="6" Type="Integer">Оценката мора да биде измеѓу 6-10</asp:RangeValidator>
            <br />
            <br />
            <asp:Button ID="addBtn" runat="server" OnClick="addBtn_Click" Text="Додади" Width="149px" />
            <br />
            <asp:Button ID="calculateAvg" runat="server" OnClick="calculateAvg_Click" Text="Пресметај Просек" Width="148px" />
        </div>
    </form>
</body>
</html>
