using CursoEFCore.Domain;
using CursoEFCore.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
           /* using var db =  new Data.ApplicationContext();            
            // para verificar se existe Migração pendente
            var existe = db.Database.GetPendingMigrations().Any();
            if (existe)
            {
                // aplicação da regra de negócio
            }
            Console.WriteLine("Hello, World!"); */  
            
            //InserirDados();  
            //InserirDadosEmMassa();     
            //ConsultarDados();    
            //CadastrarPedido();  
            //ConsultarPedidoCarregamentoAdiantado();
            //AtualizarDados();
            //RemoverRegistro();
        }  

    private static void RemoverRegistro()
    {
        using var db = new Data.ApplicationContext();

        //var cliente = db.Clientes.Find(2);
        var cliente = new Cliente { Id = 4};
        //db.Clientes.Remove(cliente);
        //db.Remove(cliente);
        db.Entry(cliente).State = EntityState.Deleted;
        db.SaveChanges();
    }

    private static void AtualizarDados()
    {
        using var db = new Data.ApplicationContext();
        //var cliente = db.Clientes.Find(1);

        var cliente = new Cliente
        {
            Id = 1
        };

        var clienteDesconectado = new 
        {
            Nome = "Cliente Desconectado Passo 3",
            Telefone = "7966669999"
        };
        
        db.Attach(cliente);
        db.Entry(cliente).CurrentValues.SetValues(clienteDesconectado);

        //db.Clientes.Update(cliente);
        db.SaveChanges();
    }

    private static void ConsultarPedidoCarregamentoAdiantado()
    {
        using var db = new Data.ApplicationContext();
        var pedidos = db
            .Pedidos
            .Include(p => p.Itens)
                .ThenInclude(p => p.Produto)
            .ToList();

        Console.WriteLine(pedidos.Count);
    }

    private static void CadastrarPedido()
    {
        using var db = new Data.ApplicationContext();

        var cliente = db.Clientes.FirstOrDefault();
        var produto = db.Produtos.FirstOrDefault();
        
        // Validando para não causar NullReferenceException
        if (cliente is null)
            throw new InvalidOperationException("Nenhum cliente cadastrado.");

        if (produto is null)
            throw new InvalidOperationException("Nenhum produto cadastrado.");
        //    

        var pedido = new Pedido
        {
            ClienteId = cliente.Id,
            IniciadoEm = DateTime.Now,
            FinalizadoEm = DateTime.Now,
            Observacao = "Pedido Teste",
            Status = StatusPedido.Analise,
            TipoFrete = TipoFrete.SemFrete,
            Itens = new List<PedidoItem>
                {
                    new PedidoItem
                    {
                        ProdutoId = produto.Id,
                        Desconto = 0,
                        Quantidade = 1,
                        Valor = 10,
                    }
                }
        };

        db.Pedidos.Add(pedido);
        db.SaveChanges();
    }    

    private static void ConsultarDados()
        {
            using var db = new Data.ApplicationContext();
            //var consultaPorSintaxe = (from cli in db.Clientes where cli.Id > 0 select cli).ToList();
            var consultaPorMetodo = db.Clientes
                .Where(p=>p.Id > 0)
                .OrderBy(p=>p.Id)
                .ToList();

            foreach(var cliente in consultaPorMetodo)
            {
                Console.WriteLine($"Consultando Cliente: {cliente.Id}");
                //db.Clientes.Find(cliente.Id);
                db.Clientes.FirstOrDefault(p=>p.Id==cliente.Id);
            }
        }    

    private static void InserirDadosEmMassa()
    {
        var produto = new Produto
        {
            Descricao = "Produto Teste",
            CodigoBarras = "9876543219753",
            Valor = 15m,
            TipoProduto = TipoProduto.MercadoriaParaRevenda,
            Ativo = true
        }; 

        var cliente = new Cliente
        {
            Nome = "Daiane Cordeiro",
            CEP = "15800000",
            Cidade = "Pindorama",
            Estado = "SP",
            Telefone = "17988001133",
        };

        var listaClientes = new[]
        {
            new Cliente
            {
                Nome = "Teste 1",
                CEP = "15700000",
                Cidade = "Catanduva",
                Estado = "SP",
                Telefone = "17988003366",   
            },
            new Cliente
            {
                Nome = "Teste 2",
                CEP = "15900000",
                Cidade = "Rio Preto",
                Estado = "SP",
                Telefone = "17988002244",   
            },            
        };        
        
        using var db = new Data.ApplicationContext();
        //db.AddRange(cliente, produto);
        db.Clientes.AddRange(listaClientes);
       
       var registros = db.SaveChanges();
        Console.WriteLine($"Total Registro(s): {registros}");
    }

    private static void InserirDados()
        {
            var produto = new Produto
            {
                Descricao = "Produto Teste",
                CodigoBarras = "1234567891231",
                Valor = 10m,
                TipoProduto = TipoProduto.MercadoriaParaRevenda,
                Ativo = true
            };
            using var db = new Data.ApplicationContext();
            //db.Produtos.Add(produto);
            //db.Set<Produto>().Add(produto);
            //db.Entry(produto).State = EntityState.Added;
            db.Add(produto);
            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registro(s): {registros}");
        }          
    }
}
