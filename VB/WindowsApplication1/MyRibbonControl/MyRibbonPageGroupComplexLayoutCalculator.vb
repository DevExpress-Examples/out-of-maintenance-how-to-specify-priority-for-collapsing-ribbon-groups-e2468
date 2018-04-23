Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsApplication1
	Public Class MyRibbonPageGroupComplexLayoutCalculator
		Inherits RibbonPageGroupComplexLayoutCalculator

		Public Sub New(ByVal groupInfo As RibbonPageGroupViewInfo)
			MyBase.New(groupInfo)
		End Sub

		Public ReadOnly Property ViewInfo() As MyRibbonViewInfo
			Get
				Return TryCast(GroupInfo.ViewInfo, MyRibbonViewInfo)
			End Get
		End Property

		Protected Overrides Function Reduce() As Integer
			If GroupInfo.Items.Count = 0 Then
				Return 0
			End If

			Dim pageGroupInfo As RibbonPageGroupViewInfo = TryCast(GroupInfo, RibbonPageGroupViewInfo)
			If pageGroupInfo Is Nothing Then
				Return MyBase.Reduce()
			End If

            If (Not ViewInfo.CanMinimizePageGroup(pageGroupInfo.PageGroup)) Then
                Return 1
            End If

			Return MyBase.Reduce()
		End Function
	End Class
End Namespace
