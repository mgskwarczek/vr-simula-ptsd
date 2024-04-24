import random

class ShopWorld:
  def __init__(self):
    self.sklep = {
      "Dział spożywczy": {"produkty": ["Mleko", "Chleb", "Owoce", "Warzywa"], "półki": 4},
    }
    self.klienci = []

  def generuj_klientów(self, liczba_klientów):
    for _ in range(liczba_klientów):
      self.klienci.append({"pozycja": random.choice(list(self.sklep.keys())), "kierunek": random.choice(["lewo", "prawo"])})

  def wyświetl_świat(self):
    print("Wirtualny sklep:")
    for dział, informacje in self.sklep.items():
      print(f"- {dział}:")
      print(f"  Produkty: {informacje['produkty']}")
      print(f"  Liczba półek: {informacje['półki']}")
    print(f"Liczba klientów: {len(self.klienci)}")

  def poruszaj_klientów(self):
    for klient in self.klienci:
      if klient["kierunek"] == "lewo":
        nowa_pozycja = list(self.sklep.keys())[(list(self.sklep.keys()).index(klient["pozycja"]) - 1) % len(self.sklep)]
      else:
        nowa_pozycja = list(self.sklep.keys())[(list(self.sklep.keys()).index(klient["pozycja"]) + 1) % len(self.sklep)]
      klient["pozycja"] = nowa_pozycja
