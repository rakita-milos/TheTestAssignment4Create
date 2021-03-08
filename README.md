# TheTestAssignment4Create

Test je napravljen sa Selenium NUnit i C# (.NetCore 2.1) i TestProject-om

Zbog bezbednosti na google-u i pretraživača (Chrome, Mozila, Edge, Opera)  novijih verzija, nije bilo moguće da se uradi automatizacija za te pretraživače.

Ovaj testo za logovanje na GMail je moguće na windows-u koji na sebi nema Edge pretraživač.

Test se pokreće preko TestProject Agent-a. 

Potrebno je da bude instaliran i pokrenut TestProject Agent na mašini na kojoj se pokreće test.
Ako test neće da se pokrene na drugom nalogu od TestProject-a potrebno je da se promeni DevToken u class-i TheTestAssignmentTEST.Data.TestProjectHelper. Ovaj podatak se može dobiti kad se na TestProject-u kad se ulogujemo u gornjem MENU odabere "Integrations" i onda u opciji pod "1. Get a developer token" klikne na "Display Token" i onda se kopira taj koji dobijemo u gore pomenutu class-u.
