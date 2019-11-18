<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MenuLoadControl.ascx.cs" Inherits="cms_admin_Menu_MenuLoadControl" %>

<div class="pg pgMenu">
	<div class="container">
		<div class="cotTrai">
			<div class="slider-bar">
				<div class="head">
					Quản lý
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=Menu">Danh sách Menu</a></li>
				</ul>
			</div>
			<div class="slider-bar">
				<div class="head">
					Thêm mới
				</div>
				<ul>
					<li><a href="Admin.aspx?modul=Menu&thaotac=ThemMoi">Danh sách Menu</a></li>
				</ul>
			</div>
		</div>
		<div class="cotPhai">
			<asp:PlaceHolder ID="phMenuLoadControl" runat="server"></asp:PlaceHolder>
		</div>
	</div>
</div>
<div class="cb"></div>