# SignalR Intro Project

Messages to send to the Hub
* {"protocol":"json","version":1} ,which establishes the protocol and truly begins the connection (OnConnectedAsync is triggered)

Invoke message on Hub from Client
* {"arguments":["My Test Message LOL"], "invocationId":"0","target": "SendMessage","type":1} , (after the first command) calls the SendMessage function on the Hub with argument "My Test Message LOL". InvocationId is simply an id for the invocation (calling) of a method (error checking and stuff). type specifies the type of action (e.g 1 = method invocation,3 = completion etc.)

- Hub is now strongly-typed meaning there are specific things that are exposed to the client now, not just random strings. (Check IChatClient interface)
Should be noted that the Hub has two types of functions
1. Client-invoked Methods: clients call these through requests.
2. Server-to-client methods: methods that are defined (most likely) on the IChatClient interface or whatever you have named it. Usually for sending notifications and such,obviously on the server ever sends these.