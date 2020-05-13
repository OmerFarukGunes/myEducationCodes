hesap=lambda a,b: a*b/2 #a ve b parametreleri al ve return yap işlemleri yapıp.
print(hesap(2,3))
print(type(hesap))
x=hesap #lambdanın tricki buradadır. 
print(x(4,5))