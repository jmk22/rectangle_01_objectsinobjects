using Nancy;
using System;
using System.Collections.Generic;

namespace RectangleChecker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/rectangle"] = _ => {
        Dictionary<string, object> shapes = new Dictionary<string, object>();

        // var myRectangle = new Rectangle {
        //   Length = Request.Query["side-length"],
        //   Width = Request.Query["side-width"]
        // };
        Rectangle myRectangle = new Rectangle(Request.Query["side-length"], Request.Query["side-width"]);
        shapes.Add("shape1", myRectangle);

        return View["rectangle.cshtml", shapes];
      };
    }
  }
}
