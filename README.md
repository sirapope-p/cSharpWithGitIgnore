﻿# cSharpWithGitIgnore

## คุณจำเป็นจะต้องสร้างไฟล์ App.config ดังนี้ และแก้ไขค่า config Database

```xml
<configuration>
	<configSections>
		
	</configSections>
 <connectionStrings>
  <add name="CsharpWithGitIgnore.Properties.Settings.strConn" connectionString="Data Source=Your DB Server;Initial Catalog=Your DB Name;Persist Security Info=True;User ID=Your User;Password=Your Password"
   providerName="System.Data.SqlClient" />
 </connectionStrings>
</configuration>
```
