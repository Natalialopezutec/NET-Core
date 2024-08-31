namespace TallerTarea02Minimal.Model
{
    public interface ITareaRepo
    {
        public void Add(Tarea tarea);
        public Tarea Get(int id);
        public void Delete(int id);
        public IList<Tarea> GetTareas();
    }

}
