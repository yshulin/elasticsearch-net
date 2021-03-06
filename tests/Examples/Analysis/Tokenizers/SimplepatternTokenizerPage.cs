using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Analysis.Tokenizers
{
	public class SimplepatternTokenizerPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("analysis/tokenizers/simplepattern-tokenizer.asciidoc:36")]
		public void Line36()
		{
			// tag::9ffc049d5c5a570b90d913e92f910ee4[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::9ffc049d5c5a570b90d913e92f910ee4[]

			response0.MatchesExample(@"PUT my_index
			{
			  ""settings"": {
			    ""analysis"": {
			      ""analyzer"": {
			        ""my_analyzer"": {
			          ""tokenizer"": ""my_tokenizer""
			        }
			      },
			      ""tokenizer"": {
			        ""my_tokenizer"": {
			          ""type"": ""simple_pattern"",
			          ""pattern"": ""[0123456789]{3}""
			        }
			      }
			    }
			  }
			}");

			response1.MatchesExample(@"POST my_index/_analyze
			{
			  ""analyzer"": ""my_analyzer"",
			  ""text"": ""fd-786-335-514-x""
			}");
		}
	}
}