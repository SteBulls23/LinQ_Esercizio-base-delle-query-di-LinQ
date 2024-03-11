namespace EsercizioLinQ_OperazioniListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeriInteri = new List<int>() { 10, 123, 19, 27, 36, 78, 245, 1567, 89, 765 };
            List<string> animali = new List<string>() { "cane", "gatto", "topo", "balena", "canguro", "scoiattolo", "pesce", "tasso", "iena", "ragno" };
            bool cicla = true;
            opzioniGenerali();
            do
            {
                Console.WriteLine("\nScegli un'opzione tra quelle disponibili nel menù delle opzioni generali!\n");
                char scelta = char.Parse(Console.ReadLine());
                if (scelta == 'V')
                {
                    visualizzaListe(numeriInteri, animali);
                }
                else if (scelta == 'F')
                {
                    filtraggioNumeri(numeriInteri);
                }
                else if (scelta == 'O')
                {
                    ordinamentoListaAnimali(animali);
                }
                else if (scelta == 'R')
                {
                    ricercaElememto(numeriInteri, animali);
                }
                else if (scelta == 'S')
                {
                    calcolaSomma(numeriInteri);
                }
                else if (scelta == 'U')
                {
                    unisciListe(numeriInteri, animali);
                }
                else if (scelta == 'E')
                {
                    cicla = false;
                    Console.WriteLine("\nGrazie per aver utilizzato questo programma! Arrivederci e buona giornata!\n");
                }
                else
                {
                    Console.WriteLine("\nERRORE! L'opzione che hai scelto non è tra quelle disponibili nel menù! Scegli un'altra opzione!\n");
                }

            } while (cicla);
        }

        public static void opzioniGenerali()
        {
            Console.WriteLine("---------------SCEGLI UN'OPZIONE---------------");
            Console.WriteLine("1) Premi 'V' per visualizzare a schermo le due liste!");
            Console.WriteLine("2) Premi 'F' per filtrare la lista di numeri interi in base a determinati criteri!");
            Console.WriteLine("3) Premi 'O' per ordinare la lista di animali in ordine alfabetico!");
            Console.WriteLine("4) Premi 'R' per ricercare un elemento specifico all'interno di una delle due liste!");
            Console.WriteLine("5) Premi 'S' per calcolare la somma di tutti gli elementi della lista di numeri interi!");
            Console.WriteLine("6) Premi 'U' per unire le due liste, senza duplicati!");
            Console.WriteLine("7) Premi 'E' per uscire dal programma!");
            Console.WriteLine("---------------FINE DELLE OPZIONI---------------\n");
        }

        public static void opzioniFiltraggioNumeri()
        {
            Console.WriteLine("\n---------------SCEGLI UN'OPZIONE---------------");
            Console.WriteLine("1) Premi '1' se vuoi visualizzare solo i numeri maggiori della media tra i numeri della lista!");
            Console.WriteLine("2) Premi '2' se vuoi visualizzare solo i numeri minori della media tra i numeri della lista!");
            Console.WriteLine("3) Premi '3' se vuoi visualizzare solo i numeri pari della lista!");
            Console.WriteLine("4) Premi '4' se vuoi visualizzare solo i numeri dispari della lista!");
            Console.WriteLine("5) Premi '5' se vuoi terminare il filtraggio della lista!");
            Console.WriteLine("---------------FINE DELLE OPZIONI---------------\n");
        }

        public static void opzioniOrdinamentoAnimali()
        {
            Console.WriteLine("\n---------------SCEGLI UN'OPZIONE---------------");
            Console.WriteLine("1) Premi '1' se vuoi ordinare la lista di animali in ordine alfabetico crescente!");
            Console.WriteLine("2) Premi '2' se vuoi ordinare la lista di animali in ordine alfabetico decrescente!");
            Console.WriteLine("3) Premi '3' se vuoi terminare l'ordinamento della lista di animali!");
            Console.WriteLine("---------------FINE DELLE OPZIONI---------------\n");
        }

        public static void opzioniRicercaElemento()
        {
            Console.WriteLine("\n---------------SCEGLI UN'OPZIONE---------------");
            Console.WriteLine("1) Premi '1' se vuoi cercare un elemento dalla lista dei numeri interi!");
            Console.WriteLine("2) Premi '2' se vuoi cercare un elemento dalla lista degli animali!");
            Console.WriteLine("3) Premi '3' se vuoi terminare la ricerca di un elemento!");
            Console.WriteLine("---------------FINE DELLE OPZIONI---------------\n");
        }

        public static void visualizzaListe(List<int> numeriInteri, List<string> animali)
        {
            Console.WriteLine("\nVisualizzazione a schermo della lista di numeri interi:\n");
            foreach (int numero in numeriInteri)
            {
                Console.Write(numero);
                if (numero != numeriInteri[numeriInteri.Count() - 1])
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nVisualizzazione a schermo della lista di animali:\n");
            foreach (string animale in animali)
            {
                Console.Write(animale);
                if (animale != animali[animali.Count() - 1])
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        public static void filtraggioNumeri(List<int> numeriInteri)
        {
            bool cicla = true;
            double media = numeriInteri.Average();
            Console.WriteLine("\nLa media tra i numeri della lista è {0}!", media);
            opzioniFiltraggioNumeri();
            do
            {
                Console.WriteLine("\nScegli un'opzione tra quelle disponibili nel menù!\n");
                char scelta = char.Parse(Console.ReadLine());
                if (scelta == '1')
                {
                    List<int> numeriMaggioreMedia = numeriInteri.Where(n => n > media).Order().ToList();
                    Console.WriteLine("\nI numeri maggiori della media tra i numeri della lista sono:\n");
                    foreach (int numero in numeriMaggioreMedia)
                    {
                        Console.Write(numero);
                        if (numero != numeriMaggioreMedia[numeriMaggioreMedia.Count() - 1])
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (scelta == '2')
                {
                    List<int> numeriMinoriMedia = numeriInteri.Where(n => n < media).Order().ToList();
                    Console.WriteLine("\nI numeri minori della media tra i numeri della lista sono:\n");
                    foreach (int numero in numeriMinoriMedia)
                    {
                        Console.Write(numero);
                        if (numero != numeriMinoriMedia[numeriMinoriMedia.Count() - 1])
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (scelta == '3')
                {
                    List<int> numeriPari = numeriInteri.Where(n => n % 2 == 0).Order().ToList();
                    Console.WriteLine("\nI numeri pari della lista sono:\n");
                    foreach (int numero in numeriPari)
                    {
                        Console.Write(numero);
                        if (numero != numeriPari[numeriPari.Count() - 1])
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (scelta == '4')
                {
                    List<int> numeriDispari = numeriInteri.Where(n => n % 2 != 0).Order().ToList();
                    Console.WriteLine("\nI numeri dispari della lista sono:\n");
                    foreach (int numero in numeriDispari)
                    {
                        Console.Write(numero);
                        if(numero != numeriDispari[numeriDispari.Count() - 1])
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (scelta == '5')
                {
                    cicla = false;
                    Console.WriteLine("\nGrazie per aver utilizzato le opzioni di filtraggio della lista!");
                }
                else
                {
                    Console.WriteLine("\nERRORE! L'opzione che hai scelto non è tra quelle disponibili nel menù! Scegli un'altra opzione!\n");
                }
            } while (cicla); 
        }

        public static void ordinamentoListaAnimali(List<string> animali)
        {
            bool cicla = true;
            opzioniOrdinamentoAnimali();
            do
            {
                Console.WriteLine("\nScegli un'opzione tra quelle disponibili nel menù!\n");
                char scelta = char.Parse(Console.ReadLine());
                if (scelta == '1')
                {
                    List<string> ordinamentoCrescente = animali.Order().ToList();
                    Console.WriteLine("\nLa lista di animali ordinata in ordine alfabetico crescente:\n");
                    foreach (string animale in ordinamentoCrescente)
                    {
                        Console.Write(animale);
                        if (animale != ordinamentoCrescente[ordinamentoCrescente.Count() - 1])
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (scelta == '2')
                {
                    List<string> ordinamentoDecrescente = animali.OrderDescending().ToList();
                    Console.WriteLine("\nLa lista di animali ordinata in ordine alfabetico decrescente:\n");
                    foreach (string animale in ordinamentoDecrescente)
                    {
                        Console.Write(animale);
                        if (animale != ordinamentoDecrescente[ordinamentoDecrescente.Count() - 1])
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (scelta == '3')
                {
                    cicla = false;
                    Console.WriteLine("\nGrazie per aver utilizzato le opzioni di ordinamento della lista di animali!");
                }
                else
                {
                    Console.WriteLine("\nERRORE! L'opzione che hai scelto non è tra quelle disponibili nel menù! Scegli un'altra opzione!\n");
                }
            } while (cicla);
        }

        public static void ricercaElememto(List<int> numeriInteri, List<string> animali)
        {
            bool cicla = true;
            opzioniRicercaElemento();
            do
            {
                Console.WriteLine("\nScegli un'opzione tra quelle disponibili nel menù!\n");
                char scelta = char.Parse(Console.ReadLine());
                if (scelta == '1')
                {
                    Console.WriteLine("\nScrivi il numero che vuoi cercare nella lista!\n");
                    int numeroDaCercare = int.Parse(Console.ReadLine());
                    bool ricercaNumero = numeriInteri.Contains(numeroDaCercare);
                    if (ricercaNumero)
                    {
                        int index = numeriInteri.IndexOf(numeroDaCercare);
                        Console.WriteLine("\n{0} è presente nella lista, alla posizione {1} della lista!\n", numeroDaCercare, index);
                    }
                    else
                    {
                        Console.WriteLine("\nERRORE! Il numero che stai cercando non è presente nella lista!\n");
                    }
                }
                else if (scelta == '2')
                {
                    Console.WriteLine("\nScrivi l'animale che vuoi cercare nella lista!\n");
                    string animaleDaCercare = Console.ReadLine();
                    bool ricercaAnimale = animali.Contains(animaleDaCercare);
                    if (ricercaAnimale)
                    {
                        int index = animali.IndexOf(animaleDaCercare);
                        Console.WriteLine("\n{0} è presente nella lista, alla posizione {1} della lista!\n", animaleDaCercare, index);
                    }
                    else
                    {
                        Console.WriteLine("\nERRORE! L'animale che stai cercando non è presente nella lista!\n");
                    }
                }
                else if (scelta == '3')
                {
                    cicla = false;
                    Console.WriteLine("\nGrazie per aver utilizzato le opzioni di ricerca di un elemento in una lista!");
                }
                else
                {
                    Console.WriteLine("\nERRORE! L'opzione che hai scelto non è tra quelle disponibili nel menù! Scegli un'altra opzione!\n");
                }
            } while (cicla);
        }

        public static void calcolaSomma(List<int> numeriInteri)
        {
            int somma = numeriInteri.Sum();
            Console.WriteLine("\nLa somma di tutti gli elementi della lista di numeri interi è {0}!\n", somma);
        }

        public static void unisciListe(List<int> numeriInteri, List<string> animali)
        {
            List<string> conversioneNumeriInteri = numeriInteri.Order().Select(n => n.ToString()).ToList();
            List<string> unioneListe = conversioneNumeriInteri.Concat(animali.Order()).ToList();
            Console.WriteLine("\nLa lista risultante dall'unione delle due liste:\n");
            foreach (string elemento in unioneListe)
            {
                Console.Write(elemento);
                if (elemento != unioneListe[unioneListe.Count() - 1])
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
