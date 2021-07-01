<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tactical_Gautlet._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Final Fantasy Tactics Ps1</asp:ListItem>
            <asp:ListItem>Final Fantasy Tactics PSP</asp:ListItem>
            <asp:ListItem>Tactics Ogre PSP</asp:ListItem>
            <asp:ListItem>Tactics Ogre Ps1/SNES</asp:ListItem>
            <asp:ListItem>Tactics Ogre: Knights of Lodis</asp:ListItem>
            <asp:ListItem>Fell Seal</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="116px" Width="218px" Enabled="False" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Randomize" OnClick="Button1_Click" />
    </div>

    <div class="row">
    </div>

</asp:Content>
