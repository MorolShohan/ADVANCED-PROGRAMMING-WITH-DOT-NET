<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebAppForm.MyPages.LoginForm" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <div>
                <header>
                    <h1>Login Page</h1>
                </header>
            </div>
        </div>

        <div>
            <asp:Label ID="Label1" runat="server" Text="User ID" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <br/>
            <asp:TextBox ID="txtID" runat="server" Font-Size="Medium" placeHolder="Enter an user Id"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <br/>
            <asp:TextBox ID="txtPassword" runat="server" Font-Size="Medium" placeHolder="Enter a password"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
            
        </div>
    <section />
</asp:Content>
