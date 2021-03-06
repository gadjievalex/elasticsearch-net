using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.XPack.Docs.En.Security.Authorization
{
	public class AliasPrivilegesPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line30()
		{
			// tag::195fe9fadf952ddd7a69c8aaf98d47a1[]
			var response0 = new SearchResponse<object>();
			// end::195fe9fadf952ddd7a69c8aaf98d47a1[]

			response0.MatchesExample(@"GET /current_year/_doc/1");
		}

		[U(Skip = "Example not implemented")]
		public void Line56()
		{
			// tag::c4d60fd70ef1be46616a0d4e7578d8b9[]
			var response0 = new SearchResponse<object>();
			// end::c4d60fd70ef1be46616a0d4e7578d8b9[]

			response0.MatchesExample(@"PUT /2015
			{
			    ""aliases"" : {
			        ""current_year"" : {}
			    }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line68()
		{
			// tag::06f6cb6e20d2faf6599cfe1f39c6c56b[]
			var response0 = new SearchResponse<object>();
			// end::06f6cb6e20d2faf6599cfe1f39c6c56b[]

			response0.MatchesExample(@"POST /_aliases
			{
			    ""actions"" : [
			        { ""add"" : { ""index"" : ""2015"", ""alias"" : ""current_year"" } }
			    ]
			}");
		}
	}
}