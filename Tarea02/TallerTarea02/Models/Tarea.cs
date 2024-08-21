namespace TallerTarea02.Models
{
    public class Tarea // id, nombre, desc, duración horas, responsabl
    {
        private long _id; //campo privado
        public long Id
        {
            set { _id = value; }
            get { return _id; } //propiedad suele estar asociadas
                                //a un campo privado de la clase
        }
        public string? Nombre { get; set; } //atributo opcional tipo string
        public string? Desc { get; set; }
        public int? Duracion { get; set; } //atributo opcional tipo entero
        public string? Responsable { get; set; }
        public DateTime? Fecha { get; set; }// Nuevo atributo de tipo fecha

        public Tarea(int id, string nombre, string desc, int duracion, string responsable)
        {
            this._id = id;
            this.Nombre = nombre;
            this.Desc = desc;
            this.Duracion = duracion;
            this.Responsable = responsable;
        }
        public Tarea(int id, string nombre, string desc, int duracion, string responsable, DateTime? fecha) 
        { 
            this._id = id;
            this.Nombre = nombre;
            this.Desc = desc;   
            this.Duracion = duracion;
            this.Responsable = responsable;
            this.Fecha = fecha;
        }

        public Tarea() { }

    }
}
