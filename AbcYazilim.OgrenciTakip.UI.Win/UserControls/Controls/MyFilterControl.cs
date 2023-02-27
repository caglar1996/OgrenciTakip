using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl : DevExpress.XtraEditors.FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true; // Gruplama yaparken imagelerin çıkmasını sağlar
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";
    }
}
