<!-- default file list -->
*Files to look at*:

* [CanMinimizePageGroupEventArgs.cs](./CS/WindowsApplication1/MyRibbonControl/CanMinimizePageGroupEventArgs.cs) (VB: [CanMinimizePageGroupEventArgs.vb](./VB/WindowsApplication1/MyRibbonControl/CanMinimizePageGroupEventArgs.vb))
* [MyRibbonControl.cs](./CS/WindowsApplication1/MyRibbonControl/MyRibbonControl.cs) (VB: [MyRibbonControl.vb](./VB/WindowsApplication1/MyRibbonControl/MyRibbonControl.vb))
* [MyRibbonPageGroupComplexLayoutCalculator.cs](./CS/WindowsApplication1/MyRibbonControl/MyRibbonPageGroupComplexLayoutCalculator.cs) (VB: [MyRibbonPageGroupComplexLayoutCalculator.vb](./VB/WindowsApplication1/MyRibbonControl/MyRibbonPageGroupComplexLayoutCalculator.vb))
* [MyRibbonViewInfo.cs](./CS/WindowsApplication1/MyRibbonControl/MyRibbonViewInfo.cs) (VB: [MyRibbonViewInfo.vb](./VB/WindowsApplication1/MyRibbonControl/MyRibbonViewInfo.vb))
* [RibbonForm1.cs](./CS/WindowsApplication1/RibbonForm1.cs) (VB: [RibbonForm1.vb](./VB/WindowsApplication1/RibbonForm1.vb))
<!-- default file list end -->
# How to specify priority for collapsing Ribbon groups


<p>This sample demonstrates how to make Ribbon page groups minimized in a user-defined order. To implement this a RibbonControl descendant with a CanMinimizePageGroup event was created. Every time the Ribbon control is going to minimize a page group, the CanMinimizePageGroup event is raised. In a handler of this event, you can implement your business logic to determine the order in which page groups should be minimized.</p>

<br/>


