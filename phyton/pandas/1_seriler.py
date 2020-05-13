#numpy dan farkı  sayısal hesaplamalardan iyade verileri işleme görselleştirmede de kullanılır

import pandas as pd
import numpy as np


data =np.array(["omer","faruk","gunes"]) #sayılarlada çalışabiliriz.
s= pd.Series(data) #datayı pandasa çeviriyoruz

print(s) #indexlenmiş şekilde ekrana yazar.
s=pd.Series(data,index=[1,2,3]) #indexi kendin verebilirsin ve bu senin diziyle aynı boyutta olmalıdır !

print(s)
data2={"matematik":10,"fizik":20,"beden egitimi":100}
s2= pd.Series(data2,index =["beden egitimi","fiz","matematik"]) 
print(s2) #bu şekilde indexlerin dictionary de ne ise pandastada o olur. indexleme yaparken dict teki kelimeleri birebir kullanmak zorundasın.

s3=pd.Series(5,index=[1,2,3])#kaç tane index verirsen ver ya da verme o indexlerin karşılığı 5 olur default index 0 dır.
print(s3)
print(s2[0]) #ilk index ataması neyse onu verir. ayarlama yapmadıysan defaultta yani dictionary de ne sıralı ise onu verir.
print(s2["matematik"])#indexi yazarakta veriye ulaşabilirsin.

