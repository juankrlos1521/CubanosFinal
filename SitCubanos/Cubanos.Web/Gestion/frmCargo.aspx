<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="frmCargo.aspx.cs" Inherits="Cubanos.Web.Gestion.frmCargo" %>
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
                Cargo
            </header>
            <div class="panel-body">
                <asp:FormView runat="server" ID="fvCargo"
                    ItemType="Cubanos.BusinessEntity.Cargo"
                    DefaultMode="Insert"
                    InsertMethod="AddCargo"
                    UpdateMethod="UpdateCargo"
                    SelectMethod="GetCargo"
                    CssClass="form-horizontal col-lg-10">
                    <InsertItemTemplate>
                        <fieldset>
                            <asp:HiddenField runat="server" ID="hfId" Value="<%# BindItem.Id %>" />
                            <div class="form-group">
                                <label class="col-lg-3 control-label">Nombre</label>
                                <div class="col-lg-9">
                                    <asp:TextBox runat="server" ID="txtNombre" Text="<%# BindItem.Nombre %>" CssClass="form-control"/>
                                </div>                          
                            </div>
                            <div class="form-group">
                                <label class="col-lg-3 control-label">Descripción</label>
                                <div class="col-lg-9">
                                    <asp:TextBox runat="server" ID="txtDescripcion" Text="<%# BindItem.Descripcion %>" CssClass="form-control" TextMode="MultiLine"/>
                                </div>                          
                            </div>
                            <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CommandName="insert" CssClass="btn btn-default" />
                        </fieldset>
                    </InsertItemTemplate>
                    <EditItemTemplate>
                        <fieldset>
                            <div class="form-group">
                                <label class="col-lg-3 control-label">Nombre</label>
                                <div class="col-lg-9">
                                    <asp:TextBox runat="server" ID="txtNombre" Text="<%# BindItem.Nombre %>" CssClass="form-control"/>
                                </div>                          
                            </div>
                            <div class="form-group">
                                <label class="col-lg-3 control-label">Descripción</label>
                                <div class="col-lg-9">
                                    <asp:TextBox runat="server" ID="txtDescripcion" Text="<%# BindItem.Descripcion %>" CssClass="form-control" TextMode="MultiLine"/>
                                </div>                          
                            </div>
                            <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CommandName="insert" CssClass="btn btn-default" />
                        </fieldset>
                    </EditItemTemplate>
                </asp:FormView>
            </div>
        </section>
    </div>
    <!-- fin de contenido -->
</div>



</asp:Content>
