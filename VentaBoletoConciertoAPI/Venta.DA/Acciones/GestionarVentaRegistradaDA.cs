using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BW.Interfaces.DA;
using Venta.DA.Entidades;
using Ventan.DA.Contexto;

namespace Venta.DA.Acciones
{
    public class GestionarVentaRegistradaDA : IGestionarVentaRegistradaDA
    {
        private readonly ContextoData _contextoData;

        public GestionarVentaRegistradaDA(ContextoData contextoData)
        {
            this._contextoData = contextoData;
        }

        public async Task<VentaRegistrada> RealizarNuevaVenta(int idUsuario, IEnumerable<int> idsAsientos, decimal pagoTotal)
        {
            //se crea la infromacion correspondiente a una nueva venta en la base de datos
            var ventaNueva = new VentaRegistradaDA()
            {
                idUsuario = idUsuario,
                pagoTotal = pagoTotal,
            };

            //se agrega la nueva tupla de informacion
            await this._contextoData.VentaDA.AddAsync(ventaNueva);

            List<BoletoDA> boletos = new List<BoletoDA>();

            foreach (var id in idsAsientos)
            {
                var boleto = new BoletoDA() {idAsiento = id};
                boletos.Add( boleto );
                await this._contextoData.BoletoDA.AddAsync(boleto);
            }

            var resultado = await this._contextoData.SaveChangesAsync();

            if (resultado < 0)
            {
                return null;
            }

            foreach (var boletoDA in boletos)
            {
                var ventaBoleto = new VentaBoletoDA() 
                {
                    idVenta = ventaNueva.idVenta,
                    idBoleto = boletoDA.idBoleto,
                };
                await this._contextoData.VentaBoletoDA.AddAsync(ventaBoleto);
            }

            resultado = await this._contextoData.SaveChangesAsync();

            if (resultado < 0)
            {
                return null;
            }

            return new VentaRegistrada()
            {
                idVenta
            }

        }
    }
}
