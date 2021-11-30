print( range(10))
# range başlangıç ve bitiş değeri olan sıralı numaralar dizer
# 3. eleman yazdığında mesela 1,10,2 yazarsan 1 den 10 a kadar 2 şer atla derdin
Liste = [1,3,4]
print(type(Liste))
Liste = range(10)
print(Liste)
harfler = ['a','b','c']
for harf in enumerate(harfler):
    print(harf)
# enumerate sıralama işlemi yapar her bir indexin kaçıncı olduğu yazar

countries = ['TR','USA','UK']
sort = range(1,4)
for ulke in zip(countries,sort):
    print(ulke)
# zip iki listeyi birbirine bağlar. Uzunluk önemlin