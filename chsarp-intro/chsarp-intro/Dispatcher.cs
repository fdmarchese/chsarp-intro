﻿using chsarp_intro._1_Tipos_de_datos;
using chsarp_intro._3_Clases_de_Usuario;
using chsarp_intro._4_Validaciones;
using chsarp_intro._5_Colecciones;
using System;
using System.Collections.Generic;

namespace chsarp_intro
{
    public static class Dispatcher
    {
        private static readonly IDictionary<Opcion, Action> _acciones = new Dictionary<Opcion, Action>
        {
            { Opcion.Tipos_de_valor, Tipos.DeValor },
            { Opcion.Tipos_de_referencia, Tipos.DeReferencia },
            { Opcion.Jerarquia_de_tipos, Tipos.Jerarquia },
            { Opcion.Nulables, Tipos.Nulables },
            { Opcion.Enteros, Numericos.Enteros },
            { Opcion.Decimales, Numericos.Decimales },
            { Opcion.Fechas, Fechas.Ejemplo },
            { Opcion.Tipos_anonimos, Tipos.Anonimos },
            { Opcion.Genericos, Generics.Genericos },
            { Opcion.Clases_de_usuario, Clases.ClasesDeUsuario },
            { Opcion.Metodos_del_tipo_object, Clases.MetodosDelTipoObject },
            { Opcion.Strings_definicion, Strings.Definicion },
            { Opcion.Strings_funciones_comunes, Strings.FuncionesComunes },
            { Opcion.Casting, Tipos.Castings },
            { Opcion.Manejo_de_excepciones, Excepciones.Manejo },
            { Opcion.Jerarquia_de_excepciones, Excepciones.Jerarquia },
            { Opcion.Arrays, Colecciones.Arrays },
            { Opcion.ICollections, Colecciones.ICollections },
            { Opcion.Listas, Colecciones.Listas },
        };

        public static void Execute(Opcion opcion)
        {
            _acciones.TryGetValue(opcion, out Action action);
            action?.Invoke();
        }
    }
}
