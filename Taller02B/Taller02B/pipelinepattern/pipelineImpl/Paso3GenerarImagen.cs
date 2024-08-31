using System.Drawing;

namespace Taller02B.pipelinepattern.pipelineImpl
{
    internal class Paso3GenerarImagen: IPipelinePaso
    {
        public void hacerAlgo(IContexto contexto)
        {

            String imagenSalida = @"C:\Users\natil\source\repos\TallerNET\01_02b_pipelinePattern\01_02b_pipelinePattern\pipelinepattern\pipelineImpl\imagenSalida.jpeg";
            Image nueva = ((InfoImagen)contexto).Imagen;
            nueva.Save(imagenSalida, System.Drawing.Imaging.ImageFormat.Jpeg);
            Console.WriteLine("Se generó imagen de salida");
        
        }
    }
}
