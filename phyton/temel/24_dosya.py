# f = open("24_dosyaDeneme.txt","w") #default olarak r dir. w olmasa sadece dosyayı açıp okumaya çalışır.
# #w dosya yoksa oluşturmanıda sağlar ve üzerine yazmanı sağlar. a ilede dosya açılabilir.
# f = open("24_dosyaDeneme.txt","a") #a veri eklemeni sağlar
# f = open("24_dosyaDeneme.txt","x")#x dosya oluşturmanı sağlar ancak dosya varsa yeniden oluşturmaz
#r okuma yapmanı sağlar.
f = open("24_dosyaDeneme.txt")
print(f.readline())#satırı oku demektir. #eğer read den sonra bunu oluşturursan sadece space oluşur ekranda
#nedeni ise read komutu dosyanın tamamını okur ve en sonda  kalır
print(f.readline())# 2. satırı okur.
print(f.read())#dosya içerisindeki veriyi bize verir.
print("***")
print(f.read(10))#10 karakteri oku demektir. #önceden dendiği gibi read dosya okumasını en sonda bırakır.
f.close() #dosyayı kapar.
f = open("24_dosyaDeneme.txt")
for l in f:
    print(l) #bütün line ları gez demektir