using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    class Conexao
    {
        SqlConnection cnn;

        public Conexao()
        {
            try
            {
                //Conexão SQL Local
                //cnn = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB; Initial Catalog = PDVCluster; Integrated Security=SSPI");

                //Conexão SQL Azure
                cnn = new SqlConnection(@"Server = tcp:pdvcluster.database.windows.net, 1433; Initial Catalog = PDVCluster; Persist Security Info = False; User ID = adminPDV; Password =Administrador!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão" + ex.ToString());
            }
        }

        #region Funcionario
        public SqlCommand SelecionarFuncionario(string id = "")
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_FUNCIONARIO ";

            if (id != "")
                strSQL += $"WHERE ID = {id} ";

            strSQL += "ORDER BY NOME ASC";

            cnn.Open();
            SqlCommand funcionario = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return funcionario;
        }

        public SqlCommand BuscarFuncionario(int idFuncionario)
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_FUNCIONARIO WHERE ID = {idFuncionario}";

            cnn.Open();
            SqlCommand funcionario = new SqlCommand(strSQL, cnn);
            funcionario.ExecuteNonQuery();
            cnn.Close();

            return funcionario;
        }

        public SqlCommand SelecionarFuncionarioPorLogin(string login = "")
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_FUNCIONARIO WHERE LOGIN = '{login}'";

            cnn.Open();
            SqlCommand funcionario = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return funcionario;
        }

        public SqlCommand SelecionarFuncionarioPorCodigoInterno(string codigoInterno)
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_FUNCIONARIO WHERE COD_INTERNO = '{codigoInterno}'";

            cnn.Open();
            SqlCommand funcionario = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return funcionario;
        }

        public SqlCommand IncluirFuncionario(string nome, string login, string endereco, string telefone, string cpf, string rg, string cod_interno, string salario, string nivel_acesso)
        {
            string strSQL = "INSERT INTO TB_CADASTRO_FUNCIONARIO (NOME, LOGIN, ENDERECO, TELEFONE, CPF, RG, COD_INTERNO, SALARIO, NIVEL_ACESSO) ";
            strSQL += "VALUES (@NOME, @LOGIN, @ENDERECO, @TELEFONE, @CPF, @RG, @COD_INTERNO, @SALARIO, @NIVEL_ACESSO)";

            cnn.Open();
            SqlCommand funcionario = new SqlCommand(strSQL, cnn);
            funcionario.Parameters.AddWithValue("@NOME", nome);
            funcionario.Parameters.AddWithValue("@LOGIN", login);
            funcionario.Parameters.AddWithValue("@ENDERECO", endereco);
            funcionario.Parameters.AddWithValue("@TELEFONE", telefone);
            funcionario.Parameters.AddWithValue("@CPF", cpf);
            funcionario.Parameters.AddWithValue("@RG", rg);
            funcionario.Parameters.AddWithValue("@COD_INTERNO", cod_interno);
            funcionario.Parameters.AddWithValue("@SALARIO", salario);
            funcionario.Parameters.AddWithValue("@NIVEL_ACESSO", nivel_acesso);
            funcionario.ExecuteNonQuery();
            cnn.Close();

            return funcionario;
        }

        public SqlCommand AlterarFuncionario(int id, string nome, string login, string endereco, string telefone, string cpf, string rg, string cod_interno, string salario, string nivel_acesso)
        {
            string strSQL = "UPDATE TB_CADASTRO_FUNCIONARIO ";
            strSQL += "SET NOME = @NOME, LOGIN = @LOGIN, ENDERECO = @ENDERECO, TELEFONE = @TELEFONE, CPF = @CPF, RG = @RG, COD_INTERNO = @COD_INTERNO, SALARIO = @SALARIO, NIVEL_ACESSO = @NIVEL_ACESSO ";
            strSQL += "WHERE ID = @ID";

            cnn.Open();
            SqlCommand funcionario = new SqlCommand(strSQL, cnn);
            funcionario.Parameters.AddWithValue("@ID", id);
            funcionario.Parameters.AddWithValue("@NOME", nome);
            funcionario.Parameters.AddWithValue("@LOGIN", login);
            funcionario.Parameters.AddWithValue("@ENDERECO", endereco);
            funcionario.Parameters.AddWithValue("@TELEFONE", telefone);
            funcionario.Parameters.AddWithValue("@CPF", cpf);
            funcionario.Parameters.AddWithValue("@RG", rg);
            funcionario.Parameters.AddWithValue("@COD_INTERNO", cod_interno);
            funcionario.Parameters.AddWithValue("@SALARIO", salario.Replace(",", "."));
            funcionario.Parameters.AddWithValue("@NIVEL_ACESSO", nivel_acesso);
            funcionario.ExecuteNonQuery();
            cnn.Close();

            return funcionario;
        }

        public SqlCommand AlterarSenhaFuncionario(string login, string senha)
        {
            string strSQL = "UPDATE TB_CADASTRO_FUNCIONARIO ";
            strSQL += "SET SENHA = @SENHA ";
            strSQL += "WHERE LOGIN = @LOGIN";

            cnn.Open();
            SqlCommand funcionario = new SqlCommand(strSQL, cnn);
            funcionario.Parameters.AddWithValue("@LOGIN", login);
            funcionario.Parameters.AddWithValue("@SENHA", senha);
            funcionario.ExecuteNonQuery();
            cnn.Close();

            return funcionario;
        }

        public SqlCommand ExcluirFuncionario(int idFuncionario)
        {
            string strSQL = $"DELETE FROM TB_CADASTRO_FUNCIONARIO WHERE ID = {idFuncionario}";

            cnn.Open();
            SqlCommand funcionario = new SqlCommand(strSQL, cnn);
            funcionario.ExecuteNonQuery();
            cnn.Close();

            return funcionario;
        }
        #endregion

        #region Fornecedor
        public SqlCommand SelecionarFornecedor(string nome)
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_FORNECEDOR WHERE NOME LIKE '%{nome}%'";

            cnn.Open();
            SqlCommand fornecedor = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return fornecedor;
        }

        public SqlCommand BuscarFornecedor(int? idFornecedor = null)
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_FORNECEDOR ";
            
            if (idFornecedor != null)
                strSQL += $"WHERE ID = {idFornecedor} ";

            strSQL += "ORDER BY NOME ASC";

            cnn.Open();
            SqlCommand fornecedor = new SqlCommand(strSQL, cnn);
            fornecedor.ExecuteNonQuery();
            cnn.Close();

            return fornecedor;
        }

        public SqlCommand IncluirFornecedor(string nome, string endereco, string telefone, string cnpj)
        {
            string strSQL = "INSERT INTO TB_CADASTRO_FORNECEDOR (NOME, ENDERECO, TELEFONE, CNPJ) ";
            strSQL += "VALUES (@NOME, @ENDERECO, @TELEFONE, @CNPJ)";

            cnn.Open();
            SqlCommand fornecedor = new SqlCommand(strSQL, cnn);
            fornecedor.Parameters.AddWithValue("@NOME", nome);
            fornecedor.Parameters.AddWithValue("@ENDERECO", endereco);
            fornecedor.Parameters.AddWithValue("@TELEFONE", telefone);
            fornecedor.Parameters.AddWithValue("@CNPJ", cnpj);
            fornecedor.ExecuteNonQuery();
            cnn.Close();

            return fornecedor;
        }

        public SqlCommand AlterarFornecedor(int id, string nome, string endereco, string telefone, string cnpj)
        {
            string strSQL = "UPDATE TB_CADASTRO_FORNECEDOR ";
            strSQL += "SET NOME = @NOME, ENDERECO = @ENDERECO, TELEFONE = @TELEFONE, CNPJ = @CNPJ ";
            strSQL += "WHERE ID = @ID";

            cnn.Open();
            SqlCommand fornecedor = new SqlCommand(strSQL, cnn);
            fornecedor.Parameters.AddWithValue("@ID", id);
            fornecedor.Parameters.AddWithValue("@NOME", nome);
            fornecedor.Parameters.AddWithValue("@ENDERECO", endereco);
            fornecedor.Parameters.AddWithValue("@TELEFONE", telefone);
            fornecedor.Parameters.AddWithValue("@CNPJ", cnpj);
            fornecedor.ExecuteNonQuery();
            cnn.Close();

            return fornecedor;
        }

        public SqlCommand ExcluirFornecedor(int idFornecedor)
        {
            string strSQL = $"DELETE FROM TB_CADASTRO_FORNECEDOR WHERE ID = {idFornecedor}";

            cnn.Open();
            SqlCommand fornecedor = new SqlCommand(strSQL, cnn);
            fornecedor.ExecuteNonQuery();
            cnn.Close();

            return fornecedor;
        }
        #endregion

        #region Produto
        public SqlCommand SelecionarProduto(string nome)
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_PRODUTO WHERE NOME like '%{nome}%'";

            cnn.Open();
            SqlCommand produto = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return produto;
        }

        public SqlCommand SelecionarProdutoPorId(string codInt)
        {
            string strSQL = $"SELECT ID, Nome, PRECO_VENDA FROM TB_CADASTRO_PRODUTO WHERE COD_INTERNO = {codInt}";

            cnn.Open();
            SqlCommand produto = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return produto;
        }

        //TODO separar fabricante e fornecedor
        public SqlCommand SelecionarProdutoPorFornecedor(int idFornecedor)
        {
            string strSQL = $"SELECT ID, Nome, PRECO_VENDA FROM TB_CADASTRO_PRODUTO WHERE ID_FABRICANTE = {idFornecedor}";

            cnn.Open();
            SqlCommand produto = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return produto;
        }

        public SqlCommand BuscarProduto(int idProduto)
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_PRODUTO WHERE ID = {idProduto}";

            cnn.Open();
            SqlCommand produto = new SqlCommand(strSQL, cnn);
            produto.ExecuteNonQuery();

            cnn.Close();

            return produto;
        }

        public SqlCommand BuscarProdutoPorCodigo(int codProduto)
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_PRODUTO WHERE COD_INTERNO = {codProduto}";

            cnn.Open();
            SqlCommand produto = new SqlCommand(strSQL, cnn);
            produto.ExecuteNonQuery();

            cnn.Close();

            return produto;
        }

        public SqlCommand IncluirProduto(string nome, string codbarras, string codinterno, string precovenda, string margemlucro, string fabricante, string precocompra)
        {
            string strSQL = "INSERT INTO TB_CADASTRO_PRODUTO (NOME, COD_BARRAS, COD_INTERNO, PRECO_COMPRA, PRECO_VENDA, MARGEM_LUCRO, ID_FABRICANTE) ";
            strSQL += "VALUES(@NOME, @COD_BARRAS, @COD_INTERNO, @PRECO_COMPRA, @PRECO_VENDA, @MARGEM_LUCRO, @ID_FABRICANTE)";

            cnn.Open();
            SqlCommand produto = new SqlCommand(strSQL, cnn);
            produto.Parameters.AddWithValue("@NOME", nome);
            produto.Parameters.AddWithValue("@COD_BARRAS", codbarras);
            produto.Parameters.AddWithValue("@COD_INTERNO", codinterno);
            produto.Parameters.AddWithValue("@PRECO_COMPRA", precocompra);
            produto.Parameters.AddWithValue("@PRECO_VENDA", precovenda);
            produto.Parameters.AddWithValue("@MARGEM_LUCRO", margemlucro);
            produto.Parameters.AddWithValue("@ID_FABRICANTE", fabricante);
            produto.ExecuteNonQuery();
            cnn.Close();

            return produto;
        }

        public SqlCommand AlterarProduto(int id, string nome, string codBarras, string codInterno, string precoVenda, string margemLucro, string fabricante, string precoCompra)
        {
            string strSQL = "UPDATE TB_CADASTRO_PRODUTO ";
            strSQL += "SET NOME = @NOME, COD_BARRAS = @COD_BARRAS, COD_INTERNO = @COD_INTERNO, PRECO_COMPRA = @PRECO_COMPRA, ";
            strSQL += "PRECO_VENDA = @PRECO_VENDA, MARGEM_LUCRO = @MARGEM_LUCRO, ID_FABRICANTE = @ID_FABRICANTE ";
            strSQL += "WHERE ID = @ID";

            cnn.Open();
            SqlCommand produto = new SqlCommand(strSQL, cnn);
            produto.Parameters.AddWithValue("@ID", id);
            produto.Parameters.AddWithValue("@NOME", nome);
            produto.Parameters.AddWithValue("@COD_BARRAS", codBarras);
            produto.Parameters.AddWithValue("@COD_INTERNO", codInterno);
            produto.Parameters.AddWithValue("@PRECO_COMPRA", Convert.ToDecimal(precoCompra));
            produto.Parameters.AddWithValue("@PRECO_VENDA", Convert.ToDecimal(precoVenda));
            produto.Parameters.AddWithValue("@MARGEM_LUCRO", Convert.ToDecimal(margemLucro));
            produto.Parameters.AddWithValue("@ID_FABRICANTE", fabricante);
            produto.ExecuteNonQuery();
            cnn.Close();

            return produto;
        }

        public SqlCommand ExcluirProduto(int Id_produto)
        {
            string strSQL = $"DELETE FROM TB_CADASTRO_PRODUTO WHERE ID = {Id_produto}";

            cnn.Open();
            SqlCommand produto = new SqlCommand(strSQL, cnn);
            produto.ExecuteNonQuery();

            cnn.Close();

            return produto;
        }
        #endregion

        #region Caixa
        public SqlCommand SelecionarCaixa(int? id = null)
        {
            string strSQL = $"SELECT ID, DESCRICAO, STATUS FROM TB_CAIXA ";

            if (id != null)
                strSQL += $"WHERE ID = {id} ";

            strSQL += "ORDER BY DESCRICAO ASC";

            cnn.Open();
            SqlCommand caixa = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return caixa;
        }

        public SqlCommand SelecionarProdutoCaixa(string nome)
        {
            string strSQL = $"SELECT * FROM TB_CADASTRO_PRODUTO WHERE NOME LIKE '%{nome}%'";

            cnn.Open();
            SqlCommand produtoCaixa = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return produtoCaixa;
        }

        public SqlCommand SelecionarVenda(int idVenda)
        {
            string strSQL = $"SELECT * FROM TB_VENDA WHERE ID = '{idVenda}'";

            cnn.Open();
            SqlCommand itemVenda = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return itemVenda;
        }

        public SqlCommand SelecionarItemVenda(int idVenda)
        {
            string strSQL = $"SELECT * FROM TB_ITEM_VENDA WHERE ID_VENDA = '{idVenda}'";

            cnn.Open();
            SqlCommand itemVenda = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return itemVenda;
        }

        public SqlCommand SelecionarItemVendaSubTotal(int idVenda)
        {
            string strSQL = $"SELECT ISNULL(SUM(VALOR_SUBTOTAL), 0) FROM TB_ITEM_VENDA WHERE ID_VENDA = '{idVenda}'";

            cnn.Open();
            SqlCommand subTotal = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return subTotal;
        }

        public SqlCommand SelecionarItemVendaProduto(int idVenda, int idProduto)
        {
            string strSQL = $"SELECT ID, QTD FROM TB_ITEM_VENDA WHERE ID_VENDA = {idVenda} AND ID_PRODUTO = {idProduto}";

            cnn.Open();
            SqlCommand itemVenda = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return itemVenda;
        }

        public SqlCommand SelecionarItemVendaPorProduto(int idProduto)
        {
            string strSQL = $"SELECT ID, QTD FROM TB_ITEM_VENDA WHERE ID_PRODUTO = {idProduto}";

            cnn.Open();
            SqlCommand itemVenda = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return itemVenda;
        }

        public int IncluirVenda(int idFuncionario,
                                int idCaixa,
                                decimal valor,
                                decimal valorTotal,
                                DateTime data)
        {
            string strSQL = "INSERT INTO TB_VENDA (ID_FUNCIONARIO, ID_CAIXA, VALOR, VALOR_TOTAL, DATA) ";
            strSQL += "VALUES(@ID_FUNCIONARIO, @ID_CAIXA, @VALOR, @VALOR_TOTAL, @DATA); SELECT SCOPE_IDENTITY();";

            cnn.Open();
            SqlCommand venda = new SqlCommand(strSQL, cnn);
            venda.Parameters.AddWithValue("@ID_FUNCIONARIO", idFuncionario);
            venda.Parameters.AddWithValue("@ID_CAIXA", idCaixa);
            venda.Parameters.AddWithValue("@VALOR", valor);
            venda.Parameters.AddWithValue("@VALOR_TOTAL", valorTotal);
            venda.Parameters.AddWithValue("@DATA", data);
            int id = Convert.ToInt32(venda.ExecuteScalar());
            cnn.Close();

            return id;
        }

        public SqlCommand IncluirItemVenda(int idVenda,
                                           int idProduto,
                                           string nomeProduto,
                                           int qtd,
                                           decimal valorUnitario)
        {
            decimal subtotal = valorUnitario * qtd;

            string strSQL = "INSERT INTO TB_ITEM_VENDA (ID_VENDA, ID_PRODUTO, NOME_PRODUTO, QTD, VALOR_UNITARIO, VALOR_SUBTOTAL) ";
            strSQL += "VALUES(@ID_VENDA, @ID_PRODUTO, @NOME_PRODUTO, @QTD, @VALOR_UNITARIO, @VALOR_SUBTOTAL)";

            cnn.Open();
            SqlCommand itemVenda = new SqlCommand(strSQL, cnn);
            itemVenda.Parameters.AddWithValue("@ID_VENDA", idVenda);
            itemVenda.Parameters.AddWithValue("@ID_PRODUTO", idProduto);
            itemVenda.Parameters.AddWithValue("@NOME_PRODUTO", nomeProduto);
            itemVenda.Parameters.AddWithValue("@QTD", qtd);
            itemVenda.Parameters.AddWithValue("@VALOR_UNITARIO", valorUnitario);
            itemVenda.Parameters.AddWithValue("@VALOR_SUBTOTAL", subtotal);
            itemVenda.ExecuteNonQuery();
            cnn.Close();

            return itemVenda;
        }

        public SqlCommand AlterarItemVenda(int idItemVenda, int qtd, decimal valorUnitario)
        {
            decimal subtotal = valorUnitario * qtd;

            string strSQL = "UPDATE TB_ITEM_VENDA SET QTD = @QTD, VALOR_SUBTOTAL = @VALOR_SUBTOTAL WHERE ID = @ID";

            cnn.Open();
            SqlCommand itemVenda = new SqlCommand(strSQL, cnn);
            itemVenda.Parameters.AddWithValue("@ID", idItemVenda);
            itemVenda.Parameters.AddWithValue("@QTD", qtd);
            itemVenda.Parameters.AddWithValue("@VALOR_UNITARIO", valorUnitario);
            itemVenda.Parameters.AddWithValue("@VALOR_SUBTOTAL", subtotal);
            itemVenda.ExecuteNonQuery();
            cnn.Close();

            return itemVenda;
        }

        public SqlCommand ExcluirItemVenda(int id)
        {
            string strSQL = $"DELETE FROM TB_ITEM_VENDA WHERE ID = {id}";

            cnn.Open();
            SqlCommand itemVenda = new SqlCommand(strSQL, cnn);
            itemVenda.ExecuteNonQuery();
            cnn.Close();

            return itemVenda;
        }

        public SqlCommand FinalizarVenda(int id,
                                         int idFuncionario,
                                         int idCaixa,
                                         int idTipoPagamento,
                                         string cpf,
                                         decimal valor,
                                         decimal valorTotal,
                                         decimal desconto,
                                         decimal valorRecebido,
                                         decimal troco
            )
        {
            string strSQL = "UPDATE TB_VENDA ";
            strSQL += "SET ID_FUNCIONARIO = @ID_FUNCIONARIO, ID_CAIXA = @ID_CAIXA, ";
            strSQL += "ID_TIPO_PAGAMENTO = @ID_TIPO_PAGAMENTO, CPF = @CPF, VALOR = @VALOR, ";
            strSQL += "VALOR_TOTAL = @VALOR_TOTAL, DESCONTO = @DESCONTO, VALOR_RECEBIDO = @VALOR_RECEBIDO, TROCO = @TROCO, DATA = @DATA ";
            strSQL += "WHERE ID = @ID";

            cnn.Open();
            SqlCommand venda = new SqlCommand(strSQL, cnn);
            venda.Parameters.AddWithValue("@ID", id);
            venda.Parameters.AddWithValue("@ID_FUNCIONARIO", idFuncionario);
            venda.Parameters.AddWithValue("@ID_CAIXA", idCaixa);
            venda.Parameters.AddWithValue("@ID_TIPO_PAGAMENTO", idTipoPagamento);
            venda.Parameters.AddWithValue("@CPF", cpf);
            venda.Parameters.AddWithValue("@VALOR", valor);
            venda.Parameters.AddWithValue("@VALOR_TOTAL", valorTotal);
            venda.Parameters.AddWithValue("@DESCONTO", desconto);
            venda.Parameters.AddWithValue("@VALOR_RECEBIDO", valorRecebido);
            venda.Parameters.AddWithValue("@TROCO", troco);
            venda.Parameters.AddWithValue("@DATA", DateTime.Now);
            venda.ExecuteNonQuery();
            cnn.Close();

            return venda;
        }

        public SqlCommand SelecionarTipoPagamento(string id = "")
        {
            string strSQL = $"SELECT ID, DESCRICAO FROM TB_TIPO_PAGAMENTO ";

            if (id != "")
                strSQL += $"WHERE ID = {id} ";

            strSQL += "ORDER BY DESCRICAO ASC";

            cnn.Open();
            SqlCommand produto = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return produto;
        }

        public SqlCommand SelecionarFechamentoCaixa(int idCaixa, DateTime data)
        {
            string strSQL = "SELECT ID_TIPO_PAGAMENTO, VALOR ";
            strSQL += "FROM TB_FECHAMENTO_CAIXA ";
            strSQL += "WHERE ID_CAIXA = @ID_CAIXA ";
            strSQL += "AND DATA = @DATA ";

            cnn.Open();
            SqlCommand caixa = new SqlCommand(strSQL, cnn);
            caixa.Parameters.AddWithValue("@ID_CAIXA", idCaixa);
            caixa.Parameters.AddWithValue("@DATA", data.Date);
            caixa.ExecuteNonQuery();
            cnn.Close();

            return caixa;
        }

        public SqlCommand SelecionarTotalCaixa(int idCaixa, DateTime data)
        {
            string strSQL = "SELECT ID_TIPO_PAGAMENTO, SUM(VALOR_TOTAL) ";
            strSQL += "FROM TB_VENDA ";
            strSQL += "WHERE ID_CAIXA = @ID_CAIXA ";
            strSQL += "AND DATA = @DATA ";
            strSQL += "GROUP BY ID_TIPO_PAGAMENTO ";

            cnn.Open();
            SqlCommand caixa = new SqlCommand(strSQL, cnn);
            caixa.Parameters.AddWithValue("@ID_CAIXA", idCaixa);
            caixa.Parameters.AddWithValue("@DATA", data.Date);
            caixa.ExecuteNonQuery();
            cnn.Close();

            return caixa;
        }

        public SqlCommand AbrirCaixas()
        {
            string strSQL = "UPDATE TB_CAIXA SET STATUS = 1";

            cnn.Open();
            SqlCommand caixa = new SqlCommand(strSQL, cnn);
            caixa.ExecuteNonQuery();
            cnn.Close();

            return caixa;
        }

        public SqlCommand FecharCaixa(int idCaixa, DateTime data)
        {
            string strSQL = "UPDATE TB_CAIXA SET STATUS = 0 ";
            strSQL += "WHERE ID = @ID_CAIXA ";
            strSQL += "INSERT INTO TB_FECHAMENTO_CAIXA ";
            strSQL += "SELECT ID_CAIXA, ID_TIPO_PAGAMENTO, SUM(VALOR_TOTAL), DATA ";
            strSQL += "FROM TB_VENDA ";
            strSQL += "WHERE ID_CAIXA = @ID_CAIXA ";
            strSQL += "AND DATA = @DATA ";
            strSQL += "GROUP BY ID_CAIXA, ID_TIPO_PAGAMENTO, DATA ";

            cnn.Open();
            SqlCommand caixa = new SqlCommand(strSQL, cnn);
            caixa.Parameters.AddWithValue("@ID_CAIXA", idCaixa);
            caixa.Parameters.AddWithValue("@DATA", data.Date);
            caixa.ExecuteNonQuery();
            cnn.Close();

            return caixa;
        }
        #endregion

        #region NivelAcesso

        public SqlCommand SelecionarNivelAcesso(string id = "")
        {
            string strSQL = $"SELECT ID_ACESSO, DESCRICAO FROM TB_NIVEL_ACESSO ";

            if (id != "")
                strSQL += $" WHERE ID_ACESSO = {id}";

            strSQL += " ORDER BY DESCRICAO ASC";

            cnn.Open();
            SqlCommand nivelacesso = new SqlCommand(strSQL, cnn);
            cnn.Close();

            return nivelacesso;
        }

        #endregion
    }
}