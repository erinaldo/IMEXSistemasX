using System;

// Classe de Modelo (Objeto de transporte)
namespace BMSworks.Model
{
	[Serializable]
	public partial class PRODUTOS2NFEEntity
	{
		private int _IDPRODUTO;
		private string _NOMEPRODUTO;
		private string _CODPRODUTOFORNECEDOR;
		private string _CODBARRA;
		private string _LOCALIZACAO;
		private DateTime? _DATACADASTRO;
		private int? _IDUNIDADE;
		private int? _IDMARCA;
		private int? _IDMOEDA;
		private decimal? _VALORCUSTOINICIAL;
		private decimal? _FRETEPRODUTO;
		private decimal? _ENCARGOSPRODUTOS;
		private decimal? _VALORCUSTOFINAL;
		private decimal? _MARGEMLUCRO;
		private decimal? _VALORVENDA1;
		private decimal? _VALORVENDA2;
		private decimal? _VALORVENDA3;
		private decimal? _COMISSAO;
		private decimal? _IPI;
		private decimal? _ICMS;
		private decimal? _QUANTIDADEMINIMA;
		private decimal? _ESTOQUEATUAL;
		private int? _IDGRUPOCATEGORIA;
		private int? _IDSTATUS;
		private string _OBSERVACAO;
		private decimal? _PORCFRETE;
		private decimal? _PORCENCARGOS;
		private decimal? _PORCMARGEMLUCRO;
		private decimal? _PORCVENDA2;
		private decimal? _PORCVENDA3;
		private decimal? _PESO;
		private int? _IDCLASSIFICACAO;
		private int? _IDCST;
		private string _NCMSH;
		private string _EXTIPI;
		private decimal? _ALIQPIS;
		private decimal? _ALIQCOFINS;
		private string _CSTPISCONFIS;

		#region Construtores

		//Construtor default
		public PRODUTOS2NFEEntity() {
			this._DATACADASTRO = null;
			this._IDUNIDADE = null;
			this._IDMARCA = null;
			this._IDMOEDA = null;
			this._VALORCUSTOINICIAL = null;
			this._FRETEPRODUTO = null;
			this._ENCARGOSPRODUTOS = null;
			this._VALORCUSTOFINAL = null;
			this._MARGEMLUCRO = null;
			this._VALORVENDA1 = null;
			this._VALORVENDA2 = null;
			this._VALORVENDA3 = null;
			this._COMISSAO = null;
			this._IPI = null;
			this._ICMS = null;
			this._QUANTIDADEMINIMA = null;
			this._ESTOQUEATUAL = null;
			this._IDGRUPOCATEGORIA = null;
			this._IDSTATUS = null;
			this._PORCFRETE = null;
			this._PORCENCARGOS = null;
			this._PORCMARGEMLUCRO = null;
			this._PORCVENDA2 = null;
			this._PORCVENDA3 = null;
			this._PESO = null;
			this._IDCLASSIFICACAO = null;
			this._IDCST = null;
			this._ALIQPIS = null;
			this._ALIQCOFINS = null;
		}

