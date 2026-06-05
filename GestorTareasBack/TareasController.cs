[HttpGet("usuario/{usuarioId}")]
public IActionResult GetByUser(int usuarioId)
{
    return Ok(_service.ObtenerPorUsuario(usuarioId));
}
