internal class Osoba
{
    public Osoba(string imie_, string nazwisko_, int wiek_)
    {
        Imie_ = imie_;
        Nazwisko_ = nazwisko_;
        Wiek_ = wiek_;
    }

    public string Imie_ { get; }
    public string Nazwisko_ { get; }
    public int Wiek_ { get; }
}