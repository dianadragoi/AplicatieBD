﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebProfesor.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 279px;
        }
        #Button1 {
            width: 87px;
        }
    </style>
</head>
<body style="height: 299px">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 40px">
            <asp:Label ID="Label1" runat="server" Text="Intrebare:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="margin-left: 40px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="18px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:Label ID="Label3" runat="server" Text="Materie:"></asp:Label>
&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Retele</asp:ListItem>
                <asp:ListItem>Sisteme de operare</asp:ListItem>
                <asp:ListItem>Programare orientata pe obiecte</asp:ListItem>
                <asp:ListItem>Arhitectura sistemelor de calcul</asp:ListItem>
                <asp:ListItem>Administrarea si dezvoltarea aplicatiilor cu baze de date</asp:ListItem>
                <asp:ListItem>Structuri de date si Algoritmi</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="margin-left: 40px">
&nbsp;<asp:Label ID="Label2" runat="server" Text="Raspunsuri:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="margin-left: 40px">
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="margin-left: 40px">
            <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:CheckBox ID="CheckBox3" runat="server" />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:CheckBox ID="CheckBox4" runat="server" />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="27px" OnClick="Button2_Click" Text="Adaugare intrebare" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="StartQuiz" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp; &nbsp;
        </p>
    </form>
</body>
</html>

