
using System.Drawing;


namespace Taller02B.pipelinepattern.pipelineImpl
{
    internal class Paso2AplicarFiltro : IPipelinePaso
    {
        private readonly Color _originalColor;
        private readonly Color _replacementColor;

        public Paso2AplicarFiltro(Color originalColor, Color replacementColor)
        {
            _originalColor = originalColor;
            _replacementColor = replacementColor;
        }
        public void hacerAlgo(IContexto context)

        {
            Bitmap bitmap = new Bitmap(((InfoImagen)context).Imagen);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (bitmap.GetPixel(x, y) == _originalColor)
                    {
                        bitmap.SetPixel(x, y, _replacementColor);
                    }
                }
            }

             ((InfoImagen)context).Imagen = bitmap;
        }
    }
}

