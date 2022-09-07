using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VeterinariaIRUSTA.Entidades;

namespace VeterinariaIRUSTA.Datos
{
    public class AccesoBD
    {
        public SqlConnection cnn;

        public AccesoBD()
        {
            cnn = new SqlConnection(@"Data Source=(localdb)\Servidor;Initial Catalog=db_veterinaria;Integrated Security=True");
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public int EjecutarSQL(string strSql, CommandType type)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = strSql;
            afectadas = cmd.ExecuteNonQuery();
            cnn.Close();

            return afectadas;
        }

        /*public bool ConfirmarAtencion(Atencion oAtencion)
        {
            bool ok = true;

            SqlCommand cmd = new SqlCommand();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_INSERTAR_MAESTRO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente", oAtencion.Cliente);
            cmd.Parameters.AddWithValue("@dto", oAtencion.Descuento);
            cmd.Parameters.AddWithValue("@total", oAtencion.CalcularTotal());

            //parámetro de salida:
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@presupuesto_nro";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();

            int presupuestoNro = (int)pOut.Value;

            SqlCommand cmdDetalle;
            int detalleNro = 1;
            foreach (DetallePresupuesto item in oAtencion.Detalles)
            {
                cmdDetalle = new SqlCommand();

                cmdDetalle.Connection = cnn;
                cmdDetalle.CommandText = "SP_INSERTAR_MAESTRO";
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Parameters.AddWithValue("@presupuesto_nro", presupuestoNro);
                cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                cmdDetalle.Parameters.AddWithValue("@id_producto", item.Producto.ProductoNro);
                cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                cmd.ExecuteNonQuery();


                detalleNro++;
            }

            cnn.Close();

            return ok;
        }*/

        //public void ConsultarClientes()
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cnn.Open();
        //    cmd.Connection = cnn;
        //    cmd.CommandText = "SP_CONSULTAR_CLIENTES";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlParameter pNombre = new SqlParameter();
        //    pNombre.ParameterName = "@nombre";
        //    pNombre.DbType = DbType.String;
        //    pNombre.Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add(pNombre);
        //    SqlParameter pSexo = new SqlParameter();
        //    pSexo.ParameterName = "@sexo";
        //    pSexo.DbType = DbType.String;
        //    pSexo.Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add(pSexo);
        //    SqlParameter pCodigo = new SqlParameter();
        //    pCodigo.ParameterName = "@codigo";
        //    pCodigo.DbType = DbType.String;
        //    pCodigo.Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add(pCodigo);

        //    cmd.ExecuteNonQuery();

        //    cnn.Close();
        //}

        ////    create proc SP_CONSULTAR_CLIENTES
        ////    @nombre varchar output,
        ////    @sexo varchar output,
        ////    @codigo int output
        ////    as
        ////    begin
        ////        set @nombre = (SELECT nombre FROM CLIENTES);
        ////    	set @sexo = (SELECT sexo FROM CLIENTES);
        ////    	set @codigo = (SELECT codigo FROM CLIENTES);
        ////    end
    }
}
