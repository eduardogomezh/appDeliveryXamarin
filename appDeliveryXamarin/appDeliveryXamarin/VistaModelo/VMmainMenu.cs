﻿using appDeliveryXamarin.Datos;
using appDeliveryXamarin.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace appDeliveryXamarin.VistaModelo
{
    public class VMmainMenu : baseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<MPlatillos> _listaPlatos;
        #endregion
        #region CONSTRUCTOR
        public VMmainMenu(INavigation navigation)
        {
            Navigation = navigation;
            ListarPlatos();
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

        #endregion
        #region PROCESOS
       
        public void ListarPlatos()
        {
            var funcion = new Dplatillos();
            ListaPlatos = funcion.ListarPlatos();
        }
        #endregion
        #region COMANDOS
       // public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
       
        #endregion
    }

}

