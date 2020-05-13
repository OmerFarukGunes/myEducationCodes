class Maths:
    def __init__(self,sayi1,sayi2): #phytonda constructor inittir.
        self.sayi1=sayi1 #sayi1 ve sayi 2 rasgele isimler olabilir.
        self.sayi2=sayi2 #fonksiyonlarda tek tek tanımlamak yerine const içinde yani initte 
        #verileri tek seferde tanımlayabilirsin.
        print("constructor")
    def add(self):#self olmak zorunda. aksi takdirde oluşan nesne kendini bulamaz. illa self olmak zorunda değil başka bir isimde olur yeterki orası nesnenin kendi yeri olduğunu anlamak.
        return self.sayi1+self.sayi2
    def carp(self):
        return self.sayi1*self.sayi2
    def bol(self):
        return self.sayi1/self.sayi2
    def çıkart(self):
        return self.sayi1-self.sayi2
matematik = Maths(2,78) #bellekte matematik adında nesne oluştu.
print(matematik.add()) #oluştururken gönderdiğin 2 ve 78 ile toplama yaptın
