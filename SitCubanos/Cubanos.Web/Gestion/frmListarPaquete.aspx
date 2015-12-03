<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="frmListarPaquete.aspx.cs" Inherits="Cubanos.Web.Gestion.frmListarPaquete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <br/>
    <h1 style="font-family: 'Montserrat', sans-serif;">
        Lista de Paquete
    </h1>
    <hr/>

    <div class="row">
        
        <div class="col-md-2 navbar-form navbar-right">
            
            <div class="row">
        <div class="col-md-10 navbar-form navbar-input-group">
            <asp:TextBox runat="server" ID="txtCriterio" class="form-control" placeholder="Buscar Paquete"/>
            <b>Fecha Inicio:</b>
            <asp:TextBox runat="server" ID="txtFechaInicio" Type="date" class="form-control" placeholder="Buscar Paquete"/>
            <b>Fecha Fin:</b>
            <asp:TextBox runat="server" ID="txtFechaFin" Type="date" class="form-control" placeholder="Buscar Paquete"/>
            &nbsp;<asp:Button runat="server" ID="btnBuscar" Text="Buscar" class="btn btn-primary"/> 
        </div>

            <%--FrmHabitacion.aspx es a donde se linkea--%>
            <button type="button" class="btn btn-primary" aria-label="Left Align" onclick="location.href='frmCrearPersona.aspx'">
                <strong>Registrar Paquete</strong>
            </button>
        </div>
    </div>
        
    </div>
<br/>

<asp:ListView runat="server"
    ID="lvPaquete"
    DataKeyNames="Id"
    ItemType="Cubanos.BusinessEntity.Paquete"
    SelectMethod="ListarPaquete">

    <LayoutTemplate>
        <table class="table table-striped table-condensed table-hover">
            <thead>            
                <tr>                   
                    <th>Nombre</th>
                    <th>Precio</th>
                    <th>Fecha Inicio</th>
                    <th>Fecha Fin</th>
                    <th>Stock</th>
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
                <td><%# Item.Nombre %></td>
                <td><%# Item.Precio %> </td>
                <td><%# Item.FechaRegistro %></td>
                <td><%# Item.FechaVencimiento %></td>                
                <td><%# Item.Stock %></td>           
                
                <td>
                    <a href="frmCrearPersona.aspx?acc=editar&id=<%# Item.Id %>">Editar</a>
                    
                        </a>
                </td>
            </tr>
    </ItemTemplate>
</asp:ListView>

</asp:Content>
