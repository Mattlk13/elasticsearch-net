// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.SqlApi
{
	///<summary>Request options for ClearCursor <para>Clear SQL cursor</para></summary>
	public class ClearSqlCursorRequestParameters : RequestParameters<ClearSqlCursorRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for Query <para>Execute SQL</para></summary>
	public class QuerySqlRequestParameters : RequestParameters<QuerySqlRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public string Format
		{
			get => Q<string>("format");
			set => Q("format", value);
		}
	}

	///<summary>Request options for Translate <para>Translate SQL into Elasticsearch queries</para></summary>
	public class TranslateSqlRequestParameters : RequestParameters<TranslateSqlRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}
}