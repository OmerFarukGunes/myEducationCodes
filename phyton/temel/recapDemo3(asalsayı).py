sayi=int(input("sayi gir"))

asalMi=True
for x in range(2,sayi):
   if sayi %x ==0:
      asalMi=False
      break
   
if asalMi==False:
    print("asal değil")
else:
    print("asal")

 