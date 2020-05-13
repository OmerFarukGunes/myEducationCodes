import numpy as np

a=np.linspace(1,10) # 1 den 10 a kadar eşit aralıklarla artan sayılar üretir.
print(a)
a=np.linspace(1,10,5)# 1 den 10 a kadar eşit aralıkla artan 5 sayı üret
print(a)

from numpy import pi
x=np.linspace(0,2*pi,100)
print(x)
print(np.sin(x)) # 0 derece ile 360 derece arasındaki sinüsları hesaplamış olursun.