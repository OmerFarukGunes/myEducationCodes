if True:
    print("doru")
elif False:
    print("doru degil")
else: 
    print("böle birşey yooğ")
    
liste =['a',True,1,1.2]
if ('c' in liste and 'd' in liste) or 'a' == liste[0]:
   print("var")
else:
       print("yoğ")

for i in liste:
    print(i)

Tupl =(1,3,5,7)
for num in Tupl:
    print(num)
    liste =[[1,2],[3,4]]
    for x,y in liste:
        print(x,y)
        # çok boyutluı listlerde for döngüsünde ki eleman listede ki elemana eşit olmalı.
        # aynı şey dictionaryde de zorunlu. dicte 2 key varsa forda 2 item olmalı
        
user ={'name':'omer','age':12}
for k,v in user.items():
    print("{}  {}".format(k,v))
    
x=0
while x <10:
    print(x)
    x+=1

# rande 