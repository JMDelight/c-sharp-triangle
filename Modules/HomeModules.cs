using Nancy;
using Triangle.Objects;

namespace Triangle
{
  public class HomeModules : NancyModule
  {
    public HomeModules()
    {
      Get["/"] = _ => {
        return View["form.cshtml"];
      };
      Get["/results"] = _ => {
        TriangleVariables myTriangleVariables = new TriangleVariables()
        {
          Side1 = Request.Query["side1"],
          Side2 = Request.Query["side2"],
          Side3 = Request.Query["side3"]
        };
        return View["results.cshtml", myTriangleVariables];
      };
    }
  }
}
