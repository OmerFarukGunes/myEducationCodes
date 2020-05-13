ogrenciler =["ahmet","mehmet","kasım",5,6.5] #bu bir dizidir listedir. listeler belli bir türe sahip olmak zorunda değildir.
print(ogrenciler[1])
ogrenciler.append("ömer")
ogrenciler.remove("kasım")
ogrenciler[1]="veli"
#ogrenciler[4]="ASIM" bunu yapamazsın. listenin sonuna eleman eklemen için append kullan bu şekil out of range olur.
print(ogrenciler)#listenin tamamını yazar
sehirler= list(("Ankara","Istanbul"))#list constructor
print(sehirler)
print("ankara sayısı= " + str(sehirler.count("Ankara"))) #kac tane ankara var int değeri yazar
print("ankara indexi = " +str(sehirler.index("Ankara"))) #ankara İLK hangi indextedir
sehirler.pop(1) #şehirlerden indexe göre silme işlemi yaparsın.
sehirler.insert(0,"istanbul") # istediğin indexe istediğin veriyi ekler
print(sehirler)
sehirler.reverse() #diziyi ters çevirir
print(sehirler)
sehirler3=sehirler.copy()
sehirler2=sehirler# AYNI YERİ TUTMASINI SAĞLADIN. kısayol almasını sağlarsın
sehirler2[0]="izmir"
print(sehirler) #diziler referans tiptedirler yani bir pointerdırlar bu yüzden bellekteki yeri tutarsın ve orada işlem yaparsın. bu yüzden birşey değiştirince diğeride değişir. 
print(sehirler2) #kısa yol almak gibidir
print(sehirler3)#kopyalama yaparsan eğer hakkaten kopyalama yapar başka belleğe copy yaparsın.
sehirler.extend(sehirler3) #diziye dizi eklemek.
print(sehirler)
sehirler.sort() #a dan z ye sıralama yaptı sehirler.reverse() yaparsan bundan sonra tersten sıralamış olursun
print(sehirler)
print(sehirler.clear())#liste temizler print içinde olsa bile.
print(sehirler)
