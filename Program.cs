//chiedere giorno, mese e anno ritorna la data formattata (implementare controlli) 30/1/2024

namespace Users
{
    internal class Program
    {
        static void Main(string[]args)
        {
            
            Console.WriteLine("Inserici dati utente");
            Console.WriteLine("Nome:");
            string readName = Console.ReadLine();
            Console.WriteLine("Cognome:");
            string readSurname = Console.ReadLine();
            Console.WriteLine("Età:");
            byte readEta = byte.Parse(Console.ReadLine());
            Persona utente1 = new Persona(readName,readSurname,readEta);
            utente1.GetDettagli();
            


        }
    }


    class Persona 
    {
        //fields

        private string _name;
        private string _cognome;
        private byte _eta;


        //properties

        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                if(value.Length > 0)
                {
                    _name = char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                if(value.Length > 0)
                {
                    _cognome = char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
            }
        }

        public byte Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                if(value > 0 &&  value<140)
                {
                    _eta=value;
                }
            }
        }

        public Persona(string nome, string cognome, byte eta)
        {
            Name = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public void GetDettagli()
        {
            Console.WriteLine("Nome: "+Name+" Cognome: "+Cognome+" Eta:"+Eta+";");
        }




    }

}
