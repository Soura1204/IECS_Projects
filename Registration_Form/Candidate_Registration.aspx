<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Candidate_Registration.aspx.cs" Inherits="Registration_Form.Candidate_Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">

    <section id="wrapper">
        <div class="row">
            <div class="col-lg-12">
                <section class="panel">
                    <header class="panel-heading">
                        <div class="col-md-4 col-md-offset-4">
                            <h1>Registration</h1>
                        </div>
                    </header>


                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label Text="First Name" runat="server"  />
                                    <asp:TextBox ID="txtFirstName" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Enter your First Name" />
                                </div>

                                </div>

                             <div class="col-md-4 col-md-offset-1">
                             <div class="form-group">
                <asp:Label Text="Last Name" runat="server"  />
                <asp:TextBox ID="txtLastName" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Enter your Last Name" />
                 </div>
                 </div>
                  </div>


                  <div class="row">
                 <div class="col-md-4 col-md-offset-1">
                    <div class="form-group">
                        <asp:Label Text="Address" runat="server"  />
                        <asp:TextBox ID="txtAddress" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Enter your address" />
                    </div>

                   </div>

                 <div class="col-md-4 col-md-offset-1">
                 <div class="form-group">
                    <asp:Label Text="DOB" runat="server"  />
                    <asp:TextBox ID="txtDOB" runat="server" Enabled="true" TextMode="Date" CssClass="form-control input-sm" placeholder="DOB" />
                </div>

                </div>
                </div>

              <div class="row">
            <div class="col-md-4 col-md-offset-1">
            <div class="form-group">
                <asp:Label Text="Email" runat="server"  />
                 <asp:TextBox ID="txtEmail" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Enter your email" />
             </div>

            </div>

           <div class="col-md-4 col-md-offset-1">
          <div class="form-group">
           <asp:Label Text="Mobile Number" runat="server"  />
          <asp:TextBox ID="txtMobile" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Mobile Number 10 Digit Only" />
          </div>
           </div>
            </div>
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div style="height: 15vh; display: flex; justify-content: center; align-items: center;">
                    <asp:Button Text="SUBMIT" ID="btnsubmit" CssClass="btn btn-primary" Width="170px" runat="server" BackColor="#33CCFF" ForeColor="Black" OnClick="btnsubmit_Click" />
                    <asp:Button Text="UPDATE" ID="btnsubmit1" CssClass="btn btn-primary" Width="170px" runat="server" BackColor="Lime" ForeColor="Black" OnClick="btnsubmit1_Click" />
                    <asp:Button Text="DELETE" ID="btnsubmit2" CssClass="btn btn-primary" Width="170px" runat="server" BackColor="Red" ForeColor="Black" OnClick="btnsubmit2_Click" />
                    <asp:Button Text="SEARCH" ID="btnsubmit3" CssClass="btn btn-primary" Width="170px" runat="server" BackColor="Yellow" ForeColor="Black" OnClick="btnsubmit3_Click" />
                    <asp:Button Text="GET" ID="btnsubmit4" CssClass="btn btn-primary" Width="170px" runat="server" BackColor="#FF9900" ForeColor="Black" OnClick="btnsubmit4_Click" />
               </div>
                        <div style="width: 80%; margin: auto;">
            <asp:GridView 
    ID="GridView1" 
    runat="server" 
    AutoGenerateColumns="true"
    GridLines="Both"
    BorderStyle="Solid"
    BorderWidth="1"
    BorderColor="Black"
    CellPadding="5"
    CellSpacing="0"
    HeaderStyle-BackColor="#CCCCCC"
    HeaderStyle-Font-Bold="true" 
/>
            </div>
               </div>
            </div>
            
           </div>
             </section>
            </div>
            
              </div>

            </section>
        </section>

</asp:Content>
