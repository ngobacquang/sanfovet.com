<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KhachHangLoadControl.ascx.cs" Inherits="cms_admin_KhachHang_KhachHangLoadControl" %>

<div class="pg pgKhachHang">
	<div class="container">
		<div class="cotTrai">
			<div class="slider-bar">
				<div class="head">
					Quản lý
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=KhachHang&modulphu=DanhSachKhachHang">Danh sách khách hàng</a></li>
				</ul>
			</div>
			<div class="slider-bar">
				<div class="head">
					Thêm mới
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=KhachHang&modulphu=DanhSachKhachHang&thaotac=ThemMoi">Danh sách khách hàng</a></li>
				</ul>
			</div>
		</div>
		<div class="cotPhai">
			<asp:PlaceHolder ID="plKhachHangLoadControl" runat="server"></asp:PlaceHolder>
		</div>
	</div>
</div>
<div class="cb"></div>