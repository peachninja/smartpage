using Smartpage.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartpage.Controllers
{
    public interface iDataController
    {
        DataProduct GetProduct(int id);

        DataProduct PostProduct(DataProduct data);

        DataProduct DeleteProduct(int id);

        DataProduct UpdateProduct(DataProduct data);
    }
}
