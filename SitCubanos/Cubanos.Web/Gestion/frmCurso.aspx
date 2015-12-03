<%@ Page Title="" Language="C#" MasterPageFile="~/Cubanos.Master" AutoEventWireup="true" CodeBehind="frmCurso.aspx.cs" Inherits="Cubanos.Web.Gestion.frmCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <!--breadcrumbs start -->
            <ul class="breadcrumb">
                <li><a href="#"><i class="icon_house_alt"></i> Inicio</a></li>
                <li><a href="#"> Gestión</a></li>
                <li class="active"> Curso</li>
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
                    <asp:FormView runat="server" ID="fvCurso"
                        ItemType="Cubanos.BusinessEntity.Curso"
                        DefaultMode="Insert"
                        InsertMethod="AddCurso"
                        UpdateMethod="UpdateCurso"
                        SelectMethod="GetCurso"
                        CssClass="form-horizontal col-lg-10">
                        <InsertItemTemplate>
                            <fieldset>
                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Nombre</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" ID="txtNombre" Text="<%# BindItem.Nombre %>" CssClass="form-control"/>
                                    </div>                          
                                </div>                               
                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Fecha Inicio</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox CssClass="form-control" ID="txtFechaIni" runat="server" TextMode="Date" Text="<%# BindItem.FechaInicio %>" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <!--<p>Date: <input type="text" id="datepicker"></p>-->
                                    <label class="col-lg-3 control-label">Fecha Fin</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox CssClass="form-control" ID="txtFechaFin" runat="server" TextMode="Date" Text="<%# BindItem.FechaFin %>" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Precio</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" ID="txtPrecio" Text="<%# BindItem.Precio %>" placeholder="20.00" CssClass="form-control" />
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
                                    <label class="col-lg-3 control-label">Fecha Inicio</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox CssClass="form-control" ID="txtFechaIni" runat="server" TextMode="Date" Text="<%# BindItem.FechaInicio %>" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <!--<p>Date: <input type="text" id="datepicker"></p>-->
                                    <label class="col-lg-3 control-label">Fecha Fin</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox CssClass="form-control" ID="txtFechaFin" runat="server" TextMode="Date" Text="<%# BindItem.FechaFin %>" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Precio</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" ID="txtPrecio" Text="<%# BindItem.Precio %>" placeholder="20.00" CssClass="form-control" />
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
