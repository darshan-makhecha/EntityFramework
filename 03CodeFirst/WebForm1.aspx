<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_03CodeFirst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None">
               <AlternatingRowStyle BackColor="White" />
               <Columns>
                   <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                   <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                   <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                   <asp:TemplateField HeaderText="Employees">
                       <ItemTemplate>
                           <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSource='<%# Eval("Employees") %>'>
                               <Columns>
                                   <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                                   <asp:BoundField DataField="LastName" HeaderText="LastName" />
                                   <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                   <asp:BoundField DataField="Salary" HeaderText="Salary" />
                                    <asp:BoundField DataField="JobTitle" HeaderText="JobTitle" />
                                    
                               </Columns>
                           </asp:GridView>
                       </ItemTemplate>
                   </asp:TemplateField>
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
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetDepartments" TypeName="_03CodeFirst.EmployeeRepositary"></asp:ObjectDataSource>
     
    </form>
</body>
</html>
