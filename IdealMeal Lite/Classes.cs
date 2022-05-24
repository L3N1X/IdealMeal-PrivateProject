/*



Vrlo bih rado da mogu ovaj projekt još jednostavnije napraviti, ali to nije moguće bez da više uopce nije on ošto ste napisale u opisu projekta.
Sada je on okvirno ono sto ste napisali, od nekih stvari ste odustale jer su pak previse komplicirane, tipa tjedni plan prehrane i sl.


Ono što trebate znati:
Ja sam netko kog poznajete i trazile ste moju pomoc. zezule ste se sa odabirom teme koja je dosta kompleksna
Ja sam vam pokazao kako da napravite ove stvari.

Pokazao sam vam kako korisiti klase, njihove konstruktore i liste.

Klasa je nacrt za neki objekt. Mi tu u programiranju imamo int, string, double, char. To su samo ili neka slova ili riječi ili brojevi.
Radimo nacrt za čovjeka, što čovijek ima? Recimo ime, prezime, i starost.
ime i prezime bi bili stringovi, dok starost može biti cijeli broj int,

Kako radimo klasu:

    public class Covjek
    {
        public string Ime { get; set;}
        public string Prezime { get; set; }    -> ako vas zbunjuje ovaj get set, tako kreirate vrijednosti u klasi, samo napisete "prop" + klik na TAB tipku i samo se generira. Onda upišete vrijednosti 
        public int Starost { get; set; }
    }


Sada smo negdje u kodu i želimo napraviti covijeka, kako se to radi? To se zove instanciranje klase, onda je to sada objekt

Covjek c = new Covjek();   -> Ovo je objekt klase Covjek, naziv varijable je c

Sada je taj čovijek živ, ali nema niti ime niti prezime, nismo mu ga dali :(
Kako mu dajemo ime, prezime i starost?

Lagano: 

c.Ime = "Milica";
c.Prezime = "Krmpotic"
c.Starost = 25;

Kako sada te vrijednosti možemo staviti u neki label (to je iz ovih windows forma u kojima radite projekt)?
label1.Text = c.Ime;

Vidite da je taj label zapravo isto nekakva klasa, ali niste ju vi napisali vec ju je netko iz microsofta napisao.
Taj label vjerojatno izgleda ovako nekako:

    public class Label
    {
        public int KoordinataX { get; set; }
        ...y....
        ... neke druge stvari ...
                    ....
        public string Text { get; set; }
                    ....
        .. jos neke druge stvari
    }

Trebamo kreirati puno ljudi u svojoj aplikaciji, neda nam se svakome davat ime, prezime zasebno.
Zelimo da cim se kreira covjek da mu se MORA dati ime, prezime starost. Da nema nekih ljudi bez imena, bez prezimena ili starosti.

U svojoj klasi stavljamo nesto sto se zove konstruktor i stavljamo ga u klasu tako da napisemo ime te klase, otvorimo i zatvorimo okrugle zagrade, otvroimo i zatvorimo viticaste zagrade

kako to izgleda?

public class Covjek
    {
        public string Ime { get; set;}
        public string Prezime { get; set; }
        public int Starost { get; set; }

        public Covjek()
        {

        }
    }

Kada se kreira covjek, sada mozemo dodati da mu se MORA dati ime, prezime i starost.

public class Covjek
    {
        public string Ime { get; set;}
        public string Prezime { get; set; }
        public int Starost { get; set; }

        public Covjek(string ime, string prezime, int starost)
        {
            Ime = ime;
            Prezime = prezime; -> sada ovdje dodjeljujemo vrijednosti, a ne tamo vani
            Starost = starost
        }
    }

Kako to izgleda? Kako sada kreiramo novog covjeka?

Covjek c = new Covjek("Milica", "Krmpotic", 25);


Želimo imati puno ljudi, ajmo ih spremiti u listu.
napravimo troje ljudi: 

Covjek c1 = new Covjek("Pero", "Peric", 25);
Covjek c2 = new Covjek("Maja", "Majic", 25);
Covjek c3 = new Covjek("Kruno", "Krunic", 25);

Kako radimo listu?
List<int> lista_brojeva = new List<int>(); -> ovo je lista brojeva, podataka tipa int (int su cijeli brojevi)

Kako radimo listu riječI?
List<string> lista_rijeci = new List<string>();

Vidimo da između <> ide naziv tipa podataka (naziv klase). Mi imamo klasu Covjek i kreirali smo ih troje. Ajmo ih spremiti u listu.
List<Covjek> ljudi = new List<Covjek>();

Sada imamo praznu listu ljudi.
Dodavanje ljudi:

ljudi.Add(c1);
ljudi.Add(c2);
ljudi.Add(c3);

Kako sada pristupamo covjeku c1? on je na pocetku liste jer smo ga stavili prvog. To radimo tako da kazemo ljudi[0]
Sve u programiranju počinje od 0, ne od 1.

Imamo sada te ljude i na ekran na labeli želimo ispisati ime druge osobe u listi.

label1.Text = ljudi[1].Ime;

Kako prolazimo kroz listu (trčimo kroz listu)

foreach(Covjek covjek in ljudi) -> ovako sada pristupamo SVAKOM COVJEKU po redu
{
    
}

Ajmo zbrojiti godine svih ljudi!

int ukupne_godine = 0;
foreach(Covjek covjek in ljudi)
{
    ukupne_godine = ukupne_godine + covjek.Starost;
}

label1.Text = ukupne_godine.ToString();

Sada smo ispisali ukupne godine na ekran, zašto ToString()? svaki objekt, pa cak int, double i sl (brojevi) imaju svoju tekstualnu reprezentaciju, njoj pristupamo tako da samo pozovemo .ToString();

Kako ispisemo broj 100?

label1.Text = 100; -> KRIVO!!! ovo ce biti crveno potcrtano, vrijednost Text u klasi Label je tipa string, ne možemo joj dodjeliti sada nešto sto je tipa int (100 je int).
label1.Text = "100" -> ovako sada možemo, ali mi trebamo znati kako se piše 100. Što ako je to neki broj koji je izračunao program? Da zna ispisati bilo koji broj?
To radimo kao kako sam gore napisao, samo sada bi to bilo ovako:

label1.Text = 100.ToString();
label1.Text = neki_broj.ToString();
label1.Text = brojKalorija.ToString() + " kcal";

            :)

 */
