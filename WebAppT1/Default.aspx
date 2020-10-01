<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppT1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>BOM Example</h1>
        <p class="lead">This is a quick and easy interface to add more shapes to the BOM</p>
    </div>
     <div class="row">
       <div class="col-md-8">
           <asp:Button runat="server" ID="btnRectangle" Text="Add Rectangle" CssClass="btn btn-primary" OnClick="btnRectangle_Click" CausesValidation="false" />
           <asp:Button runat="server" ID="btnSquare" Text="Add Square" CssClass="btn btn-default" CausesValidation="false" OnClick="btnSquare_Click"  />
            <asp:Button runat="server" ID="btnElipsis" Text="Add Ellipsis" CssClass="btn btn-default" CausesValidation="false" OnClick="btnElipsis_Click"  />
           <asp:Button runat="server" ID="btnCircle" Text="Add Circle" CssClass="btn btn-default" CausesValidation="false" OnClick="btnCircle_Click"  />
            <asp:Button runat="server" ID="btnTextbox" Text="Add Textbox" CssClass="btn btn-default" CausesValidation="false" OnClick="btnTextbox_Click"  />
       </div>
        <div class="col-md-4">
           
           <asp:Button runat="server" ID="btnClear" Text="Clear Bill" CssClass="btn btn-danger" CausesValidation="false" OnClick="btnClear_Click"  />
       </div>
    </div>
    <div class="row">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-md-4">PositionX:</label>
                    <div class="col-md-4">
                        <asp:TextBox runat="server" ID="txtPositionX" MaxLength="4" Text="0" CssClass="form-control" />
                    </div>
                    <div class="col-md-4">
                        <asp:RequiredFieldValidator runat="server" ID="t1" ControlToValidate="txtPositionX" Display="Dynamic" ErrorMessage="Position X is required!"></asp:RequiredFieldValidator>
                        <asp:RangeValidator runat="server" ID="r12" ControlToValidate="txtPositionX" Display="Dynamic" ErrorMessage="Please enter a valid value!" 
                            MinimumValue="0" MaximumValue="1000" Type="Integer" />
                    </div>
                </div>
                 <div class="form-group">
                    <label class="control-label col-md-4">PositionY:</label>
                    <div class="col-md-4">
                        <asp:TextBox runat="server" ID="txtPositionY" MaxLength="4" Text="0" CssClass="form-control" />
                    </div>
                    <div class="col-md-4">
                        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtPositionY" Display="Dynamic" ErrorMessage="Position Y is required!"></asp:RequiredFieldValidator>
                        <asp:RangeValidator runat="server" ID="RangeValidator1" ControlToValidate="txtPositionY" Display="Dynamic" ErrorMessage="Please enter a valid value!" Type="Integer" MinimumValue="0" MaximumValue="1000" />
                    </div>
                </div>
                 <div class="form-group">
                    <asp:Label CssClass="control-label col-md-4" Text="Width:" runat="server" ID="lblWidth" />
                    <div class="col-md-4">
                        <asp:TextBox runat="server" ID="txtWidth" MaxLength="4" Text="200" CssClass="form-control" />
                    </div>
                    <div class="col-md-4">
                        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="txtWidth" Display="Dynamic" ErrorMessage="Field is required!"></asp:RequiredFieldValidator>
                        <asp:RangeValidator runat="server" ID="RangeValidator2" ControlToValidate="txtWidth" Display="Dynamic" ErrorMessage="Please enter a valid value!" Type="Integer" MinimumValue="1" MaximumValue="1000" />
                    </div>
                </div>
                <asp:Panel runat="server" ID="pnlHeight" CssClass="form-group">
                    <asp:Label CssClass="control-label col-md-4" Text="Height:" runat="server" ID="lblHeight" />
                    <div class="col-md-4">
                        <asp:TextBox runat="server" ID="txtHeight" MaxLength="4" Text="100" CssClass="form-control" />
                    </div>
                    <div class="col-md-4">
                        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="txtHeight" Display="Dynamic" ErrorMessage="Field is required!"></asp:RequiredFieldValidator>
                        <asp:RangeValidator runat="server" ID="RangeValidator3" ControlToValidate="txtHeight" Display="Dynamic" ErrorMessage="Please enter a valid value!" Type="Integer" MinimumValue="1" MaximumValue="1000" />
                    </div>
                </asp:Panel>
                <asp:Panel runat="server" ID="pnlTExt" CssClass="form-group" Visible="false">
                    <asp:Label CssClass="control-label col-md-4" Text="Text:" runat="server" ID="Label1" />
                    <div class="col-md-4">
                        <asp:TextBox runat="server" ID="txtText" MaxLength="255" Text="" Width="100%" placeholder="please enter texbox text" CssClass="form-control" />
                    </div>
                    <div class="col-md-4">
                     </div>
                </asp:Panel>
                <div class="form-footer">
                    <div class="col-md-4">
                        <asp:Button runat="server" ID="btnAdd" Text="Add" CssClass="btn btn-primary" CausesValidation="true" OnClick="btnAdd_Click" />
                    </div>
                </div>
            </div>
    </div>
   
    <div class="row">
        <div class="col-md-12">
        <asp:Literal runat="server" ID="litData" />
        <br />
        <asp:Button runat="server" ID="btnGenerate" Text="Generate BOM" CssClass="btn btn-primary" OnClick="btnGenerate_Click" />
        <br />
        <asp:label runat="server" ID="txtReport"  />
        </div>
    </div>
</asp:Content>
