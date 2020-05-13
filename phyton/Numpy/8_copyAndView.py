import numpy as np

a=np.arange(10)
print(a)
b=a
print(b)
print(a[2])
print(b[2])
b[0]=100
print(a) # a nında ilk elemanıda değişir. çünkü diziler aslında konum olarak tutar ! sen o konumun ilk elemanını değiştirirsin. a da b de o ilk konumu tutar
print(b)
c=a.copy() #bu şekilde farklı bir a nın kopyası olur
c[0]=1000
print(a)
print(c)
d=a.view()
print("****")
print(a)
print(d)
d[0]=250
print(a)
print(d)
d.shape=2,5 #data değişince değişir ama shapeler değişmez
print(a)
print(d)