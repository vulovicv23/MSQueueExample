# MSQueueExample
Example of Building 2 CMD applications that communicate via Microsoft Messaging Queue using POJO Objects

# Steps

1. Go to Control Panel/Programs and Features/Turn Windows fetaures on or off

2. Find "Microsoft Message Queuq (MSMQ) Server" and inside it tick "Microsoft Message Queque (MSMQ) Server Core". Click Ok and install feature.

3. Clone project from here.

4. In order for project to work, you need to start both MSQue.ReaderApp and MSQue.SenderApp. In order to do that, right click on Solution node(root node) and select properties. In left view tree select Common Properties/Startup Project. Then on the right pane, select multiple startup projects and add Actions "Start" to both MSQue.ReaderApp and MSQue.SenderApp. Click Ok and start projects with F5.

5. In SenderApp, you type whatever you want, in ReaderApp, that will show.
