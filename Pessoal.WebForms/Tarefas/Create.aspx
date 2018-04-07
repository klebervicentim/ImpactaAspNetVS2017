<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Tarefas_Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Nova tarefa</h1>
    <hr />

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="text-danger" />

    <table style="width: 100%;">
        <tr>
            <td style="height: 24px">Nome:</td>
            <td style="height: 24px"><asp:TextBox ID="nomeTextBox" runat="server" Width="243px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nomeTextBox" CssClass="text-danger" ErrorMessage="O nome é obrigatório" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Prioridade:</td>
            <td>
                <asp:DropDownList ID="prioridadeDropDownList" runat="server" AppendDataBoundItems="true" DataSourceID="ObjectDataSource1" Width="245px">
                <asp:ListItem Text="Selecione uma prioridade"></asp:ListItem>
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ObterPrioridades" TypeName="Pessoal.WebForms.Helper"></asp:ObjectDataSource>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="prioridadeDropDownList" CssClass="text-danger" ErrorMessage="A prioridade é obrigatória" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Concluída?</td>
            <td>
                <asp:CheckBox ID="concluidaCheckBox" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Observação:</td>
            <td><asp:TextBox ID="observacaoTextBox" runat="server" Rows="5" TextMode="MultiLine" Width="242px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="gravarButton" runat="server" Text="GRAVAR" Width="95px" OnClick="gravarButton_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

