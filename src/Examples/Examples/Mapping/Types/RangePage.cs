using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Mapping.Types
{
	public class RangePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line21()
		{
			// tag::2b371fbf0654d76436d49f5703d6c137[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::2b371fbf0654d76436d49f5703d6c137[]

			response0.MatchesExample(@"PUT range_index
			{
			  ""settings"": {
			    ""number_of_shards"": 2
			  },
			  ""mappings"": {
			    ""properties"": {
			      ""expected_attendees"": {
			        ""type"": ""integer_range""
			      },
			      ""time_frame"": {
			        ""type"": ""date_range"", \<1>
			        ""format"": ""yyyy-MM-dd HH:mm:ss||yyyy-MM-dd||epoch_millis""
			      }
			    }
			  }
			}");

			response1.MatchesExample(@"PUT range_index/_doc/1?refresh
			{
			  ""expected_attendees"" : { \<2>
			    ""gte"" : 10,
			    ""lte"" : 20
			  },
			  ""time_frame"" : { \<3>
			    ""gte"" : ""2015-10-31 12:00:00"", \<4>
			    ""lte"" : ""2015-11-01""
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line63()
		{
			// tag::84edb44c5b74426f448b2baa101092d6[]
			var response0 = new SearchResponse<object>();
			// end::84edb44c5b74426f448b2baa101092d6[]

			response0.MatchesExample(@"GET range_index/_search
			{
			  ""query"" : {
			    ""term"" : {
			      ""expected_attendees"" : {
			        ""value"": 12
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line120()
		{
			// tag::1572696b97822d3332be51700e09672f[]
			var response0 = new SearchResponse<object>();
			// end::1572696b97822d3332be51700e09672f[]

			response0.MatchesExample(@"GET range_index/_search
			{
			  ""query"" : {
			    ""range"" : {
			      ""time_frame"" : { \<1>
			        ""gte"" : ""2015-10-31"",
			        ""lte"" : ""2015-11-01"",
			        ""relation"" : ""within"" \<2>
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line187()
		{
			// tag::f894f680943a8af8328aab4741e6ab93[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::f894f680943a8af8328aab4741e6ab93[]

			response0.MatchesExample(@"PUT range_index/_mapping
			{
			  ""properties"": {
			    ""ip_whitelist"": {
			      ""type"": ""ip_range""
			    }
			  }
			}");

			response1.MatchesExample(@"PUT range_index/_doc/2
			{
			  ""ip_whitelist"" : ""192.168.0.0/16""
			}");
		}
	}
}