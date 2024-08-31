using System.Drawing;

namespace Taller02B.pipelinepattern.pipelineImpl
{
    public class Paso1CargarImagen: IPipelinePaso
    {
        public void hacerAlgo(IContexto contexto)
        {

            String camino = @"C:\Users\natil\Documents\GitHub\NET-Core\Taller02B\Taller02B\pipelinepattern\pipelineImpl\flor.jpeg";
            //el uso del @ le indica al compilador que la siguiente cadena se interpreta literalmente
  
            ((InfoImagen)contexto).Imagen = Image.FromFile(camino);
            Console.WriteLine("Se cargo información desde la Imagen");
        }
    }

}
