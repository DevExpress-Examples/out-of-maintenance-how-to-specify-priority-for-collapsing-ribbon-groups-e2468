# How to specify priority for collapsing Ribbon groups


<p>This sample demonstrates how to make Ribbon page groups minimized in a user-defined order. To implement this a RibbonControl descendant with a CanMinimizePageGroup event was created. Every time the Ribbon control is going to minimize a page group, the CanMinimizePageGroup event is raised. In a handler of this event, you can implement your business logic to determine the order in which page groups should be minimized.</p>

<br/>


