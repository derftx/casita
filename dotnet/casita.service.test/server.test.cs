using Microsoft.AspNetCore.Http;
using Xunit;

namespace casita.service.test
{
  public class TestServer
  {
    [Fact]
    public void Test_Server_Index()
    {
      Assert.True(Server.Index(new DefaultHttpContext()) is Task);
    }
  }
}
