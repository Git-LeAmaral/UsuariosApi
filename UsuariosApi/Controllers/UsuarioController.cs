using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;
using UsuariosApi.Service;

namespace UsuariosApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    private UsuarioService _usuarioService;

    public UsuarioController(UsuarioService cadastroService)
    {
        _usuarioService = cadastroService;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDto dto)
    {
        await _usuarioService.Cadastro(dto);
        return Ok("Usuário cadastrado com sucesso!");
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(LoginUsuarioDto dto)
    {
        await _usuarioService.Login(dto);
        return Ok("Usuário autenticado!");
    }
}
