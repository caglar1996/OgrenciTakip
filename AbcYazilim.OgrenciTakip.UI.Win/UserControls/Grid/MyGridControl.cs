using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid
{
    public class MyGridControl : GridControl
    {

    }

    public class MyGridView : GridView, IStatusBarKisaYol
    {
        #region Properties
        public string StatusBarKisaYol { get; set; }
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
        #endregion

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null)
                return;

            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
        }
    }

    public class MyGridColumn : GridColumn, IStatusBarKisaYol
    {

        #region Properties
        public string StatusBarKisaYol { get; set; }
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
        #endregion
    }
}
