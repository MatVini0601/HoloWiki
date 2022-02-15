namespace ListagemMVC.Models
{
    public class Units
    {
        public string name { get; set; }

        public List<Units> getUnitsEN()
        {
            return new List<Units>()
            {
                new Units
                {
                    name = "Myth"
                },
                new Units
                {
                    name = "Council"
                },
                new Units
                {
                    name = "HOPE"
                }
            };
        }
        public List<Units> getUnitsJP()
        {
            return new List<Units>()
            {
                new Units
                {
                    name = "Generation 0"
                },
                new Units
                {
                    name = "1st Generation"
                },
                new Units
                {
                    name = "2nd Generation"
                },
                new Units
                {
                    name = "GAMERS"
                },
                new Units
                {
                    name = "Fantasy"
                },
                new Units
                {
                    name = "holoForce"
                },
                new Units
                {
                    name = "holoFive"
                },
                new Units
                {
                    name = "holoX"
                },
                new Units
                {
                    name = "INoNaKa"
                }
            };
        }
    }
}
