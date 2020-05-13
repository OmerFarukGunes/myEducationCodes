import numpy as np

a=np.array([1.3,3,5,7,9,11]) #kendi dizini bu şekilde yaparsın.
print(a.dtype)#1.3 yüzünden tüm dizi float olur. hepsi tek tip olmalı
print(a)
a=np.array([1.3,3,5,"7",9,11])
a=a.reshape(2,3)#tekrar boyutlandırabilirsin. ve bunu eşitlemek zorundasın.
print(a)#bütün hepsini string olarak alır bu seferde bu sefer en genelini alır.
b= np.array([[1,3],[5,7],[9,11]]) #çok boyutlu dizi oluşturabilirsin.
print(b.ndim)
print(b)