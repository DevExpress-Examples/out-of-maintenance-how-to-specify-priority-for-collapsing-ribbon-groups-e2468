Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class RibbonForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItemGroup3 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(RibbonForm1))
			Dim galleryItemGroup4 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItemGroup5 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItemGroup6 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItemGroup7 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
			Dim toolTipSeparatorItem1 As New DevExpress.Utils.ToolTipSeparatorItem()
			Dim toolTipTitleItem2 As New DevExpress.Utils.ToolTipTitleItem()
			Dim superToolTip2 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem3 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem2 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip3 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem4 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem3 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip4 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem5 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem4 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip5 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem6 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem5 As New DevExpress.Utils.ToolTipItem()
			Me.rgbiFontColor = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.gddFontColor = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
			Me.ribbonControl1 = New WindowsApplication1.MyRibbonControl()
			Me.pmAppMain = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
			Me.idNew = New DevExpress.XtraBars.BarButtonItem()
			Me.pmNew = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.iNew = New DevExpress.XtraBars.BarButtonItem()
			Me.iTemplate = New DevExpress.XtraBars.BarButtonItem()
			Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
			Me.sbiSave = New DevExpress.XtraBars.BarSubItem()
			Me.iSave = New DevExpress.XtraBars.BarButtonItem()
			Me.iSaveAs = New DevExpress.XtraBars.BarButtonItem()
			Me.iPrint = New DevExpress.XtraBars.BarButtonItem()
			Me.iClose = New DevExpress.XtraBars.BarButtonItem()
			Me.iExit = New DevExpress.XtraBars.BarButtonItem()
			Me.pccAppMenu = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.pcAppMenuFileLabels = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.iUndo = New DevExpress.XtraBars.BarButtonItem()
			Me.iReplace = New DevExpress.XtraBars.BarButtonItem()
			Me.iCut = New DevExpress.XtraBars.BarButtonItem()
			Me.iCopy = New DevExpress.XtraBars.BarButtonItem()
			Me.iPaste = New DevExpress.XtraBars.BarButtonItem()
			Me.iClear = New DevExpress.XtraBars.BarButtonItem()
			Me.iSelectAll = New DevExpress.XtraBars.BarButtonItem()
			Me.iFind = New DevExpress.XtraBars.BarButtonItem()
			Me.iFont = New DevExpress.XtraBars.BarButtonItem()
			Me.gddFont = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
			Me.beiFontSize = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.bbiFontColorPopup = New DevExpress.XtraBars.BarButtonItem()
			Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.iBullets = New DevExpress.XtraBars.BarButtonItem()
			Me.iProtected = New DevExpress.XtraBars.BarButtonItem()
			Me.iWeb = New DevExpress.XtraBars.BarButtonItem()
			Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
			Me.iBold = New DevExpress.XtraBars.BarButtonItem()
			Me.iItalic = New DevExpress.XtraBars.BarButtonItem()
			Me.iUnderline = New DevExpress.XtraBars.BarButtonItem()
			Me.iAlignLeft = New DevExpress.XtraBars.BarButtonItem()
			Me.iCenter = New DevExpress.XtraBars.BarButtonItem()
			Me.iAlignRight = New DevExpress.XtraBars.BarButtonItem()
			Me.iFontColor = New DevExpress.XtraBars.BarButtonItem()
			Me.siPosition = New DevExpress.XtraBars.BarButtonItem()
			Me.siModified = New DevExpress.XtraBars.BarButtonItem()
			Me.siDocName = New DevExpress.XtraBars.BarStaticItem()
			Me.bgFontStyle = New DevExpress.XtraBars.BarButtonGroup()
			Me.bgAlign = New DevExpress.XtraBars.BarButtonGroup()
			Me.bgFont = New DevExpress.XtraBars.BarButtonGroup()
			Me.bgBullets = New DevExpress.XtraBars.BarButtonGroup()
			Me.sbiPaste = New DevExpress.XtraBars.BarSubItem()
			Me.iPasteSpecial = New DevExpress.XtraBars.BarButtonItem()
			Me.sbiFind = New DevExpress.XtraBars.BarSubItem()
			Me.iLargeUndo = New DevExpress.XtraBars.BarLargeButtonItem()
			Me.iPaintStyle = New DevExpress.XtraBars.BarSubItem()
			Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.rgbiFont = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.ribbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
			Me.ribbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgFont = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgFontColor = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.pmMain = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.imageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
			CType(Me.gddFontColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pmAppMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pmNew, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pccAppMenu, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pccAppMenu.SuspendLayout()
			CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gddFont, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pmMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' rgbiFontColor
			' 
			Me.rgbiFontColor.Caption = "Color"
			' 
			' 
			' 
			Me.rgbiFontColor.Gallery.ColumnCount = 10
			galleryItemGroup1.Caption = "Main"
			Me.rgbiFontColor.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.rgbiFontColor.Gallery.ImageSize = New System.Drawing.Size(10, 7)
			Me.rgbiFontColor.GalleryDropDown = Me.gddFontColor
			Me.rgbiFontColor.Id = 37
			Me.rgbiFontColor.Name = "rgbiFontColor"
			' 
			' gddFontColor
			' 
			' 
			' 
			' 
			Me.gddFontColor.Gallery.Appearance.ItemCaption.Font = New System.Drawing.Font("Tahoma", 6.75F)
			Me.gddFontColor.Gallery.Appearance.ItemCaption.Options.UseFont = True
			Me.gddFontColor.Gallery.Appearance.ItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.gddFontColor.Gallery.FilterCaption = "All Colors"
			Me.gddFontColor.Gallery.FixedImageSize = False
			galleryItemGroup2.Caption = "Web Colors"
			galleryItemGroup3.Caption = "System Colors"
			Me.gddFontColor.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2, galleryItemGroup3})
			Me.gddFontColor.Gallery.ImageSize = New System.Drawing.Size(48, 16)
			Me.gddFontColor.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
			Me.gddFontColor.Gallery.RowCount = 5
			Me.gddFontColor.Gallery.ShowItemText = True
			Me.gddFontColor.Gallery.SizeMode = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
			Me.gddFontColor.Name = "gddFontColor"
			Me.gddFontColor.Ribbon = Me.ribbonControl1
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonDropDownControl = Me.pmAppMain
			Me.ribbonControl1.ApplicationButtonText = Nothing
			Me.ribbonControl1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() { New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")), New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")), New DevExpress.XtraBars.BarManagerCategory("Format", New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")), New DevExpress.XtraBars.BarManagerCategory("Help", New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d"))})
			' 
			' 
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.ExpandCollapseItem.Name = ""
			Me.ribbonControl1.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			Me.ribbonControl1.Images = Me.imageCollection2
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.iOpen, Me.iSave, Me.iUndo, Me.iReplace, Me.idNew, Me.iClose, Me.iSaveAs, Me.iPrint, Me.iExit, Me.iCut, Me.iCopy, Me.iPaste, Me.iClear, Me.iSelectAll, Me.iFind, Me.iFont, Me.iBullets, Me.iProtected, Me.iWeb, Me.iAbout, Me.iBold, Me.iItalic, Me.iUnderline, Me.iAlignLeft, Me.iCenter, Me.iAlignRight, Me.iFontColor, Me.siPosition, Me.siModified, Me.siDocName, Me.bgFontStyle, Me.bgAlign, Me.bgFont, Me.bgBullets, Me.sbiSave, Me.sbiPaste, Me.sbiFind, Me.iPasteSpecial, Me.iNew, Me.iLargeUndo, Me.iTemplate, Me.iPaintStyle, Me.rgbiSkins, Me.beiFontSize, Me.rgbiFont, Me.bbiFontColorPopup, Me.rgbiFontColor, Me.barEditItem1, Me.barButtonItem1})
			Me.ribbonControl1.LargeImages = Me.imageCollection1
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 120
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.ribbonPageCategory1})
			Me.ribbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
			Me.ribbonControl1.PageHeaderItemLinks.Add(Me.iAbout)
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage2, Me.ribbonPage3})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemPictureEdit1})
			Me.ribbonControl1.SelectedPage = Me.ribbonPage1
			Me.ribbonControl1.Size = New System.Drawing.Size(890, 148)
			Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iOpen)
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iSave)
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iUndo)
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iReplace, True)
			Me.ribbonControl1.Toolbar.ItemLinks.Add(Me.iPaintStyle)
			Me.ribbonControl1.TransparentEditors = True
