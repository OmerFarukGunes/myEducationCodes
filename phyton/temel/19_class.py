class Maths:
    def add(self,sayi1,sayi2):#self olmak zorunda. aksi takdirde oluşan nesne kendini bulamaz. illa self olmak zorunda değil başka bir isimde olur yeterki orası nesnenin kendi yeri olduğunu anlamak.
        return sayi1+sayi2
    def carp(self,sayi1,sayi2):
        return sayi1*sayi2
    def bol(self,sayi1,sayi2):
        return sayi1/sayi2
    def çıkart(self,sayi1,sayi2):
        return sayi1-sayi2
matematik = Maths() #bellekte matematik adında nesne oluştu.
print(matematik.add(2,78)) #sen o fonka maths classı 2 ve 78 i gönderip işlem yaptın.