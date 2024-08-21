
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Xml.Linq;
using TallerTarea02.Models;

namespace TallerTarea02.Controllers
{
    [ApiController]
    [Route("api/tareas")]

    public class TareaController : Controller
    {
        private readonly ILogger<TareaController> _logger;

        private IList<Tarea> _tareaList;

        public TareaController(ILogger<TareaController> logger)
        {
            _logger = logger;
            this._tareaList = new List<Tarea>();
            this._tareaList.Add(new Tarea(1, "EDA", "programacion", 4, "Gualberto"));
            this._tareaList.Add(new Tarea(2, "Taller Java", "programacion", 6, "Gabriel"));
            this._tareaList.Add(new Tarea(3, "Programacion Avanzada", "programacion", 12, "Juan"));
            this._tareaList.Add(new Tarea(4, "Programacion Aplicaciones", "programacion", 4, "Andres"));
        }

        [HttpGet]
        public ActionResult<IList<Tarea>> GetAll()
        {
            _logger.LogInformation("Lista de todas las tareas");
            return Ok(this._tareaList.ToList());
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Tarea> GetById(int id)
        {
            _logger.LogInformation($"Tarea por Id {id}");
            return Ok(this._tareaList.FirstOrDefault(t => t.Id == id));
        }

        [HttpPost]
        public ActionResult NuevaTarea([FromBody]Tarea tarea)
        {
            _logger.LogInformation("Tarea nueva");
            this._tareaList.Add(tarea);
            return Ok();
        }

        [HttpDelete ("{id}")]
        public ActionResult DeleteById(int id)
        {
            _logger.LogInformation("Tarea borrado por id");
            this._tareaList.RemoveAt(id);
            return Ok();
        }
    }
}