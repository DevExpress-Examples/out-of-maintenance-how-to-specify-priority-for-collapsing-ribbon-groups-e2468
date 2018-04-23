Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsApplication1
	Public Class MyRibbonViewInfo
		Inherits RibbonViewInfo
		Public Sub New(ByVal ribbon As RibbonControl)
			MyBase.New(ribbon)

		End Sub

		Protected Overrides Function CreateGroupLayoutCalculator(ByVal pageInfo As RibbonPageGroupViewInfo) As RibbonPageGroupLayoutCalculator
			Return New MyRibbonPageGroupComplexLayoutCalculator(pageInfo)
		End Function

		Public Function CanMinimizePageGroup(ByVal group As RibbonPageGroup) As Boolean
			Dim ribbonControl As MyRibbonControl = CType(Ribbon, MyRibbonControl)
			Return ribbonControl.RaiseCanMinimizePageGroup(group, Panel)
		End Function
	End Class
End Namespace