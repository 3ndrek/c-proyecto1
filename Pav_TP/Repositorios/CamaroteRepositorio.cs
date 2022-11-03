using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pav_TP.Repositorios
{
    public class CamaroteRepositorio
    {
        public List<Barco> GetBarcos()
        {
            var sql = "SELECT * from navio WHERE esDadoBaja is null";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var barcos = new List<Barco>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var barco = new Barco();
                barco.Codigo = Convert.ToInt32(fila["codigo_navio"]);
                barco.Nombre = fila["nombre"].ToString();
                barcos.Add(barco);
            }
            return barcos;

        }

        public List<Cubierta> GetCubiertas(int cod_navio)
        {
            var sql = $"select cub.* from cubiertas cub left join navio n on cub.cod_navio = n.codigo_navio where n.codigo_navio = {cod_navio} and cub.esDadoBaja is null and n.esDadoBaja is null";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var cubiertas = new List<Cubierta>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cubierta = new Cubierta();
                cubierta.cod_navio = Convert.ToInt32(fila["cod_navio"]);
                cubierta.num_cubierta = Convert.ToInt32(fila["num_cubierta"]);
                cubierta.desc = fila["descripcion"].ToString();
                cubierta.leg_encargado = Convert.ToInt32(fila["leg_encargado"].ToString());
                cubiertas.Add(cubierta);
            }
            return cubiertas;
        }

        public List<TipoCamarote> GetTipoCamarotes()
        {
            var sql = "select * from tipoCamarote";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var tiposDeCamarotes = new List<TipoCamarote>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var tipoCamarote = new TipoCamarote();
                tipoCamarote.tipo = Convert.ToInt32(fila["tipo"]);
                tipoCamarote.desc = fila["descripcion"].ToString();
                tiposDeCamarotes.Add(tipoCamarote);
            }
            return tiposDeCamarotes;
        }

        public List<Camarote> GetCamarotes(int cod_navio)
        {
            var sql = $"select c.* from camarotes c left join navio n on c.cod_navio = n.codigo_navio where n.codigo_navio = {cod_navio} and c.esDadoBaja is null and n.esDadoBaja is null";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var camarotes = new List<Camarote>();
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var camarote = new Camarote();
                camarote.cod_navio = Convert.ToInt32(fila["cod_navio"]);
                camarote.num_cubierta = Convert.ToInt32(fila["num_cubierta"]);
                camarote.num_camarote = Convert.ToInt32(fila["num_camarote"]);
                camarote.tipo = Convert.ToInt32(fila["tipo"]);
                camarote.cant_camas = Convert.ToInt32(fila["cant_camas"]);
                camarote.monto= Convert.ToInt32(fila["monto"]);
                camarotes.Add(camarote);
            }
            return camarotes;
        }

        public List<Camarote> ObtenerCamarotes(int cod_navio, int num)
        {   
            //join camarot
            var sql = $"select c.cod_navio,c.num_cubierta,c.tipo,c.monto ,c.num_camarote, c.cant_camas, Cv.ocupacion, Cc.descripcion as cubierta_desc,Tc.descripcion as tipo_camarote " +
                $"from camarotes c left join camarotesXviajes Cv on c.num_camarote= Cv.num_camarote and c.cod_navio=Cv.cod_navio and c.num_cubierta= Cv.num_cubierta " +
                $"left join cubiertas Cc on Cc.num_cubierta = c.num_cubierta left join tipoCamarote Tc on Tc.tipo = c.tipo " +
                $"where c.cod_navio = {cod_navio} and c.cant_camas >= {num} and c.esDadoBaja is null and Cc.esDadoBaja is null";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var camarotes = new List<Camarote>();
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var camarote = new Camarote();
                
                camarote.cod_navio = Convert.ToInt32(fila["cod_navio"]);
                camarote.num_cubierta = Convert.ToInt32(fila["num_cubierta"]);
                camarote.num_camarote = Convert.ToInt32(fila["num_camarote"]);
                camarote.tipo = Convert.ToInt32(fila["tipo"]);
                camarote.cant_camas = Convert.ToInt32(fila["cant_camas"]);

                // ClienteId = string.IsNullOrEmpty(txtClienteId.Text) ? (int ?)null : Convert.ToInt32(txtClienteId.Text);
                if (string.IsNullOrEmpty(fila["ocupacion"].ToString()))
                {
                    camarote.ocupacion = 0;
                }
                else
                {
                    camarote.ocupacion = Convert.ToInt32(fila["ocupacion"]);
                }

                camarote.cubierta_desc = fila["cubierta_desc"].ToString();
                camarote.tipo_desc = fila["tipo_camarote"].ToString();
                camarote.monto= Convert.ToInt32(fila["monto"]);
                camarotes.Add(camarote);
            }
            return camarotes;
        }

        public List<Camarote> GetCamarotes(int b, int cub)
        {
            var sql = $"select c.* from camarotes c left join cubiertas cub on c.num_cubierta = cub.num_cubierta left join navio n on cub.cod_navio = n.codigo_navio where n.codigo_navio = {b} and cub.num_cubierta = {cub} and c.esDadoBaja is null and cub.esDadoBaja is null";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var camarotes = new List<Camarote>();
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var camarote = new Camarote();
                camarote.cod_navio = Convert.ToInt32(fila["cod_navio"]);
                camarote.num_cubierta = Convert.ToInt32(fila["num_cubierta"]);
                camarote.num_camarote = Convert.ToInt32(fila["num_camarote"]);
                camarote.tipo = Convert.ToInt32(fila["tipo"]);
                camarote.cant_camas = Convert.ToInt32(fila["cant_camas"]);
                camarotes.Add(camarote);
            }
            return camarotes;
        }

        public void CargarGrillaCamarotes(DataGridView dgv)
        {
            var sql = "select * from camarotes where esDadoBaja is null";
            var midata = DBHelper.GetDBHelper().ConsultaSQL(sql);
            dgv.DataSource = midata;
            var col = new DataGridViewCheckBoxColumn();
            col.Name = "Seleccionar";
            dgv.Columns.Add(col);
        }

        public void RegistrarCamarote(Camarote camarote)
        {
            var sql = $"Insert into camarotes(cod_navio,num_cubierta, num_camarote,tipo,monto,cant_camas) " +
                $"values ({camarote.cod_navio}, {camarote.num_cubierta}, {camarote.num_camarote}, {camarote.tipo},{camarote.monto},{camarote.cant_camas})";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public void ModificarCamarote(Camarote camarote)
        {
            var sql = $"Update camarotes set tipo = {camarote.tipo}, monto = {camarote.monto}," +
                $"cant_camas = {camarote.cant_camas} where cod_navio = {camarote.cod_navio} and " +
                $"num_cubierta = {camarote.num_cubierta} and num_camarote = {camarote.num_cubierta}";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public void EliminarCamarote(Camarote camarote)
        {
            var sql = $"UPDATE camarotes set esDadoBaja=1 WHERE cod_navio = {camarote.cod_navio} and num_cubierta = {camarote.num_cubierta} and num_camarote = {camarote.num_camarote}";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public DataTable ConsultarCamarote(Camarote camarote)
        {
            var sql = "";
            if (camarote.num_camarote == 0)
            {
                sql = $"select c.cod_navio,c.num_cubierta,c.num_camarote, c.tipo,c.monto,c.cant_camas from camarotes c " +
                    $"where c.cod_navio = {camarote.cod_navio} and c.num_cubierta = {camarote.num_cubierta}";
            }
            else sql += $"and c.num_camarote = {camarote.num_camarote}";
            DataTable datos = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return datos;

        }


    }
}
