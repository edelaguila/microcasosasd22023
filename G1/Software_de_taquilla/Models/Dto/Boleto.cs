using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class Boleto 
    {
      public int id;
      public int id_venta;
      public int id_pelicula;
      public int id_cine;
      public int id_asiento;
      public double precio;
      public string clasificacion;


      public Boleto(int id, int id_v, int id_p, int id_c, int id_as,double prec, string clas){
        this.id = id;
        this.id_venta = id_v;
        this.id_pelicula = id_p;
        this.id_cine = id_c;
        this.id_asiento = id_as;
        this.precio = prec;
        this.clasificacion = clas;
      }


      public Boleto(int id_v, int id_p, int id_c, int id_as,double prec, string clas){
        this.id_venta = id_v;
        this.id_pelicula = id_p;
        this.id_cine = id_c;
        this.id_asiento = id_as;
        this.precio = prec;
        this.clasificacion = clas;
      }


    }
}
