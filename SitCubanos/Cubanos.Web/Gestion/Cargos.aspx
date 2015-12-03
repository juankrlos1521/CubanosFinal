<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="Cargos.aspx.cs" Inherits="Cubanos.Web.Gestion.Cargos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-lg-12">
        <section class="panel">
            <header class="panel-heading">
                Lista de Cargos
            </header>
            <div class="panel-body">
                <!-- Caja de busqueda  -->
                <div class="row">
                    <div class="col-lg-4"></div>
                    <div class="col-lg-4">
                        <div class="input-group">
                            <asp:TextBox runat="server" ID="txtCriterio" CssClass="form-control" placeholder="nombre" />
                            <span class="input-group-btn">
                            <asp:Button runat="server" ID="btnBuscar" Text="Buscar" CssClass="btn btn-default" />
                            </span>
                        </div>
                    </div>
                    <div class="col-lg-4"></div>
                </div>
                
                <!-- fin busqueda-->
                <br />
                
                <!--tabla-->
                <div class="row">
                    <div class="col-lg-4"></div>
                    <asp:ListView runat="server" ID="lvCargos" SelectMethod="GetCargos" ItemType="Cubanos.BusinessEntity.Cargo">
                    
                        <LayoutTemplate>
                            <table class="table-responsive col-lg-4">
                                <thead>
                                    <tr>                                    
                                        <th>Nombre</th>
                                        <th>Descripción</th>
                                        <th>Aciones</th>
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
                                <td><%# Item.Descripcion %></td>
                                <td>
                                    <div class="btn-group">
                                        <a href="frmCargo.aspx?acc=editar&id=<%# Item.Id %>" class="btn btn-primary"><i class="icon_pencil-edit_alt"></i></a>
                                        <a href="frmCargo.aspx?acc=eliminar&id=<%# Item.Id %>" class="btn btn-danger"><i class="icon_close_alt2" onclick="return confirm('Seguro que desea eliminar este cargo')"></i></a>
                                    </div>                                    
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                    <div class="col-lg-4"></div>
                </div>                
                <!--fin tabla-->

                <div class="row">
                    <div class="col-sm-4"></div>
                    <a href="frmCargo.aspx" class="btn btn-default col-sm-1"><i class="icon_plus_alt2"></i> Nuevo</a>
                    <div class="col-sm-7"></div>
                </div>
            </div>
        </section>
    </div>   
   
</asp:Content>