		public PRODUTOS2NFEEntity(int IDPRODUTO, string NOMEPRODUTO, string CODPRODUTOFORNECEDOR, string CODBARRA, string LOCALIZACAO, DateTime? DATACADASTRO, int? IDUNIDADE, int? IDMARCA, int? IDMOEDA, decimal? VALORCUSTOINICIAL, decimal? FRETEPRODUTO, decimal? ENCARGOSPRODUTOS, decimal? VALORCUSTOFINAL, decimal? MARGEMLUCRO, decimal? VALORVENDA1, decimal? VALORVENDA2, decimal? VALORVENDA3, decimal? COMISSAO, decimal? IPI, decimal? ICMS, decimal? QUANTIDADEMINIMA, decimal? ESTOQUEATUAL, int? IDGRUPOCATEGORIA, int? IDSTATUS, string OBSERVACAO, decimal? PORCFRETE, decimal? PORCENCARGOS, decimal? PORCMARGEMLUCRO, decimal? PORCVENDA2, decimal? PORCVENDA3, decimal? PESO, int? IDCLASSIFICACAO, int? IDCST, string NCMSH, string EXTIPI, decimal? ALIQPIS, decimal? ALIQCOFINS, string CSTPISCONFIS) {

			this._IDPRODUTO = IDPRODUTO;
			this._NOMEPRODUTO = NOMEPRODUTO;
			this._CODPRODUTOFORNECEDOR = CODPRODUTOFORNECEDOR;
			this._CODBARRA = CODBARRA;
			this._LOCALIZACAO = LOCALIZACAO;
			this._DATACADASTRO = DATACADASTRO;
			this._IDUNIDADE = IDUNIDADE;
			this._IDMARCA = IDMARCA;
			this._IDMOEDA = IDMOEDA;
			this._VALORCUSTOINICIAL = VALORCUSTOINICIAL;
			this._FRETEPRODUTO = FRETEPRODUTO;
			this._ENCARGOSPRODUTOS = ENCARGOSPRODUTOS;
			this._VALORCUSTOFINAL = VALORCUSTOFINAL;
			this._MARGEMLUCRO = MARGEMLUCRO;
			this._VALORVENDA1 = VALORVENDA1;
			this._VALORVENDA2 = VALORVENDA2;
			this._VALORVENDA3 = VALORVENDA3;
			this._COMISSAO = COMISSAO;
			this._IPI = IPI;
			this._ICMS = ICMS;
			this._QUANTIDADEMINIMA = QUANTIDADEMINIMA;
			this._ESTOQUEATUAL = ESTOQUEATUAL;
			this._IDGRUPOCATEGORIA = IDGRUPOCATEGORIA;
			this._IDSTATUS = IDSTATUS;
			this._OBSERVACAO = OBSERVACAO;
			this._PORCFRETE = PORCFRETE;
			this._PORCENCARGOS = PORCENCARGOS;
			this._PORCMARGEMLUCRO = PORCMARGEMLUCRO;
			this._PORCVENDA2 = PORCVENDA2;
			this._PORCVENDA3 = PORCVENDA3;
			this._PESO = PESO;
			this._IDCLASSIFICACAO = IDCLASSIFICACAO;
			this._IDCST = IDCST;
			this._NCMSH = NCMSH;
			this._EXTIPI = EXTIPI;
			this._ALIQPIS = ALIQPIS;
			this._ALIQCOFINS = ALIQCOFINS;
			this._CSTPISCONFIS = CSTPISCONFIS;
		}
		#endregion

		#region Propriedades Get/Set

		public int IDPRODUTO
		{
			get { return _IDPRODUTO; }
			set { _IDPRODUTO = value; }
		}

		public string NOMEPRODUTO
		{
			get { return _NOMEPRODUTO; }
			set { _NOMEPRODUTO = value; }
		}

		public string CODPRODUTOFORNECEDOR
		{
			get { return _CODPRODUTOFORNECEDOR; }
			set { _CODPRODUTOFORNECEDOR = value; }
		}

		public string CODBARRA
		{
			get { return _CODBARRA; }
			set { _CODBARRA = value; }
		}

		public string LOCALIZACAO
		{
			get { return _LOCALIZACAO; }
			set { _LOCALIZACAO = value; }
		}

		public DateTime? DATACADASTRO
		{
			get { return _DATACADASTRO; }
			set { _DATACADASTRO = value; }
		}

		public int? IDUNIDADE
		{
			get { return _IDUNIDADE; }
			set { _IDUNIDADE = value; }
		}

		public int? IDMARCA
		{
			get { return _IDMARCA; }
			set { _IDMARCA = value; }
		}

		public int? IDMOEDA
		{
			get { return _IDMOEDA; }
			set { _IDMOEDA = value; }
		}

		public decimal? VALORCUSTOINICIAL
		{
			get { return _VALORCUSTOINICIAL; }
			set { _VALORCUSTOINICIAL = value; }
		}

