using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarShop
{
    public class Inventory
    {
        private List<Guitar> _guitars;

        public Inventory()
        {
            _guitars = new List<Guitar>();
        }

        public void AddGuitar(
            string serialNumber,
            Builder builder,
            string model,
            _Type type,
            Wood topWood,
            Wood backWood,
            double price)
        {
            Guitar guitar = new Guitar(serialNumber, builder, model, type, topWood, backWood, price);

            _guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in this._guitars)
            {
                if (guitar.GetSerialNumber().Equals(serialNumber))
                    return guitar;
            }

            return null;
        }

        public  Guitar Search(Guitar searchGuitar)
        {
            foreach (var guitar in this._guitars)
            {
                string builder = searchGuitar.GetBuilder();

                if ((builder != null) && (builder != "") && (builder != guitar.GetBuilder()))
                    continue;

                string model = searchGuitar.GetModel().ToLower();

                if ((model != null) && (model != "") && (model != guitar.GetModel().ToLower()))
                    continue;

                string type = searchGuitar.getType();

                if ((type != null) && (type != "") && (type != guitar.getType()))
                    continue;

                string backWood =searchGuitar.GetBackWood();

                if ((backWood != null) && (backWood != "") && (backWood != guitar.GetBackWood()))
                    continue;

                string topWood = searchGuitar.GetTopWood();

                if ((topWood != null) && (topWood != "") && (topWood != guitar.GetTopWood()))
                    continue;

                return guitar;
            }

            return null;
        }
    }
}
