sayi=10
print(sayi)
sayi="sdaf"
print(sayi)
# değişken türünü yazmazsın
sayi +='1'
print(sayi)
#int float string bool listler var ayrıyeten setler dictionary ve tuple var
#list [] set {} dictionary{tanım: value} tuple()
#set bir collection listeden farkı aynı değerleri almaması kendi içinde yani
#listede [1,2,true,1] olabilir ama sete bunu tanımlarsan {1,2,true} olur
#tuple liste ve sete benzer en önemli özelliği immutable olması yani değerler tek
#atanmalıktır.
print( type(1.3))
# normal çarpma işlemleri burada da var
str = "deneme"
print(str[3])
print(str[2:5])
#2 den 5 e kadar boş bırakabilirsin
print(str[1:3:1]) 
#baslangıc ve bitis arasındakiş elemanlar üçüncü kısımdakji değere göre atlayarak deger alır
print(str[::2])
#0 dan başla 2 atlayarak al
#len uzunluk gosterir + ile string ekleyebilirsin. * ile coğaltabilirsin
#.upper() harfleri büyütür .lower() harfleri  küçültür
#.split() boşlukları ayırır.
print(str.split('e',1))
#aynı şekilde belli karakterden de ayırabilirsin. ve kaç ayırma yapacağınıda yazabilirsin.
liste =['a',True,1,1.2]
liste +=['f']
print(liste)
liste.append('g')
print(liste)
print(liste.pop())
liste.pop(3)
sayılar = [1234123,12,123541235,1234532,1,1,12]
sayılar.sort()
print(sayılar)
sayılar.reverse()
print(sayılar)
print(set(sayılar)) #set yapınca aynı elemanlar silindi süslü parantezle yazıldığını
tuple =['a',True,1,1.2]
print(tuple)
tuple =('a',True,1,1.2)
print(tuple)
# tuple[0] ='b' burada hata verir.
print(tuple.count('a')) #a kaçıncı eleman olmayan eleman yazarsan 0 döner.
print(tuple.index('a')) #a kaçıncı index olmayan eleman yazamazsın
dict = {'name':'omer',
        'yas':32,
        'local':{'city':"mardin"}
        #iç içe dict yapabilirsin.
        }
print(dict)
print(dict.get('local')['city'])
#hem get ile hemde köşeli parantez ile eleman çağırabilirsin.
