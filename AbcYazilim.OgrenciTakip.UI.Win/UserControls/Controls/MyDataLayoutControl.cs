using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDataLayoutControl : DataLayoutControl
    {
        public MyDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false; // TAb ile geçişlerde bizim belirlediğimiz düzenle gidicek
        }

        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner controlOwner) : base(controlOwner)
        {

        }

        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;

            return item;
        }

        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var grp = base.CreateLayoutGroup(parent);
            grp.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table; // table seçtimiz zaman 2 satır 2 sutün otomatik ekliyor

            #region Columns
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute; // sabit
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;

            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 100;

            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 90 }); //Toogdle Swicth için
            #endregion

            #region Rows
            grp.OptionsTableLayoutGroup.RowDefinitions.Clear(); // default olusturulan rowlar temizlendi.

            for (int i = 0; i < 9; i++)
            {
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Absolute,
                    Height = 24 // Satır Yüksekliği
                });

                if (i + 1 != 9) continue;

                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition { SizeType = SizeType.Percent, Height = 100 });
            }
            #endregion

            return grp;
        }
    }
}
