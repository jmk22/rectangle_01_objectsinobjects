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
        Rectangle myRectangle = new Rectangle(Request.Query["side-length"], Request.Query["side-width"]);
        shapes.Add("shape1", myRectangle);

        if (myRectangle.IsSquare()) {
          Cube myCube = new Cube(myRectangle);
          shapes.Add("shape2", myCube);
        }
        return View["rectangle.cshtml", shapes];
      };
    }
  }
}
