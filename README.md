# AutoOglasi

## Opis
Ovaj projekat je veb aplikacija izrađena korišćenjem ASP.NET Core 5 i MongoDB-a, dizajnirana da omogući korisnicima postavljanje i pregled oglasa za prodaju automobila. Platforma podržava registraciju i prijavu korisnika, upravljanje oglasima, komentarisanje i napredne opcije filtriranja.

## Funkcionalnosti
### Funkcionalnosti za korisnike
- **Autentifikacija**: Korisnici mogu da se registruju i prijave na svoje naloge.
- **Pregled oglasa**: Prijavljeni korisnici mogu da pregledaju sve oglase i da ih filtriraju po:
  - Godini proizvodnje
  - Brendu
- **Upravljanje oglasima**:
  - Postavljanje novog oglasa
  - Izmena ili brisanje svojih oglasa
  - Pregled detalja bilo kog oglasa
- **Komentarisanje**: Korisnici mogu da ostavljaju komentare na oglase.

### Tehnologije
- **Backend**: ASP.NET Core 5
- **Baza podataka**: MongoDB

## Instalacija i pokretanje

### Preduslovi
- Instalirajte [.NET SDK 5](https://dotnet.microsoft.com/download/dotnet/5.0)
- Instalirajte [MongoDB](https://www.mongodb.com/try/download/community)

### Koraci
1. Klonirajte repozitorijum:
   ```bash
   git clone <repository-url>
   ```
2. Pređite u direktorijum projekta:
   ```bash
   cd AutoOglasi
   ```
3. Povucite zavisnosti:
   ```bash
   dotnet restore
   ```
4. Ažurirajte `appsettings.json` sa vašim MongoDB konekcionim stringom:
   ```json
   "ConnectionStrings": {
       "MongoDb": "<Vaš MongoDB konekcioni string>"
   }
   ```
5. Pokrenite aplikaciju:
   ```bash
   dotnet run
   ```
6. Idite na `https://localhost:44300/User/CreateRole` i kreirajte ulogu `Admin`.
   ![image](https://github.com/user-attachments/assets/d9def474-1403-443f-afcb-b1fbe58136fa)


## Upotreba
### Registracija i prijava
- Registrujte novi nalog ili se prijavite koristeći postojeće kredencijale.
  ![image](https://github.com/user-attachments/assets/68dadc20-81df-4967-894d-22cc2097e148)
![image](https://github.com/user-attachments/assets/c9a08ccf-f0a8-43bf-b923-42262816544f)

### Upravljanje oglasima
- **Postavljanje oglasa**: Popunite potrebna polja (naslov, opis, godina proizvodnje, brend, itd.) da biste postavili novi oglas.
  ![image](https://github.com/user-attachments/assets/e2ea9c24-b8f6-434a-ae1f-ee8349aae7b5)
  
- **Izmena/Brisanje oglasa**: Upravljajte svojim oglasima iz korisničkog menija.
  ![image](https://github.com/user-attachments/assets/d82b453d-ff64-4191-ad5a-db64bc51a0ce)
  ![image](https://github.com/user-attachments/assets/5c6ef620-74d3-4bb1-ac11-eb1b5aa736ff)
  ![image](https://github.com/user-attachments/assets/ea15e208-f1ea-4bc6-be1d-32c960f03611)

- **Pregled oglasa**: Pregledajte sve oglase i primenite filtere po potrebi.
  ![image](https://github.com/user-attachments/assets/db56b39c-1fde-4682-a633-e06bd235e6a7)

### Filtriranje oglasa
- Koristite opcije filtriranja na stranici "Svi oglasi" kako biste suzili pretragu prema:
  - Godini proizvodnje
  - Brendu


Autor: Nevena Milenkovic
