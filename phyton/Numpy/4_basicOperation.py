import numpy as np

a= np.array([20,30,40,50])
b= np.arange(4)
c= a-b
print(c) #aynı yapıda olması aynı shape sahip npdizilerde yapabilirsin.
d= b**2 #bu şekilde b dizisinin karesini bu şekilde alabilirsin.
print(d)
e= 10 * np.sin(a) #a elemanlarının sinüsü
print (e)
print(e<7)#e deki bütün elemanlar 7 den küçük mü? true false
print(a*b)
print(a@b)#matris çarpımıdır.
print(d.dot(e))#bu da matris çarpımıdır.

f= np.ones((2,4))#2 satır 4 sütünluk 1 ler oluştur.
g=np.zeros((2,4)) #2 satır 4 sütünluk 0 lar oluştur.
print(f)
print(g)
h=np.random.random((2,4)) #oluşturduğu array 0 la 1 arasında her çalıştırdığında random sayılı arrayler üretecektir.
print(h)
i = np.sum(b) #b dizisinin toplamını al
print(a.sum())#bu şekildede yapabilirsin
print(i)
j=np.min(a) #min a değeri
k=np.max(b) #min b değeri
print(j)
print(k)
l=np.sqrt(b)#b nin kareköklerini verir
print(l)