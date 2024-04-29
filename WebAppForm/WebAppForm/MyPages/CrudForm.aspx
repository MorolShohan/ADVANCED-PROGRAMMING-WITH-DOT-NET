<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrudForm.aspx.cs" Inherits="WebAppForm.MyPages.CrudForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <div>
                <header>
                    <h1>Welcome to ASP</h1>
                </header>
            </div>
        </div>

        <div>
            <asp:Label ID="Label1" runat="server" Text="User ID" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <br/>
            <asp:TextBox ID="txtID" runat="server" Font-Size="Medium" placeHolder="Enter an Id"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Label ID="Label2" runat="server" Text="User Name" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <br/>
            <asp:TextBox ID="txtName" runat="server" Font-Size="Medium" placeHolder="Enter a name"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Label ID="Label3" runat="server" Text="Password" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <br/>
            <asp:TextBox ID="txtPassword" runat="server" Font-Size="Medium" placeHolder="Enter password"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Label ID="Label4" runat="server" Text="User Role" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <br/>
            <asp:TextBox ID="txtRole" runat="server" Font-Size="Medium" placeHolder="Enter Role"></asp:TextBox>
        </div>
        <br />
        
        <div>
            <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click"/>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
        
        </div>
        <br />

        <div>
            <asp:TextBox ID="txtSearch" runat="server" Font-Size="Medium" placeHolder="Enter name"></asp:TextBox>
            
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"/>
            <br />
            <br />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
        </div>
        <br />

        <div>
            <asp:GridView ID="grid" runat="server" Width="700px" AutoGenerateSelectButton ="True">
                <HeaderStyle BackColor="#999999" />
                <SelectedRowStyle BackColor="#669999" />
            </asp:GridView>
        </div>
        <br />

    </section>

</asp:Content>
