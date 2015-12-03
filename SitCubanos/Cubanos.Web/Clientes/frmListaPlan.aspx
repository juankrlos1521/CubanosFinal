<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="frmListaPlan.aspx.cs" Inherits="Cubanos.Web.Clientes.frmListaPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br/>
    <h1 style="font-family: 'Montserrat', sans-serif;">
        Lista de Planes
    </h1>
    <hr/>

    <div class="row">      
                     
        <div class="col-md-4 navbar-form navbar-input-group">            
            <b>Fecha Inicio:</b>
            <asp:TextBox runat="server" ID="txtFechaInicio" Type="date" class="form-control" placeholder="Buscar Paquete"/>
        </div>
        <div class="col-md-4 navbar-form navbar-input-group"> 
            <b>Fecha Fin:</b>
            <asp:TextBox runat="server" ID="txtFechaFin" Type="date" class="form-control" placeholder="Buscar Paquete"/>
         </div>
        <div class="col-md-2 navbar-form navbar-input-group"> 
            &nbsp;<asp:Button runat="server" ID="btnBuscar" Text="Buscar" class="btn btn-primary"/> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        
        

        <div class="col-md-2 navbar-form navbar-input-group"> 
            <%--FrmHabitacion.aspx es a donde se linkea--%>
            <button type="button" class="btn btn-primary" aria-label="Left Align" onclick="location.href='frmCrearPersona.aspx'">
                <strong>Registrar Nuevo Plan</strong>
            </button>
        </div>
        
    
        
    
<br/>
    <%--<div> <asp:Label runat="server" ID="lbNombre" AssociatedControlID="" ></asp:Label> </div>--%>
<asp:ListView runat="server"
    ID="lvPlan"
    DataKeyNames="Id"
    ItemType="Cubanos.BusinessEntity.Plan"
    SelectMethod="ListarPlan">

    <LayoutTemplate>
        
        <table class="table table-striped table-condensed table-hover">
            <thead>            
                <tr>                   
                    <th>Nombre cliente</th>                    
                    <th>Fecha Inicio</th>
                    <th>Fecha Fin</th>
                    <th>Detalle de rutina</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                <tr id="itemPlaceholder" runat="server"/>
            </tbody>
        </table>
    </LayoutTemplate>
    <ItemTemplate>
            <tr>
                <td><%# Item.Cliente.ApellidoPaterno %> <%# Item.Cliente.ApellidoMaterno %> <%# Item.Cliente.Nombres%></td>
                <td><%# Item.FechaInicio %> </td>
                <td><%# Item.FechaFin %></td>
                <td>Detalle</td>                
                          
                
                <td>
                    <a href="frmCrearPersona.aspx?acc=editar&id=<%# Item.Id %>">Editar</a>
                    <a href="frmCrearPersona.aspx?acc=eliminar&id=<%# Item.Id %>"
                            onclick="return confirm('Desea Eliminar la Habitación Nro: ' + <%# Item.Id %>)">
                            Eliminar
                        </a>
                      
                </td>
            </tr>
        
    </ItemTemplate>
</asp:ListView>

</asp:Content>
