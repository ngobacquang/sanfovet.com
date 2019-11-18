<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoanLoadControl.ascx.cs" Inherits="cms_admin_TaiKhoan_TaiKhoanLoadControl" %>

<div class="pg pgTaiKhoan">
	<div class="container">
		<div class="cotTrai">
			<div class="slider-bar">
				<div class="head">
					Quản lý
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan">Danh sách tài khoản</a></li>
				</ul>
			</div>
			<div class="slider-bar">
				<div class="head">
					Thêm mới
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan&thaotac=ThemMoi">Danh sách tài khoản</a></li>
				</ul>
			</div>
		</div>
		<div class="cotPhai">
			<asp:PlaceHolder ID="plTaiKhoanLoadControl" runat="server"></asp:PlaceHolder>
		</div>
	</div>
</div>
<div class="cb"></div>