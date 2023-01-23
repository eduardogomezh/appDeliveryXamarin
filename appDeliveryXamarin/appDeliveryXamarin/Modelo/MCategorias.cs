using appDeliveryXamarin.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace appDeliveryXamarin.Modelo
{
    public class MCategorias:baseViewModel
    {
        public String Nombre { get; set; }
        public String Icon { get; set; }

        //objetos
        String _color1;
        String _color2;
        String _textColor;
        Boolean _select;

        public Boolean Select
        {
            get { return _select; }
            set { SetValue(ref _select, value); }
        }
        public string Color1
        {
            get { return _color1; }
            set { SetValue(ref _color1, value); }
        }
        public string Color2
        {
            get { return _color2; }
            set { SetValue(ref _color2, value); }
        }
        public string TexColor
        {
            get { return _textColor; }
            set { SetValue(ref _textColor, value); }
        }
    }
}
