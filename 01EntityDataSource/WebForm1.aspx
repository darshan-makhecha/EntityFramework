<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_01EntityDataSource.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="ID" DataSourceID="EntityDataSource1" >
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:TemplateField HeaderText="Employees">
                    <ItemTemplate>
                          
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSource='<%# Eval("Employees") %>' >
                    <Columns>
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="Salary" HeaderText="Salary" />
                    </Columns>
                </asp:GridView>
          
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
          
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=EmployeeModelContainer" DefaultContainerName="EmployeeModelContainer" EnableFlattening="False" EntitySetName="Departments" Include="Employees"></asp:EntityDataSource>
    </form>
</body>
</html>
