<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartTest.aspx.cs" Inherits="WebApplication1.StartTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;<br />
    
    </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Height="251px" ImageUrl="~/Images/6144618366.jpg" Width="406px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Testeaza-ti nivelul actual de cunostinte. Prin raspunsuri rapide si precise<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; testul poate fi folosit cu succes pentru pregatirea in vederea sustinerii<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; examenului de licenta.
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BorderStyle="Groove" Height="37px" OnClick="Button1_Click" Text="Start" Width="145px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    </form>
</body>
</html>
