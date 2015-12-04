<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="frmListarPago.aspx.cs" Inherits="Cubanos.Web.Gestion.frmListarPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
     <br/>
    <h1 style="font-family: 'Montserrat', sans-serif;">
        Lista de Pagos
    </h1>
    <hr/>

    <div class="row">
        <div class="col-md-10 navbar-form navbar-input-group">
            <b>Criterio:</b>&nbsp;
            <asp:TextBox runat="server" ID="txtCriterio" class="form-control" placeholder="Buscar pago"/>
            &nbsp;<asp:Button runat="server" ID="btnBuscar" Text="Buscar" class="btn btn-primary"/> 
        </div>
        <div class="col-md-2 navbar-form navbar-right">
            <%--FrmHabitacion.aspx es a donde se linkea--%>
<%--            <button type="button" class="btn btn-primary" aria-label="Left Align" onclick="location.href='frmRegistrarCliente.aspx'">
                <strong>Registrar Cliente</strong>
            </button>--%>
        </div>
    </div>

<br/>

<asp:ListView runat="server"
    ID="lvPago"
    DataKeyNames="Id"
    ItemType="Cubanos.BusinessEntity.Pago"
    SelectMethod="ListarPagox">

    <LayoutTemplate>
        <table class="table table-striped table-condensed table-hover">
            <thead>            
                <tr>
                    <th>Cliente</th>
                    <th>Nro Cuota</th>
                    <th>Monto</th>
                    <th>Fecha Pago</th>
                    <th>Fecha Vencimiento</th>
                    <th>Estado</th>
                </tr>
            </thead>
            <tbody>
                <tr id="itemPlaceholder" runat="server"/>
            </tbody>
        </table>
    </LayoutTemplate>
    <ItemTemplate>
            <tr>
                <td><%# Item.Inscripcion.Cliente.Nombres %> <%# Item.Inscripcion.Cliente.ApellidoPaterno %> <%# Item.Inscripcion.Cliente.ApellidoMaterno %></td>
                <td><%# Item.NroCuota %></td>
                <td>S/. <%# Item.Monto %></td>
                <td><%# (Item.FechaPago.ToShortDateString() ==  "1/01/1754") ? "-" : (Item.FechaPago.ToShortDateString()) %></td>
                <td><%# Item.FechaVencimiento.ToShortDateString() %></td>
                <td><%# (Item.EstadoCuota == true) ?  "<div class='text-success'><b>Pagado</b></div>" :  "<div class='text-danger'><b>Adeudado</b></div>" %></td>
                <td>
<%--                    
                    <a href="frmRegistrarCliente.aspx?acc=editar&id=<%# Item.Id %>">Editar</a>
                    <a href="frmRegistrarCliente.aspx?acc=eliminar&id=<%# Item.Id %>"
                            onclick="return confirm('Desea eliminar a <%# Item.ApellidoPaterno %> <%# Item.ApellidoMaterno %>, <%# Item.Nombres %>')">
                            Eliminar
                        </a>--%>
                </td>
                
            </tr>
    </ItemTemplate>
</asp:ListView>

</asp:Content>
