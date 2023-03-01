using Microsoft.AspNetCore.Http;
using Xunit;

namespace casita.service.test
{
  public class TestServer
  {
    [Fact]
    public void Test_Server_Index()
    {
      Assert.NotNull(Server.Index(new DefaultHttpContext()));
    }
  }
}
