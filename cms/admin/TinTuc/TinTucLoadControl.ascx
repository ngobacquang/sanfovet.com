<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TinTucLoadControl.ascx.cs" Inherits="cms_admin_TinTuc_TinTucLoadControl" %>

<div class="pg pgSanPham">
	<div class="container">
		<div class="cotTrai">
			<div class="slider-bar">
				<div class="head">
					Quản lý
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=TinTuc&modulphu=DanhMuc">Danh mục tin tức</a></li>
					<li><a href="Admin.aspx?modul=TinTuc&modulphu=DanhSach">Danh sách tin tức</a></li>
				</ul>
			</div>
			<div class="slider-bar">
				<div class="head">
					Thêm mới
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=TinTuc&modulphu=DanhMuc&thaotac=ThemMoi">Danh mục tin tức</a></li>
					<li><a href="Admin.aspx?modul=TinTuc&modulphu=DanhSach&thaotac=ThemMoi">Danh sách tin tức</a></li>
				</ul>
			</div>
		</div>
		<div class="cotPhai">
			<asp:PlaceHolder ID="plTinTucControl" runat="server"></asp:PlaceHolder>
		</div>
	</div>
</div>
<div class="cb"></div>