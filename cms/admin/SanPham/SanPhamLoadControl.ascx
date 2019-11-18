<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamLoadControl.ascx.cs" Inherits="cms_admin_SanPham_SanPhamLoadControl" %>

<div class="pg pgSanPham">
	<div class="container">
		<div class="cotTrai">
			<div class="slider-bar">
				<div class="head">
					Quản lý
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=DanhMuc">Danh mục sản phẩm</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=DanhSach">Danh sách sản phẩm</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=Mau">Màu sản phẩm</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=ChatLieu">Chất liệu sản phẩm</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=Size">Size sản phẩm</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=Nhom">Nhóm sản phẩm</a></li>
				</ul>
			</div>
			<div class="slider-bar">
				<div class="head">
					Thêm mới
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ThemMoi">Danh mục sản phẩm</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=DanhSach&thaotac=ThemMoi">Danh sách sản phẩm</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=Mau&thaotac=ThemMoi">Màu sản phẩm</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=ChatLieu&thaotac=ThemMoi">Chất liệu sản phẩm</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ThemMoi">Size</a></li>
					<li><a href="Admin.aspx?modul=SanPham&modulphu=Nhom&thaotac=ThemMoi">Nhóm sản phẩm</a></li>
				</ul>
			</div>
		</div>
		<div class="cotPhai">
			<asp:PlaceHolder ID="plSanPhamLoadControl" runat="server"></asp:PlaceHolder>
		</div>
	</div>
</div>
<div class="cb"></div>



