<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<%@ Register Src="~/cms/admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang quản trị website</title>
	<link href="cms/admin/css/styleAdmin.min.css" rel="stylesheet" />
	<%-- js --%>
	<script src="cms/admin/js/jquery-3.2.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
		<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
		<div>
			<%-- Header --%>
			<div id="header">
				<div class="container">
					<div class="logo">
						<a href="/Admin.aspx"><img src="pic/Logo/LogoTet2.png" /></a>
					</div>
					<div class="accountMenu">
						Xin chao: <asp:Literal ID="ltrTenDangNhap" runat="server"></asp:Literal> | <asp:LinkButton ID="lbtDangXuat" runat="server" OnClick="lbtDangXuat_Click">Dang Xuat</asp:LinkButton>
					</div>
				</div>
			</div>
			<%-- Menu chính --%>
			<div class="menuChinh">
				<div class="container">
					<ul>
						<li><a href="Admin.aspx?modul=SanPham" title="Sản phẩm">Sản phẩm</a></li>
						<li><a href="Admin.aspx?modul=KhachHang" title="Khách hàng">Khách hàng</a></li>
						<li><a href="Admin.aspx?modul=TinTuc" title="Tin tức">Tin tức</a></li>
						<li><a href="Admin.aspx?modul=TaiKhoan" title="Tài khoản">Tài khoản</a></li>
						<li><a href="Admin.aspx?modul=QuangCao" title="Quảng cáo">Quảng cáo</a></li>
						<li><a href="Admin.aspx?modul=Menu" title="Menu">Menu</a></li>
					</ul>
				</div>
			</div>
			<%-- Nội dung trang --%>
			<uc1:AdminLoadControl runat="server" ID="AdminLoadControl" />
		</div>
    </form>
</body>
</html>
