namespace casita.service
{
  public static class Server
  {
    public static Task Index(HttpContext context)
    {
      return context.Response.WriteAsJsonAsync(new { runtime = ".NET Core" });
    }
  }
}
