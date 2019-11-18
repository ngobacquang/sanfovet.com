<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DangNhap.ascx.cs" Inherits="cms_display_ThanhVien_DangNhap" %>
<link href="../../../css/dang-ky.css" rel="stylesheet" />
<div class="title-gioithieu">
        <h1>Đăng nhập</h1>
    </div>
    <div class="userbox">

        <div id="create_customer">
            <input name="form_type" type="hidden" value="create_customer">
            <input name="utf8" type="hidden" value="✓">
            <div class="clearfix">
                <div class="label-email"></div>
				<asp:TextBox ID="tbEmail" runat="server" CssClass="text" placeholder="Email"></asp:TextBox>
				<div style="clear: both"></div>
				<%--  bắt buộc phải nhập --%>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" SetFocusOnError="true" Display="Dynamic" ControlToValidate="tbEmail"></asp:RequiredFieldValidator>
				<%-- Định dạng email --%>
				<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="<div style='color: red;padding:3px 0;'>Email sai định dạng</div>" SetFocusOnError="true" Display="Dynamic" ControlToValidate="tbEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>

            <div class="clearfix">
                <div class="label-pass"></div>
				<asp:TextBox ID="tbMatKhau" runat="server" CssClass="password text" TextMode="Password" placeholder="Mật khẩu"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" SetFocusOnError="true" Display="Dynamic" ControlToValidate="tbMatKhau"></asp:RequiredFieldValidator>
            </div>
            <div class="action_bottom">
				<asp:LinkButton ID="lbtDangNhap" CssClass="btn" runat="server" OnClick="lbtDangNhap_Click">Đăng Nhập</asp:LinkButton>
            </div>
            <div class="req_pass">
                <a class="come-back" href="/">Quay về</a>
            </div>
        </div>
    </div>