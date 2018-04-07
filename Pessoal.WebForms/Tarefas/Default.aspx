<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Tarefas_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
   
    <h1>Tarefas:</h1>
    <hr />
    <asp:LinkButton Text="+ NOVA" runat="server" PostBackUrl="Create" />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Width="100%">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Prioridade" HeaderText="Prioridade" SortExpression="Prioridade" />
            <asp:CheckBoxField DataField="Concluida" HeaderText="Concluida" SortExpression="Concluida" />
            <asp:BoundField DataField="Obervacao" HeaderText="Obervacao" SortExpression="Obervacao" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>

<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Selecionar" TypeName="Pessoal.Repositorios.SqlServer.TarefaRepositorio"></asp:ObjectDataSource>

</asp:Content>

