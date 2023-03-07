using Serilog;
using Xunit;

namespace casita.service.test
{
  public class TestLogger
  {
    [Fact]
    public void Test_Logger()
    {
      Logger.UseSerilog();

      Assert.NotNull(Log.Logger);
    }
  }
}
