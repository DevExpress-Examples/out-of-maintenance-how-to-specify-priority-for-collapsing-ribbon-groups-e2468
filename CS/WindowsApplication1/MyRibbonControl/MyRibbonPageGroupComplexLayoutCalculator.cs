using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsApplication1
{
    public class MyRibbonPageGroupComplexLayoutCalculator : RibbonPageGroupComplexLayoutCalculator
    {

        public MyRibbonPageGroupComplexLayoutCalculator(RibbonPageGroupViewInfo groupInfo)
            : base(groupInfo)
        {

        }

        public MyRibbonViewInfo ViewInfo
        {
            get
            {
                return GroupInfo.ViewInfo as MyRibbonViewInfo;
            }
        }

        protected override int Reduce()
        {
            if ( GroupInfo.Items.Count == 0 )
                return 0;

            if ( !ViewInfo.CanMinimizePageGroup(GroupInfo.PageGroup) )
                return 1;

            return base.Reduce();
        }

    }
}
