<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="frmRegistrarCliente.aspx.cs" Inherits="Cubanos.Web.Clientes.frmRegistrarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <asp:FormView ID="fvCliente" runat="server"
        ItemType="Cubanos.BusinessEntity.Cliente"
        InsertMethod="InsertarCliente"     
        UpdateMethod="Actualizar"
        SelectMethod="GetCliente"
        DefaultMode="Insert">        
        
        <InsertItemTemplate>
            <!--<asp:ScriptManager runat="server"></asp:ScriptManager>-->
           
            <ContentTemplate>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server"></asp:ValidationSummary>
                <fieldset>
                    <legend>Registrar Cliente</legend>
                    <!-- table>tr*7>td*2 -->
                    <table>
                        <tr>
                            <td><b>Dni:</b></td>
                            <td>
                                <asp:TextBox runat="server" ID="TextDni" CssClass="form-control" Text="<%# BindItem.Dni  %>"/>
                            </td>
                        </tr>
                        <tr>
                            <td><b>Nombre:</b></td>
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
                            <td><b>Direccion: </b></td>
                            <td>
                                <asp:TextBox runat="server" ID="TxtDireccion"  CssClass="form-control"  Text="<%# BindItem.Direccion  %>"/>
                            </td>
                        </tr>

                            <tr>
                            <td><b>Sexo:</b></td>
                            <td>                                    
                                <asp:RadioButton GroupName="GrupoGenero" runat="server" ID="RaBtnMasculino" Checked="<%# BindItem.Sexo %>" Text="Masculino"/>
                                <asp:RadioButton GroupName="GrupoGenero" runat="server" ID="RaBtnFemenino" Text="Femenino"/>   
                                   
                            </td>
                        </tr>                                   
                            
                            <%--<tr>
                            <td><b>Fecha De Registro </b></td>
                            <td>
                                <asp:TextBox runat="server" ID="TxtFechaRegistro" CssClass="form-control" ReadOnly="true" Type="Text" Text="<%# BindItem.FechaRegistro  %>"/>
                            </td>
                        </tr>--%>
                                                                                                      
                        <tr>
                            <td><b>Estado:</b></td>
                            <td>
                                <%-- <asp:CheckBox runat="server" ID="chkActivo"  Checked="<%# BindItem.Estado %>"/>--%>
                                    <asp:RadioButton GroupName="GrupoActivo" runat="server" ID="RaBtnActivo" Checked="<%# BindItem.Estado %>" Text="Activo"/>
                                <asp:RadioButton GroupName="GrupoActivo" runat="server" ID="RaBtnInactivo" Text="Inactivo"/>  
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
          
            
        </InsertItemTemplate>

        <EditItemTemplate>           
            <ContentTemplate>
                <fieldset>
                        <legend>Registrar Cliente</legend>
                        <!-- table>tr*7>td*2 -->
                        <table>
                            <asp:HiddenField ID="hfId" runat="server" Value="<%# BindItem.Id %>" />
                            <tr>
                                <td><b>Dni:</b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TextDni" CssClass="form-control" Text="<%# BindItem.Dni %>"/>
                                </td>
                            </tr>
                            <tr>
                                <td><b>Nombre:</b></td>
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
                                <td><b>Direccion: </b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TxtDireccion"  CssClass="form-control"  Text="<%# BindItem.Direccion  %>"/>
                                </td>
                            </tr>

                             <tr>
                                <td><b>Sexo:</b></td>
                                <td>                                    
                                    <asp:RadioButton GroupName="GrupoGenero" runat="server" ID="RaBtnMasculino" Checked="<%# BindItem.Sexo %>" Text="Masculino"/>
                                    <asp:RadioButton GroupName="GrupoGenero" runat="server" ID="RaBtnFemenino" Text="Femenino"/>   
                                   
                                </td>
                            </tr>                                   
                            
                             <%--<tr>
                                <td><b>Fecha De Registro </b></td>
                                <td>
                                    <asp:TextBox runat="server" ID="TxtFechaRegistro" CssClass="form-control" ReadOnly="true" Type="Text" Text="<%# BindItem.FechaRegistro  %>"/>
                                </td>
                            </tr>--%>
                                                                                                      
                            <tr>
                                <td><b>Estado:</b></td>
                                <td>
                                   <%-- <asp:CheckBox runat="server" ID="chkActivo"  Checked="<%# BindItem.Estado %>"/>--%>
                                     <asp:RadioButton GroupName="GrupoActivo" runat="server" ID="RaBtnActivo" Checked="<%# BindItem.Estado %>" Text="Activo"/>
                                    <asp:RadioButton GroupName="GrupoActivo" runat="server" ID="RaBtnInactivo" Text="Inactivo"/>  
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CommandName="update"/>
                                </td>
                                <td>
                                    <a href="frmListarCliente.aspx">Cancelar</a>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
            </ContentTemplate>
          
        </EditItemTemplate>

        
    </asp:FormView> 
   
</asp:Content>
