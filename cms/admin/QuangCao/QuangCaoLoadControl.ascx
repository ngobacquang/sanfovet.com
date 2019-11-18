<%@ Control Language="C#" AutoEventWireup="true" CodeFile="QuangCaoLoadControl.ascx.cs" Inherits="cms_admin_QuangCao_QuangCaoLoadControl" %>


<div class="pg pgQuangCao">
	<div class="container">
		<div class="cotTrai">
			<div class="slider-bar">
				<div class="head">
					Quản lý
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=QuangCao&modulphu=Nhom">Nhóm quảng cáo</a></li>
					<li><a href="Admin.aspx?modul=QuangCao&modulphu=DanhSach">Danh sách quảng cáo</a></li>
				</ul>
			</div>
			<div class="slider-bar">
				<div class="head">
					Thêm mới
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=QuangCao&modulphu=Nhom&thaotac=ThemMoi">Nhóm quảng cáo</a></li>
					<li><a href="Admin.aspx?modul=QuangCao&modulphu=DanhSach&thaotac=ThemMoi">Danh sách quảng cáo</a></li>
				</ul>
			</div>
		</div>
		<div class="cotPhai">
			<asp:PlaceHolder ID="phQuangCaoLoadControl" runat="server"></asp:PlaceHolder>
		</div>
	</div>
</div>
<div class="cb"></div>