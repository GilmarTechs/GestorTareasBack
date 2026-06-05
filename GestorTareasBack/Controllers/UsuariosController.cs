[ApiController]
[Route("api/usuarios")]
public class UsuariosController : ControllerBase
{
    private readonly IUsuarioService _service;

    public UsuariosController(IUsuarioService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
        => Ok(_service.ObtenerTodos());

    [HttpPost]
    public IActionResult Post(CrearUsuarioDTO dto)
        => Ok(_service.Crear(dto));
}
