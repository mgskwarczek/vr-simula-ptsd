class Gamer:
  def __init__(self):
    self.pozycja = "Hall Główny"  # Początkowa pozycja gracza
    self.koszyk = []  # Lista produktów w koszyku
    self.zebrane_przedmioty = 0  # Liczba zebranych przedmiotów
    self.ukończone_zadania = 0  # Liczba ukończonych zadań
    self.punkty = 0  # Punkty zdobyte w grze

  def porusz_sie(self, kierunek):
    if kierunek == "lewo":
      nowe_polozenie = list(sklepy.keys())[(list(sklepy.keys()).index(self.pozycja) - 1) % len(sklepy)]
    elif kierunek == "prawo":
      nowe_polozenie = list(sklepy.keys())[(list(sklepy.keys()).index(self.pozycja) + 1) % len(sklepy)]
    else:
      print(f"Niepoprawny kierunek: {kierunek}.")
      return

    if nowe_polozenie == "Kasa":
      //finalizacji zakupów (np. wyświetlenie paragonu, pobranie płatności??????)
     // print("Dotarłeś/aś do kasy. Czas zapłacić za zakupy!")
      // 
    else:
      self.pozycja = nowe_polozenie
      print(f"Przeszedłeś/aś do {self.pozycja}.")

  def podnies_przedmiot(self, produkt):
    if self.pozycja in sklepy[self.pozycja]["produkty"]:
      if produkt in sklepy[self.pozycja]["produkty"]:
        self.koszyk.append(produkt)
        sklepy[self.pozycja]["produkty"].remove(produkt)
        self.zebrane_przedmioty += 1
        print(f"Podniosłeś/aś {produkt} i dodałeś/aś go do koszyka.")
      else:
        print(f"W {self.pozycja} nie ma produktu {produkt}.")
    else:
      print(f"Nie możesz nic podnieść w {self.pozycja}.")

  def wyswietl_koszyk(self):
    if self.koszyk:
      print("Zawartość koszyka:")
      for produkt in self.koszyk:
        print(f"- {produkt}")
    else:
      print("Koszyk jest pusty.")

  def usun_z_koszyka(self, produkt):
    if produkt in self.koszyk:
      self.koszyk.remove(produkt)
      print(f"Usunąłeś/aś {produkt} z koszyka.")
    else:
      print(f"Produkt {produkt} nie znajduje się w koszyku.")

  def wykonaj_zadanie(self, zadanie):
    if zadanie in sklepy[self.pozycja]["zadania"]:
      if zadanie not in self.ukończone_zadania:
        sklepy[self.pozycja]["zadania"].remove(zadanie)
        self.ukończone_zadania += 1
        self.punkty += 10
        print(f"Ukończyłeś/aś zadanie: {zadanie}. Zdobyłeś/aś 10 punktów!")
      else:
        print(f"Zadanie {zadanie} jest już ukończone.")
    else:
      print(f"W {self.pozycja} nie ma zadania: {zadanie}.")

gamer = Gamer()

while True:
  print(f"Twoja pozycja: {gamer.pozycja}")
  print("Dostępne akcje:")
  print("1. Porusz się (lewo/prawo)")
  print("2. Podnieś przedmiot (nazwa przedmiotu)")
  print("3. Wyświetl koszyk")
  print("4. Usuń z koszyka (nazwa przedmiotu)")
  print("5. Wykonaj zadanie (nazwa zadania)")
  print("6. Zakończ grę")

  wybrana_opcja = input("Wybierz akcję: ")

   if wybrana_opcja == "1":
    kierunek = input("Podaj kierunek (lewo/prawo): ")
    gamer.porusz_sie(kierunek)
  elif wybrana_opcja == "2":
    produkt = input("Podaj nazwę przedmiotu do podniesienia: ")
    gamer.podnies_przedmiot(produkt)
