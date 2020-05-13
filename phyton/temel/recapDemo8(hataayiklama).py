import sys
liste =["omer",3,4.4,"4",0]

for x in liste:
    try:
        print("sayı : " +str(x))
        sonuc= 1/int(x)
        print("sonuc: " +str(sonuc))
    except ValueError:
        print("bu bir harf topluluğu sayı değil.")
    except:
        print(str(x)+ " hesaplanamadı")#işlem yapılamayanlar hesaplanamaz mesela string HAFRLER
        print(sys.exc_info()[0])#hatanın ne olduğunu burada görebilirsin. 