using System.Collections.Generic;

namespace IdealMeal_Lite
{
    //Ova klasa predstavlja korisnika
    public class User
    {
        //Ovaj korisnik ima:
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Konstruktor: korisnik se ne može kreirati bez da mu se da ime prezime, korisnicko ime i password
        public User(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
        }
    }
    //Ova klasa predstavlja objekt namrinicu
    public class Grocery
    {
        //Namrinica ima
        //Svoj naziv
        public string Name { get; set; }
        //Broj kalorija (pretvaramo se da je to kao broj kalorija na 100 grama)
        public int Calories { get; set; }
        //Konstruktor: Namrinicu ne možemo kreirati bez da joj damo ime i broj kalorija
        public Grocery(string name, int calories)
        {
            Calories = calories;
            Name = name;
        }

        //Ovaj kod je generirao Visual Studio
        public override bool Equals(object obj)
        {
            return obj is Grocery grocery &&
                   Name == grocery.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
        //Ovaj kod je generirao Visual Studio
    }
    //Ova klasa predstavlja objekt sastojak
    public class Ingridient
    {
        //Sastojak ima:

        //Namrinicu npr: spagetti
        public Grocery Grocery { get; set; }
        //I danu kolicinu, mi se pretvaramo da su ovo grami, double jer zelimo imati decimalna mjesta
        public double Amount { get; set; }

        //Konstruktor: sastojak se ne može generirati bez da mu proslijedimo namirnicu i količinu (opet, glumimo da su to grami, ne znamo bolje)
        public Ingridient(Grocery grocery, double amount)
        {
            Grocery = grocery;
            Amount = amount;
        }

        //Ovo je generirao Visual Studio
        public override bool Equals(object obj)
        {
            return obj is Ingridient ingridient &&
                   EqualityComparer<Grocery>.Default.Equals(Grocery, ingridient.Grocery);
        }

        public override int GetHashCode()
        {
            return -676798384 + EqualityComparer<Grocery>.Default.GetHashCode(Grocery);
        }
        //Ovo je generirao Visual Studio
    }
    public class Recepie
    {
        //Naziv recepta
        public string Name { get; set; }
        //Opis recepta
        public string Description { get; set; }
        //Lista svih Sastojaka u ovom receptu
        public List<Ingridient> Ingridients { get; set; }
        //Konstruktor, recept se ne može generirati
        public Recepie(string name, string description, List<Ingridient> ingridients)
        {
            this.Name = name;
            this.Description = description;
            this.Ingridients = ingridients;
        }

        //Ova funkcija provjerava da li se ovaj odredeni recept može napraviti sa danim sastojcima
        public bool CanMakeWithGivenIngridients(IList<Ingridient> avaliableIngridients)
        {
            int ingridentsValid = 0;
            //Za svaki sastojak ovog recepta
            foreach (var ingridient in Ingridients)
            {
                //Za svaki sastojak koji smo proslijedili receptu koje on mora provjeriti
                foreach (var avaliableIngridient in avaliableIngridients)
                {
                    //Ako je dani sastojak jednak sastojku recepta i tog danog sastojka ima vise ili jednako nego sastojka u receptu
                    if (ingridient == avaliableIngridient && ingridient.Amount <= avaliableIngridient.Amount)
                    {
                        //Dodaj jedan broju valjanih sastojaka
                        ingridentsValid = ingridentsValid + 1;
                    }
                }
            }
            //Ako je broj valjanih sastojaka recepta jednak broju sastojaka u receptu
            if (ingridentsValid == Ingridients.Count)
            {
                //Moze se napraviti ovaj recept
                return true;
            }
            else
            {
                //Ne moze
                return false;
            }
        }

        //Ova funkcija vraca ukupni broj kalorija ovog recepta, prolazi svaki sastojak i zbraja kalorije
        public int GetTotalCalories()
        {
            //Ukupni broj kalorija
            int totalCalories = 0;
            //Za svaki sastojak u sastojcima ovog recepta
            foreach (var ingridient in Ingridients)
            {
                //Zbroji kalorije (kalorije svakog sastojka se nalaze u njegovoj namirnici)
                totalCalories = totalCalories + ingridient.Grocery.Calories;
            }
            return totalCalories;
        }

        //Ovo je generirao Visual Studio
        public override bool Equals(object obj)
        {
            return obj is Recepie recepie &&
                   Name == recepie.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
        //Ovo je generirao Visual Studio
    }


}
