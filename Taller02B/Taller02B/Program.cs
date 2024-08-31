// See https://aka.ms/new-console-template for more information
using System.Drawing;
using Taller02B.pipelinepattern;
using Taller02B.pipelinepattern.pipelineImpl;

Console.WriteLine("Ejemplo de PipeLine");

IContexto contexto = new InfoImagen();
PipelineOrquestador pipeLine = new PipelineOrquestador(contexto);
pipeLine.AgregarPaso(new Paso1CargarImagen());
pipeLine.AgregarPaso(new Paso2AplicarFiltro(Color.Aqua, Color.Black));
pipeLine.AgregarPaso(new Paso3GenerarImagen());
pipeLine.Ejecutar();