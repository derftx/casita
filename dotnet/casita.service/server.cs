using Serilog;

namespace casita.service
{
  public static class Server
  {
    public static async Task Index(HttpContext context)
    {
      Log.Information("index route");

      await context.Response.WriteAsJsonAsync(new { runtime = ".NET Core" });
    }
  }
}
