# Akceptační kritéria: Kalkulacka.Secti

Zadání: `Kalkulacka.Secti(a, b)` vrací součet dvou celých čísel typu `int`.

## K1: Vrací součet

Pro dvě celá čísla, jejichž součet se vejde do rozsahu `int`, vrací `a + b`.

Klíčové příklady (každý odhalí jinou věrohodnou chybu):

| a  | b | výsledek | co odhalí                                      |
|----|---|----------|------------------------------------------------|
| 2  | 3 | 5        | násobení (6), odčítání (−1)                     |
| −2 | 5 | 3        | ztrátu znaménka (7), násobení (−10)            |
| 0  | 7 | 7        | násobení (0), vrácení jen prvního čísla (0)    |

## K2: Přetečení vyhodí výjimku

Když součet přesáhne rozsah `int` (víc než `int.MaxValue` nebo míň než `int.MinValue`), metoda vyhodí `OverflowException` a nevrátí žádnou hodnotu.

| a              | b  | výsledek            |
|----------------|----|---------------------|
| `int.MaxValue` | 1  | `OverflowException` |
| `int.MinValue` | −1 | `OverflowException` |
| `int.MaxValue` | 0  | `int.MaxValue` (hranice ještě platí) |

Proč: tiše špatný výsledek je horší než chyba. Výchozí chování C# (`unchecked`) by vrátilo `int.MinValue`, tedy záporné číslo bez varování.

Logování: `Kalkulacka` nic neloguje, je to knihovna bez závislostí. Výjimku zachytí a zaloguje volající vrstva aplikace.

## Mimo rozsah

- Jiné operace (dělení, násobení). Každá je samostatný ticket s vlastními rozhodnutími.
- Jiné typy (`long`, `decimal`).

## Poznámka pro ověřovatele

Příklady výše vidí i agent, takže je může natvrdo zapsat. Holdout testy mají ověřit stejná pravidla na jiných hodnotách.
