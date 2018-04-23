using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsApplication1
{
    public class MyRibbonControl : RibbonControl
    {
        public MyRibbonControl()
        {
        }

        protected override RibbonViewInfo CreateViewInfo()
        {
            return new MyRibbonViewInfo(this);
        }

        public delegate void CanMinimizePageGroupEventHandler(object sender, CanMinimizePageGroupEventArgs e);
        public event CanMinimizePageGroupEventHandler CanMinimizePageGroup;

        internal bool RaiseCanMinimizePageGroup(RibbonPageGroup group, RibbonPanelViewInfo panelViewInfo)
        {
            CanMinimizePageGroupEventArgs args = new CanMinimizePageGroupEventArgs(true, group, panelViewInfo);
            if ( CanMinimizePageGroup != null )
                CanMinimizePageGroup(this, args);

            return args.CanMinimize;
        }

    }
}