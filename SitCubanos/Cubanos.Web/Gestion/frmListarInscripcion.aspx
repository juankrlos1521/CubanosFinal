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

<asp:ListView runat="server" 
    ID="lvInscripcion"
    DataKeyNames="Id"
    ItemType="Cubanos.BusinessEntity.Inscripcion"    
    SelectMethod="Listarinscripcion">

    <LayoutTemplate>
        <table class="table table-striped table-condensed table-hover">
            <thead>            
                <tr>                    
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
                
                <td><%# Item.Cliente.ApellidoPaterno %> <%# Item.Cliente.ApellidoMaterno %>, <%# Item.Cliente.Nombres %> </td>               
                <td>
                    <%--<asp:CheckBox ID="chbAsistencia" runat="server" AutoPostBack="true" OnCheckedChanged="asignarAsistencia_Check" />--%>
                    <a href="frmRegistrarCliente.aspx?acc=eliminar&id=<%# Item.Id %>"
                            onclick="return confirm('Desea eliminar a <%# Item.ApellidoPaterno %> <%# Item.ApellidoMaterno %>, <%# Item.Nombres %>')">
                            Eliminar
                        </a>
                </td>
                                
            </tr>
    </ItemTemplate>
</asp:ListView>
        
     </div>
</asp:Content>
