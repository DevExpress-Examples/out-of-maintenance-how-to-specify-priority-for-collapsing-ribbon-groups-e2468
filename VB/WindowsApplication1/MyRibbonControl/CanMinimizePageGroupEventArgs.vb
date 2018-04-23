Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsApplication1
	Public Class CanMinimizePageGroupEventArgs
		Inherits EventArgs
		Private _canMinimize As Boolean
		Private _pageGroup As RibbonPageGroup
		Private _panelViewInfo As RibbonPanelViewInfo

		Public Sub New(ByVal canMinimize As Boolean, ByVal pageGroup As RibbonPageGroup, ByVal panelViewInfo As RibbonPanelViewInfo)
			MyBase.New()
			_canMinimize = canMinimize
			_pageGroup = pageGroup
			_panelViewInfo = panelViewInfo
		End Sub

		Public ReadOnly Property PageGroup() As RibbonPageGroup
			Get
				Return _pageGroup
			End Get
		End Property

		Public Property CanMinimize() As Boolean
			Get
				Return _canMinimize
			End Get
			Set(ByVal value As Boolean)
				_canMinimize = value
			End Set
		End Property
		Public ReadOnly Property PanelViewInfo() As RibbonPanelViewInfo
			Get
				Return _panelViewInfo
			End Get
		End Property

	End Class
End Namespace
