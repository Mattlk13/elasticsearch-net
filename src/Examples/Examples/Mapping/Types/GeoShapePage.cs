using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Mapping.Types
{
	public class GeoShapePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line219()
		{
			// tag::3fef996cf6795e881918ffedc273c642[]
			var response0 = new SearchResponse<object>();
			// end::3fef996cf6795e881918ffedc273c642[]

			response0.MatchesExample(@"PUT /example
			{
			    ""mappings"": {
			        ""properties"": {
			            ""location"": {
			                ""type"": ""geo_shape""
			            }
			        }
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line308()
		{
			// tag::f851d1be5d5e5fe5455ba81344d01133[]
			var response0 = new SearchResponse<object>();
			// end::f851d1be5d5e5fe5455ba81344d01133[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""point"",
			        ""coordinates"" : [-77.03653, 38.897676]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line322()
		{
			// tag::d673a2c008015ac6f754661ae336131c[]
			var response0 = new SearchResponse<object>();
			// end::d673a2c008015ac6f754661ae336131c[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : ""POINT (-77.03653 38.897676)""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line340()
		{
			// tag::21a9348800406e09b8bdaab192245096[]
			var response0 = new SearchResponse<object>();
			// end::21a9348800406e09b8bdaab192245096[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""linestring"",
			        ""coordinates"" : [[-77.03653, 38.897676], [-77.009051, 38.889939]]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line354()
		{
			// tag::48625e23b05d33977451cde7b98b634a[]
			var response0 = new SearchResponse<object>();
			// end::48625e23b05d33977451cde7b98b634a[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : ""LINESTRING (-77.03653 38.897676, -77.009051 38.889939)""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line374()
		{
			// tag::1d6ee162260a21f6e4597eadbea88650[]
			var response0 = new SearchResponse<object>();
			// end::1d6ee162260a21f6e4597eadbea88650[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""polygon"",
			        ""coordinates"" : [
			            [ [100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0], [100.0, 0.0] ]
			        ]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line390()
		{
			// tag::18c34a2c5820e330a125dfddf2624c69[]
			var response0 = new SearchResponse<object>();
			// end::18c34a2c5820e330a125dfddf2624c69[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : ""POLYGON ((100.0 0.0, 101.0 0.0, 101.0 1.0, 100.0 1.0, 100.0 0.0))""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line403()
		{
			// tag::f83e3ea198f6e87046aab2c5dea60d61[]
			var response0 = new SearchResponse<object>();
			// end::f83e3ea198f6e87046aab2c5dea60d61[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""polygon"",
			        ""coordinates"" : [
			            [ [100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0], [100.0, 0.0] ],
			            [ [100.2, 0.2], [100.8, 0.2], [100.8, 0.8], [100.2, 0.8], [100.2, 0.2] ]
			        ]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line420()
		{
			// tag::00eb71b03b73e605da6368041a64a8ad[]
			var response0 = new SearchResponse<object>();
			// end::00eb71b03b73e605da6368041a64a8ad[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : ""POLYGON ((100.0 0.0, 101.0 0.0, 101.0 1.0, 100.0 1.0, 100.0 0.0), (100.2 0.2, 100.8 0.2, 100.8 0.8, 100.2 0.8, 100.2 0.2))""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line448()
		{
			// tag::4c42c8835876a2271e7ba63d6bd3149f[]
			var response0 = new SearchResponse<object>();
			// end::4c42c8835876a2271e7ba63d6bd3149f[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""polygon"",
			        ""coordinates"" : [
			            [ [-177.0, 10.0], [176.0, 15.0], [172.0, 0.0], [176.0, -15.0], [-177.0, -10.0], [-177.0, 10.0] ],
			            [ [178.2, 8.2], [-178.8, 8.2], [-180.8, -8.8], [178.2, 8.8] ]
			        ]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line468()
		{
			// tag::60294ea29c96c432047d4fffcb3cc8b4[]
			var response0 = new SearchResponse<object>();
			// end::60294ea29c96c432047d4fffcb3cc8b4[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""polygon"",
			        ""orientation"" : ""clockwise"",
			        ""coordinates"" : [
			            [ [100.0, 0.0], [100.0, 1.0], [101.0, 1.0], [101.0, 0.0], [100.0, 0.0] ]
			        ]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line489()
		{
			// tag::2eca42af76c6ddc657fca3948f3865bd[]
			var response0 = new SearchResponse<object>();
			// end::2eca42af76c6ddc657fca3948f3865bd[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""multipoint"",
			        ""coordinates"" : [
			            [102.0, 2.0], [103.0, 2.0]
			        ]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line505()
		{
			// tag::f1e1f4f37194a899e7056d0782804790[]
			var response0 = new SearchResponse<object>();
			// end::f1e1f4f37194a899e7056d0782804790[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : ""MULTIPOINT (102.0 2.0, 103.0 2.0)""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line520()
		{
			// tag::c4ba19b62e87ed837dc6f1f9fe184244[]
			var response0 = new SearchResponse<object>();
			// end::c4ba19b62e87ed837dc6f1f9fe184244[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""multilinestring"",
			        ""coordinates"" : [
			            [ [102.0, 2.0], [103.0, 2.0], [103.0, 3.0], [102.0, 3.0] ],
			            [ [100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0] ],
			            [ [100.2, 0.2], [100.8, 0.2], [100.8, 0.8], [100.2, 0.8] ]
			        ]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line538()
		{
			// tag::117096e1830e7acedf38bd6a92a9c8b4[]
			var response0 = new SearchResponse<object>();
			// end::117096e1830e7acedf38bd6a92a9c8b4[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : ""MULTILINESTRING ((102.0 2.0, 103.0 2.0, 103.0 3.0, 102.0 3.0), (100.0 0.0, 101.0 0.0, 101.0 1.0, 100.0 1.0), (100.2 0.2, 100.8 0.2, 100.8 0.8, 100.2 0.8))""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line553()
		{
			// tag::4be91bb5ac3a1b83b767a060c58e0b12[]
			var response0 = new SearchResponse<object>();
			// end::4be91bb5ac3a1b83b767a060c58e0b12[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""multipolygon"",
			        ""coordinates"" : [
			            [ [[102.0, 2.0], [103.0, 2.0], [103.0, 3.0], [102.0, 3.0], [102.0, 2.0]] ],
			            [ [[100.0, 0.0], [101.0, 0.0], [101.0, 1.0], [100.0, 1.0], [100.0, 0.0]],
			              [[100.2, 0.2], [100.8, 0.2], [100.8, 0.8], [100.2, 0.8], [100.2, 0.2]] ]
			        ]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line571()
		{
			// tag::9290410340f0e66e67fa96aacc83bbdc[]
			var response0 = new SearchResponse<object>();
			// end::9290410340f0e66e67fa96aacc83bbdc[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : ""MULTIPOLYGON (((102.0 2.0, 103.0 2.0, 103.0 3.0, 102.0 3.0, 102.0 2.0)), ((100.0 0.0, 101.0 0.0, 101.0 1.0, 100.0 1.0, 100.0 0.0), (100.2 0.2, 100.8 0.2, 100.8 0.8, 100.2 0.8, 100.2 0.2)))""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line586()
		{
			// tag::a99750fb5d296fa8df97ee71a34c698c[]
			var response0 = new SearchResponse<object>();
			// end::a99750fb5d296fa8df97ee71a34c698c[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"": ""geometrycollection"",
			        ""geometries"": [
			            {
			                ""type"": ""point"",
			                ""coordinates"": [100.0, 0.0]
			            },
			            {
			                ""type"": ""linestring"",
			                ""coordinates"": [ [101.0, 0.0], [102.0, 1.0] ]
			            }
			        ]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line609()
		{
			// tag::71bb89f56d847b636a050c553c0cd0a7[]
			var response0 = new SearchResponse<object>();
			// end::71bb89f56d847b636a050c553c0cd0a7[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : ""GEOMETRYCOLLECTION (POINT (100.0 0.0), LINESTRING (101.0 0.0, 102.0 1.0))""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line626()
		{
			// tag::f893fffd649507119d0a9afd98a0cf87[]
			var response0 = new SearchResponse<object>();
			// end::f893fffd649507119d0a9afd98a0cf87[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""envelope"",
			        ""coordinates"" : [ [100.0, 1.0], [101.0, 0.0] ]
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line642()
		{
			// tag::65208190e9640cb4ca67271f1694814d[]
			var response0 = new SearchResponse<object>();
			// end::65208190e9640cb4ca67271f1694814d[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : ""BBOX (100.0, 102.0, 2.0, 0.0)""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line660()
		{
			// tag::76039c2fd422a6bb6340848cc0a78bbd[]
			var response0 = new SearchResponse<object>();
			// end::76039c2fd422a6bb6340848cc0a78bbd[]

			response0.MatchesExample(@"POST /example/_doc
			{
			    ""location"" : {
			        ""type"" : ""circle"",
			        ""coordinates"" : [101.0, 1.0],
			        ""radius"" : ""100m""
			    }
			}");
		}
	}
}