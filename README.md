# 2AHET-arrays

Dieser Aufgabenblock befasst sich mit ein- und mehrdimensionalen Arrays.

## Projektstruktur

Jede Teilaufgaben muss in einer eigenen Projektmappe mit dem Namen der Teilaufgabe umgesetzt werden. Die Abgabe des Endstandes einer Teilaufgabe hat jeweils mit einem eigenen Commit zu erfolgen.

## Dokumentation

Jeder Funktion muss ein Dokumentationsblock vorangestellt sein, in dem die Funktionalität, Parameter und Rückgabewerte beschrieben werden. Wichtige bzw. komplexe Bereiche im Programmcode müssen ebenfalls ausreichend kommentiert sein. Die Dokumentationssprache ist Deutsch.

## Teilaufgaben

### Temperature Statistics

In dieser Teilaufgabe wird ein Programm erstellt, welches statistische Auswertungen für eine Reihe von Temperaturwerten eines Sensors berechnet. Zum Zwecke dieser Teilaufgabe wird der Sensor mittels eines Zufallszahlengenerators simuliert.

#### GetMeasurements

Diese Funktion erstellt die Messwerte, welche für den Rest des Programms benötigt werden. Die Funktion hat drei Parameter: die Anzahl n der zu erstellenden Werte, den Minimalwert und den Maximalwert.

Die Funktion erstellt ein neues Gleitkommazahl-Array mit n Elementen und füllt dieses mit Zufallszahlen zwischen dem Minimal- und dem Maximalwert.

#### GetMinimum

Diese Funktion erhält ein Gleitkommazahl-Array als Parameter und liefert den niedrigsten vorkommenden Wert als Rückgabewert.

#### GetMaximum

Diese Funktion erhält ein Gleitkommazahl-Array als Parameter und liefert den höchsten vorkommenden Wert als Rückgabewert.

#### GetMean

Diese Funktion erhält ein Gleitkommazahl-Array als Parameter und liefert den arithmetischen Mittelwert als Rückgabewert.

#### GetStandardDeviation

Diese Funktion erhält ein Gleitkommazahl-Array als Parameter und liefert die Standardabweichung als Rückgabewert.

#### Hauptfunktion

In der Hauptfunktion werden mit Hilfe der oben genannten Funktionen 200 Messwerte zwischen -10.0 und +34.0 ermittelt und statistisch ausgewertet. Die errechneten Werte werden ausgegeben.

### Temperature Statistics (Mehrdimensional)

In dieser Teilaufgabe wird ein Programm erstellt, welches statistische Auswertungen für eine Reihe von Temperaturwerten mehrerer Sensoren berechnet. Zum Zwecke dieser Teilaufgabe werden die Sensor mittels eines Zufallszahlengenerators simuliert.

#### GetMeasurements

Diese Funktion erstellt die Messwerte, welche für den Rest des Programms benötigt werden. Die Funktion hat drei Parameter: die Anzahl m der Sensoren, die Anzahl n der zu erstellenden Werte, den Minimalwert und den Maximalwert.

Die Funktion erstellt ein neues Gleitkommazahl-Array mit (m x n) Elementen und füllt dieses mit Zufallszahlen zwischen dem Minimal- und dem Maximalwert.

#### GetMinimumArray

Diese Funktion erhält ein mehrdimensionales Gleitkommazahl-Array als Parameter und liefert ein eindimensionales Array mit den jeweils niedrigsten vorkommenden Werten der m Sensoren als Rückgabewert.

#### GetMaximumArray

Diese Funktion erhält ein mehrdimensionales Gleitkommazahl-Array als Parameter und liefert ein eindimensionales Array mit den jeweils höchsten vorkommenden Werten der m Sensoren als Rückgabewert.

#### GetMeanArray

Diese Funktion erhält ein mehrdimensionales Gleitkommazahl-Array als Parameter und liefert ein eindimensionales Array mit jeweils dem arithemtischen Mittelwert der m Sensoren als Rückgabewert.

#### GetStandardDeviationArray

Diese Funktion erhält ein mehrdimensionales Gleitkommazahl-Array als Parameter und liefert ein eindimensionales Array mit jeweils der Stsandardabweichung der m Sensoren als Rückgabewert.

#### GetGlobalMinimum

Diese Funktion erhält ein mehrdimensionales Gleitkommazahl-Array als Parameter und liefert den niedrigsten vorkommenden Wert aller Sensoren als Rückgabewert.

#### GetGlobalMaximum

Diese Funktion erhält ein mehrdimensionales Gleitkommazahl-Array als Parameter und liefert den höchsten vorkommenden Wert  aller Sensoren als Rückgabewert.

#### GetGlobalMean

Diese Funktion erhält ein mehrdimensionales Gleitkommazahl-Array als Parameter und liefert den arithmetischen Mittelwert  aller Sensoren als Rückgabewert.

#### GetGlobalStandardDeviation

Diese Funktion erhält ein mehrdimensionales Gleitkommazahl-Array als Parameter und liefert die Standardabweichung  aller Sensoren als Rückgabewert.



#### Hauptfunktion

In der Hauptfunktion werden mit Hilfe der oben genannten Funktionen 6x200 Messwerte zwischen -10.0 und +34.0 ermittelt und statistisch ausgewertet. Die errechneten Werte werden ausgegeben.
