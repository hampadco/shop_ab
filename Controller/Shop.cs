
using Microsoft.AspNetCore.Mvc;


[Route("[Action]")]
[ApiController]

public class Shop : Controller
{

     Context db = new Context();

     //insert
        [HttpPost]
        public IActionResult Insert([FromBody] Product product)
        {
            db.Tbl_product.Add(product);
            db.SaveChanges();
            return Ok();
        }

        //get all
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = db.Tbl_product.ToList();
            return Ok(products);
        }


        //delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //lambda expression
            var product = db.Tbl_product.Find(id);
            db.Tbl_product.Remove(product);
            db.SaveChanges();
            return Ok();
        }

        //update
        [HttpPut]
        public IActionResult Update([FromBody] Product product)
        {
            var p = db.Tbl_product.Find(product.Id);
            p.Name = product.Name;
            p.Price = product.Price;

            db.Tbl_product.Update(p);
            db.SaveChanges();
            return Ok();
           
        }

   


    
}