using System;
using System.Collections.Generic;
using System.Text;
using WebDisplay.Data.Models;
using WebDisplay.Models.Models;
using WebDisplayLogic.Interfaces;

namespace WebDisplayLogic.Services
{
    public class CatService : ICatService
    {
        public void ProcessCat(CatDto cat)
        {
            var catDb = new Cat() { Color = cat.Color, Name = cat.Name };
            Console.WriteLine($"{catDb.Name} is {catDb.Color}");
        }
    }
}
