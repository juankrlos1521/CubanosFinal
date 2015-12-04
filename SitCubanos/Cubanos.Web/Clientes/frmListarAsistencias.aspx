<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="frmListarAsistencias.aspx.cs" Inherits="Cubanos.Web.Clientes.frmListarAsistencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <br/>
    <h1 style="font-family: 'Montserrat', sans-serif;">
        Lista de Asistencias
    </h1>
    <hr/>

    <div class="row">
        <b>Cliente:</b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblCliente" runat="server" Text=""></asp:Label>
        <%--<div class="col-md-10 navbar-form navbar-input-group">
            <b>Criterio:</b>&nbsp;
            <asp:TextBox runat="server" ID="txtCriterio" class="form-control" placeholder="Buscar cliente"/>
            &nbsp;<asp:Button runat="server" ID="btnBuscar" Text="Buscar" class="btn btn-primary"/> 
        </div>
        <div class="col-md-2 navbar-form navbar-right">
         
            <button type="button" class="btn btn-primary" aria-label="Left Align" onclick="location.href='frmRegistrarCliente.aspx'">
                <strong>Registrar Cliente</strong>
            </button>
        </div>--%>
    </div>

<br/>

<asp:ListView runat="server"
    ID="lvAsistencia"
    DataKeyNames="Id"
    ItemType="Cubanos.BusinessEntity.Asistencia"
    SelectMethod="ListarAsistencia">

    <LayoutTemplate>
        <table class="table table-striped table-condensed table-hover">
            <thead>            
                <tr>
                    <%--<th>Curso</th>--%>
                    <th>Fecha</th>
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
                <%--<td><%# Item.Inscripcion.Curso.Nombre %></td>--%>
                <td><%# Item.Fecha %></td>
                <td><%# (Item.Estado == true) ?"<div class='text-success'><b>Asistio</b></div>" : "<div class='text-danger'><b>Ausente</b></div>" %></td>               
                
                
            </tr>
    </ItemTemplate>
</asp:ListView>

</asp:Content>
