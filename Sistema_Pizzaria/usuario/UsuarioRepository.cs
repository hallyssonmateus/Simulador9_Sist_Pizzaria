namespace Sistema_Pizzaria.usuario
{
    public static class UsuarioRepository
    {
        public static Usuario Get(string nome, string senha)
        {
            var usuarios = new List<Usuario>();
            usuarios.Add(new Usuario { Id = 1, Nome = "Pedro", Senha = "1234", Role = "cozinheiro" });
            usuarios.Add(new Usuario { Id = 2, Nome = "Carlos", Senha = "4321", Role = "garcom" });

            return usuarios.FirstOrDefault(x =>
                x.Nome == nome
                && x.Senha == senha);
        }
    }
}
