using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsApplication1
{
    public partial class RibbonForm1 : RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();

        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            ribbonPageGroup1.Tag = 1;
            ribbonPageGroup2.Tag = 2;
            ribbonPageGroup3.Tag = 3;
            ribbonPageGroup4.Tag = 4;
            ribbonPageGroup5.Tag = 5;
            ribbonPageGroup6.Tag = 6;
            ribbonPageGroup7.Tag = 7;
            ribbonPageGroup8.Tag = 8;
            ribbonPageGroup9.Tag = 9;
        }

        private int GetGroupMinimizeIndex(RibbonPageGroup group)
        {
            int result;
            try
            {
                result = Convert.ToInt32(group.Tag);
            }
            catch
            {
                result = -1;
            }

            return result;
        }

        private void ribbonControl1_CanMinimizePageGroup(object sender, CanMinimizePageGroupEventArgs e)
        {
            if ( e.PageGroup.Tag == null )
                return;

            int groupMinimizeIndex = GetGroupMinimizeIndex(e.PageGroup);
            if ( groupMinimizeIndex == -1 )
            {
                e.CanMinimize = false;
                return;
            }

            for ( int i = 0; i < e.PanelViewInfo.Groups.Count; i++ )
            {
                RibbonPageGroupViewInfo groupViewInfo = e.PanelViewInfo.Groups[i];

                int minimizeIndex = GetGroupMinimizeIndex(groupViewInfo.PageGroup);
                if ( minimizeIndex > 0 && minimizeIndex < groupMinimizeIndex )
                    if ( !groupViewInfo.Minimized )
                    {
                        e.CanMinimize = false;
                        return;
                    }

            }
        }
    }
}