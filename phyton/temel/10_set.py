#indexsiz ve sırasızdır
#tüm elemanlar eşsizdir tekrarı olmaz
#çok performanslıdır
#listelere benzerdir
#setlerde tuple lar gibi özelleştirilemez
mySet = {"Omer","Faruk","Aslı","Orkun"}
print(mySet) #sırayla gelmez rasgele çıktı verir
#bunda dolaşabilirsin.
for student in mySet:
    print(student) #bu şekilde elemanlarda gezip yazdırabilirsin
    
print("aslı" in mySet)#sette aslı varmıdır (Aslı değil aslı) T veya F döndürür

if "Aslı" in mySet:
    print("listede var")
    
    mySet.add("Ali") #eleman değiştiremezsin ama eleman ekleyebilirsin
    mySet.update(["Akif","Lale"])#genelde yeni elemanLAR eklerken yapıyoruz.
    print(mySet)
print(len(mySet))
mySet.remove("Orkun")
mySet.discard("Orkun") #bulursan sil bulamazsan sıkıntı yok arıza çıkarma devam et demek
x=mySet.pop()#listeden son elemanı silmektir KENDİ SIRASINA GÖRE EN SON ELEMAN SENİN SIRANA GÖRE DEĞİL
print(mySet)
mySet.clear()#setin elemanlarını temizler
del mySet #bu ise tamamen seti yok eder.
mySet =set("mehet","veli")# bu şekildede set oluşturabilirsin.