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

        private Builder _builder;

        private string _model;

        private _Type _type;

        private Wood _topWood;

        private Wood _backWood;

        private double _price;

        public Guitar(
            string serialNumber,
            Builder builder,
            string model,
            _Type type,
            Wood topWood,
            Wood backWood,
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

        public Builder GetBuilder() =>this._builder;

        public string GetModel() => this._model;

        public _Type getType() => this._type;

        public Wood GetBackWood() => this._backWood;

        public Wood GetTopWood() => this._backWood;
    }

    public enum _Type
    {
        ACOUSTIC,
        ELECTRIC
    }

    public enum Builder
    {
        FENDER,
        MARTIN,
        GIBSON,
        COLLINGS,
        OLSON,
        RYAN,
        PRS,
        ANY
    }

    public enum Wood
    {
        INDIAN_ROSEWOOD,
        BRAZILIAN_ROSEWOOD,
        MAHOGANY,
        MAPLE,
        COCOBOLO,
        CEDAR,
        ADIRONDACK,
        ALDER,
        SITKA
    }



}
