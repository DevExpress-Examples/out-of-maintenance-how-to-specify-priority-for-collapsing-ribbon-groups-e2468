Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsApplication1
	Partial Public Class RibbonForm1
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub RibbonForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			ribbonPageGroup1.Tag = 1
			ribbonPageGroup2.Tag = 2
			ribbonPageGroup3.Tag = 3
			ribbonPageGroup4.Tag = 4
			ribbonPageGroup5.Tag = 5
			ribbonPageGroup6.Tag = 6
			ribbonPageGroup7.Tag = 7
			ribbonPageGroup8.Tag = 8
			ribbonPageGroup9.Tag = 9
		End Sub

		Private Function GetGroupMinimizeIndex(ByVal group As RibbonPageGroup) As Integer
			Dim result As Integer
			Try
				result = Convert.ToInt32(group.Tag)
			Catch
				result = -1
			End Try

			Return result
		End Function

		Private Sub ribbonControl1_CanMinimizePageGroup(ByVal sender As Object, ByVal e As CanMinimizePageGroupEventArgs) Handles ribbonControl1.CanMinimizePageGroup
			If e.PageGroup.Tag Is Nothing Then
				Return
			End If

			Dim groupMinimizeIndex As Integer = GetGroupMinimizeIndex(e.PageGroup)
			If groupMinimizeIndex = -1 Then
				e.CanMinimize = False
				Return
			End If

			For i As Integer = 0 To e.PanelViewInfo.Groups.Count - 1
				Dim groupViewInfo As RibbonPageGroupViewInfo = e.PanelViewInfo.Groups(i)

				Dim minimizeIndex As Integer = GetGroupMinimizeIndex(groupViewInfo.PageGroup)
				If minimizeIndex > 0 AndAlso minimizeIndex < groupMinimizeIndex Then
					If (Not groupViewInfo.Minimized) Then
						e.CanMinimize = False
						Return
					End If
				End If

			Next i
		End Sub
	End Class
End Namespace