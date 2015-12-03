<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="frmRegistrarEmpleado.aspx.cs" Inherits="Cubanos.Web.Clientes.frmRegistrarEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
   <asp:FormView ID="fvEmpleado" runat="server"
        ItemType="Cubanos.BusinessEntity.Empleado"
        InsertMethod="InsertarEmpleado"        
        DefaultMode="Insert">
        
        <InsertItemTemplate>
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="upAgregar" runat="server">
                <ContentTemplate>

                    <asp:ValidationSummary ID="ValidationSummary1" runat="server"></asp:ValidationSummary>

                    <fieldset>
                        <legend>Registrar Empleado</legend>
                        <!-- table>tr*7>td*2 -->
                        <table>
                            <tr>
                                <td><b>Dni:</b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TextDni" CssClass="form-control" Text="<%# BindItem.Dni  %>"/>
                                </td>
                            </tr>
                            <tr>
                                <td><b>Nombres:</b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" Text="<%# BindItem.Nombres %>"/>
                                </td>
                            </tr>
                            <tr>
                                <td><b>Apellido Paterno:</b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TxtAppPaterno"  CssClass="form-control" Text="<%# BindItem.ApellidoPaterno  %>"/>
                                </td>
                            </tr>
                            <tr>
                                <td><b>Apellido Materno</b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TxtAppMaterno" CssClass="form-control" Text="<%# BindItem.ApellidoMaterno %>"/>
                                </td>
                            </tr>
                            <tr>
                                <td><b>Fecha De Nacimiento </b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TxtFechaNacimiento" CssClass="form-control" type="date" Text="<%# BindItem.FechaNacimiento  %>"/>
                                </td>
                            </tr>
                            <tr>
                                <td><b>Direccion: </b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TxtDireccion"  CssClass="form-control"  Text="<%# BindItem.Direccion  %>"/>
                                </td>
                            </tr>
                            <tr>
                                <td><b>Telefono: </b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TxtTelefono" CssClass="form-control" type="Number" Text="<%# BindItem.Telefono  %>"/>
                                </td>
                            </tr>                            
                            <tr>
                                <td><b>Email: </b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtEmail"  CssClass="form-control"  Text="<%# BindItem.Email  %>"/>
                                </td>
                            </tr>                                                                              
                            <tr>
                                <td><b>Sexo:</b></td>
                                <td>                                    
                                    <asp:RadioButton GroupName="GrupoGenero" runat="server" ID="RaBtnMasculino" Checked="<%# BindItem.Sexo %>" Text="Masculino"/>
                                    <asp:RadioButton GroupName="GrupoGenero" runat="server" ID="RaBtnFemenino" Text="Femenino" />   
                                   
                                </td>                                
                            </tr>                                                                                                                                                                             
                            <tr>
                                <td><b>Estado:</b></td>
                                <td>
                                   <%-- <asp:CheckBox runat="server" ID="chkActivo"  Checked="<%# BindItem.Estado %>"/>--%>
                                     <asp:RadioButton GroupName="GrupoActivo" runat="server" ID="RaBtnActivo" Checked="<%# BindItem.Estado %>" Text="Activo"/>
                                    <asp:RadioButton GroupName="GrupoActivo" runat="server" ID="RaBtnInactivo" Text="Inactivo"/>  
                                </td>
                            </tr>
                                                       
                            <tr>
                                <td><b>Fecha De Ingreso: </b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtFechaIngreso" CssClass="form-control"  Type="Date" Text="<%# BindItem.FechaIngreso  %>"/> <%--ReadOnly="true"     (sirve para bloquear el textbox)--%> 
                                </td>
                            </tr>
                            <tr>
                                <td><b>Cargo</b></td>
                                <td>
                                    <asp:DropDownList runat="server" ID="ddlCargo" 
                                        SelectMethod="TraerCargos" 
                                        ItemType="Cubanos.BusinessEntity.Cargo"
                                        DataTextField="Nombre"
                                        DataValueField="Id"
                                        SelectedValue ="<%# BindItem.CargoId %>"/>
                                </td>
                            </tr>
                            <tr>
                                <td><b>Salario:</b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TextBox1" CssClass="form-control" Type="number" Text="<%# BindItem.Salario  %>"/> 
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CommandName="insert"/>
                                </td>
                                <td>
                                    <a href="frmListarCliente.aspx">Cancelar</a>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </ContentTemplate>
               
            </asp:UpdatePanel>
        </InsertItemTemplate>
        
    </asp:FormView> 

</asp:Content>
