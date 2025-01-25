
# FaceWinSkan1

**FaceWinSkan1** to aplikacja wykorzystująca algorytmy rozpoznawania twarzy do detekcji oraz identyfikacji osób na podstawie obrazów. Projekt oparty na technologii **Emgu.CV** (wrapper dla OpenCV) pozwala na wykrywanie twarzy w czasie rzeczywistym, a także na identyfikację osób, których twarze zostały wcześniej zapisane. Aplikacja jest idealnym rozwiązaniem do nauki i eksperymentowania z algorytmami przetwarzania obrazu oraz rozpoznawania twarzy.

## Spis treści

- [Opis projektu](#opis-projektu)
- [Funkcjonalności](#funkcjonalności)
- [Instalacja](#instalacja)
- [Przygotowanie środowiska](#przygotowanie-środowiska)
- [Użycie](#użycie)
- [Zależności](#zależności)
- [Autor](#autor)
- [Licencja](#licencja)

## Opis projektu

**FaceWinSkan1** to aplikacja stworzona z myślą o wykrywaniu twarzy na obrazach oraz ich identyfikacji. Program wykorzystuje wbudowany algorytm detekcji twarzy i model do identyfikacji osób na podstawie wcześniej zapisanych próbek twarzy. Projekt jest napisany w języku C# z wykorzystaniem **Emgu.CV**, co pozwala na wykorzystanie funkcji OpenCV w aplikacji desktopowej działającej w systemie Windows.

Aplikacja wspiera zarówno detekcję twarzy na obrazach, jak i na wideo w czasie rzeczywistym, oferując użytkownikowi możliwość rozpoznawania twarzy z kamery internetowej. W trakcie wykrywania twarzy aplikacja oblicza poziom pewności rozpoznania, dzięki czemu użytkownik wie, jak dokładne jest wykrycie danej twarzy.

## Funkcjonalności

- **Wykrywanie twarzy**: Wykrywa twarze na obrazach i wideo, korzystając z algorytmu detekcji twarzy.
- **Rozpoznawanie twarzy**: Przypisuje etykiety osobom na podstawie wcześniejszych danych (przykłady twarzy).
- **Detekcja w czasie rzeczywistym**: Obsługuje kamerę internetową i wykrywa twarze na bieżąco.
- **Pewność wykrycia**: Oblicza i wyświetla poziom pewności wykrycia twarzy.
- **Personalizacja progu pewności**: Pozwala na ustawienie minimalnego progu pewności, poniżej którego rozpoznanie nie jest uznawane.

## Instalacja

Aby uruchomić projekt, wykonaj następujące kroki:

1. **Klonowanie repozytorium**:

   Skopiuj repozytorium na swój lokalny komputer za pomocą Git:

   ```bash
   git clone https://github.com/TWOJE-GITHUB-USERNAME/FaceWinSkan1.git
   ```

2. **Otwórz projekt w Visual Studio**:

   Otwórz sklonowane repozytorium w **Visual Studio** (zalecana wersja to 2019 lub wyższa).

3. **Instalacja zależności**:

   Aby zainstalować wymagane zależności, takie jak **Emgu.CV**, przejdź do **Tools > NuGet Package Manager > Manage NuGet Packages for Solution**. Następnie wyszukaj i zainstaluj **Emgu.CV** (najlepiej wersję 4.x lub wyższą).

   Możesz również zainstalować inne wymagane biblioteki, takie jak **System.Drawing**.

4. **Skonfiguruj kamerę (opcjonalnie)**:

   Jeśli chcesz używać kamery internetowej do rozpoznawania twarzy w czasie rzeczywistym, upewnij się, że masz podłączoną kamerę i aplikacja ma dostęp do niej.

## Przygotowanie środowiska

Projekt wykorzystuje następujące technologie i narzędzia:

- **C#** (język programowania)
- **.NET Framework** (preferowana wersja: 4.7.2 lub wyższa)
- **Emgu.CV** – wrapper dla OpenCV, umożliwiający łatwą integrację z C#.
- **System.Drawing** – do manipulacji obrazami.
- **Windows Forms** – do budowy interfejsu użytkownika.
- **Visual Studio 2019+** – do rozwoju i uruchamiania projektu.

Wymagania:

- Visual Studio (wersja 2019 lub wyższa)
- **Emgu.CV** (zainstalowane za pomocą NuGet)

## Użycie

1. **Uruchomienie aplikacji**:

   Po zbudowaniu projektu możesz uruchomić aplikację bezpośrednio z Visual Studio. Jeśli projekt jest poprawnie skompilowany, otworzy się okno z kamerą, która zacznie wykrywać twarze w czasie rzeczywistym.

2. **Rozpoznawanie twarzy**:

   Podczas wykrywania twarzy program oblicza poziom pewności i przypisuje etykiety osobom na podstawie zapisanych wcześniej danych.

3. **Dostosowanie progu pewności**:

   Możesz dostosować próg pewności wykrycia, aby uzyskać dokładniejsze wyniki. Program nie będzie rozpoznawał twarzy, jeśli poziom pewności jest poniżej ustalonego progu.

4. **Zatrzymywanie wykrywania**:

   Aplikacja umożliwia zatrzymanie wykrywania twarzy oraz zamknięcie kamery w dowolnym momencie za pomocą przycisków w interfejsie użytkownika.

## Zależności

- **Emgu.CV** – dla detekcji twarzy oraz operacji na obrazach.
- **System.Drawing** – do manipulacji obrazami.
- **System.IO** – do operacji na plikach i zapisywania danych.
- **Windows Forms** – do budowy GUI.

Zainstalowane paczki NuGet:

- **Emgu.CV** (wersja 4.x)
- **System.Drawing.Common**
  
## Autor

Projekt został stworzony przez **[Twoje Imię]**. Jest to projekt open-source, który ma na celu edukację i eksperymentowanie z algorytmami rozpoznawania twarzy. 

Jeśli masz jakiekolwiek pytania lub chcesz wnieść wkład w projekt, możesz otworzyć **Issue** lub złożyć **Pull Request**.

## Licencja

Projekt jest dostępny na licencji **MIT**. Zobacz plik [LICENSE](LICENSE) dla szczegółowych informacji.
