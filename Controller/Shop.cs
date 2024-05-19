
using Microsoft.AspNetCore.Mvc;


[Route("[Action]")]
[ApiController]

public class Shop : Controller
{

    //list static Colors string array
    public static List<string> Colors = new List<string> { "Red", "Green", "Blue" };

    //get all colors
    [HttpGet]
    public IActionResult GetColors()
    {
        return Ok(Colors);
    }

    //insert new color
    [HttpPost]
    public IActionResult Insert(string color)
    {
        Colors.Add(color);
        return Ok();
    }

    //delete color
    [HttpDelete]
    public IActionResult Delete(string color)
    {
        //check if exist
        if (!Colors.Contains(color))
        {
            return NotFound();
        }
        Colors.Remove(color);
        return Ok();
    }

    //update color
    [HttpPut]
    public IActionResult Update(string oldColor, string newColor)
    {
        //check if exist
        if (!Colors.Contains(oldColor))
        {
            return NotFound();
        }
        Colors.Remove(oldColor);
        Colors.Add(newColor);
        return Ok();
    }


    
}