namespace AppFicha9.Models
{
    public static class Dados
    {
        private static List<Cliente> ListaClientes = new List<Cliente>();   
        
        public static List<Cliente> todosClientes()
        {
            return ListaClientes;
        }

        public static void adicionarNovoCliente(Cliente c)
        {
            int id = 0;
            if(ListaClientes.Count != 0)
            {
                id = ListaClientes.Last<Cliente>().Id + 1;
            }

            c.Id = id;
            ListaClientes.Add(c);
        }

        public static Cliente dados_cliente(int id)
        {
            Cliente c = ListaClientes.Where(i => i.Id == id).FirstOrDefault();
            return c;
        }

        public static void editarCliente(Cliente c)
        {
            ListaClientes.First<Cliente>(i => i.Id == c.Id).Nome = c.Nome;
            ListaClientes.First<Cliente>(i => i.Id == c.Id).Telefone = c.Telefone;
        }

        public static void eliminarCliente(int id)
        {
            var c = ListaClientes.First<Cliente>(i => i.Id == id);
            ListaClientes.Remove(c);
        }
    }
}
