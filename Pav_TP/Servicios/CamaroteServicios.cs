using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.Servicios
{
    public class CamaroteServicios
    {
        private readonly CamaroteRepositorio camaroteRepositorio;

        public CamaroteServicios() { camaroteRepositorio = new CamaroteRepositorio(); }

        public List<Barco> GetBarcos()
        {
            return camaroteRepositorio.GetBarcos();
        }

        public List<Cubierta> GetCubiertas(int b)
        {
            return camaroteRepositorio.GetCubiertas(b);
        }

        public List<TipoCamarote> GetTipoCamarotes()
        {
            return camaroteRepositorio.GetTipoCamarotes();
        }

        public List<Camarote> GetCamarotes(int b)
        {
            return camaroteRepositorio.GetCamarotes(b);
        }

        public List<Camarote> GetCamarotes(int b, int c)
        {
            return camaroteRepositorio.GetCamarotes(b, c);
        }

        public List<Camarote> ObtenerCamarotes(int b, int c)
        {
            return camaroteRepositorio.ObtenerCamarotes(b, c);
        }

        public void RegistrarCamarote(Camarote c)
        {
            camaroteRepositorio.RegistrarCamarote(c);
        }

        public void ModificarCamarote(Camarote c)
        {
            camaroteRepositorio.ModificarCamarote(c);   
        }

        public void EliminarCamarote(Camarote c)
        {
            camaroteRepositorio.EliminarCamarote(c);
        }

        public void ValidarCamarote(Camarote c)
        {
            c.ValidarNavio();
            c.ValidarCubierta();
            c.ValidarNro();

        }

        public void CargarBarcos(ComboBox cmb)
        {
            var barcos = GetBarcos();
            var barcoDefault = new Pav_TP.Entidades.Barco();
            barcoDefault.Codigo = 0;
            barcos.Add(barcoDefault);

            var conector = new BindingSource();
            conector.DataSource = barcos;

            cmb.DataSource = conector;
            cmb.DisplayMember = "Nombre";
            cmb.ValueMember = "Codigo";
            cmb.SelectedItem = barcoDefault;

        }

        public void CargarTipoCamarote(ComboBox cmb)
        {
            var tipoCamarote = GetTipoCamarotes();
            var tipoDefault = new TipoCamarote();
            tipoDefault.tipo = 0;
            tipoDefault.desc = "";

            var conector = new BindingSource();
            conector.DataSource = tipoCamarote;

            cmb.DataSource = conector;
            cmb.DisplayMember = "desc";
            cmb.ValueMember = "tipo";
            cmb.SelectedItem = tipoDefault;
        }        
    }
}
