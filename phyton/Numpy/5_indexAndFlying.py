import numpy as np

sayilar = np.array([0,5,10,15,20,25,30])
print(sayilar[0]) #dizi gibi kullanabilirsin.
print(sayilar[1:3])
print(sayilar[::-1]) #tersten dizmek tek boyutlularda yapılır.
sayilar2 = np.array([[0,5,10],[15,20,1],[25,30,2]])
print(sayilar2[2])
print(sayilar2[:,0]) #tüm satırlardan ilk elemanları ver.
print(sayilar2[:,0:2])#tüm satırlardan 0 dan 2. ye kadar elemanları yaz demektir.
print(sayilar2[-1,:])
print(sayilar2[:,-1])