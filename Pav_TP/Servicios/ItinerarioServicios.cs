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
    public class ItinerarioServicios
    {
        private readonly ItinerarioRepositorio itinerarioRepositorio;

        public ItinerarioServicios() { itinerarioRepositorio = new ItinerarioRepositorio(); }

        public List<Paises> GetPaises() { return itinerarioRepositorio.GetPaises(); }

        public List<CategoriasItinerarios> GetCategoriasItinerarios() { return itinerarioRepositorio.GetCategoriasItinerarios(); }

        public List<Puertos> GetPuertosXPais(int cod_pais) { return itinerarioRepositorio.GetPuertosXPais(cod_pais);}

        public void CargarPaises(ComboBox cmb)
        {
            var paises = GetPaises();
            var paisDefault = new Paises();
            paisDefault.cod_pais = 0;
            paisDefault.nombre = "Seleccionar";
            paises.Add(paisDefault);

            var conector = new BindingSource();
            conector.DataSource = paises;

            cmb.DataSource = conector;
            cmb.DisplayMember = "nombre";
            cmb.ValueMember = "nombre";
            cmb.SelectedItem = paisDefault;

        }

        public int GetCodPais(string n)
        {
            return itinerarioRepositorio.GetCodPais(n);
        }
        public int GetCodPuerto(string n) 
        { 
            return itinerarioRepositorio.GetCodPuerto(n); 
        }

        public void CargarCategorias(ComboBox cmb)
        {
            var categorias = GetCategoriasItinerarios();
            var catDefault = new CategoriasItinerarios();
            catDefault.categoria = 0;
            catDefault.descripcion = "Seleccionar";
            categorias.Add(catDefault);

            var conector = new BindingSource();
            conector.DataSource = categorias;

            cmb.DataSource = conector;
            cmb.DisplayMember = "descripcion";
            cmb.ValueMember = "categoria";
            cmb.SelectedItem = catDefault;
            
        }
        public int GenerarCodItinerario()
        {
            return itinerarioRepositorio.GenerarCodItinerario();
        }

        public int RegistrarItinerario(int cod_i, int cat, string n)
        {
            var sql = $"insert into itinerarios(cod_itinerario,categoria, nombre) values ({cod_i},{cat},'{n}')";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
            return cod_i;
        }

        public void RegistrarPuertosXItinerario(DataGridView dgv, int cod_i)
        {
            int c = dgv.Rows.Count - 1;
            for(int i = 0; i < c; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                int cod_p = GetCodPuerto(row.Cells[1].Value.ToString());
                int num_e = Convert.ToInt32(row.Cells[2].Value);
                itinerarioRepositorio.RegistrarPuertosXItinerario(cod_i, num_e, cod_p);
            }
        }

        public int GenerarNroEscala(DataGridView dgv)
        {
            int n = dgv.RowCount;
            return n;
        }

    }
}
