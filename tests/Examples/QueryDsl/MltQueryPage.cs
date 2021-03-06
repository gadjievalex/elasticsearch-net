using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.QueryDsl
{
	public class MltQueryPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line19()
		{
			// tag::32db70e5e08349aa254788ab4a2c4a51[]
			var response0 = new SearchResponse<object>();
			// end::32db70e5e08349aa254788ab4a2c4a51[]

			response0.MatchesExample(@"GET /_search
			{
			    ""query"": {
			        ""more_like_this"" : {
			            ""fields"" : [""title"", ""description""],
			            ""like"" : ""Once upon a time"",
			            ""min_term_freq"" : 1,
			            ""max_query_terms"" : 12
			        }
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line38()
		{
			// tag::cba099b82792fa5ba7741d00483c2b47[]
			var response0 = new SearchResponse<object>();
			// end::cba099b82792fa5ba7741d00483c2b47[]

			response0.MatchesExample(@"GET /_search
			{
			    ""query"": {
			        ""more_like_this"" : {
			            ""fields"" : [""title"", ""description""],
			            ""like"" : [
			            {
			                ""_index"" : ""imdb"",
			                ""_id"" : ""1""
			            },
			            {
			                ""_index"" : ""imdb"",
			                ""_id"" : ""2""
			            },
			            ""and potentially some more text here as well""
			            ],
			            ""min_term_freq"" : 1,
			            ""max_query_terms"" : 12
			        }
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line67()
		{
			// tag::33f77a3b80f33323faa091538220de2a[]
			var response0 = new SearchResponse<object>();
			// end::33f77a3b80f33323faa091538220de2a[]

			response0.MatchesExample(@"GET /_search
			{
			    ""query"": {
			        ""more_like_this"" : {
			            ""fields"" : [""name.first"", ""name.last""],
			            ""like"" : [
			            {
			                ""_index"" : ""marvel"",
			                ""doc"" : {
			                    ""name"": {
			                        ""first"": ""Ben"",
			                        ""last"": ""Grimm""
			                    },
			                    ""_doc"": ""You got no idea what I'd... what I'd give to be invisible.""
			                  }
			            },
			            {
			                ""_index"" : ""marvel"",
			                ""_id"" : ""2""
			            }
			            ],
			            ""min_term_freq"" : 1,
			            ""max_query_terms"" : 12
			        }
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line121()
		{
			// tag::084b3e3ff6f22c1c9a56b79760f50b36[]
			var response0 = new SearchResponse<object>();
			// end::084b3e3ff6f22c1c9a56b79760f50b36[]

			response0.MatchesExample(@"PUT /imdb
			{
			    ""mappings"": {
			        ""properties"": {
			            ""title"": {
			                ""type"": ""text"",
			                ""term_vector"": ""yes""
			            },
			            ""description"": {
			                ""type"": ""text""
			            },
			            ""tags"": {
			                ""type"": ""text"",
			                ""fields"" : {
			                    ""raw"": {
			                        ""type"" : ""text"",
			                        ""analyzer"": ""keyword"",
			                        ""term_vector"" : ""yes""
			                    }
			                }
			            }
			        }
			    }
			}");
		}
	}
}