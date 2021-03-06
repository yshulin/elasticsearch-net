﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.Ingest.SimulatePipeline
{
	public class SimulatePipelineUrlTests
	{
		[U] public async Task Urls()
		{
			await POST($"/_ingest/pipeline/_simulate")
					.Fluent(c => c.Ingest.SimulatePipeline(s => s))
					.Request(c => c.Ingest.SimulatePipeline(new SimulatePipelineRequest()))
					.FluentAsync(c => c.Ingest.SimulatePipelineAsync(s => s))
					.RequestAsync(c => c.Ingest.SimulatePipelineAsync(new SimulatePipelineRequest()))
				;

			var id = "id";
			await POST($"/_ingest/pipeline/{id}/_simulate")
					.Fluent(c => c.Ingest.SimulatePipeline(s => s.Id(id)))
					.Request(c => c.Ingest.SimulatePipeline(new SimulatePipelineRequest(id)))
					.FluentAsync(c => c.Ingest.SimulatePipelineAsync(s => s.Id(id)))
					.RequestAsync(c => c.Ingest.SimulatePipelineAsync(new SimulatePipelineRequest(id)))
				;
		}
	}
}
