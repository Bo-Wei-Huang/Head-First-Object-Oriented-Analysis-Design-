using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarShop
{
    public class FindGuitarTester
    {
        private Inventory  inventory;

        public FindGuitarTester()
        {
            inventory = new Inventory();
        }

        private void InitializeInventories()
        {
            var guitar = new Guitar(string.Empty, Builder.FENDER, "Stratocastor", _Type.ELECTRIC, Wood.ALDER, Wood.ALDER,1499.95);

            var _guitar = new Guitar(string.Empty, Builder.FENDER, "Stratocastor", _Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 1549.95);


            inventory.AddGuitar(
                guitar.GetSerialNumber(),
                                guitar.GetBuilder(),
                                guitar.GetModel(),
                                guitar.getType(),
                                guitar.GetTopWood(),
                                guitar.GetBackWood(),
                                guitar.GetPrice());


        }
    }
}
