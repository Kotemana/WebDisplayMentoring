using System;
using System.Collections.Generic;
using System.Text;
using WebDisplay.Models.Models;

namespace WebDisplayLogic.Interfaces
{
    public interface ICatService
    {
        void ProcessCat(CatDto cat);
    }
}
