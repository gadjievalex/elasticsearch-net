using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Indices
{
	public class ClearcachePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line10()
		{
			// tag::486eee2c8e75520f825fec08c1fbd67e[]
			var response0 = new SearchResponse<object>();
			// end::486eee2c8e75520f825fec08c1fbd67e[]

			response0.MatchesExample(@"POST /twitter/_cache/clear");
		}

		[U(Skip = "Example not implemented")]
		public void Line99()
		{
			// tag::e97b14be2c4030bfc92e5d09a27e9fc9[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();

			var response2 = new SearchResponse<object>();
			// end::e97b14be2c4030bfc92e5d09a27e9fc9[]

			response0.MatchesExample(@"POST /twitter/_cache/clear?fielddata=true  <1>");

			response1.MatchesExample(@"POST /twitter/_cache/clear?query=true      <2>");

			response2.MatchesExample(@"POST /twitter/_cache/clear?request=true    <3>");
		}

		[U(Skip = "Example not implemented")]
		public void Line119()
		{
			// tag::62069c4118d79daf9612b29659b16627[]
			var response0 = new SearchResponse<object>();
			// end::62069c4118d79daf9612b29659b16627[]

			response0.MatchesExample(@"POST /twitter/_cache/clear?fields=foo,bar   \<1>");
		}

		[U(Skip = "Example not implemented")]
		public void Line131()
		{
			// tag::2f43c5e976713a5c5cd8eb4b08cfffca[]
			var response0 = new SearchResponse<object>();
			// end::2f43c5e976713a5c5cd8eb4b08cfffca[]

			response0.MatchesExample(@"POST /kimchy,elasticsearch/_cache/clear");
		}

		[U(Skip = "Example not implemented")]
		public void Line141()
		{
			// tag::c4a1d03dcfb82913d0724a42b0a89f20[]
			var response0 = new SearchResponse<object>();
			// end::c4a1d03dcfb82913d0724a42b0a89f20[]

			response0.MatchesExample(@"POST /_cache/clear");
		}
	}
}