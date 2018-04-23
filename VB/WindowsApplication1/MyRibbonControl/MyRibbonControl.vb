Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsApplication1
	Public Class MyRibbonControl
		Inherits RibbonControl
		Public Sub New()
		End Sub

		Protected Overrides Function CreateViewInfo() As RibbonViewInfo
			Return New MyRibbonViewInfo(Me)
		End Function

		Public Delegate Sub CanMinimizePageGroupEventHandler(ByVal sender As Object, ByVal e As CanMinimizePageGroupEventArgs)
		Public Event CanMinimizePageGroup As CanMinimizePageGroupEventHandler

		Friend Function RaiseCanMinimizePageGroup(ByVal group As RibbonPageGroup, ByVal panelViewInfo As RibbonPanelViewInfo) As Boolean
			Dim args As New CanMinimizePageGroupEventArgs(True, group, panelViewInfo)
			RaiseEvent CanMinimizePageGroup(Me, args)

			Return args.CanMinimize
		End Function

	End Class
End Namespace