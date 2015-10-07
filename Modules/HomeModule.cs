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
        // dynamic model = new DynamicDictionary();
        // var myRectangle = new Rectangle (Request.Query["side-length"], Request.Query["side-width"]);
        Dictionary<string, object> shapes = new Dictionary<string, object>();
        var myRectangle = new Rectangle {
          Length = Request.Query["side-length"],
          Width = Request.Query["side-width"]
        };
        // shapes.Rectangle = myRectangle;
        var rectangle2 = new Rectangle {
          Length = 100,
          Width = 5
        };
        shapes.Add("shape1", myRectangle);
        shapes.Add("shape2", rectangle2);

        return View["rectangle.cshtml", shapes];
      };
    }
  }
}
