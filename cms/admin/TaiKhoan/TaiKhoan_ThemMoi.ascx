<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoan_ThemMoi.ascx.cs" Inherits="cms_admin_TaiKhoan_TaiKhoan_ThemMoi" %>

<div class="head">
	Thêm mới, chỉnh sửa tài khoản 
</div>
<div class="wapp formThemMoi">
	<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
	<div class="thongTin">
		<div class="tenTruong">Chọn quyền</div>
		<div class="oNhap">
			<asp:DropDownList ID="ddlQuyenDangNhap" runat="server"></asp:DropDownList>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Tên đang nhập</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenDangNhap" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTenDangNhap" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Mật khẩu</div>
		<div class="oNhap">
			<asp:HiddenField ID="hfMatKhauCu" runat="server" />
			<asp:TextBox ID="tbMatKhau" runat="server" TextMode="Password"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Email</div>
		<div class="oNhap">
			<asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Địa chỉ</div>
		<div class="oNhap">
			<asp:TextBox ID="tbDiaChi" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Tên đầy đủ</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenDayDu" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Ngày sinh (tháng/ngày/năm)</div>
		<div class="oNhap">
			<asp:TextBox ID="tbNgaySinh" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Giới Tinh</div>
		<div class="oNhap">
			<asp:DropDownList ID="ddlGioiTinh" runat="server">
				<asp:ListItem Text="Nam" Value="Nam"></asp:ListItem>
				<asp:ListItem Text="Nư" Value="Nữ"></asp:ListItem>
				<asp:ListItem Text="Khác" Value="Khác"></asp:ListItem>
			</asp:DropDownList>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:Button ID="btDangKy" runat="server" Text="Đăng ký" CssClass="btThemMoi" OnClick="btDangKy_Click" />
			<asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
		</div>
	</div>
</div>