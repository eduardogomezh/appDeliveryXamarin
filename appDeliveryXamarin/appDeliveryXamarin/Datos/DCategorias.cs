using appDeliveryXamarin.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace appDeliveryXamarin.Datos
{
    public class DCategorias
    {
        public ObservableCollection<MCategorias> Mostrarcategorias()
        {
            return new ObservableCollection<MCategorias>()
            {
                new MCategorias()
                {
                    Nombre="Burguer",
                    Icon="https://cdn-icons-png.flaticon.com/512/2921/2921822.png",
                    TexColor="#2F3948",
                    Color1="#ffffff",
                    Color2="#ffffff",
                    Select=false
                },
                 new MCategorias()
                {
                    Nombre="health",
                    Icon="https://cdn-icons-png.flaticon.com/512/706/706164.png",
                    TexColor="#2F3948",
                    Color1="#ffffff",
                    Color2="#ffffff",
                    Select=false
                }
            };
        }
    }
}
