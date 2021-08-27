<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617732/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2468)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [CanMinimizePageGroupEventArgs.cs](./CS/WindowsApplication1/MyRibbonControl/CanMinimizePageGroupEventArgs.cs) (VB: [CanMinimizePageGroupEventArgs.vb](./VB/WindowsApplication1/MyRibbonControl/CanMinimizePageGroupEventArgs.vb))
* [MyRibbonControl.cs](./CS/WindowsApplication1/MyRibbonControl/MyRibbonControl.cs) (VB: [MyRibbonControl.vb](./VB/WindowsApplication1/MyRibbonControl/MyRibbonControl.vb))
* [MyRibbonPageGroupComplexLayoutCalculator.cs](./CS/WindowsApplication1/MyRibbonControl/MyRibbonPageGroupComplexLayoutCalculator.cs) (VB: [MyRibbonPageGroupComplexLayoutCalculator.vb](./VB/WindowsApplication1/MyRibbonControl/MyRibbonPageGroupComplexLayoutCalculator.vb))
* [MyRibbonViewInfo.cs](./CS/WindowsApplication1/MyRibbonControl/MyRibbonViewInfo.cs) (VB: [MyRibbonViewInfo.vb](./VB/WindowsApplication1/MyRibbonControl/MyRibbonViewInfo.vb))
* [RibbonForm1.cs](./CS/WindowsApplication1/RibbonForm1.cs) (VB: [RibbonForm1.vb](./VB/WindowsApplication1/RibbonForm1.vb))
<!-- default file list end -->
# How to specify priority for collapsing Ribbon groups


<p>This sample demonstrates how to make Ribbon page groups minimized in a user-defined order. To implement this a RibbonControl descendant with a CanMinimizePageGroup event was created. Every time the Ribbon control is going to minimize a page group, the CanMinimizePageGroup event is raised. In a handler of this event, you can implement your business logic to determine the order in which page groups should be minimized.</p>

<br/>


