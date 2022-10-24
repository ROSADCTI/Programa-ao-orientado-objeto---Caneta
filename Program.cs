// See https://aka.ms/new-console-template for more information
using System; 
public class Principal
{
    static void Main(string[] args)
    {
        Caneta objeto = new Caneta();
        Caneta ObjCH = new Caneta();
        
        objeto.Cor = "Vermelho";
        objeto.Tamanho = 12.0;
        objeto.Peso = 3.6;
        objeto.Tampada = true;
        // false(falso) true(verdadeiro)
        objeto.PercenteCarga = 50;
        objeto.Marca = "Faber Castell";
        objeto.Material = "Acrilico";
        objeto.Ponta = 1.0;
        objeto.TipoPonta = "Média";
        objeto.Caida = true;
        objeto.Estourada = true;

       ObjCH.Cor = "Verde";
       ObjCH.Tamanho = 8.0;
       ObjCH.Peso = 1.6;
       ObjCH.Tampada = true;
       ObjCH.PercenteCarga = 80;
       ObjCH.Marca = "Stabilio";
       ObjCH.Material = "Plastico rigido";
       ObjCH.Ponta = 0.4;
       ObjCH.TipoPonta = "Fino";
       ObjCH.Caida = false;
       ObjCH.Estourada = false;

        Console.WriteLine("\n*********** Caneta Esteriografica ******  ");
        objeto.dados();
        objeto.Cair();
        objeto.Destampar();
        objeto.Escrever();
        objeto.Tampar();
        objeto.Estourado();
     
        
        Console.WriteLine("\n*********** Caneta Hidrografica ****** ");
        ObjCH.dados();
        ObjCH.Cair();
        ObjCH.Destampar();
        ObjCH.Escrever();
        ObjCH.Tampar();
        ObjCH.Estourado();



    }
    public class Caneta
    {


        public string   Cor;
        public double   Tamanho;
        public double   Peso;
        public bool    Tampada;
        public int     PercenteCarga;
        public string  Marca;
        public string  Material;
        public double  Ponta;
        public string  TipoPonta;
        public bool   Caida;
        public bool   Estourada;

        public void Cair()
        {
            if (Caida == true)
            {
                Console.WriteLine("\nCaneta esta no chão");

            }

            else
            {
                Console.WriteLine("\nCaneta não esta caida");
            }

        }
        public void Destampar()
        {
            if (Tampada == true)
            {
                Console.WriteLine("\nDestampe a caneta");
            }
            else
            {
                Console.WriteLine("\nCaneta já esta destampar");
            }
        }
        public void Escrever()
        {
            if (Tampada == true)
            {
                Console.WriteLine("\nVocê não pode escrever com caneta tampada, retira tampa.");
            }
            else
            {
                Console.WriteLine("\n já  escrever com caneta");
            }

        }

        public void Tampar()
        {
            if (Tampada == true)
            {
                Console.WriteLine("\nCaneta esta tampada");
            }
            else
            {
                Console.WriteLine("\nTampar caneta.");
            }
        }
        public void Estourado()
        {
           if (Estourada == false)
            {
                Console.WriteLine("\nA caneta não estourada.");
            }
            else
            {
                Console.WriteLine("\nA caneta esta estourada, não  pode ser usado.\n\n");
            }
        }


        public void dados()
        {
           Console.WriteLine("\nCor: "+Cor);
           Console.WriteLine("\nTamanho: " + Tamanho);
           Console.WriteLine("\nPeso: " + Peso);
           Console.WriteLine("\nTampada: " + Tampada);
           Console.WriteLine("\nPercentcarga: " + PercenteCarga);
           Console.WriteLine("\nMarca: " + Marca);
           Console.WriteLine("\nMaterial: " + Material);
           Console.WriteLine("\nPonto: " + Ponta);
           Console.WriteLine("\nTipoPonta :" + TipoPonta);
           Console.WriteLine("\nCaida:" + Caida);
           Console.WriteLine("\nEstourada: " + Estourada);

        }
    }
}

