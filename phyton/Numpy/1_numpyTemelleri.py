#mevzular genellikle diziler üzerinde yürür.
import numpy as np

a= np.arange(15) #15 elemanlı dizi oluşturur
print(a)
a = np.arange(15).reshape(3,5) #3 satır 5 sütünluk bir array oluştur
print(type(a))
print(a)
print(a.ndim)

b= np.arange(10)
print(b.shape) #10 elemanlı tek satır
print(b.ndim) #boyutunu söyler