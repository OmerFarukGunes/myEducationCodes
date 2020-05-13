sehirler=["Ankara","Mardin","İstanbul","İzmir"]
for sehir in sehirler: #sehir bir nevi iter gibidir listede dolaşır.
    if sehir=="İzmir": 
        break
    if sehir=="Mardin":
        continue #o anki dönme durumunu iptal eder ama devam ettirir.
    print(sehir)
    print(sehir[0:3])