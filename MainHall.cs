class MainHall:
  def __init__(self):
    self.drzwi = {
      "Drzwi 1": "Zrób zakupy",
      "Drzwi 2": "Wizyta u lekarza",
      "Drzwi 3": "Wystąpienie publiczne",
      "Drzwi 4": "Jazda komunikacją miejską"
    }
    self.drzwi_wybrane = None

  def powitanie(self):
    print("Witamy w symulacji")
    print("Znajdujesz się w holu głównym. Do dyspozycji masz następujące drzwi:")
    for nazwa_drzwi, opis in self.drzwi.items():
      print(f"- {nazwa_drzwi}: {opis}")

  def wybierz_drzwi(self):
    while True:
      wybrana_opcja = input("Wybierz drzwi, do których chcesz wejść (np. Drzwi 1): ")
      if wybrana_opcja in self.drzwi:
        self.drzwi_wybrane = wybrana_opcja
        print(f"Wybrałeś/aś {self.drzwi_wybrane}.")
        break
      else:
        print("Nieprawidłowa nazwa drzwi. Spróbuj ponownie.")

  def get_drzwi_wybrane(self):
    return self.drzwi_wybrane

  def get_opis_drzwi_wybrane(self):
    return self.drzwi[self.drzwi_wybrane]
