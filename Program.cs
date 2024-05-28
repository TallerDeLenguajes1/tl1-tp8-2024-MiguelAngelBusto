// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
using System;

Calculadora c1 = new Calculadora();

c1.Sumar(16);
c1.Dividir(2);
c1.Multiplicar(4);
c1.Limpiar();
c1.Sumar(41);
c1.Restar(20);
c1.MostrarLista();


public enum TipoOperacion
{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar
}