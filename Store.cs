using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * @Author: Lasse B. Hindsberg
 * 
 * Used Snippets from https://github.com/jpandersen61/UML2
 * 
*/

namespace UML2
{
    public class Store
    {
        MenuCatalog menuCatalog;

        public Store()
        {
            menuCatalog = new MenuCatalog();
        }
        
        public void Run()
        {
            new UserDialog(menuCatalog).Run();
        }
    }

}
