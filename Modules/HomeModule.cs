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
        dynamic model = new DynamicDictionary();
        // var myRectangle = new Rectangle (Request.Query["side-length"], Request.Query["side-width"]);
        var myRectangle = new Rectangle {
          Length = Request.Query["side-length"],
          Width = Request.Query["side-width"]
        };
        model.Rectangle = myRectangle;

        return View["rectangle.cshtml", model];
      };
    }
  }
}
