﻿using System;
using chsarp_intro._1_Tipos_de_datos;
using chsarp_intro._2_Administracion_de_codigo;
using chsarp_intro._3_Clases_de_Usuario;
using chsarp_intro._4_Validaciones;
using chsarp_intro._5_Delegates;
using chsarp_intro._6_Colecciones;
using chsarp_intro._7_Extension_Methods;

namespace chsarp_intro
{
    /// <summary>
    /// Este proyecto intenta exponer un roadmap de conceptos básicos a cubrir relacionados con OOP 
    /// utilizando como plataforma dotnet core 3.1 y como lenguaje c# 8.0
    /// 
    /// Los aspectos básicos que se cubren en este proyecto son:
    /// - Tipos
    ///     - Tipos en NET.
    ///         - <see cref="Fechas"/>.
    ///         - <see cref="Numericos"/>.
    ///         - <see cref="Strings"/>.
    ///         - Nulables <see cref="Tipos.Nulables"/>
    ///     - Jerarquía de tipos en NET. <see cref="Tipos.Jerarquia"/>
    ///     - Ref vs Value types.
    ///         - <see cref="Tipos.DeReferencia"/>.
    ///         - <see cref="Tipos.DeValor"/>.
    ///     - Casting <see cref="Tipos.Castings"/>
    ///     - Tipos anónimos <see cref="Tipos.Anonimos"/>
    ///     - Generics <see cref="Generics"/>
    /// - Administración de código
    ///     - Uso de regiones. <see cref="Regiones"/>
    ///     - Espacios de nombres. <see cref="Namespaces"/>
    ///     - Modificadores de acceso. <see cref="ModificadoresDeAcceso"/>
    /// - Clases de usuario
    ///     - Definición y uso de clases de usuario. <see cref="Clases.ClasesDeUsuario"/>
    ///     - Herencia. <see cref="Clases.Herencia"/>
    ///     - Interfaces. <see cref="Interfaces"/>
    /// - Validaciones
    ///     - Manejo de excepciones. <see cref="Excepciones.Manejo"/>
    ///     - Jerarquía de excepciones. <see cref="Excepciones.Jerarquia"/>
    ///     - Validation attributes. <see cref="ValidationAttributes"/>
    /// - Delegates
    ///     - Delegates <see cref="Delegates.Definicion"/> & generic delegates <see cref="Delegates.Genericos"/>.
    ///     - Lambdas <see cref="Delegates.Lambdas"/>.
    /// - Colecciones
    ///     - Arrays. <see cref="Colecciones.Arrays"/>
    ///     - ICollection. <see cref="Colecciones.ICollections"/>
    ///     - List. <see cref="Colecciones.Listas"/>
    ///     - Linq. <see cref="Linq"/>
    /// - Extension methods <see cref="ExtensionMethods"/>
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            Opcion opcion;
            do
            {
                ImprimirMenu();

                int.TryParse(Console.ReadLine(), out int seleccion);
                opcion = seleccion != 0 ?
                    (Opcion)seleccion :
                    Opcion.Salir;

                Console.Clear();

                Dispatcher.Execute(opcion);

                if (opcion != Opcion.Salir)
                {
                    Console.WriteLine();
                    Console.WriteLine("Desea ejecutar otra acción? S/N");

                    opcion = char.ToUpper(Console.ReadKey().KeyChar) == 'N' ?
                        Opcion.Salir :
                        opcion;
                }
            }
            while (opcion != Opcion.Salir);
        }

        private static void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("Menú");
            Console.WriteLine("Elegir qué desea mostrar:");
            foreach (var opcion in Enum.GetValues(typeof(Opcion)))
            {
                Console.WriteLine($"{(int)opcion} - {opcion.ToString().Replace("_", " ")}");
            }
        }
    }
}
