<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu_HienThi.ascx.cs" Inherits="cms_admin_Menu_Menu_HienThi" %>

<div class="head">
	Các menu đã tạo
	<div class="action fr">
		<a class="btThemMoi" href="/Admin.aspx?modul=Menu&thaotac=ThemMoi" title="Thêm mới menu"><i class="fa fa-plus-circle" aria-hidden="true"></i></a>
	</div>
	<div class="cb">
	</div>
</div>
<div class="wapp">
	<table class="tb tbSach">
		<tr>
			<th class="cotMa">Mã</th>
			<th class="cotTen">Tên menu</th>
			<th class="cotThuTu">Thứ tự</th>
			<th class="cotCongCu">Công cụ</th>
		</tr>
		<asp:Literal ID="ltrMenu" runat="server"></asp:Literal>
	</table>
</div>
<script>
	function XoaMenu(MaMenu) {
		if (confirm("Bạn có chắc chắn muốn xóa menu có ID là: " + MaMenu + "?")) {
			// viết code xóa danh mục tại đây
			$.post("cms/admin/Menu/Ajax/Menu.aspx",
			{
				"ThaoTac": "XoaMenu",
				"MaMenu": MaMenu
			},
			function(data, status){
				if(data == 1){ 
					$("#maDong_" + MaMenu).slideUp();
				}
			});
		}
	}
</script>