namespace Taller02B.pipelinepattern
{
    internal class PipelineOrquestador
    {
        private IList<IPipelinePaso> _pasosAEjecutar;
        private IContexto _contexto;

        public PipelineOrquestador(IContexto contexto)
        {
            this._pasosAEjecutar = new List<IPipelinePaso>();
            this._contexto = contexto;
        }

        public void AgregarPaso(IPipelinePaso paso)
        {
            this._pasosAEjecutar.Add(paso);
        }

        public void Ejecutar()
        {
            Console.WriteLine("Inicio pipeline");
            foreach (IPipelinePaso paso in this._pasosAEjecutar)
            {
                //aca es donde se ve la "fuerza" de la interface
                Console.WriteLine("Ejecutando paso");
                paso.hacerAlgo(this._contexto);

            }
            Console.WriteLine("Fin pipeline");
        }



    }
}
