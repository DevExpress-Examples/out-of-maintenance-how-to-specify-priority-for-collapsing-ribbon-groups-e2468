using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsApplication1
{
    public class CanMinimizePageGroupEventArgs : EventArgs
    {
        private bool _canMinimize;
        private RibbonPageGroup _pageGroup;
        private RibbonPanelViewInfo _panelViewInfo;

        public CanMinimizePageGroupEventArgs(bool canMinimize, RibbonPageGroup pageGroup, RibbonPanelViewInfo panelViewInfo)
            : base()
        {
            _canMinimize = canMinimize;
            _pageGroup = pageGroup;
            _panelViewInfo = panelViewInfo;
        }

        public RibbonPageGroup PageGroup
        {
            get
            {
                return _pageGroup;
            }
        }

        public bool CanMinimize
        {
            get
            {
                return _canMinimize;
            }
            set
            {
                _canMinimize = value;
            }
        }
        public RibbonPanelViewInfo PanelViewInfo
        {
            get
            {
                return _panelViewInfo;
            }
        }

    }
}
