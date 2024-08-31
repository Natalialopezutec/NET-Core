namespace TallerTarea02Minimal.Model
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Desc { get; set; }
        public int? Duracion { get; set; }
        public string? Responsable { get; set; }

        public Tarea() { }

        public Tarea(int id, string? nombre, string? desc, int? duracion, string? responsable)
        {
            Id = id;
            Nombre = nombre;
            Desc = desc;
            Duracion = duracion;
            Responsable = responsable;
         
        }

    }
}
