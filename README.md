# Docker #

- Docker je pogodan alat za korišćenje u mikroservisnoj arhitekturi jer nam omogućava kontejnerizaciju aplikacije, a samim tim i lakši deployment(možemo navesti sve potrebne servise u docker-compose.yml fajlu)



**Docker Image** je paket koji sadrži sve što je potrebno za pokretanje aplikacije, uključujući izvršne datoteke, biblioteke, konfiguraciju i druge potrebne komponente. 

**Docker container** je pokrenuta instanca Docker slike, poseduje port na kome se izvršava.

 
1. Da bismo koristili docker potrebno je instalirati [Docker Desktop aplikaciju](https://www.docker.com/products/docker-desktop/.).

2. Da bismo kreirali kontejner potrebno je pokrenuti komandu docker-compose up, to mozemo odraditi rucno(iz terminala na lokaciji gde je docker-compose.yml fajl) ili iz vs-a: 
     
     ![image](https://github.com/dockerInstructions/Docker/assets/142311749/4e7a0a3c-591b-42ea-a398-81b4bbee0177)

    U Docker Desktop app možemo videti kreirane kontejnere i slike: 
     
     ![image](https://github.com/dockerInstructions/Docker/assets/142311749/08e44259-e362-4a85-9af8-bc3db081d93f)

![image](https://github.com/dockerInstructions/Docker/assets/142311749/9ff6881d-5bac-443f-ad44-ed78dc0df037)


     
3. Output iz konzole:

     ![image](https://github.com/dockerInstructions/Docker/assets/142311749/3757fdd6-9b01-4eb3-acb1-c346695fc69f)

   Što znači da koristimo Postgres bazu iako je nismo lično instalirali(to bismo morali da uradimo u slucaju da ne koristimo docker). 
<br />
<br />
<br />
Proces kreiranja kontejnera: 


![docker_structure](https://github.com/dockerInstructions/Docker/assets/142311749/8760887f-dd11-4055-bbde-17e0f0b97483)

- [Jedan zanimljiv problem sa kojim sam se susreo radeci sa dokerizovanom bazom i servisom koji komuniciraju medjusobno.](https://www.linkedin.com/pulse/docker-compose-dependson-luka-anti%2525C4%252587%3FtrackingId=H4d9VMw31jiGKb%252FC%252FOI5RA%253D%253D/?trackingId=H4d9VMw31jiGKb%2FC%2FOI5RA%3D%3D)

 
 
 

 
