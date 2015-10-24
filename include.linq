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
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
  <Namespace>System.Collections</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Data.Entity</Namespace>
  <Namespace>System.Diagnostics</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>

// doying queries for APPLICATION_ID == 8364846
// connected via CSOMContext in CSOM.STS.DataAccess.dll

Stopwatch sw = Stopwatch.StartNew(); // get query result time


List<string> Available = new List<string>();

var personWintContactInfo = PEOPLE
			.Include("PHONENUMBERS")
			.Include("ADDRESSES")
			.FirstOrDefault(p => p.PERSON_ID == 500);

var test = PEOPLE
			.Include("APPLICATIONS")
			.FirstOrDefault(p => p.PERSON_ID == 500);
			
var app = APPLICATIONS.Find(8364846);	// will give you the application using key value
var t = app.PERSON_ID;					// will retuern the person id in app collection




personWintContactInfo.Dump();

TimeSpan elapsed = sw.Elapsed;
elapsed.Dump("Total Query Time:");

