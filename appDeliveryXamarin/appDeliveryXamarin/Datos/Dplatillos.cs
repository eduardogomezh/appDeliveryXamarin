using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using appDeliveryXamarin.Modelo;

namespace appDeliveryXamarin.Datos
{
    public class Dplatillos
    {
        public ObservableCollection<MPlatillos> ListarPlatos()
        {
            return new ObservableCollection<MPlatillos>()
            {
                new MPlatillos()
                {
                    Descripcion="Plato 1",
                    Precio="$14.45",
                    Icon="https://cdn-icons-png.flaticon.com/512/783/783051.png"
                },
                 new MPlatillos()
                {
                    Descripcion="Plato 2",
                    Precio="$20.45",
                    Icon="https://cdn-icons-png.flaticon.com/512/3511/3511307.png"
                },
                  new MPlatillos()
                {
                    Descripcion="Plato 3",
                    Precio="$10.45",
                    Icon="https://cdn-icons-png.flaticon.com/512/5854/5854405.png"
                }
            };
        }
    }
}