'			Me.ribbonControl1.CanMinimizePageGroup += New WindowsApplication1.MyRibbonControl.CanMinimizePageGroupEventHandler(Me.ribbonControl1_CanMinimizePageGroup);
			' 
			' pmAppMain
			' 
			Me.pmAppMain.BottomPaneControlContainer = Nothing
			Me.pmAppMain.ItemLinks.Add(Me.idNew)
			Me.pmAppMain.ItemLinks.Add(Me.iOpen)
			Me.pmAppMain.ItemLinks.Add(Me.sbiSave, True)
			Me.pmAppMain.ItemLinks.Add(Me.iPrint)
			Me.pmAppMain.ItemLinks.Add(Me.iClose, True)
			Me.pmAppMain.ItemLinks.Add(Me.iExit)
			Me.pmAppMain.Name = "pmAppMain"
			Me.pmAppMain.Ribbon = Me.ribbonControl1
			Me.pmAppMain.RightPaneControlContainer = Me.pccAppMenu
			Me.pmAppMain.ShowRightPane = True
			' 
			' idNew
			' 
			Me.idNew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.idNew.Caption = "New"
			Me.idNew.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.idNew.Description = "Creates a new, blank file."
			Me.idNew.DropDownControl = Me.pmNew
			Me.idNew.Hint = "Creates a new, blank file"
			Me.idNew.Id = 0
			Me.idNew.ImageIndex = 6
			Me.idNew.LargeImageIndex = 0
			Me.idNew.Name = "idNew"
			' 
			' pmNew
			' 
			Me.pmNew.ItemLinks.Add(Me.iNew)
			Me.pmNew.ItemLinks.Add(Me.iTemplate)
			Me.pmNew.Name = "pmNew"
			Me.pmNew.Ribbon = Me.ribbonControl1
			' 
			' iNew
			' 
			Me.iNew.Caption = "&New"
			Me.iNew.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iNew.Description = "Creates a new, blank file."
			Me.iNew.Hint = "Creates a new, blank file"
			Me.iNew.Id = 0
			Me.iNew.ImageIndex = 6
			Me.iNew.LargeImageIndex = 0
			Me.iNew.Name = "iNew"
			' 
			' iTemplate
			' 
			Me.iTemplate.Caption = "Template..."
			Me.iTemplate.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iTemplate.Description = "Creates a new template"
			Me.iTemplate.Enabled = False
			Me.iTemplate.Hint = "Creates a new template"
			Me.iTemplate.Id = 1
			Me.iTemplate.ImageIndex = 6
			Me.iTemplate.Name = "iTemplate"
			' 
			' iOpen
			' 
			Me.iOpen.Caption = "&Open..."
			Me.iOpen.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iOpen.Description = "Opens a file."
			Me.iOpen.Hint = "Open a file"
			Me.iOpen.Id = 1
			Me.iOpen.ImageIndex = 7
			Me.iOpen.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
			Me.iOpen.LargeImageIndex = 9
			Me.iOpen.Name = "iOpen"
			Me.iOpen.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
			' 
			' sbiSave
			' 
			Me.sbiSave.Caption = "Save"
			Me.sbiSave.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.sbiSave.Description = "Saves the active document"
			Me.sbiSave.Hint = "Saves the active document"
			Me.sbiSave.Id = 0
			Me.sbiSave.ImageIndex = 10
			Me.sbiSave.LargeImageIndex = 2
			Me.sbiSave.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iSave), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveAs)})
			Me.sbiSave.Name = "sbiSave"
			' 
			' iSave
			' 
			Me.iSave.Caption = "&Save"
			Me.iSave.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iSave.Description = "Saves the active document with its current file name."
			Me.iSave.Hint = "Saves the active document with its current file name"
			Me.iSave.Id = 3
			Me.iSave.ImageIndex = 10
			Me.iSave.LargeImageIndex = 7
			Me.iSave.Name = "iSave"
			Me.iSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' iSaveAs
			' 
			Me.iSaveAs.Caption = "Save &As..."
			Me.iSaveAs.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iSaveAs.Description = "Saves the active document with a different file name."
			Me.iSaveAs.Hint = "Saves the active document with a different file name"
			Me.iSaveAs.Id = 4
			Me.iSaveAs.ImageIndex = 21
			Me.iSaveAs.LargeImageIndex = 2
			Me.iSaveAs.Name = "iSaveAs"
			' 
			' iPrint
			' 
			Me.iPrint.Caption = "&Print"
			Me.iPrint.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iPrint.Description = "Prints the active document."
			Me.iPrint.Hint = "Prints the active document"
			Me.iPrint.Id = 5
			Me.iPrint.ImageIndex = 9
			Me.iPrint.LargeImageIndex = 6
			Me.iPrint.Name = "iPrint"
			Me.iPrint.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
			' 
			' iClose
			' 
			Me.iClose.Caption = "&Close"
			Me.iClose.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iClose.Description = "Closes the active document."
			Me.iClose.Hint = "Closes the active document"
			Me.iClose.Id = 2
			Me.iClose.ImageIndex = 12
			Me.iClose.LargeImageIndex = 8
			Me.iClose.Name = "iClose"
			Me.iClose.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
			' 
			' iExit
			' 
			Me.iExit.Caption = "E&xit"
			Me.iExit.CategoryGuid = New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")
			Me.iExit.Description = "Closes this program after prompting you to save unsaved document."
			Me.iExit.Hint = "Closes this program after prompting you to save unsaved document."
			Me.iExit.Id = 6
			Me.iExit.ImageIndex = 22
			Me.iExit.LargeImageIndex = 1
			Me.iExit.Name = "iExit"
			' 
			' pccAppMenu
			' 
			Me.pccAppMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pccAppMenu.Controls.Add(Me.pcAppMenuFileLabels)
			Me.pccAppMenu.Controls.Add(Me.labelControl1)
			Me.pccAppMenu.Controls.Add(Me.panelControl1)
			Me.pccAppMenu.Location = New System.Drawing.Point(196, 241)
			Me.pccAppMenu.Name = "pccAppMenu"
			Me.pccAppMenu.Ribbon = Me.ribbonControl1
			Me.pccAppMenu.Size = New System.Drawing.Size(310, 162)
			Me.pccAppMenu.TabIndex = 9
			Me.pccAppMenu.Visible = False
			' 
			' pcAppMenuFileLabels
			' 
			Me.pcAppMenuFileLabels.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcAppMenuFileLabels.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pcAppMenuFileLabels.Location = New System.Drawing.Point(10, 19)
			Me.pcAppMenuFileLabels.Name = "pcAppMenuFileLabels"
			Me.pcAppMenuFileLabels.Size = New System.Drawing.Size(300, 143)
			Me.pcAppMenuFileLabels.TabIndex = 2
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl1.Appearance.Options.UseFont = True
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
			Me.labelControl1.LineVisible = True
			Me.labelControl1.Location = New System.Drawing.Point(10, 0)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(300, 19)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Recent Documents:"
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(10, 162)
			Me.panelControl1.TabIndex = 1
			' 
			' imageCollection2
			' 
			Me.imageCollection2.ImageStream = (CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' iUndo
			' 
			Me.iUndo.Caption = "&Undo"
			Me.iUndo.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iUndo.Description = "Reverses the last command or deletes the last entry you typed."
			Me.iUndo.Hint = "Undo"
			Me.iUndo.Id = 8
			Me.iUndo.ImageIndex = 11
			Me.iUndo.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
			Me.iUndo.Name = "iUndo"
			' 
			' iReplace
			' 
			Me.iReplace.Caption = "R&eplace..."
			Me.iReplace.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iReplace.Description = "Searches for and replaces the specified text."
			Me.iReplace.Hint = "Replace"
			Me.iReplace.Id = 15
			Me.iReplace.ImageIndex = 14
			Me.iReplace.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H))
			Me.iReplace.Name = "iReplace"
			' 
			' iCut
			' 
			Me.iCut.Caption = "Cu&t"
			Me.iCut.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iCut.Description = "Removes the selection from the active document and places it on the Clipboard."
			Me.iCut.Hint = "Cut"
			Me.iCut.Id = 9
			Me.iCut.ImageIndex = 2
			Me.iCut.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
			Me.iCut.Name = "iCut"
			' 
			' iCopy
			' 
			Me.iCopy.Caption = "&Copy"
			Me.iCopy.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iCopy.Description = "Copies the selection to the Clipboard."
			Me.iCopy.Hint = "Copy"
			Me.iCopy.Id = 10
			Me.iCopy.ImageIndex = 1
			Me.iCopy.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
			Me.iCopy.Name = "iCopy"
			' 
			' iPaste
			' 
			Me.iPaste.Caption = "&Paste"
			Me.iPaste.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iPaste.Description = "Inserts the contents of the Clipboard at the insertion point, and replaces any se" & "lection. This command is available only if you have cut or copied a text."
			Me.iPaste.Hint = "Paste"
			Me.iPaste.Id = 11
			Me.iPaste.ImageIndex = 8
			Me.iPaste.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
			Me.iPaste.Name = "iPaste"
			' 
			' iClear
			' 
			Me.iClear.Caption = "Cle&ar"
			Me.iClear.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iClear.Description = "Deletes the selected text without putting it on the Clipboard. This command is av" & "ailable only if a text is selected. "
			Me.iClear.Hint = "Clear"
			Me.iClear.Id = 12
			Me.iClear.ImageIndex = 13
			Me.iClear.Name = "iClear"
			' 
			' iSelectAll
			' 
			Me.iSelectAll.Caption = "Select A&ll"
			Me.iSelectAll.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iSelectAll.Description = "Selects all text in the active document."
			Me.iSelectAll.Hint = "Selects all text in the active document."
			Me.iSelectAll.Id = 13
			Me.iSelectAll.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A))
			Me.iSelectAll.Name = "iSelectAll"
			' 
			' iFind
			' 
			Me.iFind.Caption = "&Find..."
			Me.iFind.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iFind.Description = "Searches for the specified text."
			Me.iFind.Hint = "Find"
			Me.iFind.Id = 14
			Me.iFind.ImageIndex = 3
			Me.iFind.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
			Me.iFind.Name = "iFind"
			' 
			' iFont
			' 
			Me.iFont.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.iFont.Caption = "&Font..."
			Me.iFont.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iFont.Description = "Changes the font and character spacing formats of the selected text."
			Me.iFont.DropDownControl = Me.gddFont
			Me.iFont.Hint = "Font Dialog"
			Me.iFont.Id = 17
			Me.iFont.ImageIndex = 4
			Me.iFont.Name = "iFont"
			Me.iFont.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' gddFont
			' 
			' 
			' 
			' 
			Me.gddFont.Gallery.Appearance.ItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.gddFont.Gallery.Appearance.ItemCaption.Options.UseFont = True
			Me.gddFont.Gallery.Appearance.ItemCaption.Options.UseTextOptions = True
			Me.gddFont.Gallery.Appearance.ItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.gddFont.Gallery.Appearance.ItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.gddFont.Gallery.Appearance.ItemDescription.Options.UseTextOptions = True
			Me.gddFont.Gallery.Appearance.ItemDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.gddFont.Gallery.Appearance.ItemDescription.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.gddFont.Gallery.ColumnCount = 1
			Me.gddFont.Gallery.FixedImageSize = False
			galleryItemGroup4.Caption = "Main"
			Me.gddFont.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup4})
			Me.gddFont.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			Me.gddFont.Gallery.RowCount = 6
			Me.gddFont.Gallery.ShowGroupCaption = False
			Me.gddFont.Gallery.ShowItemText = True
			Me.gddFont.Gallery.SizeMode = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
			Me.gddFont.ItemLinks.Add(Me.beiFontSize)
			Me.gddFont.ItemLinks.Add(Me.bbiFontColorPopup)
			Me.gddFont.Name = "gddFont"
			Me.gddFont.Ribbon = Me.ribbonControl1
			' 
			' beiFontSize
			' 
			Me.beiFontSize.Caption = "Font Size"
			Me.beiFontSize.Edit = Me.repositoryItemSpinEdit1
			Me.beiFontSize.Hint = "Font Size"
			Me.beiFontSize.Id = 27
			Me.beiFontSize.Name = "beiFontSize"
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() { 6, 0, 0, 0})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			Me.repositoryItemSpinEdit1.UseParentBackground = True
			' 
			' bbiFontColorPopup
			' 
			Me.bbiFontColorPopup.ActAsDropDown = True
			Me.bbiFontColorPopup.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.bbiFontColorPopup.Caption = "Font Color"
			Me.bbiFontColorPopup.Description = "Formats the selected text with the color you click"
			Me.bbiFontColorPopup.DropDownControl = Me.popupControlContainer1
			Me.bbiFontColorPopup.Hint = "Formats the selected text with the color you click"
			Me.bbiFontColorPopup.Id = 36
			Me.bbiFontColorPopup.Name = "bbiFontColorPopup"
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.popupControlContainer1.Location = New System.Drawing.Point(-64, 0)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(0, 0)
			Me.popupControlContainer1.TabIndex = 10
			Me.popupControlContainer1.Visible = False
			' 
			' iBullets
			' 
			Me.iBullets.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iBullets.Caption = "&Bullets"
			Me.iBullets.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iBullets.Description = "Adds bullets to or removes bullets from selected paragraphs."
			Me.iBullets.Hint = "Bullets"
			Me.iBullets.Id = 18
			Me.iBullets.ImageIndex = 0
			Me.iBullets.Name = "iBullets"
			' 
			' iProtected
			' 
			Me.iProtected.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iProtected.Caption = "P&rotected"
			Me.iProtected.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iProtected.Description = "Protects the selected text."
			Me.iProtected.Hint = "Protects the selected text"
			Me.iProtected.Id = 19
			Me.iProtected.Name = "iProtected"
			' 
			' iWeb
			' 
			Me.iWeb.Caption = "&Developer Express on the Web"
			Me.iWeb.CategoryGuid = New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")
			Me.iWeb.Description = "Opens the web page."
			Me.iWeb.Hint = "Developer Express on the Web"
			Me.iWeb.Id = 21
			Me.iWeb.ImageIndex = 24
			Me.iWeb.Name = "iWeb"
			' 
			' iAbout
			' 
			Me.iAbout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.iAbout.Caption = "&About"
			Me.iAbout.CategoryGuid = New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")
			Me.iAbout.Description = "Displays the description of this program."
			Me.iAbout.Hint = "Displays the About dialog"
			Me.iAbout.Id = 22
			Me.iAbout.ImageIndex = 28
			Me.iAbout.Name = "iAbout"
			' 
			' iBold
			' 
			Me.iBold.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iBold.Caption = "&Bold"
			Me.iBold.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iBold.Description = "Makes selected text and numbers bold. If the selection is already bold, clicking " & "button removes bold formatting."
			Me.iBold.Hint = "Bold"
			Me.iBold.Id = 24
			Me.iBold.ImageIndex = 15
			Me.iBold.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
			Me.iBold.Name = "iBold"
			' 
			' iItalic
			' 
			Me.iItalic.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iItalic.Caption = "&Italic"
			Me.iItalic.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iItalic.Description = "Makes selected text and numbers italic. If the selection is already italic, click" & "ing button removes italic formatting."
			Me.iItalic.Hint = "Italic"
			Me.iItalic.Id = 25
			Me.iItalic.ImageIndex = 16
			Me.iItalic.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
			Me.iItalic.Name = "iItalic"
			' 
			' iUnderline
			' 
			Me.iUnderline.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iUnderline.Caption = "&Underline"
			Me.iUnderline.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iUnderline.Description = "Underlines selected text and numbers. If the selection is already underlined, cli" & "cking button removes underlining."
			Me.iUnderline.Hint = "Underline"
			Me.iUnderline.Id = 26
			Me.iUnderline.ImageIndex = 17
			Me.iUnderline.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
			Me.iUnderline.Name = "iUnderline"
			' 
			' iAlignLeft
			' 
			Me.iAlignLeft.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iAlignLeft.Caption = "Align &Left"
			Me.iAlignLeft.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iAlignLeft.Description = "Aligns the selected text to the left."
			Me.iAlignLeft.GroupIndex = 1
			Me.iAlignLeft.Hint = "Align Left"
			Me.iAlignLeft.Id = 27
			Me.iAlignLeft.ImageIndex = 18
			Me.iAlignLeft.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L))
			Me.iAlignLeft.Name = "iAlignLeft"
			' 
			' iCenter
			' 
			Me.iCenter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iCenter.Caption = "&Center"
			Me.iCenter.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iCenter.Description = "Centers the selected text."
			Me.iCenter.GroupIndex = 1
			Me.iCenter.Hint = "Center"
			Me.iCenter.Id = 28
			Me.iCenter.ImageIndex = 19
			Me.iCenter.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
			Me.iCenter.Name = "iCenter"
			' 
			' iAlignRight
			' 
			Me.iAlignRight.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.iAlignRight.Caption = "Align &Right"
			Me.iAlignRight.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iAlignRight.Description = "Aligns the selected text to the right."
			Me.iAlignRight.GroupIndex = 1
			Me.iAlignRight.Hint = "Align Right"
			Me.iAlignRight.Id = 29
			Me.iAlignRight.ImageIndex = 20
			Me.iAlignRight.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
			Me.iAlignRight.Name = "iAlignRight"
			' 
			' iFontColor
			' 
			Me.iFontColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.iFontColor.Caption = "Font C&olor"
			Me.iFontColor.CategoryGuid = New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")
			Me.iFontColor.Description = "Formats the selected text with the color you click."
			Me.iFontColor.DropDownControl = Me.gddFontColor
			Me.iFontColor.Hint = "Font Color"
			Me.iFontColor.Id = 30
			Me.iFontColor.ImageIndex = 5
			Me.iFontColor.Name = "iFontColor"
			' 
			' siPosition
			' 
			Me.siPosition.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
			Me.siPosition.Id = 0
			Me.siPosition.Name = "siPosition"
			' 
			' siModified
			' 
			Me.siModified.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
			Me.siModified.Id = 1
			Me.siModified.ImageIndex = 27
			Me.siModified.Name = "siModified"
			' 
			' siDocName
			' 
			Me.siDocName.CategoryGuid = New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")
			Me.siDocName.Id = 2
			Me.siDocName.Name = "siDocName"
			Me.siDocName.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' bgFontStyle
			' 
			Me.bgFontStyle.Caption = "FontStyle"
			Me.bgFontStyle.Id = 0
			Me.bgFontStyle.ItemLinks.Add(Me.iBold)
			Me.bgFontStyle.ItemLinks.Add(Me.iItalic)
			Me.bgFontStyle.ItemLinks.Add(Me.iUnderline)
			Me.bgFontStyle.Name = "bgFontStyle"
			' 
			' bgAlign
			' 
			Me.bgAlign.Caption = "Align"
			Me.bgAlign.Id = 0
			Me.bgAlign.ItemLinks.Add(Me.iAlignLeft)
			Me.bgAlign.ItemLinks.Add(Me.iCenter)
			Me.bgAlign.ItemLinks.Add(Me.iAlignRight)
			Me.bgAlign.Name = "bgAlign"
			' 
			' bgFont
			' 
			Me.bgFont.Caption = "Font"
			Me.bgFont.Id = 0
			Me.bgFont.ItemLinks.Add(Me.iFont)
			Me.bgFont.ItemLinks.Add(Me.iFontColor)
			Me.bgFont.Name = "bgFont"
			' 
			' bgBullets
			' 
			Me.bgBullets.Caption = "Bullets"
			Me.bgBullets.Id = 1
			Me.bgBullets.ItemLinks.Add(Me.iBullets)
			Me.bgBullets.ItemLinks.Add(Me.iProtected)
			Me.bgBullets.Name = "bgBullets"
			' 
			' sbiPaste
			' 
			Me.sbiPaste.Caption = "Paste"
			Me.sbiPaste.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.sbiPaste.Description = "Inserts the contents of the Clipboard at the insertion point"
			Me.sbiPaste.Hint = "Inserts the contents of the Clipboard at the insertion point"
			Me.sbiPaste.Id = 1
			Me.sbiPaste.ImageIndex = 8
			Me.sbiPaste.LargeImageIndex = 3
			Me.sbiPaste.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iPaste), New DevExpress.XtraBars.LinkPersistInfo(Me.iPasteSpecial)})
			Me.sbiPaste.Name = "sbiPaste"
			' 
			' iPasteSpecial
			' 
			Me.iPasteSpecial.Caption = "Paste &Special..."
			Me.iPasteSpecial.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iPasteSpecial.Description = "Opens the Paste Special dialog"
			Me.iPasteSpecial.Enabled = False
			Me.iPasteSpecial.Hint = "Opens the Paste Special dialog"
			Me.iPasteSpecial.Id = 3
			Me.iPasteSpecial.ImageIndex = 8
			Me.iPasteSpecial.Name = "iPasteSpecial"
			' 
			' sbiFind
			' 
			Me.sbiFind.Caption = "Find"
			Me.sbiFind.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.sbiFind.Description = "Searches for the specified text"
			Me.sbiFind.Hint = "Searches for the specified text"
			Me.sbiFind.Id = 2
			Me.sbiFind.ImageIndex = 3
			Me.sbiFind.LargeImageIndex = 4
			Me.sbiFind.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iFind), New DevExpress.XtraBars.LinkPersistInfo(Me.iReplace)})
			Me.sbiFind.Name = "sbiFind"
			Me.sbiFind.RibbonStyle = (CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
			' 
			' iLargeUndo
			' 
			Me.iLargeUndo.Caption = "&Undo"
			Me.iLargeUndo.CategoryGuid = New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")
			Me.iLargeUndo.Hint = "Undo"
			Me.iLargeUndo.Id = 0
			Me.iLargeUndo.ImageIndex = 11
			Me.iLargeUndo.LargeImageIndex = 5
			Me.iLargeUndo.Name = "iLargeUndo"
			' 
			' iPaintStyle
			' 
			Me.iPaintStyle.Caption = "Paint style"
			Me.iPaintStyle.Description = "Select a paint scheme"
			Me.iPaintStyle.Hint = "Select a paint scheme"
			Me.iPaintStyle.Id = 7
			Me.iPaintStyle.ImageIndex = 26
			Me.iPaintStyle.Name = "iPaintStyle"
			' 
			' rgbiSkins
			' 
			Me.rgbiSkins.Caption = "Skins"
			' 
			' 
			' 
			Me.rgbiSkins.Gallery.AllowHoverImages = True
			Me.rgbiSkins.Gallery.Appearance.ItemCaption.Options.UseFont = True
			Me.rgbiSkins.Gallery.Appearance.ItemCaption.Options.UseTextOptions = True
			Me.rgbiSkins.Gallery.Appearance.ItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiSkins.Gallery.ColumnCount = 4
			Me.rgbiSkins.Gallery.FixedHoverImageSize = False
			galleryItemGroup5.Caption = "Main Skins"
			galleryItemGroup6.Caption = "Office Skins"
			Me.rgbiSkins.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup5, galleryItemGroup6})
			Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
			Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
			Me.rgbiSkins.Gallery.RowCount = 4
			Me.rgbiSkins.Id = 13
			Me.rgbiSkins.Name = "rgbiSkins"
			' 
			' rgbiFont
			' 
			Me.rgbiFont.Caption = "Font"
			' 
			' 
			' 
			Me.rgbiFont.Gallery.AllowHoverImages = True
			galleryItemGroup7.Caption = "Main"
			Me.rgbiFont.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup7})
			Me.rgbiFont.GalleryDropDown = Me.gddFont
			Me.rgbiFont.Id = 29
			Me.rgbiFont.Name = "rgbiFont"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.barEditItem1.CanOpenEdit = False
			Me.barEditItem1.Edit = Me.repositoryItemPictureEdit1
			Me.barEditItem1.Id = 94
			Me.barEditItem1.Name = "barEditItem1"
			Me.barEditItem1.Width = 130
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.AllowFocused = False
			Me.repositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.UseParentBackground = True
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 106
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' ribbonPageCategory1
			' 
			Me.ribbonPageCategory1.Name = "ribbonPageCategory1"
			Me.ribbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage4})
			Me.ribbonPageCategory1.Text = "Selection"
			' 
			' ribbonPage4
			' 
			Me.ribbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup12, Me.ribbonPageGroup13})
			Me.ribbonPage4.Name = "ribbonPage4"
			Me.ribbonPage4.Text = "Selection"
			' 
			' ribbonPageGroup12
			' 
			Me.ribbonPageGroup12.ItemLinks.Add(Me.sbiPaste)
			Me.ribbonPageGroup12.ItemLinks.Add(Me.iCut, True)
			Me.ribbonPageGroup12.ItemLinks.Add(Me.iCopy)
			Me.ribbonPageGroup12.ItemLinks.Add(Me.iClear)
			Me.ribbonPageGroup12.Name = "ribbonPageGroup12"
			Me.ribbonPageGroup12.Text = "Edit"
			' 
			' ribbonPageGroup13
			' 
			Me.ribbonPageGroup13.ItemLinks.Add(Me.iBold)
			Me.ribbonPageGroup13.ItemLinks.Add(Me.iItalic)
			Me.ribbonPageGroup13.ItemLinks.Add(Me.iUnderline)
			Me.ribbonPageGroup13.ItemLinks.Add(Me.rgbiFont)
			Me.ribbonPageGroup13.ItemLinks.Add(Me.rgbiFontColor)
			Me.ribbonPageGroup13.Name = "ribbonPageGroup13"
			Me.ribbonPageGroup13.Text = "Format"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup10, Me.ribbonPageGroup4, Me.ribbonPageGroup9})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Home"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ImageIndex = 1
			Me.ribbonPageGroup1.ItemLinks.Add(Me.idNew)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.iOpen)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.iClose)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.iPrint)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.sbiSave, True)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			toolTipTitleItem1.Text = "Open File Dialog"
			toolTipItem1.Text = "Show the Open file dialog box"
			toolTipTitleItem2.Text = "For more information see help"
			superToolTip1.Items.Add(toolTipTitleItem1)
			superToolTip1.Items.Add(toolTipItem1)
			superToolTip1.Items.Add(toolTipSeparatorItem1)
			superToolTip1.Items.Add(toolTipTitleItem2)
			Me.ribbonPageGroup1.SuperTip = superToolTip1
			Me.ribbonPageGroup1.Text = "File"
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.ImageIndex = 2
			Me.ribbonPageGroup2.ItemLinks.Add(Me.sbiPaste)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.iCut)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.iCopy)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.iClear)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.iUndo, True)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.iSelectAll)
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			toolTipTitleItem3.Text = "Edit Popup Menu"
			toolTipItem2.Text = "Show the Edit popup menu"
			superToolTip2.Items.Add(toolTipTitleItem3)
			superToolTip2.Items.Add(toolTipItem2)
			Me.ribbonPageGroup2.SuperTip = superToolTip2
			Me.ribbonPageGroup2.Text = "Edit"
			' 
			' ribbonPageGroup3
			' 
			Me.ribbonPageGroup3.ImageIndex = 26
			Me.ribbonPageGroup3.ItemLinks.Add(Me.bgFontStyle)
			Me.ribbonPageGroup3.ItemLinks.Add(Me.bgFont)
			Me.ribbonPageGroup3.ItemLinks.Add(Me.bgBullets)
			Me.ribbonPageGroup3.ItemLinks.Add(Me.bgAlign)
			Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
			Me.ribbonPageGroup3.ShowCaptionButton = False
			Me.ribbonPageGroup3.Text = "Format"
			' 
			' ribbonPageGroup10
			' 
			Me.ribbonPageGroup10.ItemLinks.Add(Me.rgbiSkins)
			Me.ribbonPageGroup10.Name = "ribbonPageGroup10"
			Me.ribbonPageGroup10.ShowCaptionButton = False
			Me.ribbonPageGroup10.Text = "Skins"
			' 
			' ribbonPageGroup4
			' 
			Me.ribbonPageGroup4.ImageIndex = 3
			Me.ribbonPageGroup4.ItemLinks.Add(Me.sbiFind)
			Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
			Me.ribbonPageGroup4.ShowCaptionButton = False
			Me.ribbonPageGroup4.Text = "Find"
			' 
			' ribbonPageGroup9
			' 
			Me.ribbonPageGroup9.ImageIndex = 22
			Me.ribbonPageGroup9.ItemLinks.Add(Me.iExit)
			Me.ribbonPageGroup9.Name = "ribbonPageGroup9"
			toolTipTitleItem4.Text = "Save File Dialog"
			toolTipItem3.Text = "Show the Save file dialog box"
			superToolTip3.Items.Add(toolTipTitleItem4)
			superToolTip3.Items.Add(toolTipItem3)
			Me.ribbonPageGroup9.SuperTip = superToolTip3
			Me.ribbonPageGroup9.Text = "Exit"
			' 
			' ribbonPage2
			' 
			Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup5, Me.ribbonPageGroup6, Me.ribbonPageGroup7, Me.ribbonPageGroup8})
			Me.ribbonPage2.Name = "ribbonPage2"
			Me.ribbonPage2.Text = "Alternative Page"
			' 
			' ribbonPageGroup5
			' 
			Me.ribbonPageGroup5.ImageIndex = 1
			Me.ribbonPageGroup5.ItemLinks.Add(Me.idNew)
			Me.ribbonPageGroup5.ItemLinks.Add(Me.iOpen)
			Me.ribbonPageGroup5.ItemLinks.Add(Me.iSave)
			Me.ribbonPageGroup5.ItemLinks.Add(Me.iPrint)
			Me.ribbonPageGroup5.ItemLinks.Add(Me.iCut, True)
			Me.ribbonPageGroup5.ItemLinks.Add(Me.iCopy)
			Me.ribbonPageGroup5.ItemLinks.Add(Me.iPaste)
			Me.ribbonPageGroup5.ItemLinks.Add(Me.iLargeUndo)
			Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
			Me.ribbonPageGroup5.ShowCaptionButton = False
			Me.ribbonPageGroup5.Text = "Standard"
			' 
			' ribbonPageGroup6
			' 
			Me.ribbonPageGroup6.ImageIndex = 26
			Me.ribbonPageGroup6.ItemLinks.Add(Me.iBold)
			Me.ribbonPageGroup6.ItemLinks.Add(Me.iItalic)
			Me.ribbonPageGroup6.ItemLinks.Add(Me.iUnderline)
			Me.ribbonPageGroup6.ItemLinks.Add(Me.iAlignLeft, True)
			Me.ribbonPageGroup6.ItemLinks.Add(Me.iCenter)
			Me.ribbonPageGroup6.ItemLinks.Add(Me.iAlignRight)
			Me.ribbonPageGroup6.ItemLinks.Add(Me.iBullets, True)
			Me.ribbonPageGroup6.ItemLinks.Add(Me.iProtected)
			Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
			Me.ribbonPageGroup6.ShowCaptionButton = False
			Me.ribbonPageGroup6.Text = "Format"
			' 
			' ribbonPageGroup7
			' 
			Me.ribbonPageGroup7.ImageIndex = 4
			Me.ribbonPageGroup7.ItemLinks.Add(Me.iFont)
			Me.ribbonPageGroup7.ItemLinks.Add(Me.iFontColor)
			Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
			Me.ribbonPageGroup7.ShowCaptionButton = False
			Me.ribbonPageGroup7.Text = "Font"
			' 
			' ribbonPageGroup8
			' 
			Me.ribbonPageGroup8.ImageIndex = 25
			Me.ribbonPageGroup8.ItemLinks.Add(Me.iWeb)
			Me.ribbonPageGroup8.ItemLinks.Add(Me.iAbout)
			Me.ribbonPageGroup8.Name = "ribbonPageGroup8"
			Me.ribbonPageGroup8.ShowCaptionButton = False
			Me.ribbonPageGroup8.Text = "Help"
			' 
			' ribbonPage3
			' 
			Me.ribbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup11, Me.rpgFont, Me.rpgFontColor})
			Me.ribbonPage3.Name = "ribbonPage3"
			Me.ribbonPage3.Text = "Gallery Page"
			' 
			' ribbonPageGroup11
			' 
			Me.ribbonPageGroup11.ItemLinks.Add(Me.rgbiSkins)
			Me.ribbonPageGroup11.Name = "ribbonPageGroup11"
			Me.ribbonPageGroup11.ShowCaptionButton = False
			Me.ribbonPageGroup11.Text = "Skins"
			' 
			' rpgFont
			' 
			Me.rpgFont.ItemLinks.Add(Me.rgbiFont)
			Me.rpgFont.Name = "rpgFont"
			toolTipTitleItem5.Text = "Font Dialog"
			toolTipItem4.Text = "Show the Font dialog box"
			superToolTip4.Items.Add(toolTipTitleItem5)
			superToolTip4.Items.Add(toolTipItem4)
			Me.rpgFont.SuperTip = superToolTip4
			Me.rpgFont.Text = "Font"
			' 
			' rpgFontColor
			' 
			Me.rpgFontColor.ItemLinks.Add(Me.rgbiFontColor)
			Me.rpgFontColor.Name = "rpgFontColor"
			toolTipTitleItem6.Text = "Color Edit"
			toolTipItem5.Text = "Show the Color edit popup"
			superToolTip5.Items.Add(toolTipTitleItem6)
			superToolTip5.Items.Add(toolTipItem5)
			Me.rpgFontColor.SuperTip = superToolTip5
			Me.rpgFontColor.Text = "Font Color"
			' 
			' ribbonStatusBar1
			' 
			Me.ribbonStatusBar1.ItemLinks.Add(Me.siPosition)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.siModified, True)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.siDocName, True)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.barEditItem1)
			Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 426)
			Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
			Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
			Me.ribbonStatusBar1.Size = New System.Drawing.Size(890, 23)
			' 
			' pmMain
			' 
			Me.pmMain.ItemLinks.Add(Me.iUndo)
			Me.pmMain.ItemLinks.Add(Me.iCopy, True)
			Me.pmMain.ItemLinks.Add(Me.iCut)
			Me.pmMain.ItemLinks.Add(Me.iPaste)
			Me.pmMain.ItemLinks.Add(Me.iClear)
			Me.pmMain.ItemLinks.Add(Me.iSelectAll)
			Me.pmMain.ItemLinks.Add(Me.iFont, True)
			Me.pmMain.ItemLinks.Add(Me.iBullets)
			Me.pmMain.MenuCaption = "Edit Menu"
			Me.pmMain.Name = "pmMain"
			Me.pmMain.Ribbon = Me.ribbonControl1
			Me.pmMain.ShowCaption = True
			' 
			' xtraTabbedMdiManager1
			' 
			Me.xtraTabbedMdiManager1.MdiParent = Nothing
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Black"
			' 
			' imageCollection3
			' 
			Me.imageCollection3.ImageSize = New System.Drawing.Size(15, 15)
			Me.imageCollection3.ImageStream = (CType(resources.GetObject("imageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' RibbonForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(890, 449)
			Me.Controls.Add(Me.ribbonStatusBar1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Controls.Add(Me.popupControlContainer1)
			Me.Controls.Add(Me.pccAppMenu)
			Me.Name = "RibbonForm1"
			Me.Ribbon = Me.ribbonControl1
			Me.StatusBar = Me.ribbonStatusBar1
			Me.Text = "RibbonForm1"
'			Me.Load += New System.EventHandler(Me.RibbonForm1_Load);
			CType(Me.gddFontColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pmAppMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pmNew, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pccAppMenu, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pccAppMenu.ResumeLayout(False)
			CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gddFont, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pmMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private rgbiFontColor As DevExpress.XtraBars.RibbonGalleryBarItem
		Private gddFontColor As DevExpress.XtraBars.Ribbon.GalleryDropDown
		Private WithEvents ribbonControl1 As MyRibbonControl
		Private pmAppMain As DevExpress.XtraBars.Ribbon.ApplicationMenu
		Private idNew As DevExpress.XtraBars.BarButtonItem
		Private pmNew As DevExpress.XtraBars.PopupMenu
		Private iNew As DevExpress.XtraBars.BarButtonItem
		Private iTemplate As DevExpress.XtraBars.BarButtonItem
		Private iOpen As DevExpress.XtraBars.BarButtonItem
		Private sbiSave As DevExpress.XtraBars.BarSubItem
		Private iSave As DevExpress.XtraBars.BarButtonItem
		Private iSaveAs As DevExpress.XtraBars.BarButtonItem
		Private iPrint As DevExpress.XtraBars.BarButtonItem
		Private iClose As DevExpress.XtraBars.BarButtonItem
		Private iExit As DevExpress.XtraBars.BarButtonItem
		Private pccAppMenu As DevExpress.XtraBars.PopupControlContainer
		Private pcAppMenuFileLabels As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private imageCollection2 As DevExpress.Utils.ImageCollection
		Private iUndo As DevExpress.XtraBars.BarButtonItem
		Private iReplace As DevExpress.XtraBars.BarButtonItem
		Private iCut As DevExpress.XtraBars.BarButtonItem
		Private iCopy As DevExpress.XtraBars.BarButtonItem
		Private iPaste As DevExpress.XtraBars.BarButtonItem
		Private iClear As DevExpress.XtraBars.BarButtonItem
		Private iSelectAll As DevExpress.XtraBars.BarButtonItem
		Private iFind As DevExpress.XtraBars.BarButtonItem
		Private iFont As DevExpress.XtraBars.BarButtonItem
		Private gddFont As DevExpress.XtraBars.Ribbon.GalleryDropDown
		Private beiFontSize As DevExpress.XtraBars.BarEditItem
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private bbiFontColorPopup As DevExpress.XtraBars.BarButtonItem
		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private iBullets As DevExpress.XtraBars.BarButtonItem
		Private iProtected As DevExpress.XtraBars.BarButtonItem
		Private iWeb As DevExpress.XtraBars.BarButtonItem
		Private iAbout As DevExpress.XtraBars.BarButtonItem
		Private iBold As DevExpress.XtraBars.BarButtonItem
		Private iItalic As DevExpress.XtraBars.BarButtonItem
		Private iUnderline As DevExpress.XtraBars.BarButtonItem
		Private iAlignLeft As DevExpress.XtraBars.BarButtonItem
		Private iCenter As DevExpress.XtraBars.BarButtonItem
		Private iAlignRight As DevExpress.XtraBars.BarButtonItem
		Private iFontColor As DevExpress.XtraBars.BarButtonItem
		Private siPosition As DevExpress.XtraBars.BarButtonItem
		Private siModified As DevExpress.XtraBars.BarButtonItem
		Private siDocName As DevExpress.XtraBars.BarStaticItem
		Private bgFontStyle As DevExpress.XtraBars.BarButtonGroup
		Private bgAlign As DevExpress.XtraBars.BarButtonGroup
		Private bgFont As DevExpress.XtraBars.BarButtonGroup
		Private bgBullets As DevExpress.XtraBars.BarButtonGroup
		Private sbiPaste As DevExpress.XtraBars.BarSubItem
		Private iPasteSpecial As DevExpress.XtraBars.BarButtonItem
		Private sbiFind As DevExpress.XtraBars.BarSubItem
		Private iLargeUndo As DevExpress.XtraBars.BarLargeButtonItem
		Private iPaintStyle As DevExpress.XtraBars.BarSubItem
		Private rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
		Private rgbiFont As DevExpress.XtraBars.RibbonGalleryBarItem
		Private barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private ribbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
		Private ribbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private rpgFont As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private rpgFontColor As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private pmMain As DevExpress.XtraBars.PopupMenu
		Private xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private imageCollection3 As DevExpress.Utils.ImageCollection

	End Class
End Namespace