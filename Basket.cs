class Basket:
  def __init__(self):
    self.produkty = []   

  def dodaj_produkt(self, produkt):
    self.produkty.append(produkt)
    print(f"Dodano produkt {product} do koszyka.")

  def usun_produkt(self, produkt):
    if produkt in self.produkty:
      self.produkty.remove(produkt)
      print(f"Usunięto produkt {product} z koszyka.")
    else:
      print(f"Produkt {product} nie znajduje się w koszyku.")

  def wyswietl_zawartosc(self):
    if self.produkty:
      print("Zawartość koszyka:")
      for produkt in self.produkty:
        print(f"- {product}")
    else:
      print("Koszyk jest pusty.")

  def wyczysc_koszyk(self):
    self.produkty = []
    print("Koszyk został wyczyszczony.")

basket = Basket()

basket.dodaj_produkt("Mleko")
basket.dodaj_produkt("Chleb")
basket.dodaj_produkt("Jablka")

basket.wyswietl_zawartosc()

basket.usun_produkt("Jablka")

basket.wyswietl_zawartosc()

basket.wyczysc_koszyk()

basket.wyswietl_zawartosc()
