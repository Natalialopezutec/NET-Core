using TallerTarea02Minimal.Model;

namespace TallerTarea02Minimal.Infra.Data
{
    public class TareaRepo : ITareaRepo
    {
        public IList<Tarea> _tareas;
        public TareaRepo()
        {
            this._tareas = new List<Tarea>();
            this._tareas.Add(new Tarea(1, "EDA", "programacion", 4, "Gualberto"));
            this._tareas.Add(new Tarea(2, "Taller Java", "programacion", 6, "Gabriel"));
            this._tareas.Add(new Tarea(3, "Programacion Avanzada", "programacion", 12, "Juan"));
            this._tareas.Add(new Tarea(4, "Programacion Aplicaciones", "programacion", 4, "Andres"));
        }
        public void Add(Tarea tarea)
        {
            this._tareas.Add(tarea);
        }
        public Tarea Get(int id)
        {
            return this._tareas[id];
        }
        public void Delete(int id)
        {
            this._tareas.RemoveAt(id);
        }
        public IList<Tarea> GetTareas()
        {
            return this._tareas;
        }
    }
}
