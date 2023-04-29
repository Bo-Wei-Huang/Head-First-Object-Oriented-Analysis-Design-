using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarShop
{
    public class Guitar
    {
        private string _serialNumber;

        private string _builder;

        private string _model;

        private string _type;

        private string _topWood;

        private string _backWood;

        private double _price;

        public Guitar(
            string serialNumber,
            string builder,
            string model,
            string type,
            string topWood,
            string backWood,
            double price)
        {
            _serialNumber = serialNumber;
            _builder = builder;
            _model = model;
            _type = type;
            _topWood = topWood;
            _backWood = backWood;
            _price = price;
        }

        public string GetSerialNumber() => this._serialNumber;

        public double GetPrice() => this._price;

        public double SetPrice(float price) => this._price = price;

        public string GetBuilder() => this._builder;

        public string GetModel() => this._model;

        public string getType() => this._type;  

        public string GetBackWood() => this._backWood;

        public string GetTopWood() => this._topWood;
    }
}
