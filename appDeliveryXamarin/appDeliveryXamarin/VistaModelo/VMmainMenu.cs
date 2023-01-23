using appDeliveryXamarin.Datos;
using appDeliveryXamarin.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace appDeliveryXamarin.VistaModelo
{
    public class VMmainMenu : baseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<MPlatillos> _listaPlatos;
        ObservableCollection<MCategorias> _listarCategorias;
        #endregion
        #region CONSTRUCTOR
        public VMmainMenu(INavigation navigation)
        {
            Navigation = navigation;
            ListarPlatos();
            ListarCategorias();
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        public ObservableCollection<MPlatillos> ListaPlatos
        {
            get { return _listaPlatos; }
            set { SetValue(ref _listaPlatos, value); }
        }

        public ObservableCollection<MCategorias> ListaCategorias
        {
            get { return _listarCategorias; }
            set { SetValue(ref _listarCategorias, value); }
        }

        #endregion
        #region PROCESOS
        public void ListarPlatos()
        {
            var funcion = new Dplatillos();
            ListaPlatos = funcion.ListarPlatos();
        }

        public void ListarCategorias()
        {
            var funcion = new DCategorias();
            ListaCategorias = funcion.Mostrarcategorias();
        }

        private void Seleccionar(MCategorias parametros)
        {
            var index = ListaCategorias
                .ToList().FindIndex(p => p.Nombre == parametros.Nombre);
            if (index > -1)
            {
                Deseleccionar();
                ListaCategorias[index].Select = true;
                ListaCategorias[index].Color1 = "#8664ff";
                ListaCategorias[index].Color2 = "#bba8ff";
                ListaCategorias[index].TexColor = "#ffffff";
            }
        }

        private void Deseleccionar()
        {
            ListaCategorias.ForEach((item) =>
            {
                item.Select = false;
                item.Color1 = "#ffffff";
                item.Color2 = "#ffffff";
                item.TexColor = "#2f394b";
            });
        }
        #endregion
        #region COMANDOS
         public ICommand Seleccionarcommand => new Command<MCategorias>(Seleccionar);

        #endregion
    }

}

