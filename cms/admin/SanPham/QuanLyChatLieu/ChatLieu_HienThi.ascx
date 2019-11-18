<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChatLieu_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyChatLieu_ChatLieu_HienThi" %>

<div class="head">
	Các chất liệu hiện có
	<div class="action fr">
		<a href="/Admin.aspx?modul=SanPham&modulphu=ChatLieu&thaotac=ThemMoi" class="btThemMoi"><i class="fa fa-plus-circle" aria-hidden="true"></i></a>
	</div>
</div>
<div class="wapp">
	<table class="tb">
		<tr>
			<th class="cotStt">STT</th>
			<th class="cotMa">ID</th>
			<th class="cotTen">Tên chất liệu</th>
			<th class="cotCongCu">Công cụ</th>
		</tr>
		<asp:Literal ID="ltrChatLieu" runat="server"></asp:Literal>
	</table>
</div>
<script>
	function XoaChatLieu(ChatLieuID) {
		if (confirm("Bạn có chắc chắn muốn xóa chất liệu có ID là: "+ ChatLieuID +" ?")) {
			// viết code xóa danh mục tại đây
			$.post("cms/admin/SanPham/QuanLyChatLieu/Ajax/ChatLieu.aspx",
			{
				"ThaoTac": "XoaChatLieu",
				"ChatLieuID": ChatLieuID
			},
			function (data, status) {
				if (data == 1) {
					$("#maDong_" + ChatLieuID).slideUp();
				}
			});
		}
	}
</script>