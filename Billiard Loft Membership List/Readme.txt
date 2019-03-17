Billard Loft Membership List V 1.2
By Connor McNamara

Installation Instructions
By default, the membership database connection string is still set to the working directory on my PC, but a copy of that database is included with
install. To successfully launch the application, you have to update the connection string to your local directory (this is a shitty way to do this
I'll try and fix it at some point)

To do that, navigate to: C:\Users\username\AppData\Local\Apps\2.0
In that folder, there should be a bunch of really messy-looking folders, the top two should be have Billiard Loft Membership List somewhere in the title.
Open the folder with the least amount of files, probably the first one. Open the BillardLoftMembershipList.exe.config file with notepad
Find this string:
<add name="MembersListEntities" connectionString="metadata=res://*/MembersListModel.csdl|res://*/MembersListModel.ssdl|res://*/MembersListModel.msl;provider=System.Data.SQLite.EF6;provider connection string=&quot;data source=D:\Code\Git\MembershipList\BilliardLoftMembershipList\MembersList.db&quot;" providerName="System.Data.EntityClient" />

change this portion: data source=D:\Code\Git\MembershipList\BilliardLoftMembershipList\
To the folder you are currently inside of. Make sure to leave MembersList.db at the end of the string.
Save and relaunch the application