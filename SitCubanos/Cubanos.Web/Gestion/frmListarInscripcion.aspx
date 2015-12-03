<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="frmListarInscripcion.aspx.cs" Inherits="Cubanos.Web.Gestion.frmListarInscripcion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
     <br/>
    <h1 style="font-family: 'Montserrat', sans-serif;">
        Lista de Cliente
    </h1>
    <hr/>

    <div class="row">
        <div class="col-md-10 navbar-form navbar-input-group">
            <b>Curso:</b>&nbsp;<asp:Label ID="lblCurso" runat="server" Text=""></asp:Label>
            <%--<asp:TextBox runat="server" ID="cursoxId" class="form-control" placeholder="Buscar cliente"/>
            &nbsp;<asp:Button runat="server" ID="btnBuscar" Text="Buscar" class="btn btn-primary"/>--%> 
        </div>
       <%-- <div class="col-md-2 navbar-form navbar-right">--%>
            <%--FrmHabitacion.aspx es a donde se linkea--%>
            <%--<button type="button" class="btn btn-primary" aria-label="Left Align" onclick="location.href='frmRegistrarCliente.aspx'">
                <strong>Registrar Cliente</strong>
            </button>
        </div>
    </div>--%>

<br/>
    <div style="padding-left:50px; padding-right:50px">
        <asp:ListView runat="server" 
            ID="lvInscripcion"
            DataKeyNames="Id"
            ItemType="Cubanos.BusinessEntity.Inscripcion"    
            OnItemCommand="lvDetalleInscripcion_ItemCommand"
            SelectMethod="Listarinscripcion">

            <LayoutTemplate>
                <table class="table table-striped table-condensed table-hover">
                    <thead>            
                        <tr>       
                            <th>Id</th>                                            
                            <th>Nombre Completo</th>                                      
                            <th>Asistencia</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr id="itemPlaceholder" runat="server"/>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                    <tr>
                        <td><%# Item.Id %> </td>                             
                        <td><%# Item.Cliente.ApellidoPaterno %> <%# Item.Cliente.ApellidoMaterno %>, <%# Item.Cliente.Nombres %> </td>               
                        <td>
                            <asp:Button runat="server" Text="Hola" ID="btnHola" 
                                CommandName="hola"
                                CommandArgument='<%# Eval("Id")%>'/>
                        </td>
                                
                    </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>        
</div>
</asp:Content>
