using Xunit;
using SistemaGestionGimnasio.Modelos;


namespace SistemaGestionGimnasio.Test
{
    public class EntrenadorTest
    {
        [Fact]
        public void AsignarUsuario_DebeAsignarUsuario()

        {
            Usuario usuario = new Usuario("Juan", 20, "Musculo");
            Entrenador entrenador = new Entrenador("Pancho", "Musculo");

            entrenador.AgregarUsuario(usuario);

            Assert.Contains("Juan", entrenador.ObtenerUsuariosAsignados()[0].Nombre);
        }
    }
}
