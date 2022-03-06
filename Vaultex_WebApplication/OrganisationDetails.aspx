<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrganisationDetails.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Vaultex_WebApplication.OrganisationDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

            <table>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2" style="width:fit-content">
                        <asp:GridView ID="GridOrganisation" runat="server" BorderColor="White" BorderStyle="Solid" BorderWidth="3px" Caption="Organisation Details" CellPadding="4" ForeColor="#333333" OnPageIndexChanging="GridOrganisation_PageIndexChanging" AllowCustomPaging="True" AllowSorting="True">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                    
                </tr>            
            </table>
            
       
    </asp:Content>
