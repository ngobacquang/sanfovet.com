<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Nhom_HienThi.ascx.cs" Inherits="cms_admin_QuangCao_Nhom_Nhom_HienThi" %>

<div class="head">
	Các nhóm đã tạo
	<div class="action fr">
		<a class="btThemMoi" href="/Admin.aspx?modul=QuangCao&modulphu=Nhom&thaotac=ThemMoi" title="Thêm mới danh mục"><i class="fa fa-plus-circle" aria-hidden="true"></i></a>
	</div>
	<div class="cb">
	</div>
</div>
<div class="wapp">
	<table class="tb tbQuangCao">
		<tr>
			<th class="cotMa">Mã</th>
			<th class="cotTen">Tên Nhóm QC</th>
			<th class="cotAnh">Ảnh quảng cáo</th>
			<th class="cotTen">Vị trí QC</th>
			<th class="cotThuTu">Thứ tự</th>
			<th class="cotCongCu">Công cụ</th>
		</tr>
		<asp:Literal ID="ltrNhom" runat="server"></asp:Literal>
	</table>
</div>
<script>
	function XoaNhom(NhomQuangCaoID) {
		if (confirm("Bạn có chắc chắn muốn xóa nhóm có ID là: " + NhomQuangCaoID + "?")) {
			// viết code xóa danh mục tại đây
			$.post("cms/admin/QuangCao/Nhom/Ajax/Nhom.aspx",
			{
				"ThaoTac": "XoaNhom",
				"NhomQuangCaoID": NhomQuangCaoID
			},
			function(data, status){
				if(data == 1){ 
					$("#maDong_" + NhomQuangCaoID).slideUp();
				}
			});
		}
	}
</script>