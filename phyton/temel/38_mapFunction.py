#mapping eşitlemek diye geçebilir.

sayilar= [1,2,3,4,5]

# sayilarkareli=[]

# for sayi in sayilar:
#  sayilarkareli.append(sayi*sayi*sayi) bu bildiğimiz yöntem

sayilarkareli =list(map(lambda x: x**3,sayilar)) #sayılardaki her bir sayı için yani x için karesini al  ** kendinle çarp demek. oraya x*x*x yazabilirdin.
sayilarFiltreli=list(filter(lambda sayi: sayi>2,sayilar) )#sayi 2 den büyükse listeye ekle demektir.
print(sayilarFiltreli)
print(sayilarkareli)

from functools import reduce

sayilarFaktöriyel = reduce(lambda x,y:x*y,sayilar) # x=x*y x=x*y.next işlemi yapıyorsun bir nevi yani 1=1*2  2=2*3  6=6*4 diye.
print(sayilarFaktöriyel)