﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.Cluster.NodesHotThreads
{
	public class NodesHotThreadsUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			await GET("/_nodes/hot_threads")
					.Fluent(c => c.Nodes.HotThreads())
					.Request(c => c.Nodes.HotThreads(new NodesHotThreadsRequest()))
					.FluentAsync(c => c.Nodes.HotThreadsAsync())
					.RequestAsync(c => c.Nodes.HotThreadsAsync(new NodesHotThreadsRequest()))
				;

			await GET("/_nodes/foo/hot_threads")
					.Fluent(c => c.Nodes.HotThreads(n => n.NodeId("foo")))
					.Request(c => c.Nodes.HotThreads(new NodesHotThreadsRequest("foo")))
					.FluentAsync(c => c.Nodes.HotThreadsAsync(n => n.NodeId("foo")))
					.RequestAsync(c => c.Nodes.HotThreadsAsync(new NodesHotThreadsRequest("foo")))
				;
		}
	}
}
