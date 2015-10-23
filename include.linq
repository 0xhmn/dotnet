<Query Kind="Statements">
  <Connection>
    <ID>f713cc3b-c286-4c2d-a0cd-4460da0b2707</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>D:\GitHub\yar00001\AdmissionsApplicationWeb\OnlineApp\bin\CSOM.STS.DataAccess.dll</CustomAssemblyPath>
    <CustomTypeName>CSOM.STS.DataAccess.CSOMContext</CustomTypeName>
    <AppConfigPath>D:\GitHub\yar00001\AdmissionsApplicationWeb\OnlineApp\bin\OnlineApp.dll.config</AppConfigPath>
  </Connection>
  <Reference>D:\entityframework.6.1.3\lib\net45\EntityFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\mscorlib.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Core.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Data.Entity</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>

// doying queries for APPLICATION_ID == 8364846
// connected via CSOMContext in CSOM.STS.DataAccess.dll

var app = APPLICATIONS
			// .Where(a => a.APPLICATION_ID == 8364846)
			.Select(a => a);
			
			
// check the type
var type = app.GetType();
type.Dump();
app.Dump();