<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="Cubanos.Web.Gestion.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
    <div class="col-lg-12">
        <!--breadcrumbs start -->
        <ul class="breadcrumb">
            <li><a href="#"><i class="icon_house_alt"></i> Inicio</a></li>
            <li><a href="#"> Gestión</a></li>
            <li class="active"> Cargo</li>
        </ul>
        <!--breadcrumbs end -->
    </div>
    <!--contenido-->
    <div class="col-lg-12">
        <section class="panel">
            <header class="panel-heading">
                Curso
            </header>
            <div class="panel-body">
                <!-- inicio buscar-->
                <div class="row">
                    <div class="col-lg-4">
                        <div class="input-group">
                            <asp:TextBox runat="server" ID="txtCriterio" CssClass="form-control" placeholder="nombre" />
                            <span class="input-group-btn">
                            <asp:Button runat="server" ID="btnBuscar" Text="Buscar" CssClass="btn btn-default" />
                            </span>
                        </div>
                    </div>
                </div>
                <!-- fin buscar-->
                <!--tabla-->
                <br />
                <div class="row col-lg-12">
                    <div class="col-4"></div>
                    <asp:ListView runat="server" ID="lvCursos" 
                        SelectMethod="GetCursos"
                        ItemType="Cubanos.BusinessEntity.Curso">
                        <LayoutTemplate>
                            <table class="table-responsive col-lg-8">
                                <thead>
                                    <tr>
                                        <td>Nombre</td>
                                        <td>Fecha Inicio</td>
                                        <td>Fecha Fin</td>
                                        <td>Precio</td>
                                        
                                        <td>Acciones</td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr runat="server" id="itemPlaceholder" />
                                </tbody>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Item.Nombre %></td>
                                <td><%# Item.FechaInicio!=null ? Item.FechaInicio.ToShortDateString() : "Sin limite" %></td>
                                <td><%# Item.FechaFin!=null ? Item.FechaFin.ToShortDateString() : "Sin limite" %></td>
                                <td><%# Item.Precio %></td>
                                <td>
                                    
                                    <a href="frmListarInscripcion.aspx?listClientes=<%# Item.Id %>&name=<%# Item.Nombre %>"class="btn btn-warning" > <span class="glyphicon glyphicon-list" aria-hidden="true"></span></a>
                                    <a href="frmCurso.aspx?acc=editar&id=<%# Item.Id %>" class="btn btn-primary"><i class="icon_pencil-edit_alt"></i></a>
                                    <a href="frmCurso.aspx?acc=eliminar&id=<%# Item.Id %>" class="btn btn-danger"><i class="icon_close_alt2"></i></a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <!--fin tabla-->
                <div class="row col-lg-12">
                    <a href="frmCurso.aspx" class="btn btn-default col-sm-1"><i class="icon_plus_alt2"></i> Nuevo</a>
                </div>
            </div>
        </section>
    </div>
    <!-- fin de contenido -->
</div>
</asp:Content>
