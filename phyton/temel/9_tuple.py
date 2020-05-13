#tuple ın listelerden farkı üzerinde değişiklik yapamamandır. 
#diğer çoğu şey aynıdır dizilerle tek farkı dizilerde
#[]kullanılır tuple da ise ()
#tuple lar sadece readOnly dir. İşlem yaparken sana performans vadeder bu şekilde.
#sistem onda değişiklik olmicanı biliyordur.
tupleListe= (2,4.2,"omer",[5.6,3],(2.3,"omer")) #iç içe tuple yapabilirsin. veya tuple içinde liste
liste  =[2,4.2,"omer",[5.6,3],(2.3,"omer")] #iç içe liste yapabilirsin veya liste içerisinde tuple
print(type(tupleListe))
print(type(liste))
print(tupleListe)
print(liste)
print(len(tupleListe))
print(len(liste)) 
liste[0]="akif" #listenin elemanı değişebilirsin tuple da bunu değiştiremezsin !
print(liste)
print(liste[-2]) #en sağdan ikinciyi yazar ekrana
print(tupleListe[-2]) #en sağdan ikinciyi ekrana yazar
print(tupleListe[1:2]) #çıktıyı 4.2, olarak verir.  o virgül tek elemanlarda bunun bir string değil tuple olduğunu
#göstermek için konsol tarafından konur
tupleDeger=("engin") #bu şekilde bir tanım string tanımıdır
print(type(tupleDeger))
tupleDeger =("engin",) #ancak bu tek elamanlı bir tuple dır.
print(type(tupleDeger))
print(liste[1:2]) # bu ise 4.2 

