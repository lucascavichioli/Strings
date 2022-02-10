using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guid();
            //Interpolacao();
            //ComparacaoStrings();
            //StartEndString();
            //EqualsO();
            //Indices();
            //MetodosAdicionais();
            //ManipulacaoStrings();
            StringBuilder();
        }

        static void Guid()
        {
            var id = System.Guid.NewGuid();
            id.ToString();
            Console.WriteLine(id);
        }

        static void Interpolacao()
        {
            var price = 10.2;
            var texto = "O preço do produto é " + price + " apenas na promoção";
            var texto2 = string.Format("O preço do produto é {0} apenas na promoção", price);

            var texto3 = $"O preço do produto é {price}";

            var texto4 = $@"O preço do
                          produto \n é {price}";
            
            
            Console.WriteLine(texto + "\n" + texto2 + "\n" + texto3 + "\n" + texto4);

        }

        static void ComparacaoStrings()
        {

            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando"));

            Console.WriteLine(texto.Contains("Testando"));
            Console.WriteLine(texto.Contains("testando", StringComparison.OrdinalIgnoreCase));

        }

        static void StartEndString()
        {

            var texto = "Texto para testes";
            Console.WriteLine(texto.StartsWith("Texto"));
            Console.WriteLine(texto.StartsWith("texto"));
            Console.WriteLine(texto.StartsWith("qualquer"));

            Console.WriteLine(texto.EndsWith("testes"));
            Console.WriteLine(texto.EndsWith("Testes"));
            Console.WriteLine(texto.EndsWith("qualquer"));


        }

        static void EqualsO() 
        {
            var texto = "Texto";
            Console.WriteLine(texto.Equals("Texto"));
            Console.WriteLine(texto.Equals("texto"));
            Console.WriteLine(texto.Equals("texto", StringComparison.OrdinalIgnoreCase));
        }

        static void Indices()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }

        static void MetodosAdicionais()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Insert(5, " AQUI "));
            Console.WriteLine(texto.Remove(5, 5));
            Console.WriteLine(texto.Length);
        }


        static void ManipulacaoStrings()
        {
            var texto = " Este texto é um teste ";
            Console.WriteLine(texto.Replace("e", "X"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);


            //var resultado = texto.Substring(5, 5);
            var resultado = texto.Substring(5, texto.LastIndexOf("o"));
            Console.WriteLine(resultado);

            Console.WriteLine(texto.Trim());
        }

        static void StringBuilder() 
        {
            var texto = new StringBuilder();
            //var texto2 = "Este texto é um teste";
            //var texto2 += " mais um";
            texto.Append("Este texto é um teste");
            texto.Append("AWDAWDAWDAWDAWD");
            texto.Append("tjhfjfthfthfthfth");
            texto.Append("vnvbnvgnvgnvgnvgn");
            texto.Append("lmko,po,po,pp,");

            texto.ToString();
            Console.WriteLine(texto);

        }
    }
}
