using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsApplication1
{
	public class MyRibbonViewInfo : RibbonViewInfo
	{
		public MyRibbonViewInfo(RibbonControl ribbon)
			: base(ribbon)
		{
		}

		protected override RibbonPageGroupLayoutCalculator CreateGroupLayoutCalculator(RibbonPageGroupViewInfo pageInfo)
		{
			return new MyRibbonPageGroupComplexLayoutCalculator(pageInfo);
		}

		public bool CanMinimizePageGroup(RibbonPageGroup group)
		{
			MyRibbonControl ribbonControl = (MyRibbonControl)Ribbon;
			return ribbonControl.RaiseCanMinimizePageGroup(group, Panel);
		}
	}
}