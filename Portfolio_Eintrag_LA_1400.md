# **Geometrierechner**
## **Aufgabenstellung**
Bei diesem Auftrag mussten wir in Vierergruppen ein Programm schreiben, womit wir für verschiedene Formen den Umfang, das Volumen usw. berechnen können. 
In diesem Portfolioeintrag, werde ich genauer darauf eingehen, wie ich ein Intro-Video programmiert und eingefügt habe. Dieses soll, wenn der Benutzer das Programm startet, einmal abgespielt werden.
### Ziele:
Der Leser lernt:
- wie man in Windows Forms ein Video einfügen kann.
- grob, wie ein Video in Winforms funktioniert.
- neue Funktionen von WInforms kennen.


## **Inhalt**
### **Video**
[![](https://i.imgur.com/ZHw5gkR.png)](https://www.youtube.com/watch?v=gnTPGWYVqEU)
### **Bild**
![screen](https://i.imgur.com/sAkljsj.png)
### **Text**
Um dieses Intro-Video zu machen, konvertierte ich mein Video zu einem GIF, dass ich es in eine Picturebox packen konnte. Danach musste ich schauen, dass die Picturebox Visible (sichtbar) und Enable (aktiviert) ist. Das sorgt dafür, dass das GIF angezeigt wird und auch läuft. 
Nun gab es das Problem, dass das Video in einem Loop angezeigt wurde, da es ein GIF ist. Leider habe ich sehr viel Zeit verschwendet, um zu versuchen, das Video nach der richtigen Anzahl Sekunden zu beenden, da dies nicht mit unserem bereits Gelernten funktionierte. Ich suchte überall im Internet nach Methoden und versuchte einige Stunden. 
Nach vielen Stunden Probieren fand ich den richtigen Weg. Ich musste einen Timer einfügen, welcher einfach starten soll, sobald die Form lädt. Danach wird mit dem Intervall eingestellt, wie lange ein Tick des Timers dauern sollte. Ich entschied mich hier für 1000 Millisekunden, was einer Sekunde entspricht.
Danach musste ich die Anzahl Sekunden, die das Video lang ist definieren und bei jedem Tick des Timers (also 1 Sek) eins von der Videolänge abziehen. 
Wenn jetzt diese verbleibende Zeit abgelaufen ist, soll die Introform geschlossen werden und die Mainform geöffnet werden.


## **Reflexion**
Ich hatte beim Lösen dieses Teilauftrags mit dem Video sehr viele Probleme gehabt, da ich irgendwie auf die Idee kommen musste, wie man es lösen könnte.
Ich habe buchstäblich Stunden verbracht, im Internet irgend eine Möglichkeit zu suchen, wie es möglich ist, das Video nur einmal abspielen zu können. 
Zudem hätte ich  mich sicherlich früher melden sollen, um einen Hinweis zu erhalten, da ich sehr viel Zeit damit verbracht habe.
Nachdem ich jedoch einen Tipp und dann den nötigen Geistesblitz erhalten hatte, konnte ich es recht schnell lösen und nach einer kleinen Recherche auch verstehen wie es funktioniert.
Nächstes Mal werde ich früher nachfragen, wenn ich ein Problem habe anstelle von vielen Stunden im Internet suchen. Zudem werde ich versuchen weniger Syntaxfehler zu machen, da diese viel Zeit beanspruchen.

## **Verifikation**
Mein Tischnachbar hat sich diesen Portfolioeintrag angesehen und hat alle Ziele erfüllt. Er sagt, er versteht nun einigermassen, wie das Video funktioniert und er hat sicherlich viele neue Funktionen entdeckt.
