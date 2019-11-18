using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace emdepvn
{
    /// <summary>
    /// Class thực hiện các thao tác liên quan đến menu
    /// </summary>
    public class Menu
    {
        #region Delete một menu theo mã
        /// <summary>
        /// Delete một menu theo mã
        /// </summary>
        public static void Menu_Delete(string mamenu)
        {
            OleDbCommand cmd = new OleDbCommand("menu_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Insert một menu
        /// <summary>
        /// Insert một menu
        /// </summary>
        public static void Menu_Inser(
                string tenmenu,
                string lienket,
                string mamenucha,
                string thutumenu,
                string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("menu_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@mamenucha", mamenucha);
            cmd.Parameters.AddWithValue("@thutumenu", thutumenu);
            cmd.Parameters.AddWithValue("@ret", ret);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Update một menu
        /// <summary>
        /// Update một menu
        /// </summary>
        public static void Menu_Update(
                string mamenu,
                string tenmenu,
                string lienket,
                string mamenucha,
                string thutumenu
            )
        {
            OleDbCommand cmd = new OleDbCommand("menu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@mamenucha", mamenucha);
            cmd.Parameters.AddWithValue("@thutumenu", thutumenu);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Lấy thông tin menu
        /// <summary>
        /// Lấy thông tin menu
        /// </summary>
        public static DataTable Thongtin_Menu()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin menu theo ID
        /// <summary>
        /// Lấy thông tin menu theo ID
        /// </summary>
        public static DataTable Thongtin_Menu_by_id(string MaMenu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMenu", MaMenu);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy thông tin menu theo Menu cha
        /// <summary>
        /// Lấy thông tin menu theo Menu cha
        /// </summary>
        public static DataTable Thongtin_Menu_by_mamenucha(string MaMenuCha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_by_mamenucha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMenuCha", MaMenuCha);

            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}