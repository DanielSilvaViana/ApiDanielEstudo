using ApiDanielEstudo.Dto;
using ApiDanielEstudo.Model;

namespace ApiDanielEstudo.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDto usuarioCriacaoDto);
        Task<ResponseModel<List<UsuarioModel>>> ListarUsuarios();
    }
}