		public decimal? FRETEPRODUTO
		{
			get { return _FRETEPRODUTO; }
			set { _FRETEPRODUTO = value; }
		}

		public decimal? ENCARGOSPRODUTOS
		{
			get { return _ENCARGOSPRODUTOS; }
			set { _ENCARGOSPRODUTOS = value; }
		}

		public decimal? VALORCUSTOFINAL
		{
			get { return _VALORCUSTOFINAL; }
			set { _VALORCUSTOFINAL = value; }
		}

		public decimal? MARGEMLUCRO
		{
			get { return _MARGEMLUCRO; }
			set { _MARGEMLUCRO = value; }
		}

		public decimal? VALORVENDA1
		{
			get { return _VALORVENDA1; }
			set { _VALORVENDA1 = value; }
		}

		public decimal? VALORVENDA2
		{
			get { return _VALORVENDA2; }
			set { _VALORVENDA2 = value; }
		}

		public decimal? VALORVENDA3
		{
			get { return _VALORVENDA3; }
			set { _VALORVENDA3 = value; }
		}

		public decimal? COMISSAO
		{
			get { return _COMISSAO; }
			set { _COMISSAO = value; }
		}

		public decimal? IPI
		{
			get { return _IPI; }
			set { _IPI = value; }
		}

		public decimal? ICMS
		{
			get { return _ICMS; }
			set { _ICMS = value; }
		}

		public decimal? QUANTIDADEMINIMA
		{
			get { return _QUANTIDADEMINIMA; }
			set { _QUANTIDADEMINIMA = value; }
		}

		public decimal? ESTOQUEATUAL
		{
			get { return _ESTOQUEATUAL; }
			set { _ESTOQUEATUAL = value; }
		}

		public int? IDGRUPOCATEGORIA
		{
			get { return _IDGRUPOCATEGORIA; }
			set { _IDGRUPOCATEGORIA = value; }
		}

		public int? IDSTATUS
		{
			get { return _IDSTATUS; }
			set { _IDSTATUS = value; }
		}

		public string OBSERVACAO
		{
			get { return _OBSERVACAO; }
			set { _OBSERVACAO = value; }
		}

		public decimal? PORCFRETE
		{
			get { return _PORCFRETE; }
			set { _PORCFRETE = value; }
		}

		public decimal? PORCENCARGOS
		{
			get { return _PORCENCARGOS; }
			set { _PORCENCARGOS = value; }
		}

		public decimal? PORCMARGEMLUCRO
		{
			get { return _PORCMARGEMLUCRO; }
			set { _PORCMARGEMLUCRO = value; }
		}

		public decimal? PORCVENDA2
		{
			get { return _PORCVENDA2; }
			set { _PORCVENDA2 = value; }
		}

		public decimal? PORCVENDA3
		{
			get { return _PORCVENDA3; }
			set { _PORCVENDA3 = value; }
		}

		public decimal? PESO
		{
			get { return _PESO; }
			set { _PESO = value; }
		}

		public int? IDCLASSIFICACAO
		{
			get { return _IDCLASSIFICACAO; }
			set { _IDCLASSIFICACAO = value; }
		}

		public int? IDCST
		{
			get { return _IDCST; }
			set { _IDCST = value; }
		}

		public string NCMSH
		{
			get { return _NCMSH; }
			set { _NCMSH = value; }
		}

		public string EXTIPI
		{
			get { return _EXTIPI; }
			set { _EXTIPI = value; }
		}

		public decimal? ALIQPIS
		{
			get { return _ALIQPIS; }
			set { _ALIQPIS = value; }
		}

		public decimal? ALIQCOFINS
		{
			get { return _ALIQCOFINS; }
			set { _ALIQCOFINS = value; }
		}

		public string CSTPISCONFIS
		{
			get { return _CSTPISCONFIS; }
			set { _CSTPISCONFIS = value; }
		}

		#endregion
	}
}
