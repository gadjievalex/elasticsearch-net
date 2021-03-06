﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.Ingest.DeletePipeline
{
	public class DeletePipelineUrlTests
	{
		[U] public async Task Urls()
		{
			var id = "pipeline-1";

			await DELETE($"/_ingest/pipeline/{id}")
					.Fluent(c => c.Ingest.DeletePipeline(id))
					.Request(c => c.Ingest.DeletePipeline(new DeletePipelineRequest(id)))
					.FluentAsync(c => c.Ingest.DeletePipelineAsync(id))
					.RequestAsync(c => c.Ingest.DeletePipelineAsync(new DeletePipelineRequest(id)))
				;
		}
	}
}
