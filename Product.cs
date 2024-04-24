class Product:
  def __init__(self, nazwa, cena, model_3d=None, opis=""):
    self.nazwa = nazwa
    self.cena = cena
    self.model_3d = model_3d  
    self.opis = opis

  def __str__(self):
    return f"{self.nazwa} ({self.cena} zł)"  

  def get_cena(self):
    return self.cena

  def get_opis(self):
    return self.opis

  def set_model_3d(self, model_3d):
    self.model_3d = model_3d

mleko = Product("Mleko", 2.50, opis="Pasteryzowane")
woda = Product("Woda", 1.50, opis="Niegazowana")